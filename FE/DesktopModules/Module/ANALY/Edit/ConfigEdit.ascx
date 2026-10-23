<%@ Control Language="vb" CodeFile="ConfigEdit.ascx.vb" Inherits="Modules.Child.View" AutoEventWireup="false" Explicit="True" %>
<style>
    .cmsbut{height:auto !important}
</style>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Thiết lập hệ thống</h3>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-2">Tỉnh/TP</div>
                        <div class="col-md-4">
                            <asp:DropDownList  ID="drTinhTP" runat="server"  CssClass="selectpicker validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2">Kỳ dữ liệu</div>
                        <div class="col-md-4">
                            <asp:DropDownList Enabled="false"  AutoPostBack="true" runat="server" CssClass="selectpicker" ID="Config_Value" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 none">Khóa kỳ</div>
                        <div class="col-md-6 none">
                            <asp:CheckBox runat="server" CssClass="Checkbox" ID="IsLock" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 none">Thông báo</div>
                        <div class="col-md-8 none">
                            <asp:TextBox TextMode="MultiLine" Width="100%" Height="100px" runat="server" ID="Notes" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 none">Dân số</div>
                        <div class="col-md-8 none">
                             <asp:TextBox runat="server" ID="Popula" CssClass="TextBox" />
                           
                        </div>
                         <div class="clear"></div>
                        <div class="col-md-2 none">Logo Đơn vị</div>
                        <div class="col-md-8 none">
                             <asp:TextBox runat="server" ID="LogoDv" CssClass="TextBox" />
                        </div>
                    </div>
                    <div class="row">
                <div class="col-md-2 pdt5">
                   Khoảng quan sát
                </div>
                <div class="col-md-2">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year1" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                </div>
                <div class="col-md-2">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-GroupSeparator="" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="Year2" runat="server" CssClass="TextBox"></telerik:RadNumericTextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 text-left pdt5">
                   Số năm dự báo
                </div>
                <div class="col-md-1">
                    <telerik:RadNumericTextBox Width="100%" NumberFormat-DecimalDigits="0" ShowSpinButtons="true" ID="txtSoNam" CssClass="TextBox" Value="3" runat="server"></telerik:RadNumericTextBox>
                </div>
            </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate cbclick" OnClientClick="return retunwaiting();" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="ItemID" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="Config_Value" />
    </Triggers>
</asp:UpdatePanel>
<script>
    function smartNotice(remsec) {
        if (remsec == -1) {
            window.location.reload();
            return;
        }
        delay = remsec * 1000;
        $(".fix-btt-toolbar").html("<span class='label label-info strong'>Hệ thống sẽ tự động tải lại dữ liệu sau: <b style='font-size:16px'>" + remsec + "</b> giây </span>" );
        setTimeout(function () { smartNotice(remsec - 1); }, delay);
    };
    function senddata(pid, matinh, isyear, username, notif) {
        if (confirm('Bạn có chắc chắn muốn kết chuyển dữ liệu của ' + notif + '?')) {
            waiting();
            $.ajax({
                type: 'GET', url: '/api/hng/data.asmx/SendData?pid=' + pid + '&matinh=' + matinh + '&yr=' + isyear + '&username=' + username,
                success: function (data) {
                    removewaiting();
                    var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                        notify('success', json.data, 'Thông báo', false)

                    };
                      smartNotice(2);
                },
                error: function (data) {
                    removewaiting();
                    var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                        notify('info', json.data, 'Thông báo', false)
                    };
                }
            });

        };
    };
</script>
