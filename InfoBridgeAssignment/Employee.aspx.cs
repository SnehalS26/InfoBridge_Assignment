using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace InfoBridgeAssignment
{
    public partial class Employee : System.Web.UI.Page
    {
        
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataReader dr;

        public Employee()
        {
            string connstr = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(connstr);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetEmployeeList();
            }
        }
        //Clear form
        public void Clear_All()
        {
            TextId.Text = "";
            TextName.Text = "";
            DropSex.SelectedValue = DropSex.Items[0].ToString();
            TextPhone.Text = "";
            TextDOB.Text = DateTime.Today.Date.ToString();
            TextAddress.Text = "";
            lblError.Text = "";
        }

        //Add records
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               // DateTime dt = DateTime.ParseExact(TextDOB.Text, "MM-dd-yyyy ",System.Globalization.CultureInfo.InvariantCulture);
                string image = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("Image/") +image);

                string qry = "Insert into Employee Values(@Id, @Name, @DateOfBirth,@Sex, @Phone,@Address, @Image)";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(TextId.Text));
                cmd.Parameters.AddWithValue("@Name", TextName.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", TextDOB.Text);
                cmd.Parameters.AddWithValue("@Sex", DropSex.Text);
                cmd.Parameters.AddWithValue("@Phone", TextPhone.Text);
                cmd.Parameters.AddWithValue("@Address", TextAddress.Text);
                cmd.Parameters.AddWithValue("@Image", image);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                lblError.Text = "Successfully Added";

                GetEmployeeList();
                Clear_All();
            }
            catch(Exception ex)
            {
                lblError.Text = "Something went wrong...Please Check..!";
            }

        }

        //Edit by Id
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = int.Parse(TextId.Text);
                string name = TextName.Text, dob = TextDOB.Text, sex = DropSex.Text, phone = TextPhone.Text, address = TextAddress.Text;
                string image=FileUpload1.FileName;

               string qry = "Update Employee set Name=@Name, DateOfBirth=@DateOfBirth, Sex=@Sex, Phone=@Phone, Address=@Address, Image=@Image where Id=@Id";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                cmd.Parameters.AddWithValue("@Sex", sex);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Image", image);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                lblError.Text = "Successfully Edited";

                GetEmployeeList();
                Clear_All();
            }
            catch (Exception ex)
            {
                lblError.Text = "Something went wrong...Please Check..!";
            }
        }

        //Delete by id
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = int.Parse(TextId.Text);
                string qry = "Delete Employee Where @Id=Id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                lblError.Text = "Successfully Deleted";

                GetEmployeeList();
                Clear_All();

            }
            catch (Exception ex)
            {
                lblError.Text = "Something went wrong...Please Check..!";
            }
        }

        //view by id
        protected void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = int.Parse(TextId.Text);
                string qry = "Select * from Employee Where @Id=Id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                lblError.Text = "Something went wrong...Please Check..!";
            }
        }

        //view all employee
        void GetEmployeeList()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Employee",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}