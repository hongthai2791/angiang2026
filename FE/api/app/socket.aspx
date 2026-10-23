<%@ Page Language="VB" AutoEventWireup="false" CodeFile="socket.aspx.vb" Inherits="Socket_Client" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="vi-VN">
<head runat="server">
    <title>KENG - CLIENT</title>
    <link rel="SHORTCUT ICON" href="/favicon.ico" type="image/x-icon">
</head>
<body>
    <form id="form1" runat="server">
        <script src="http://127.0.0.1:46864/socket.io/socket.io.js"></script>
        <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
        <script type="text/javascript">
            $(function () {
                var socket = io.connect("http://127.0.0.1:46864");
                var _iD = "";
                var _titles = "";
                var _contents = "";
                var _sendDate = "";
                var _readDate = "";
                var _tinhTrang = "";
                var _logo = "";

                socket.on('connect', () => {
                    socket.emit('app_notify', { iD: _iD, titles: _titles, contents: _contents, sendDate: _sendDate, readDate: _readDate, tinhTrang: _tinhTrang, logo: _logo});

                });
            });

        </script>
    </form>
</body>
</html>
