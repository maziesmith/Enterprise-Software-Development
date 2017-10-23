<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex3.aspx.cs" Inherits="Practical1b.Ex3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 3</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Exercise 3"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Item Price: "></asp:Label>
&nbsp;
        <asp:TextBox ID="tbprice" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnadd" runat="server" Text="Add" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Order Total: "></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="lbltotal" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
