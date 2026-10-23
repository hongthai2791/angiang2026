<%@ Page Language="VB" AutoEventWireup="false" CodeFile="404.aspx.vb" Inherits="PageError" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title runat="server" id="Title">Không tìm thấy nội dung!</title>
    <meta name="robots" content="NOINDEX, NOFOLLOW" />
    <link href="/Portals/_default/default.css?cdv=46" rel="stylesheet" />
    <link rel="SHORTCUT ICON" href="/favicon.ico" type="image/x-icon" />
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div style="text-align: center; width: 700px; margin: 150px auto; border: 1px solid #ccc; padding: 70px 50px;background:#fff">
            <p style="font-size: 18px; font-weight: bold; line-height: 25px">
                Yêu cầu của bạn hệ thống chưa kịp xử lí hoặc nội dung không tìm thấy !
            </p>
            <p style="font-size: 18px; font-weight: bold; line-height: 25px; padding-bottom: 20px">
                Vui lòng kiểm tra lại yêu cầu của bạn hoặc quay lại sau. Trân trọng!
            </p>
            <asp:HyperLink ID="hypReturn" runat="Server" NavigateUrl="~/" CssClass="dnnPrimaryAction" Text="Về trang chủ" />
        </div>
    </form>
</body>
</html>
