<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Mar_MarketRun.ascx.vb" Inherits="Modules.SVL.View" %>
<%@ Register Src="~/DesktopModules/Module/WORK/EDIT/Mar_DNThamGia.ascx" TagPrefix="WORKS" TagName="DNThamGia" %>
<%@ Register Src="~/DesktopModules/Module/WORK/EDIT/Mar_DNMoiTG.ascx" TagPrefix="WORKS" TagName="DNMoiTG" %>
<%@ Register Src="~/DesktopModules/Module/WORK/EDIT/Mar_DSUngVien.ascx" TagPrefix="WORKS" TagName="DSUngVien" %>
<%@ Register Src="~/DesktopModules/Module/WORK/EDIT/Mar_DSBaoCao.ascx" TagPrefix="WORKS" TagName="DSBaoCao" %>
<%@ Register Src="~/DesktopModules/Module/WORK/EDIT/Mar_DSMoiUV.ascx" TagPrefix="WORKS" TagName="DSMoiUV" %>
<style>
    .nav-tabs > li.active > a {
        background: #d86196 !important;
        color: #fff !important;
        font-weight: 100;
    }

    .nav-tabs > li > a {
        background: #eee !important;
        color: #444 !important;
        font-weight: 100;
    }

    .ui-dialog .ui-dialog-titlebar {
        height: 40px;
    }

    .ui-dialog {
        z-index: 999999999;
        background: #fff;
        overflow: unset !important;
        top: 110px !important;
        left: 259px !important;
    }

    div.ui-dialog-titlebar > .ui-dialog-titlebar-close {
        top: 5px;
        right: 5px;
    }
</style>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <asp:Literal ID="litTitle" runat="server" />
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="div-title-run">
                    <asp:Label runat="server" ID="TenPhien" Text="Phiên giao dịch: " />
                </div>
            </div>
            <div class="row mar-tab-content">
                <ul class="nav nav-tabs" id="myTab">
                    <li class="active"><a data-toggle="tab" href="#tabs-1">Đăng ký tham gia
                            <span class="header_number">&nbsp;<%= Session.Item("DNThamGia_" + PhienGD)%> </span></a>
                    </li>
                    <li><a data-toggle="tab" href="#tabs-2">Mời doanh nghiệp
                            <span class="header_number">&nbsp;<%= Session.Item("DNMoiTG_" + PhienGD)%> </span></a>
                    </li>
                    <li><a data-toggle="tab" href="#tabs-3">Ứng viên tham gia
                            <span class="header_number">&nbsp;<span class="soungvien"><%= Session.Item("DSUngVien_" + PhienGD)%> </span></span></a>
                    </li>
                    <li><a data-toggle="tab" href="#tabs-4">Mời ứng viên
                            <span class="header_number">&nbsp;<%= Session.Item("DSMoiUV_" + PhienGD)%> </span></a>
                    </li>
                    <li><a data-toggle="tab" href="#tabs-5">Thống kê - báo cáo</a></li>
                </ul>
                <div class="tab-content">
                    <div id="tabs-1" class="tab-pane fade in active">
                        <WORKS:DNThamGia runat="server" ID="DNThamGia" />
                    </div>
                    <div id="tabs-2" class="tab-pane fade">
                        <WORKS:DNMoiTG runat="server" ID="DNMoiTG" />
                    </div>
                    <div id="tabs-3" class="tab-pane fade">
                        <WORKS:DSUngVien runat="server" ID="DSUngVien" />
                    </div>
                    <div id="tabs-4" class="tab-pane fade">
                        <WORKS:DSMoiUV runat="server" ID="DSMoiUV" />
                    </div>
                    <div id="tabs-5" class="tab-pane fade">
                        <WORKS:DSBaoCao runat="server" ID="DSBaoCao" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
    </div>
</div>
<script type="text/javascript">
    $(document).ready(function () {
        $('a[data-toggle="tab"]').on('show.bs.tab', function (e) {
            localStorage.setItem('activeTab', $(e.target).attr('href'));
        });
        var activeTab = localStorage.getItem('activeTab');
        if (activeTab) {
            $('#myTab a[href="' + activeTab + '"]').tab('show');
        }
    });
</script>
