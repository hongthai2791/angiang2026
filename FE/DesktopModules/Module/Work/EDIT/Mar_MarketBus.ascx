<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Mar_MarketBus.ascx.vb" Inherits="Modules.SVL.Mar_MarketBus.View" %>
<%@ Register Src="~/DesktopModules/Module/Work/EDIT/Mar_TuyenDung.ascx" TagPrefix="BT" TagName="Mar_TuyenDung" %>
<%@ Register Src="~/DesktopModules/Module/Work/EDIT/Mar_ViecLam.ascx" TagPrefix="BT" TagName="Mar_ViecLam" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-sm-12">
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
            <div class="row">
                <div id="tabs">
                    <ul>
                        <li><a href="#tabs-1">Đăng tuyển trên phiên</a></li>
                        <li><a href="#tabs-2">Tin tuyển dụng</a></li>
                    </ul>
                    <div id="tabs-1">
                        <BT:Mar_TuyenDung runat="server" ID="Mar_TuyenDung" />
                    </div>
                    <div id="tabs-2">
                        <BT:Mar_ViecLam runat="server" ID="Mar_ViecLam" />
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
<script>$('#tabs').tabs({});</script>
