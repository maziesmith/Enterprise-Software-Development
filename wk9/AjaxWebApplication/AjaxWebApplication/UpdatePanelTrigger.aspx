<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePanelTrigger.aspx.cs" Inherits="AjaxWebApplication.UpdatePanelTrigger" %>

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
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Update Panel 1 "></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnUpdateBoth" runat="server" Text="Update Both" />
&nbsp;&nbsp;
            <asp:Button ID="btnUpdateThis" runat="server" Text="Update This" />
            <br />
            <br />
            <asp:Label ID="lbllabel1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbllabel2" runat="server" Font-Bold="True">Update Panel 2</asp:Label>
            <br />
            <asp:Label ID="lbllabel3" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
