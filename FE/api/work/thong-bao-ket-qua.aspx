<%@ Page Language="VB" AutoEventWireup="false" CodeFile="thong-bao-ket-qua.aspx.vb" Inherits="DesktopModules.TinTuc.Control.Tbkq" %>

<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en-US">
<head runat="server">
    <title>Thông báo kết quả</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=yes" />
    <link rel="SHORTCUT ICON" href="/favicon.ico?ver=2017-10-27-144540-937" type="image/x-icon" />
    <link rel="stylesheet" href="/Portals/_default/fonts/resource/font-awesome/css/font-awesome.min.css?v=4.5.3" />
    <link rel="stylesheet" href="/portals/_default/skins/vbn/css/AdminLTE.min.css?v=4.1.1" />
    <link rel="stylesheet" href="/portals/_default/skins/vbn/css/style.css?v=4.0.1" />
    <link rel="stylesheet" href="/portals/_default/skins/vbn/css/manager.css?v=4.1.10" />
    <link rel="stylesheet" href="/js/datetime/datetimepicker.css?v=4.0.1" />
    <link rel="stylesheet" href="/js/validation/validationEngine.jquery.css" />
    <link rel="stylesheet" href="/js/select/bootstrap.min.css?v=4.6.0.3.3.0" />
    <link rel="stylesheet" href="/js/select/bootstrap-select.css?v=4.6.0.3.3.0" />
    <style type="text/css" media="screen">
        * {
            font-family: Tahoma;
            font-size: 16px;
        }

        #content {
            padding: 5px 5px 30px 10px;
        }

        ul {
            list-style: none;
        }

        .list-lq ul li {
            line-height: 20px;
            padding-left: 15px;
        }

            .list-lq ul li a:hover {
                color: #f59206;
            }

        .list-lq {
            padding-top: 10px;
            padding-bottom: 10px
        }

        .marqueeTB {
            color: blue;
            overflow: hidden;
        }

        table {
            margin-bottom: 0px !important;
            padding: 0px 5px !important;
            color: #444;
        }

        .tbdat {
            margin-left: -60px;
        }

        .nav-main {
            color: #036f01;
        }

            .nav-main span {
                color: #c30000
            }

        .hdTitle {
            background-color: #069;
            color: #fff;
            font-weight: 600;
            font-size: 16px;
            line-height: 20px;
        }

        .table-bordered tr.row-selected td, .table-bordered tr:hover td {
            background-color: #069 !important
        }

        .marqueeTB .table-bordered tr.row-selected td, .marqueeTB .table-bordered tr:hover td {
            background-color: unset !important
        }

        table tr:nth-child(odd) {
            background-color: #eee;
        }

        table tr:nth-child(even) {
            background-color: #fff;
        }

        .marqueeTB {
            height: calc(100% - 200px) !important
        }

        body {
            overflow: hidden !important
        }

        .js-marquee {
            margin-bottom: 0px !important
        }
    </style>

</head>
<body>
    <form id="formChoose" runat="server" style="padding: 5px; height: 100%; overflow-y: scroll;">
        <div id="content">
            <asp:HiddenField ID="PortalID" runat="server" />
            <div class="nav-main">
                <div class="col-md-12 col-sm-12 txt-center " style="padding: 10px 10px;">
                    <span style="font-weight: bold; color: #035f8c; font-size: 20px; text-transform: uppercase;">
                        <asp:Literal runat="server" ID="ltTitle" /></span>
                </div>
                <div class="clear pdb10"></div>
                <div class="col-md-3 txt-left pdt5" style="font-weight: bold; font-size: 14px;">
                    Diễn ra từ ngày:
                     <asp:Label ID="lblThoiGian" runat="server" />
                </div>
                <div class="col-md-3 txt-left pdt5" style="font-weight: bold; font-size: 14px;">
                    Đến hết ngày:  
                     <asp:Label ID="lblThoiGianKetThuc" runat="server" />
                </div>
                <div class="col-md-2 pdt5 txt-left pdr0" style="font-weight: bold; font-size: 14px;">
                    Số ứng viên:                
                    <asp:Label ID="lblSoUngVien" CssClass="lblSoUngVien" runat="server" />
                </div>
                <div class="col-md-4 pdt5">
                    <div class="col-sm-4" style="font-weight: bold; font-size: 14px;">
                        Số lượng đạt:               
                     <asp:Label ID="lblSoUngVienDat" runat="server" />
                    </div>
                    <div class="col-sm-4" style="font-weight: bold; font-size: 14px;">
                        Không đạt:
                   <asp:Label ID="lblSoUngVienHenGapLai" runat="server" />
                    </div>
                    <div class="col-sm-4" style="font-weight: bold; font-size: 14px;">
                        Khác:
                   <asp:Label ID="lblSoUngVienKhac" runat="server" />
                    </div>
                </div>
                <div class="clear "></div>

            </div>
            <table width="100%" class="table table-bordered ">
                <tr>
                    <td width="4%" class="hdTitle txt-center">STT</td>
                    <td width="15%" class="hdTitle txt-center">Họ và tên ứng viên</td>
                    <td width="7%" class="hdTitle txt-center">Giới tính</td>
                    <td width="10%" class="hdTitle txt-center">Ngày sinh</td>
                    <td width="25%" class="hdTitle txt-center">Địa chỉ liên hệ</td>
                    <td width="38%" class="hdTitle txt-center">Kết quả tham gia</td>
                </tr>
            </table>
            <div class="marqueeTB pd0">

                <asp:Literal runat="server" ID="litContent" />
            </div>

            <div class="col-md-12">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <asp:HiddenField ID="ItemID" runat="server" Value="0" Visible="false" />
        </div>
    </form>
    <script src="/Resources/Shared/scripts/jquery/jquery.min.js?v=4.6.0.3.3.0" type="text/javascript"></script>
    <script src="/js/base64.js?v=4.6.0.3.3.0" type="text/javascript"></script>
    <script type="text/javascript" src="/js/select/bootstrap.min.js?v=4.6.0.3.3.0"></script>
    <script type="text/javascript" src="/js/select/bootstrap-select.js?v=4.6.0.3.3.0"></script>

</body>


<script type="text/ecmascript" src="/js/jquery.marquee.min.js"></script>
<script type="text/ecmascript">    
    $(function () {
        $('.marqueeTB').marquee({
            allowCss3Support: true,
            css3easing: 'linear',
            easing: 'linear',
            delayBeforeStart: 10,
            direction: 'up',
            duplicated: true,
            duration: 15000,
            gap: 70,
            pauseOnCycle: true,
            pauseOnHover: false,
            startVisible: false
        });
    });
</script>
</html>
