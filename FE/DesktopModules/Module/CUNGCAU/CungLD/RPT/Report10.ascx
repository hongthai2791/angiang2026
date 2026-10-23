<%@ Control Language="vb" CodeFile="Report10.ascx.vb" Inherits="Modules.Report.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info ">
            <div class="box-header with-border">
                <div class="col-md-5">
                    <h3 class="box-title">Tổng hợp biến động</h3>
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
                        <div class="col-md-4">
                            <asp:DropDownList ID="drQuanHuyen" AutoPostBack="true" runat="server" CssClass="selectpicker " />
                        </div>
                        <div class="col-md-6">
                            <asp:DropDownList ID="drPhuongXa" AutoPostBack="true" runat="server" CssClass="selectpicker " />
                            <asp:DropDownList ID="drThonTo" Visible="false" runat="server" CssClass="selectpicker " />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="clear"></div>
                    <div class="row">
                        <div class="col-md-12">
                            <table border="1" cellspacing="0" width="100%">
                                <tr style="text-align: center; color: #fff; vertical-align: middle">
                                    <td class="hdTitle" rowspan="2" style="background-color: #566869; font-size: 12px; width: 5%">STT</td>
                                    <td class="hdTitle" rowspan="2" style="background-color: #566869; font-size: 12px">Đơn vị</td>
                                    <td class="hdTitle" rowspan="2" style="background-color: #566869; font-size: 12px; width: 10%">Tổng số bản ghi ban đầu</td>
                                    <td class="hdTitle" colspan="3" style="background-color: #566869; font-size: 12px; ">Tổng số bản ghi thay đổi, trong đó</td>
                                </tr>
                                <tr style="text-align: center; color: #fff; vertical-align: middle">
                                    <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 12%">Nhập mới</td>
                                    <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 12%">Biến động</td>
                                    <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 12%">Điều chỉnh khác</td>
                                </tr>
                                <tr style="text-align: center; color: #fff; vertical-align: middle">
                                    <td class="hdTitle">(1)</td>
                                    <td class="hdTitle">(2)</td>
                                    <td class="hdTitle">(3)</td>
                                    <td class="hdTitle">(4)</td>
                                    <td class="hdTitle">(5)</td>
                                    <td class="hdTitle">(6)</td>
                                </tr>
                                <asp:Literal ID="litData" runat="server" />
                            </table>
                        </div>
                    </div>
                </div>
            </div>

            <div class="fix-btt-toolbar">
                <div>
                    <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
                    <asp:Button ID="cmdView" runat="server" Text="Xem báo cáo" OnClientClick="retunwaiting();" CssClass="cmsbut cmdview" />
                    <asp:Button ID="cmdExport" runat="server" Text="Xuất ra Excel" OnClientClick="popexp('exports');" CssClass="cmsbut cmdexel " />
                    <asp:Button ID="cmdRun" runat="server" Text="cmdRun" CssClass="none cmdRun " />
                    <div class="clear"></div>
                </div>
            </div>
        </div>
        <asp:HiddenField ID="YearPro" runat="server" Visible="false" />
        <asp:HiddenField ID="IsNow" runat="server" Visible="false" />

        <script type="text/javascript">
            function cmdRefresh_Click() { waiting(); $(".cmdRun").click(); }
            function exports() {
                var tp = $("#<%=drTinhTP.ClientID %>").val();
                var qh = $("#<%=drQuanHuyen.ClientID %>").val();
                var px = $("#<%=drPhuongXa.ClientID %>").val();
                var year = $("#<%=drYear.ClientID %>").val();
                var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
                window.open("/exports?page=work&view=ExCungLD&typeid=report-ten&tp=" + tp + "&qh=" + qh + "&xp=" + px + "&year=" + year + "&dtype=" + dtype);
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
