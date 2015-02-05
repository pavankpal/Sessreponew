<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="JavaScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="User ID" style="z-index: 1; left: 284px; top: 154px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtid" runat="server" style="z-index: 1; left: 417px; top: 150px; position: absolute"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Password" style="z-index: 1; left: 285px; top: 202px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtpwd" TextMode="Password" runat="server" style="z-index: 1; left: 419px; top: 200px; position: absolute"></asp:TextBox><br />
        <asp:Button ID="btnlog" runat="server" Text="Login" OnClick="btnlog_Click" style="z-index: 1; left: 381px; top: 240px; position: absolute" /><br />
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 376px; top: 292px; position: absolute" ></asp:Label>
    </div> 
    </form>
</body>
</html>
