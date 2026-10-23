<%@ Page Language="VB" AutoEventWireup="false" CodeFile="reportsNLD.aspx.vb" Inherits="View.Defaults" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title runat="server" id="Title">Kết xuất dữ liệu!</title>
    <meta name="robots" content="NOINDEX, NOFOLLOW" />
    <link rel="SHORTCUT ICON" href="/favicon.ico" type="image/x-icon" />
    <link href="/Portals/_default/Skins/VBN/css/member.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="container">
        <asp:Literal ID="litCode" runat="server"></asp:Literal>
        <asp:DropDownList ID="drDanToc" Visible="false" runat="server" CssClass=" selectpicker drDanToc" />
        <asp:DropDownList ID="drTonGiao" Visible="false" runat="server" CssClass=" selectpicker drDanToc" />
        <asp:DropDownList ID="drTinhTP" Visible="false" runat="server" AutoPostBack="true" CssClass="selectpicker " />
    </form>
</body>

</html>

