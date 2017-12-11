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
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate></ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
