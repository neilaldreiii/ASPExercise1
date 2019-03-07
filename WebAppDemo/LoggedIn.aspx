<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoggedIn.aspx.cs" Inherits="WebAppDemo.LoggedIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bananas Page</title>
</head>
<body>
    <h1>Hello this is the logged in page for bananas</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="LogOutButton" text="Logout" OnClick="LogOutButton_Click" runat="server"/>
            <h1>Hey there <asp:Label ID="userLabel" runat="server" /></h1>
        </div>
    </form>
</body>
</html>
