<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePanel.aspx.cs" Inherits="AjaxWebApplication.UpdatePanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Page Load "></asp:Label>
            <br />
            <asp:Label ID="lblPageLoad" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Outside Update Panel"></asp:Label>
            <br />
            <asp:Button ID="btnOutsideUpdatePanel" runat="server" Text="Outside Update Panel" OnClick="btnOutsideUpdatePanel_Click" />
            <br />
            <asp:Label ID="lblOutsideUpdatePanel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Update Panel "></asp:Label>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Button ID="btnUpdatePanel" runat="server" Text="Inside Update Panel" OnClick="btnUpdatePanel_Click" />
                    <br />
                    <br />
                    <asp:Label ID="lblInsideUpdatePanel" runat="server"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
        </div>
    </form>
</body>
</html>
