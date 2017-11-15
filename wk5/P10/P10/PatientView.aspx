<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientView.aspx.cs" Inherits="P10.PatientView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Patient Data</h1>
    <asp:GridView ID="gvPatient" runat="server"></asp:GridView>
</asp:Content>
