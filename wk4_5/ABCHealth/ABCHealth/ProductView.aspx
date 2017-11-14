<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductView.aspx.cs" Inherits="ABCHealth.ProductView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged" DataKeyNames="Product_ID" OnRowDeleting="gvProduct_RowDeleting">
        <Columns>
            <asp:BoundField DataField="Product_ID" HeaderText="Product Ref" />
            <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" Width="60px" ImageUrl='<%# "~/Images/" + Eval("Product_Image") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
            <asp:BoundField DataField="Unit_Price" HeaderText="Unit Price" DataFormatString="{0:c}" />
            <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" />
        </Columns>
</asp:GridView>
</asp:Content>
