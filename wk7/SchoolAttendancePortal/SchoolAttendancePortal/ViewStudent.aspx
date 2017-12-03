<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewStudent.aspx.cs" Inherits="SchoolAttendancePortal.ViewStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Student Details </h1>
    <div />
        <asp:GridView ID="studentsGridView" runat="server" OnRowDeleting="studentsGridView_RowDeleting" OnSelectedIndexChanged="studentsGridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="AdminNumber" HeaderText="Admin Number" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                <asp:BoundField DataField="DateOfBirth" HeaderText="Birth Date" />
                <asp:BoundField DataField="Address" HeaderText="Home Address" />
                <asp:BoundField DataField="Citizenship" HeaderText="Citizenship" />
                <asp:BoundField DataField="MobileNumber" HeaderText="Mobile Number" />
                <asp:BoundField DataField="SchoolEmail" HeaderText="School Email" />
                <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    </asp:Content>
