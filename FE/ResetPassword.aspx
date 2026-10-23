<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ResetPassword.aspx.vb" Inherits="ResetPassword" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="vi-VN">
<head runat="server">
    <title>SKSS: Lấy lại mật khẩu</title>
    <link rel="SHORTCUT ICON" href="/favicon.ico" type="image/x-icon">
</head>
<body>
    <form id="form1" runat="server">
        <header id="header" class="navbar">
            <div class="container">
                <div class="navbar-header nav-logo">
                    <a href="/" class="navbar-brand">SKSS Thông báo</a>
                </div>
                <asp:Literal ID="litRes" runat="server" />
                <style>
                    .navbar {
                        background: #2c84cc none repeat scroll 0 0;
                        border: medium none;
                        border-radius: 0;
                        height: 42px;
                        margin-bottom: 0;
                        transition: padding 0.2s ease-in-out 0s;
                        z-index: 999;
                        padding-top: 20px;
                    }

                    a.navbar-brand {
                        color: #fff;
                        font-size: 16px;
                        text-decoration: unset !important;
                        text-transform: uppercase;
                        font-weight: bold;
                    }

                    .container {
                        width: 1024px;
                        margin: 0 auto;
                    }

                    body {
                        margin: 0 !important;
                    }
                </style>
            </div>
        </header>
    </form>
</body>
</html>
