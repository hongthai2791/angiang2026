<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CauLD.aspx.vb" Inherits="Download" %>
<%@ Register TagPrefix="dnn" TagName="jQuery" Src="~/Admin/Skins/jQuery.ascx" %>
<dnn:jQuery ID="jQuery" runat="server" />


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Xem tài liệu</title>
    <link rel="SHORTCUT ICON" href="/favicon.ico?ver=2018" type="image/x-icon">
    <script type="text/javascript" src="/Resources/libraries/jQuery/01_09_01/jquery.js?cdv=46"></script>
    <script src="/Resources/libraries/jQuery/03_02_01/jquery.js?cdv=51"></script>
    <asp:Literal ID="litJS" runat="server" />
</head>
<body class="body" style="margin: 0!important">
    <asp:Literal ID="litCode" runat="server" />
    <form id="form2" runat="server">
        <div class="obj-div">
            <asp:Literal ID="lbMsg" runat="server" />
        </div>
        
        <script>
            $(function () { $(".obj-div object").attr("style", "height:" + ($(document).height() - 10) + "px"); });</script>
    </form>
</body>
</html>
