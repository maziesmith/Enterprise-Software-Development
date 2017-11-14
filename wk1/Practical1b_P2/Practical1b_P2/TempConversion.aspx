<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TempConversion.aspx.cs" Inherits="Practical1b_P2.TempConversion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Welcome to THE TEMPERATURE CONVERSION SITE!"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="You can use this free tool to convert between Fahrenheit and Celcius temperature.  "></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Just enter the temperature in either box below and click the button to see the converted results. "></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Fahrenheit : "></asp:Label>
        <asp:TextBox ID="tbfah" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnconvert" runat="server" OnClick="btnconvert_Click" Text="&lt;-- Convert --&gt;" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Celcius: "></asp:Label>
        <asp:TextBox ID="tbcelcius" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
