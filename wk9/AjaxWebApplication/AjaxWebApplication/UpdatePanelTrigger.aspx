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
            <asp:Label ID="Label1" runat="server" Text="Update Panel 1 "></asp:Label>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Button ID="btnUpdateBoth" runat="server" OnClick="btnUpdateBoth_Click" Text="Update Both" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnUpdateThis" runat="server" OnClick="btnUpdateThis_Click" Text="Update This" />
                    <br />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Update Panel 2"></asp:Label>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnUpdateBoth" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
           
        </div>
    </form>
</body>
</html>
