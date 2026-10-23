<%@ Page Language="C#" AutoEventWireup="True" Inherits="DotNetNuke.Services.Exceptions.ErrorPage" CodeBehind="ErrorPage.aspx.cs" %>
<%@ Register Src="~/DesktopModules/Module/Home/PageError.ascx" TagPrefix="uc1" TagName="Home404" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en-US">
<head>
    <title runat="server" id="Title">Không tìm thấy nội dung!</title>
    <meta name="robots" content="NOINDEX, NOFOLLOW" />
    <link id="DefaultStylesheet" runat="server" href="/" rel="stylesheet" />
    <link id="InstallStylesheet" runat="server" rel="stylesheet" type="text/css" href="/" visible="false" />
    <link rel="SHORTCUT ICON" href="/Portals/0/logo.ico?ver=2018-11-06-163805-703" type="image/x-icon" />
</head>
<body>
    <form id="Form" runat="server">
        <uc1:Home404 runat="server" ID="Home404" />
        <div style="text-align: center; width: 700px; margin: 150px auto; border: 1px solid #ccc; padding: 70px 50px; background: #fff;">
            <p style="font-size: 18px; font-weight: bold; line-height: 25px">
                Yêu cầu của bạn hệ thống chưa kịp xử lí hoặc nội dung không tìm thấy !
            </p>
            <p style="font-size: 18px; font-weight: bold; line-height: 25px; padding-bottom: 20px">
                Vui lòng kiểm tra lại yêu cầu của bạn hoặc quay lại sau. Trân trọng!
            </p>
            <asp:HyperLink ID="hypReturn" runat="Server" NavigateUrl="~/" CssClass="dnnPrimaryAction" Text="Về trang chủ" />
        </div>
        <div style="display: none">
            <asp:Image ID="headerImage" runat="server" BorderStyle="None" Visible="false" AlternateText="DotNetNuke" />
            <asp:PlaceHolder ID="ErrorPlaceHolder" runat="server" Visible="false" />
        </div>
    </form>
</body>
</html>
