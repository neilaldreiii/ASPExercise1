<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebAppDemo.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Become a banana now!</h1>
    <a href="~/Default">Home</a> | <a href="#">Registration</a>
    <form id="form1" runat="server">
        <div>
            <div class="form-group">
                <asp:TextBox ID="FirstnameTextBox" Placeholder="First Name" runat="server" />
            </div>
            <div class="form-group">
                <asp:TextBox ID="MiddlenameTextBox" Placeholder="Middle Name" runat="server" />
            </div>
            <div class="form-group">
                <asp:TextBox ID="LastnameTextBox" Placeholder="Last Name" runat="server" />
            </div>
            <div class="form-group">
                <asp:TextBox ID="EmailTextBox" Placeholder="Email" runat="server" />
            </div>
            <div class="form-group">
                <asp:TextBox ID="PhonenumberTextBox" Placeholder="Phone Number" runat="server" />
            </div>
            <div class="form-group">
                <asp:TextBox ID="UsernameTextBox" Placeholder="Username" runat="server" />
            </div>
            <div class="form-group">
                <asp:TextBox ID="PasswordTextBox" Placeholder="Password" runat="server" />
            </div>
            <asp:Button ID="RegisterButton" Text="Save" runat="server" OnClick="registerEventMethod" />
        </div>
    </form>
</body>
</html>
