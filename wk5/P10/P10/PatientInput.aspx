<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientInput.aspx.cs" Inherits="P10.PatientInput" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>INPUT PATIENT DATA</h1>
    <div>
        <table style="width: 100%;">
            <tr>
                <td style="width: 162px">Patient Name:</td>
                <td style="width: 216px">
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Patient ID:</td>
                <td style="width: 216px">
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Gender:</td>
                <td style="width: 216px">
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Citizenship: </td>
                <td style="width: 216px">
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Address:</td>
                <td style="width: 216px">
                    <br />
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Country/ Postal Code:</td>
                <td style="width: 216px">
                    <br />
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px">
                    </asp:DropDownList>
&nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Contat Number:</td>
                <td style="width: 216px">
                    <br />
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Email: </td>
                <td style="width: 216px">
                    <br />
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
                <td style="width: 216px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 162px">&nbsp;</td>
                <td style="width: 216px">&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
