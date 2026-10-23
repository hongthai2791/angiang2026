<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Market_Run.ascx.vb" Inherits="Modules.SVL.Market_Run.View" %>
<%@ Register Src="~/DesktopModules/Member/Market/BUS/DS_TuyenDung.ascx" TagPrefix="uc1" TagName="DN_ThamGia" %>
<%@ Register Src="~/DesktopModules/Member/Market/BUS/DS_ViecLam.ascx" TagPrefix="uc1" TagName="DN_MoiTG" %>
<%@ Register Src="~/DesktopModules/Member/Market/BUS/DS_UngVien.ascx" TagPrefix="uc1" TagName="DS_UngVien" %>
<%@ Register Src="~/DesktopModules/Member/Market/BUS/DS_BaoCao.ascx" TagPrefix="uc1" TagName="DS_BaoCao" %>
<%@ Register Src="~/DesktopModules/Member/Market/BUS/DS_MoiUV.ascx" TagPrefix="uc1" TagName="DS_MoiUV" %>
<style>
    .nav-tabs > li.active > a {
        background: #d86196 !important;
        color: #fff !important;
        font-weight:100;
    }
    .nav-tabs > li > a {
        background: #eee !important;
        color: #444 !important;
        font-weight:100;
    }
</style>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
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
                    <ul class="nav nav-tabs" id="tabs">
                        <li class="active"><a data-toggle="tab" href="#tabs-1">Tin tuyển dụng tại phiên
                            <span class="header_number">&nbsp;<%= Session.Item("DN_ThamGia")%> </span>
                        </a></li>
                        <li><a  data-toggle="tab" href="#tabs-2">Danh sách tin tuyển dụng
                            <span class="header_number">&nbsp;<%= Session.Item("DN_MoiTG")%> </span>
                        </a></li>
                        <li><a  data-toggle="tab" href="#tabs-3">Ứng viên đã nộp hồ sơ
                            <span class="header_number">&nbsp;<%= Session.Item("DS_UngVien")%> </span>
                        </a></li>
                        <li><a data-toggle="tab" href="#tabs-4">Ứng viên tham gia sàn
                            <span class="header_number">&nbsp;<%= Session.Item("DS_MoiUV")%> </span>
                        </a></li>
                        <li><a data-toggle="tab" href="#tabs-5">Thống kê - báo cáo</a></li>
                    </ul>
                   <div class="tab-content">
                    <div id="tabs-1" class="tab-pane fade in active">
                        <uc1:DN_ThamGia runat="server" ID="DN_ThamGia" />
                    </div>
                    <div id="tabs-2" class="tab-pane fade">
                        <uc1:DN_MoiTG runat="server" ID="DN_MoiTG" />
                    </div>
                    <div id="tabs-3" class="tab-pane fade">
                        <uc1:DS_UngVien runat="server" ID="DS_UngVien" />
                    </div>
                    <div id="tabs-4" class="tab-pane fade">
                        <uc1:DS_MoiUV runat="server" ID="DS_MoiUV" />
                    </div>
                    <div id="tabs-5"  class="tab-pane fade">
                        <uc1:DS_BaoCao runat="server" ID="DS_BaoCao" />
                    </div>
                   </div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
    </div>
</div>
<script type="text/javascript">
    $(document).ready(function () {
        $('a[data-toggle="tab"]').on('show.bs.tab', function (e) {
            localStorage.setItem('activeTab', $(e.target).attr('href'));
        });
        var activeTab = localStorage.getItem('activeTab');
        if (activeTab) {
            $('#tabs a[href="' + activeTab + '"]').tab('show');
        }

    });
    
</script>