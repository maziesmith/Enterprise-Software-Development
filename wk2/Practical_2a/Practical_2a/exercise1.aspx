<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercise1.aspx.cs" Inherits="practical_2a.Account.Exercise1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Welcome to the BMI Calculator Site"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="You can use this free tool to calculate your BMI"></asp:Label>
    </p>
    <p>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Weight: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbweight" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Kilograms"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Height:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbheight" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="metres"></asp:Label>
    </p>
    <p>
    </p>
    <p>
        <asp:Button ID="btncal" runat="server" OnClick="btncal_Click" Text="Calculate BMI" />
    </p>
    <p>
        <asp:Label ID="lblbmi" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblstatus" runat="server"></asp:Label>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
