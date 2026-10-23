<%@ Control Language="vb" CodeFile="Report4.ascx.vb" Inherits="Modules.Report.Edit" AutoEventWireup="false" Explicit="True" %>

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info ">
            <div class="box-header with-border">
                <div class="col-md-5">
                    <h3 class="box-title">Danh sách lao động làm việc ở nước ngoài (<asp:Literal ID="litCount" runat="server" />)</h3>
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
                        <div class="col-md-3">
                            <asp:DropDownList ID="drQuanHuyen" AutoPostBack="true" runat="server" CssClass="selectpicker " />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="drPhuongXa" AutoPostBack="true" runat="server" CssClass="selectpicker " />
                        </div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="drThonTo" runat="server" CssClass="selectpicker " />
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
                        <asp:Literal ID="litPage1" runat="server" />
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                                <ItemStyle BackColor="#fbf2ec" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderStyle-CssClass="hdTitle" HeaderText="STT">
                                        <ItemTemplate>
                                            <asp:Literal ID="IsOrder" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Họ tên" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="HoTen" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="left" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Giới tính" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="GioiTinh" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="8%" HorizontalAlign="center" />
                                        <ItemStyle HorizontalAlign="center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Ngày sinh" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="NgaySinh" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="15%" HorizontalAlign="center" />
                                        <ItemStyle HorizontalAlign="center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Trình độ CM" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="TrinhDoCM" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="12%" HorizontalAlign="Left" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Công việc đang làm" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="CongViec" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Left" />
                                        <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Địa chỉ nơi làm" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="DiaChiLamViec" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Left" />
                                        <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
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
            <asp:HiddenField ID="ItemId" runat="server" />
            <asp:HiddenField ID="currPage" runat="server" Visible="false" />
            <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
            <asp:HiddenField ID="YearPro" runat="server" Visible="false" />
            <asp:HiddenField ID="IsNow" runat="server" Visible="false" />
            <asp:HiddenField ID="hidTotal" runat="server" />

        </div>
        <script type="text/javascript">
            function cmdRefresh_Click() { waiting(); $(".cmdRun").click(); }
            function exports() {
                var tp = $("#<%=drTinhTP.ClientID %>").val();
                var qh = $("#<%=drQuanHuyen.ClientID %>").val();
                var px = $("#<%=drPhuongXa.ClientID %>").val();
                var tto = $("#<%=drThonTo.ClientID %>").val();
                var ttu = $("#<%=DoTuoiTu.ClientID %>").val();
                var tden = $("#<%=DoTuoiDen.ClientID %>").val();
                var total = $("#<%=hidTotal.ClientID %>").val();
                var year = $("#<%=drYear.ClientID %>").val();
                var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
                window.open("/exports?page=work&view=ExCungLD&typeid=report-four&tp=" + tp + "&qh=" + qh + "&xp=" + px + "&tto=" + tto + "&ttu=" + ttu + "&tden=" + tden + "&year=" + year + "&total=" + total + "&dtype=" + dtype);
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
