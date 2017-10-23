<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex2.aspx.cs" Inherits="Practical1b.Ex2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 2</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Exercise 2"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Please enter a word: "></asp:Label>
        <asp:TextBox ID="tbword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="How many times to repeat? "></asp:Label>
        <asp:TextBox ID="tbno" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btngo" runat="server" OnClick="btngo_Click" Text="Go" />
        <br />
        <br />
        <asp:Label ID="lblrepeat" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
