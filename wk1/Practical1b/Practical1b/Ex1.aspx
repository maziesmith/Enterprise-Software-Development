<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex1.aspx.cs" Inherits="Practical1b.Ex1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 1</title>
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Label ID="Label1" runat="server" Text="Exercise 1"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter N1: "></asp:Label>
        <asp:TextBox ID="tbn1" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label3" runat="server" Text="Enter N2: "></asp:Label>
        <asp:TextBox ID="tbn2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btncompute" runat="server" OnClick="btncompute_Click" Text="Compute!" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Sum: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblsum" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Average: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblavg" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Max: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblmax" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Min:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblmin" runat="server"></asp:Label>
    
    </form>
</body>
</html>
