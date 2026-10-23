<%@ Control Language="vb" CodeFile="DayOffEdit.ascx.vb" Inherits="Modules.DayOffEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin nội dung ngày nghỉ, nghỉ lễ tết</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-2 lb">Diễn giải</div>
            <div class="col-md-4">
                <asp:TextBox ID="OffTime_Name" runat="server" TextMode="MultiLine" Height="50" CssClass="TextBox validate[required]" />
            </div>
            <div class="clr"></div>
            <div class="col-md-2 lb">Ngày nghỉ</div>
            <div class="col-md-4">
                <asp:TextBox ID="IsDay" runat="server" CssClass="TextBox validate[required,custom[number]]" />
            </div>
            <div class="clr"></div>
            <div class="col-md-2 lb">Tháng</div>
            <div class="col-md-4">
                <asp:DropDownList ID="IsMonth" runat="server" CssClass="selectpicker validate[required]" />
            </div>
            <div class="clr"></div>
            <div class="col-md-2 lb">Năm</div>
            <div class="col-md-4">
                <asp:TextBox ID="IsYear" runat="server" CssClass="TextBox validate[custom[number]]" />
            </div>
            <div class="clr"></div>
            <div class="col-md-2 lb">Sử dụng?</div>
            <div class="col-md-10">
                <asp:CheckBox ID="IsActive" CssClass="CheckBox" runat="server" />
            </div>
            <div class="clr"></div>
            <div class="col-md-2 lb">Thứ tự</div>
            <div class="col-md-4">
                <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox validate[custom[number]]" />
            </div>
            <div class="clr clUp"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Cập nhật" CssClass="cmsbut cmsbtupdate" OnClientClick=" return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
