<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="InfoBridgeAssignment.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height:300px;
        }
        
        .auto-style4 {
            width: 677px;
            height: 238px;
        }
        .auto-style5 {
            height: 12px;
        }
        .auto-style6 {
            width: 769px;
            height: 44px;
        }
    </style>
</head>
<body style="height: 298px">
    <form id="form1" runat="server">
        <table class="auto-style1" align="center" style="background-color: #CECDD5;">
            <tr>
                <td>
                    <table style="border: 1px solid #3498DB;" class="auto-style4" align="center">
                        <tr>
                            <td style="background-color: #3498DB; color: white; font-size: 24px; font-weight: bold; height: 50px; text-align:center"
                                class="auto-style12">Login Form</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>                           
                            <td class="auto-style6" style="background-color: #D9D6D2; border: 1px solid #180539">
                                <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextUserName" runat="server" Width="251px" Height="26px"></asp:TextBox>
                               
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextUserName" ErrorMessage="username required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            </td>                          
                        </tr>
                        <tr>                           
                            <td class="auto-style6" style="background-color: #D9D6D2; border: 1px solid #180539">
                                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextPassword" runat="server" Width="251px" Height="26px"></asp:TextBox>                               
                                
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                               
                                
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextPassword" ErrorMessage="password required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                
                            </td>                           
                        </tr>
                        <tr>                           
                            <td class="auto-style6" style="background-color: #D9D6D2; border: 1px solid #180539;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="80px" Height="30px" />
                                &nbsp;</td>                            
                        </tr>                        
                    </table>
                </td>
            </tr>                        
        </table>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
