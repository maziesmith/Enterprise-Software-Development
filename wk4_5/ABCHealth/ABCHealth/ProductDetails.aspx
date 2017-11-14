<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ABCHealth.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
    <table style="width: 94%;">
        <tr>
            <td rowspan="3" style="width: 99px; height:96px;">
                <asp:Image ID="img_Product" style="width:99px; height:96px;" runat="server" />
            </td>
            <td>
                <asp:Label ID="lbl_ProdName" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lbl_ProdDesc" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl_Price" runat="server"></asp:Label>
                <br />
                <asp:Button ID="btn_Add_To_Cart" runat="server" Text="Add to Cart" OnClick="btn_Add_To_Cart_Click" />
            </td>
        </tr>
    </table>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
                <asp:Button ID="btn_back" runat="server" Text="Back" OnClick="btn_back_Click" />
            </p>
    <p>
    </p>
</asp:Content>
