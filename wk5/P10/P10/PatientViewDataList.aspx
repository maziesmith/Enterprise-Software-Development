<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientViewDataList.aspx.cs" Inherits="P10.PatientViewDataList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DataList ID="ddlPatient" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%# Bind("PatientID") %>'></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text='<%# Bind("PatientName") %>'></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text='<%# Bind("PostalCode") %>'></asp:Label>
            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Country") %>'></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" Height="20px" ImageUrl="~/Images/Phone.png" Width="20px" />
            <asp:Label ID="Label6" runat="server" Text='<%# Bind("ContactNumber") %>'></asp:Label>
            <br />
            <asp:Image ID="Image2" runat="server" Height="20px" ImageUrl="~/Images/email.png" Width="20px" />
            <asp:Label ID="Label7" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
