<%@ Control Language="vb" CodeFile="Report5.ascx.vb" Inherits="Modules.Report.Edit" AutoEventWireup="false" Explicit="True" %>

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info ">
            <div class="box-header with-border">
                <div class="col-md-5">
                    <h3 class="box-title">Thống kê thị trường lao động</h3>
                </div>
                <div class="col-md-1 txt-center lb">Tỉnh/TP</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drTinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker " />
                </div>
                <div class="col-md-1 txt-center lb">Năm BC</div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drYear" runat="server" CssClass="selectpicker " />
                </div>
                <div class="col-md-2">
                    <asp:Button ID="cmdRefresh" runat="server" Text="Tổng hợp lại" CssClass="cmsbut cmdTH" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-2 txt-center lb">Quận/huyện</div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="drQuanHuyen" AutoPostBack="true" runat="server" CssClass="selectpicker " />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="drPhuongXa" AutoPostBack="true" runat="server" CssClass="selectpicker " />
                        </div>
                        <div class="col-md-1 txt-center lb">Tuổi từ</div>
                        <div class="col-md-1">
                            <telerik:RadNumericTextBox Width="100%" ID="DoTuoiTu" MinValue="0"  Value="15" runat="server" CssClass="TextBox" ShowSpinButtons="true" NumberFormat-DecimalDigits="0" />
                        </div>
                        <div class="col-md-1 txt-center lb">đến</div>
                        <div class="col-md-1">
                            <telerik:RadNumericTextBox Width="100%" ID="DoTuoiDen" MinValue="0"  Value="65" runat="server" CssClass="TextBox" ShowSpinButtons="true" NumberFormat-DecimalDigits="0" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <table border="1" cellspacing="0" width="100%">
                                <tr style="text-align: center; color: #fff; vertical-align: middle">
                                    <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 5%">STT</td>
                                    <td class="hdTitle" style="background-color: #566869; font-size: 12px;">Chỉ số</td>
                                    <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 10%">Đơn vị tính</td>
                                    <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 10%">Kỳ trước</td>
                                    <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 10%">Tăng trong kỳ</td>
                                    <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 10%">Giảm trong kỳ</td>
                                    <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 10%">Kỳ báo cáo</td>
                                </tr>
                                <asp:Literal ID="litData" runat="server" />
                            </table>
                        </div>
                    </div>
                </div>

                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
                        <asp:Button ID="cmdView" OnClientClick="retunwaiting();" runat="server" Text="Xem báo cáo" CssClass="cmsbut cmdview" />
                        <asp:Button ID="cmdExport" runat="server" Text="Xuất ra Excel" OnClientClick="popexp('exports');" CssClass="cmsbut cmdexel " />
                        <asp:Button ID="cmdRun" runat="server" Text="cmdRun" CssClass="none cmdRun " />
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" />
            <asp:HiddenField ID="YearPro" runat="server" />
            <asp:HiddenField ID="IsNow" runat="server" Visible="false" />
        </div>
        <script type="text/javascript">
            function cmdRefresh_Click() { waiting(); $(".cmdRun").click(); }
            function exports() {
                var tp = $("#<%=drTinhTP.ClientID %>").val();
                    var qh = $("#<%=drQuanHuyen.ClientID %>").val();
                    var px = $("#<%=drPhuongXa.ClientID %>").val();
                    var ttu = $("#<%=DoTuoiTu.ClientID %>").val();
                    var tden = $("#<%=DoTuoiDen.ClientID %>").val();
                    var year = $("#<%=drYear.ClientID %>").val();
                var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
                window.open("/exports?page=work&view=ExCungLD&typeid=report-five&tp=" + tp + "&qh=" + qh + "&xp=" + px + "&ttu=" + ttu + "&tden=" + tden + "&year=" + year + "&dtype=" + dtype);
                return false;
            };
        </script>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drTinhTP" />
        <asp:AsyncPostBackTrigger ControlID="drQuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="drPhuongXa" />
    </Triggers>
</asp:UpdatePanel>
