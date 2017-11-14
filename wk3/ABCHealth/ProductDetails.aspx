<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td rowspan="3" style="width: 72px">
                <asp:Image ID="img_Product" runat="server" Height="96px" Width="99px" />
            </td>
            <td style="height: 32px">
                <br />
            </td>
        </tr>
        <tr>
            <td style="height: 23px">
                <asp:Label ID="lbl_ProdName" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lbl_ProdDesc" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl_Price" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btn_Add_To_Cart" runat="server" Text="Add to Cart" />
                <br />
                <br />
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
            </td>
        </tr>
    </table>
</asp:Content>

