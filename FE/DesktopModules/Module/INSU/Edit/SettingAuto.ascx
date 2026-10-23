<%@ Control Language="vb" CodeFile="SettingAuto.ascx.vb" Inherits="Modules.SettingAuto.Edit" AutoEventWireup="false" Explicit="True" %>
<style>
    .w100 {
        width: 100px
    }
</style>
<div class="box box-info ">
    <div class="box-header with-border">
        <h3 class="box-title">Thiết lập đăng ký lấy số tự động</h3>
    </div>
    <div class="box-body ">
        <div class="col-md-6">
            <div class="col-md-3 pdt5 b">Chọn trung tâm</div>
            <div class="col-md-9">
                <asp:DropDownList ID="drPortal" Enabled="false" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
            </div>
        </div>
        <div class="col-md-6">
            <div class="col-md-3 pdt5 b">Chọn vệ tinh</div>
            <div class="col-md-9">
                <asp:DropDownList ID="drSatellite" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>

            </div>
        </div>
        <div class="col-md-6">
            <div class="col-md-3 pdt5 b">Chọn dịch vụ xử lý </div>
            <div class="col-md-9">
                <asp:DropDownList ID="drFlagType" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
            </div>
        </div>
        <div class="col-md-6">
            <div class="col-md-6 pdt5 b">Số lượng hồ sơ xử lý 1 cửa/1 ngày</div>
            <div class="col-md-6">
                <telerik:RadNumericTextBox ID="txtNumDoor" ShowSpinButtons="true" NumberFormat-DecimalDigits="0" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12 pdl5">
                <b>Cấu hình khung giờ tiếp dân trong ngày</b>
            </div>
            <asp:DataGrid ID="grdTime" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
                <ItemStyle BackColor="#fbf2ec" />
                <AlternatingItemStyle BackColor="#ffffff" />
                <Columns>
                    <asp:TemplateColumn HeaderText="STT">
                        <ItemTemplate>
                            <asp:TextBox ID="IsOrder" ReadOnly="true" runat="server" CssClass="std med txt-center noborder" />
                        </ItemTemplate>
                        <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                        <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Giờ từ">
                        <ItemTemplate>
                            <div style="display: flex">
                                <asp:DropDownList ID="FHour" runat="server" CssClass="selectpicker" /><div class="w100 pdt5">giờ</div>
                                <asp:DropDownList ID="FMinute" runat="server" CssClass="selectpicker" />
                                <div class="w100 pdt5">phút</div>
                            </div>
                        </ItemTemplate>
                        <HeaderStyle Width="20%" HorizontalAlign="Center" CssClass="fix-column STT" />
                        <ItemStyle Width="20%" HorizontalAlign="Center" CssClass="fix-column STT" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Giờ đến">
                        <ItemTemplate>
                            <div style="display: flex">
                                <asp:DropDownList ID="THour" runat="server" CssClass="selectpicker" /><div class="w100 pdt5 pdl10">giờ</div>
                                <asp:DropDownList ID="TMinute" runat="server" CssClass="selectpicker" /><div class="w100 pdt5 pdl10">phút </div>
                            </div>
                        </ItemTemplate>
                        <ItemStyle Width="20%" CssClass="column-primary"  />
                        <HeaderStyle Width="20%" CssClass="column-primary"  HorizontalAlign="Center"/>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Giờ sáng?">
                        <ItemTemplate>
                                <asp:CheckBox ID="chkMorning" runat="server" CssClass="selectpicker" />
                        </ItemTemplate>
                        <ItemStyle Width="5%"  HorizontalAlign="Center" />
                        <HeaderStyle Width="5%"  HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
        </div>
        <div class="clr clUp"></div>
        <asp:Literal ID="litUpdate" runat="server" />
    </div>
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
    <asp:HiddenField ID="IsLang" runat="server" Visible="false" />
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick=" return $('#Form').validationEngine('validate'); " />
    </div>
</div>
