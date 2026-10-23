<%@ Control Language="vb" CodeFile="SettingDoor.ascx.vb" Inherits="Modules.SettingAuto.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Thiết lập cửa tiếp nhận xếp hàng lấy số</h3>
        </div>
        <div class="col-md-6">
            <div class="col-md-3 pdt5 b">Chọn trung tâm</div>
            <div class="col-md-9">
                <asp:DropDownList Enabled="false" ID="drPortal" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="box-body ">
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
            <div class="col-md-3 pdt5 b">Chọn tháng</div>
            <div class="col-md-3">
                <asp:DropDownList ID="drMonth" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="col-md-2 pdt5 b">Chọn năm</div>
            <div class="col-md-4">
                <asp:DropDownList ID="drYear" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
            </div>
        </div>
        <div class="col-md-6">
            <div class="col-md-3 pdt5 b">Số cửa mặc định</div>
            <div class="col-md-4">
                <asp:TextBox ID="txtSoCua" runat="server" Text="2" CssClass="TextBox" ></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:button ID="cmdChangeDoor" runat="server" Text="Thay đổi" CssClass="cmsbut Refresh" ></asp:button>
            </div>

        </div>
        <div class="row">
            <div class="col-md-12 pdl5">
                <b>Lịch tiếp dân</b>
            </div>
            <asp:DataGrid ID="grdTime" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
                <ItemStyle BackColor="#fbf2ec" />
                <AlternatingItemStyle BackColor="#ffffff" />
                <Columns>
                    <asp:TemplateColumn HeaderText="Thứ">
                        <ItemTemplate>
                            <asp:Literal runat="server" ID="litThu" />
                        </ItemTemplate>
                        <HeaderStyle Width="8%" HorizontalAlign="Center" CssClass="fix-column STT" />
                        <ItemStyle Width="8%" HorizontalAlign="Center" CssClass="fix-column STT" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Ngày">
                        <ItemTemplate>
                            <asp:Literal runat="server" ID="litDate" />
                        </ItemTemplate>
                        <HeaderStyle Width="7%" HorizontalAlign="Center" CssClass="fix-column STT" />
                        <ItemStyle Width="7%" HorizontalAlign="Center" CssClass="fix-column STT" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Số cửa tiếp dân">
                        <ItemTemplate>
                            <asp:TextBox runat="server" ID="txtNumDoor" CssClass="TextBox text-center" />
                        </ItemTemplate>
                        <ItemStyle CssClass="column-primary" HorizontalAlign="Center" />
                        <HeaderStyle CssClass="column-primary" HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Ghi chú">
                        <ItemTemplate>
                            <asp:TextBox runat="server" ID="txtNotes" CssClass="TextBox text-center" />
                        </ItemTemplate>
                        <ItemStyle Width="15%" HorizontalAlign="Center" />
                        <HeaderStyle Width="15%" HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="(Sáng) Số lượt tiếp">
                        <ItemTemplate>
                            <asp:TextBox Enabled="false" runat="server" ID="txtSumWelcomeSA" CssClass="TextBox text-center" />
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Right" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="(Chiều) Số lượt tiếp">
                        <ItemTemplate>
                            <asp:TextBox Enabled="false" runat="server" ID="txtSumWelcomeCH" CssClass="TextBox text-center" />
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Right" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Tổng số lượt tiếp">
                        <ItemTemplate>
                            <asp:TextBox Enabled="false" runat="server" ID="txtSumWelcome" CssClass="TextBox text-center" />
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Right" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Đã đăng ký">
                        <ItemTemplate>
                            <asp:TextBox Enabled="false" runat="server" ID="txtSumRegister" CssClass="TextBox text-center" />
                        </ItemTemplate>
                        <ItemStyle Width="10%" HorizontalAlign="Center" />
                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Ngày nghỉ">
                        <ItemTemplate>
                            <asp:CheckBox Enabled="false" runat="server" ID="chkDayOff" />
                        </ItemTemplate>
                        <ItemStyle Width="8%" HorizontalAlign="Center" />
                        <HeaderStyle Width="8%" HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
        </div>
        <div class="clr clUp"></div>
        <asp:Literal ID="litUpdate" runat="server" />
    </div>
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
    <asp:HiddenField ID="IsLang" runat="server" Visible="false" />
    <asp:HiddenField ID="HidNumDoor" runat="server" Value="0" />
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick=" return $('#Form').validationEngine('validate'); " />
    </div>
</div>
<script>
    function caclwelcome(t, t2, t3, t4) {
        $("#" + t2).val($(t).val() * $("#<%=HidNumDoor.ClientID%>").val());
        var tong = $("#" + t2).val();
        $("#" + t3).val(Math.floor(tong / 2));
        $("#" + t4).val(Math.round(tong / 2, 0));
        $("#" + t3).attr("value", Math.floor(tong / 2));
        $("#" + t4).attr("value", Math.round(tong / 2, 0));
        $("#<%=grdTime.ClientID%>").trigger('reloadGrid');
    }
</script>
