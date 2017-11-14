<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductInsert.aspx.cs" Inherits="ABCHealth.ProductInsert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
    <table style="width: 81%;">
        <tr>
            <td style="width: 130px">
                <asp:Label ID="Label1" runat="server" Text="Product Name: "></asp:Label>
            </td>
            <td style="width: 224px">
                <br />
                <asp:TextBox ID="tb_ProductName" runat="server" style="margin-top: 0" Width="575px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="height: 22px; width: 130px">
                <asp:Label ID="Label2" runat="server" Text="Product Desc:"></asp:Label>
            </td>
            <td style="width: 224px; height: 22px">
                <br />
                <asp:TextBox ID="tb_ProductDesc" runat="server" Height="140px" style="margin-top: 0" TextMode="MultiLine" Width="575px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 130px">
                <asp:Label ID="Label3" runat="server" Text="Unit Price: "></asp:Label>
            </td>
            <td style="width: 224px">
                <br />
                <asp:TextBox ID="tb_UnitPrice" runat="server" Height="22px" style="margin-top: 0" Width="575px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 130px">
                <asp:Label ID="Label4" runat="server" Text="Stock Level:"></asp:Label>
            </td>
            <td style="width: 224px">
                <br />
                <asp:TextBox ID="tb_StockLevel" runat="server" Height="22px" style="margin-top: 0" Width="575px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 130px">
                <asp:Label ID="Label5" runat="server" Text="Product Image: "></asp:Label>
            </td>
            <td style="width: 224px">
                <asp:FileUpload ID="fileUpload" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 130px">&nbsp;</td>
            <td style="width: 224px">
                <asp:Label ID="lbl_Result" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 130px">&nbsp;</td>
            <td style="width: 224px">
                <br />
                <asp:Button ID="btn_Insert" runat="server" OnClick="btn_Insert_Click" Text="Insert" />
                <asp:Button ID="btn_View_Product_List" runat="server" OnClick="btn_View_Product_List_Click" Text="View Product List" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    </p>
</asp:Content>
