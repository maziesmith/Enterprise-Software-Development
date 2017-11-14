<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradeApplication.aspx.cs" Inherits="Practical1b_P2.BLL.GradeApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grading application</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Welcome to THE GREAT APPLICATION"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="You can use the free tool to display the grade of your students."></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Student 1: "></asp:Label>
&nbsp;
        <asp:TextBox ID="tbstud1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="lblstud1grade" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblpass1" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Student 2: "></asp:Label>
&nbsp;
        <asp:TextBox ID="tbstud2" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="lblstud2grade" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblpass2" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Student 3: "></asp:Label>
&nbsp;
        <asp:TextBox ID="tbstud3" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="lblstud3grade" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblpass3" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Student 4: "></asp:Label>
&nbsp;
        <asp:TextBox ID="tbstud4" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="lblstud4grade" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblpass4" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Student 5: "></asp:Label>
&nbsp;
        <asp:TextBox ID="tbstud5" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="lblstud5grade" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblpass5" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lbltag" runat="server">Average Score: </asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="lblavg" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbltag0" runat="server">Highest:</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblavg0" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbltag1" runat="server">Lowest:</asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblavg1" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btngrade" runat="server" OnClick="btngrade_Click" Text="Process Grades" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnreset" runat="server" Text="Reset" OnClick="btnreset_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
