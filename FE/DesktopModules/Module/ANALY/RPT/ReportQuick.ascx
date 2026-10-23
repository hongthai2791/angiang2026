<%@ Control Language="vb" CodeFile="ReportQuick.ascx.vb" Inherits="Modules.ReportQuick.Edit" AutoEventWireup="false" Explicit="True" %>
<%@ Register Assembly="DevExpress.XtraReports.v19.1.Web.WebForms, Version=19.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraReports.v19.1.Web.WebForms, Version=19.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Báo cáo nhanh thực trạng và xu hướng thị trường lao động</h3>
        </div>
        <div class="col-md-1 lb txt-center">Đơn vị</div>
        <div class="col-md-2">
            <asp:DropDownList runat="server" ID="drTinh" CssClass="selectpicker" />
        </div>
                <div class="col-md-2 lb pdt5">
                    Khoảng quan sát
                </div>
        <div class="col-md-2">
            <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year1" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
        </div>
        <div class="col-md-2">
            <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year2" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
        </div>
        <div class="col-md-2 lb pdt5">
           Số năm dự báo
        </div>
        <div class="col-md-1">
            <telerik:RadNumericTextBox Width="100%" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" MinValue="1" MaxValue="7" ID="txtSoNam" CssClass="TextBox" Value="5" runat="server"></telerik:RadNumericTextBox>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <dx:ASPxWebDocumentViewer ID="rptView" runat="server"></dx:ASPxWebDocumentViewer>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" TabIndex="9" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdView" runat="server" Text="Xem báo cáo" TabIndex="8" CssClass="cmsbut cmdview" />
                <asp:Button ID="cmdRefresh" Visible="false" runat="server" data-toggle="tooltip" ToolTip="Tổng hợp lại dữ liệu và chạy lại dự báo dữ liệu" Text="Tổng hợp lại" TabIndex="8" CssClass="cmsbut Refresh" />

                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
    <asp:HiddenField ID="_MagazineCode" runat="server" />
</div>

