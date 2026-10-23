<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="SubMod.ascx.vb" Inherits="DesktopModules.Modules.SubMod" %>
<link href="/portals/_default/skins/vbn/css/submod.css?v=2.1" rel="stylesheet" />
<link href="/Portals/_default/Skins/VBN/css/animate.css" rel="stylesheet" />
<div class="bodyContent row">
        <div class="col-md-4 right-login bg-cover">
            <h2>HỆ QUẢN TRỊ TẬP TRUNG</h2>
            <sub>(e-Portal CMS v<%=EPORTAL.flReg.WebConfig("BuildVersion") %>, build <%=EPORTAL.flReg.WebConfig("BuildDate") %>)</sub>
            <asp:Literal runat="server" ID="litAcc"></asp:Literal>
             <div class="col-md-12 mt40">
            <a  target="_blank" class="btn btnInfo" href="/profiles/userid/<%=User_ID%>/pageno/1"><i class="fa fa-info"></i> Thông tin tài khoản</a>
           &nbsp;&nbsp; <a class="btn btnLogoff" href="/logoff" ><i class="fa fa-sign-in"></i> Đăng xuất</a></div>
            <div class="row mt40">
                <span id="clock"></span><br />
                
                <%--<span id="time"><%=DateTime.Now.ToString("dd/MM/yyyy") %></span>--%>
            </div>
        </div>
        <div class="col-md-8 left-login text-center bg-cover animated fadeInRightBig">
            <div class="item-grid">
            <asp:Literal ID="litSub" runat="server"></asp:Literal>
            </div>
        </div>
</div>

<script type="text/javascript">
    //$(function () { var w = $(".bodyContent").width(); if (w > 1366) { $(".bodyContent").attr("style", "height:610px") } else { $(".bodyContent").removeAttr("style") } });
    $(".an1cai").click(function () { if ($(".personalBarContainer").hasClass("andi")) { $(".personalBarContainer").removeClass("andi"); $("#Body").attr("style", "margin-left:60px!important"); } else { $(".personalBarContainer").addClass("andi"); $("#Body").removeAttr("style"); } $(".personalBarContainer").removeAttr("style"); }); $(".personalBarContainer").addClass("andi");
    //$(document).keydown(function (event) { if (event.keyCode == 123) { return false; } else if (event.ctrlKey && event.shiftKey && event.keyCode == 73) { return false; } });
    //document.onkeydown = function (e) { if (e.ctrlKey && (e.keyCode === 85 || e.keyCode === 117)) { return false; } }; window.oncontextmenu = function () { return false; }
    //var span = document.getElementById('clock');

    //function time() {
    //    var d = new Date();
    //    var s = d.getSeconds();
    //    var m = d.getMinutes();
    //    var h = d.getHours();
    //    span.textContent =
    //        ("0" + h).substr(-2) + ":" + ("0" + m).substr(-2) + ":" + ("0" + s).substr(-2);
    //}

    //setInterval(time, 1000);
</script>

