<%@ Control Language="vb" CodeFile="Report8.ascx.vb" Inherits="Modules.Report.Edit" AutoEventWireup="false" Explicit="True" %>
<style>
    .BoxDynamic option {
        padding: 8px 4px;
        font-size: 14px;
    }
</style>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-8">
            <h3 class="box-title">Biểu tổng hợp tùy biến</h3>
        </div>
        <div class="col-md-1 txt-center lb">Tỉnh/TP</div>
        <div class="col-md-3">
            <asp:DropDownList ID="drTinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker " />
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body ">
            <div class="col-md-4">
                <asp:DropDownList ID="drQuanHuyen" AutoPostBack="true" runat="server" CssClass="selectpicker " />
            </div>
            <div class="col-md-4">
                <asp:DropDownList ID="drPhuongXa" AutoPostBack="true" runat="server" CssClass="selectpicker " />
            </div>
            <div class="col-md-2 lb txt-center">Năm dữ liệu</div>
            <div class="col-md-2">
                <asp:DropDownList ID="drYear" runat="server" CssClass="selectpicker " />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 txt-center lb">Chọn hàng</div>
            <div class="col-md-4">
                <asp:DropDownList ID="drRow" runat="server" CssClass="selectpicker " />
            </div>
            <div class="col-md-2 lb txt-center">Chọn cột</div>
            <div class="col-md-4">
                <asp:DropDownList ID="drCol" runat="server" CssClass="selectpicker " />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 txt-center lb">Tùy chọn 1</div>
            <div class="col-md-4">
                <asp:DropDownList ID="drOption" runat="server" CssClass="selectpicker " />
            </div>
            <div class="col-md-2 lb txt-center">Tùy chọn 2</div>
            <div class="col-md-4">
                <asp:DropDownList ID="drOption2" runat="server" CssClass="selectpicker " />
            </div>
            <div class="row scroll" style="overflow: auto">
                <div class="col-md-12">
                    <asp:Literal runat="server" ID="litData" />
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
                <asp:Button ID="cmdView" OnClientClick="waiting();" runat="server" Text="Xem kết quả" CssClass="cmsbut cmdview" />
                <asp:LinkButton ID="cmdExport" runat="server" Text="Xuất ra Excel" OnClientClick="removewaiting();" CssClass="cmsbut cmdexel " />
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="ItemId" runat="server" />
    <asp:HiddenField ID="currPage" runat="server" Visible="false" />
    <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    <asp:HiddenField ID="YearPro" runat="server" Visible="false" />
    <asp:HiddenField ID="IsNow" runat="server" Visible="false" />
    <asp:HiddenField ID="regionalID" runat="server" Value="0" />
    <asp:HiddenField ID="regionalLevel" runat="server" Value="1" />
</div>

