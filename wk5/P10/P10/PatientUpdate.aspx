<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientUpdate.aspx.cs" Inherits="P10.PatientUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1>UPDATE PATIENT DATA</h1>
     <div>
        <table style="width: 100%;">
            <tr>
                <td style="width: 162px">Patient Name:</td>
                <td style="width: 216px">
                    <br />
                    <asp:TextBox ID="tbPatientName" runat="server" Width="400px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Patient ID:</td>
                <td style="width: 216px">
                    <br />
                    <asp:TextBox ID="tbPatientID" runat="server" Width="400px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px; height: 86px">Gender:</td>
                <td style="width: 216px; height: 86px">
                    <asp:RadioButtonList ID="rblGender" runat="server" Height="68px" Width="161px">
                        <asp:ListItem Value="m">Male</asp:ListItem>
                        <asp:ListItem Value="f">Female </asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Citizenship: </td>
                <td style="width: 216px">
                    <br />
                    <asp:DropDownList ID="ddlCitizenship" runat="server" Height="25px" Width="200px">
                        <asp:ListItem>Singapore</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Address:</td>
                <td style="width: 216px">
                    <br />
                    <asp:TextBox ID="tbAddress" runat="server" Height="50px" TextMode="MultiLine" Width="400px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Country/ Postal Code:</td>
                <td style="width: 216px">
                    <br />
                    <asp:DropDownList ID="ddlCountry" runat="server" Height="25px" Width="200px">
                        <asp:ListItem>Singapore</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:TextBox ID="tbPostalCode" runat="server" Width="150px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Contact Number:</td>
                <td style="width: 216px">
                    <br />
                    <asp:TextBox ID="tbContactNumber" runat="server" Width="200px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">Email: </td>
                <td style="width: 216px">
                    <br />
                    <asp:TextBox ID="tbEmail" runat="server" Width="400px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 162px">
                    <asp:Label ID="lbMessage" runat="server"></asp:Label>
                </td>
                <td style="width: 216px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 162px">&nbsp;</td>
                <td style="width: 216px">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
