<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Market_Run.ascx.vb" Inherits="Modules.SVL.US.Market_Run.View" %>
<%@ Register Src="~/DesktopModules/Member/Market/USE/USE_DoanhNghiep.ascx" TagPrefix="BT" TagName="USE_DoanhNghiep" %>
<%@ Register Src="~/DesktopModules/Member/Market/USE/USE_ViecLam.ascx" TagPrefix="BT" TagName="USE_ViecLam" %>
<%@ Register Src="~/DesktopModules/Member/Market/USE/USE_BaoCao.ascx" TagPrefix="BT" TagName="USE_BaoCao" %>
<style>
    .modal-backdrop
    {
        display:none !important;
    }
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
                    <li class="active"><a data-toggle="tab" href="#tabs-1">Nhà tuyển dụng
                            <span class="header_number">&nbsp;<%= Session.Item("USE_DoanhNghiep")%> </span>
                    </a></li>
                    <li><a data-toggle="tab" href="#tabs-2">Danh sách việc làm
                            <span class="header_number">&nbsp;<%= Session.Item("USE_ViecLam")%> </span>
                    </a></li>
                    <li><a data-toggle="tab" href="#tabs-3">Thống kê - báo cáo</a></li>
                </ul>
                <div class="tab-content">
                    <div id="tabs-1" class="tab-pane fade in active">
                        <BT:USE_DoanhNghiep runat="server" ID="USE_DoanhNghiep" />
                    </div>
                    <div id="tabs-2" class="tab-pane fade">
                        <BT:USE_ViecLam runat="server" ID="USE_ViecLam" />
                    </div>
                    <div id="tabs-3" class="tab-pane fade">
                        <BT:USE_BaoCao runat="server" ID="USE_BaoCao" />
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
         debugger;
        $('a[data-toggle="tab"]').on('show.bs.tab', function (e) {
            localStorage.setItem('activeTab', $(e.target).attr('href'));
        });
        var activeTab = localStorage.getItem('activeTab');
     var tab = ('<%= idtab%>');
        if (tab == "tabs-2") {
            $('#tabs a[href="' + "#tabs-2" + '"]').tab('show');
        }
        else {
            $('#tabs a[href="' + activeTab + '"]').tab('show');
        }
    });

</script>
