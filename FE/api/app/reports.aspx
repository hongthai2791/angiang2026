<%@ Page Language="VB" AutoEventWireup="false" CodeFile="reports.aspx.vb" Inherits="View.Defaults" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title runat="server" id="Title">Kết xuất dữ liệu!</title>
    <meta name="robots" content="NOINDEX, NOFOLLOW" />
    <link rel="SHORTCUT ICON" href="/favicon.ico" type="image/x-icon" />
    <link href="/Portals/_default/Skins/VBN/css/member.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="">
        <div class="login-top-header ">
            <a href="/" target="_blank" title="Eportal">
                <img src="/image/hng/bigtech.png?h=40" alt="Eportal" /></a>
        </div>
        <div class="grid login-grid">
            <div class="member-login-title">
                <h3>
                    <asp:Literal ID="litCode" runat="server" Text="HỆ THỐNG ĐANG XỬ LÝ DỮ LIỆU TẢI XUỐNG, VUI LÒNG CHỜ TRONG GIÂY LÁT"></asp:Literal>
                </h3>
            </div>
        </div>
    </form>
</body>
</html>

