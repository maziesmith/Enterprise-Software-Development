<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exercise2.aspx.cs" Inherits="practical_2a.Exercise2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Welcome to Look Sharp Fitness Centre</h1>
    <div>
        <h2>Juice Bar Order</h2>
        <table style="width: 100%;">
            <tr>
                <th>Drink Type</th>
                <th>Size</th>
            </tr>
            <tr>
                <td style="height: 23px">
                    <br />
                    <asp:RadioButtonList ID="rbDrink" runat="server" OnSelectedIndexChanged="rbDrink_SelectedIndexChanged">
                        <asp:ListItem Selected="True">Fruit</asp:ListItem>
                        <asp:ListItem>Veggie</asp:ListItem>
                        <asp:ListItem>Promegranate</asp:ListItem>
                        <asp:ListItem>Banana</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="height: 23px">
                    <br />
                    <asp:RadioButtonList ID="rbSize" runat="server" OnSelectedIndexChanged="rbSize_SelectedIndexChanged">
                        <asp:ListItem Value="12">12 Ounce - $3.00</asp:ListItem>
                        <asp:ListItem Selected="True" Value="16">16 Ounce - $3.50</asp:ListItem>
                        <asp:ListItem Value="20">20 Ounce - $4.00</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="height: 23px"></td>
            </tr>
            <tr>
                <td>
                    <br />
                    Extras - $0.50 each
                    <br />
                    <br />
                    <asp:CheckBox ID="cbVitaminPack" runat="server" Text="Vitamin Pack" OnCheckedChanged="cbVitaminPack_CheckedChanged" />
                    <br />
                    <br />
                    <asp:CheckBox ID="cbEnergyBooster" runat="server" Text="Energy Booster" />
                    <br />
                    <br />
                    <asp:CheckBox ID="cbLite" runat="server" Text="Lite" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <br />
                    Item Price
                </td>
                <td>

                    <br />

                    <asp:Label ID="lblPrice" runat="server" Text="0"></asp:Label>

                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    Quantity Order
                </td>
                <td>

                    <br />

                    <asp:TextBox ID="txtQty" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>

                    <br />

                    <asp:Button ID="btnAddtoOrder" runat="server" Text="Add to Order" OnClick="btnAddtoOrder_Click" />

                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    Amount Due
                </td>
                <td>

                    <br />

                    <asp:Label ID="lblAmountDue" runat="server" Text="0"></asp:Label>

                </td>
            </tr>
        </table>
        <div>

            <asp:TextBox ID="txtSummary" runat="server" Height="170px" ReadOnly="True" TextMode="MultiLine" Width="462px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSummaryReport" runat="server" OnClick="btnSummaryReport_Click" Text="Summary Report" />

        </div>

    </div>
</asp:Content>
