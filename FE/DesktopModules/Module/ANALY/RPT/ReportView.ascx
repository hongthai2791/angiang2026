<%@ Control Language="vb" CodeFile="ReportView.ascx.vb" Inherits="Modules.Magazine.Edit" AutoEventWireup="false" Explicit="True" %>
<%@ Register Assembly="DevExpress.XtraReports.v19.1.Web.WebForms, Version=19.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">
                <asp:Literal runat="server" ID="litTitle" /></h3>
        </div>
        <div class="col-md-1 lb txt-center">Đơn vị</div>
        <div class="col-md-2">
            <asp:DropDownList runat="server" ID="drTinh" CssClass="selectpicker" />
        </div>
        <div class="col-md-2 lb txt-center">Kỳ báo cáo</div>
        <div class="col-md-2">
            <asp:DropDownList runat="server" ID="drYearID" CssClass="selectpicker" />
        </div>
        <div class="col-md-2 lb txt-center">Kỳ so sánh</div>
        <div class="col-md-2">
            <asp:DropDownList runat="server" ID="drYearIDFr" CssClass="selectpicker" />
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <dx:ASPxWebDocumentViewer ID="rptView" runat="server"></dx:ASPxWebDocumentViewer>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" TabIndex="9" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdView" runat="server" Text="Xem dữ liệu" TabIndex="8" CssClass="cmsbut cmdview" />
                <asp:Button ID="cmdRefresh" runat="server" Text="Tổng hợp lại" TabIndex="8" CssClass="cmsbut Refresh" />

                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
    <asp:HiddenField ID="_MagazineCode" runat="server" />
</div>

