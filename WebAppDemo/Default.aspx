<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>This is the Home Page</h1>
    <a href="#">Home</a> | <a href="Registration.aspx">Registration</a>
    <form id="form1" runat="server">
        <div>
            <div class="form-group">
                <asp:TextBox ID="usernameTextBox" Text="Username" runat="server" />
            </div>
            <div class="form-group">
                <asp:TextBox ID="passwordTextBox" Text="Password" runat="server" />
            </div>
            <div class="form-group">
                <asp:Button ID="submitButton" Text="Log in" runat="server" OnClick="SubmitEventMethod"/>
            </div>
        </div>
    </form>
</body>
</html>
