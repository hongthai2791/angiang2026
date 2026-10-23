<%@ Control Language="vb" CodeFile="Report0.ascx.vb" Inherits="Modules.Report.Edit" AutoEventWireup="false" Explicit="True" %>

<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info ">
            <div class="box-header with-border">
                <div class="col-md-5">
                    <h3 class="box-title">Danh sách lao động tổng hợp (<asp:Literal ID="litCount" runat="server" />)</h3>
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
                    <asp:Button ID="cmdRefresh" runat="server" Text="Tổng hợp lại" CssClass="cmsbut cmdTH Refresh" />
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
                            <telerik:RadNumericTextBox Width="100%" ID="DoTuoiTu" MinValue="0" Value="15" runat="server" CssClass="TextBox" ShowSpinButtons="true" NumberFormat-DecimalDigits="0" />
                        </div>
                        <div class="col-md-1 txt-center lb">đến</div>
                        <div class="col-md-1">
                            <telerik:RadNumericTextBox Width="100%" ID="DoTuoiDen" MinValue="0" Value="65" runat="server" CssClass="TextBox" ShowSpinButtons="true" NumberFormat-DecimalDigits="0" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage1" runat="server" />
                    </div>
                    <div class="row" style="overflow: auto">
                        <div class="col-md-12">
                            <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                                <ItemStyle BackColor="#fbf2ec" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderStyle-CssClass="hdTitle" HeaderText="STT">
                                        <ItemTemplate>
                                           <%#Container.ItemIndex + 1 %>
                                        </ItemTemplate>
                                        <HeaderStyle Width="3%" HorizontalAlign="Center" />
                                        <ItemStyle Width="3%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Họ tên" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <%#DataBinder.Eval(Container.DataItem, "HoTen") %>
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="left" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Giới tính" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                           <%#EPORTAL.flDic.Sex_Name(DataBinder.Eval(Container.DataItem, "GioiTinh"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="8%" HorizontalAlign="center" />
                                        <ItemStyle HorizontalAlign="center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Ngày sinh" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                           <%#EPORTAL.flReg.ReadDate(DataBinder.Eval(Container.DataItem, "NgaySinh"), False)%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="8%" HorizontalAlign="center" />
                                        <ItemStyle HorizontalAlign="center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="CCCD" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <%#DataBinder.Eval(Container.DataItem, "CMND") %>
                                        </ItemTemplate>
                                        <HeaderStyle Width="8%" HorizontalAlign="center" />
                                        <ItemStyle HorizontalAlign="center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Mã BHXH" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <%#DataBinder.Eval(Container.DataItem, "SoBHXH") %>
                                        </ItemTemplate>
                                        <HeaderStyle Width="8%" HorizontalAlign="center" />
                                        <ItemStyle HorizontalAlign="center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Quận/huyện TT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                               <%#EPORTAL.flDic.RegionalQH_Name(PId, DataBinder.Eval(Container.DataItem, "MaHuyen_TT"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Xã/phường TT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                               <%#EPORTAL.flDic.RegionalXP_Name(PId, DataBinder.Eval(Container.DataItem, "MaXa_TT"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Thôn/tổ TT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                               <%#EPORTAL.flDic.RegionalTO_Name(PId, DataBinder.Eval(Container.DataItem, "MaThon_TT"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Quận/huyện HT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                               <%#EPORTAL.flDic.RegionalQH_Name(PId, DataBinder.Eval(Container.DataItem, "MaHuyen_HT"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Xã/phường HT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                               <%#EPORTAL.flDic.RegionalXP_Name(PId, DataBinder.Eval(Container.DataItem, "MaXa_HT"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Thôn/tổ HT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                               <%#EPORTAL.flDic.RegionalTO_Name(PId, DataBinder.Eval(Container.DataItem, "MaThon_HT"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Trình độ học vấn" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                           <%# CUNG.flCheck.Education_Name(Me.PortalId, DataBinder.Eval(Container.DataItem, "TrinhDoGD"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Trình độ CM" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                           <%# CUNG.flCheck.Specialize_Name(Me.PortalId, DataBinder.Eval(Container.DataItem, "TrinhDoCM"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Chuyên ngành đào tạo" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                           <%# CUNG.flCheck.Trainning_Name(Me.PortalId, DataBinder.Eval(Container.DataItem, "LinhVucDT"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Đối tượng ưu tiên" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                           <%# DTUT_Name(DataBinder.Eval(Container.DataItem, "DTUT_NKT"), DataBinder.Eval(Container.DataItem, "DTUT_HN"), DataBinder.Eval(Container.DataItem, "DTUT_DTTS"), DataBinder.Eval(Container.DataItem, "DTUT_CN"), DataBinder.Eval(Container.DataItem, "DTUT_THUHOI"), DataBinder.Eval(Container.DataItem, "DTUT_NCC"))%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tình trạng tham gia HĐKT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <%# TinhTrangHDKT(DataBinder.Eval(Container.DataItem, "NCVL"), DataBinder.Eval(Container.DataItem, "NTN"), DataBinder.Eval(Container.DataItem, "KTGHDKT")) %>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />

                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Lý do không tham gia" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                              <%#CUNG.flCheck.Reason_Name(Me.PortalId, DataBinder.Eval(Container.DataItem, "LyDoKhongThamGia")) %>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Vị thế việc làm" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <%#CUNG.flCheck.Method_Name(Me.PortalId, DataBinder.Eval(Container.DataItem, "HinhThuc")) %>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />

                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Công việc cụ thể đang làm" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <%#CUNG.flCheck.WorkJoin_Name(Me.PortalId, DataBinder.Eval(Container.DataItem, "CongViecThamGia")) %>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />

                                    </asp:TemplateColumn>
                                    
                                    <asp:TemplateColumn HeaderText="Loại hình nơi làm việc" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <%#CUNG.flCheck.LoaiHinhNoiLamViec(DataBinder.Eval(Container.DataItem, "LoaiHinhKT")) %>
                                        </ItemTemplate>
                                        <HeaderStyle   Width="50px" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />

                                    </asp:TemplateColumn>

                                    <asp:TemplateColumn HeaderText="Người thất nghiệp" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <%#CUNG.flCheck.TypeUnemploy_Name(Me.PortalId, DataBinder.Eval(Container.DataItem, "LoaiThatNghiep")) %>                                    
                                        </ItemTemplate>
                                        <HeaderStyle   Width="50px" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />

                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Thời gian thất nghiệp" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <%#DataBinder.Eval(Container.DataItem, "ThoiGianThatNghiep") %>     
                                        </ItemTemplate>
                                        <HeaderStyle   Width="50px" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />

                                    </asp:TemplateColumn> 
                                    <asp:TemplateColumn HeaderText="Ngày tạo" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <%#EPORTAL.flReg.ReadDate(DataBinder.Eval(Container.DataItem, "CreatedDate"), False) %>
                                        </ItemTemplate>
                                        <HeaderStyle   Width="50px" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />

                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Ngày cập nhật" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                             <%#EPORTAL.flReg.ReadDate(DataBinder.Eval(Container.DataItem, "UpdatedDate"), False) %>
                                        </ItemTemplate>
                                        <HeaderStyle   Width="50px" HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Center" />

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
                        <asp:Button ID="cmdExport" Visible="false" runat="server" Text="Xuất ra Excel" OnClientClick="popexp('exports');" CssClass="cmsbut cmdexel " />
                        <asp:Button ID="cmdExportTT" runat="server" Text="Xuất theo Thôn/tổ (Nhiều tệp)" data-toggle="tooltip" ToolTip="Kết xuất dữ liệu thành nhiều tệp excel tương ứng với từng Thôn/tổ" OnClientClick="popexp('exportstt');" CssClass="cmsbut cmdexel " />
                        <asp:Button ID="cmdExportTTAll" runat="server" Text="Xuất theo Thôn/tổ (Một tệp)" data-toggle="tooltip" ToolTip="Kết xuất dữ liệu thành một tệp excel duy nhất của tất cả các Thôn/tổ" OnClientClick="popexp('exportsttall');" CssClass="cmsbut cmdexel " />
                        <asp:Button ID="cmdRun" runat="server" Text="cmdRun" CssClass="none cmdRun " />
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" />
            <asp:HiddenField ID="currPage" runat="server" Visible="false" />
            <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
            <asp:HiddenField ID="hidTotal" runat="server" />
            <asp:HiddenField ID="YearPro" runat="server" Visible="false" />
            <asp:HiddenField ID="IsNow" runat="server" Visible="false" />
        </div>
        <script type="text/javascript">

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
                window.open("/exports?page=work&view=ExCungLD&typeid=report-all&tp=" + tp + "&qh=" + qh + "&xp=" + px + "&tto=" + tto + "&ttu=" + ttu + "&tden=" + tden + "&year=" + year + "&total=" + total + "&dtype=" + dtype + "&typeex=0");
                return false;
            };
            function exportstt() {
                var tp = $("#<%=drTinhTP.ClientID %>").val();
                var qh = $("#<%=drQuanHuyen.ClientID %>").val();
                var px = $("#<%=drPhuongXa.ClientID %>").val();
                var tto = $("#<%=drThonTo.ClientID %>").val();
                var ttu = $("#<%=DoTuoiTu.ClientID %>").val();
                var tden = $("#<%=DoTuoiDen.ClientID %>").val();
                var total = $("#<%=hidTotal.ClientID %>").val();
                var year = $("#<%=drYear.ClientID %>").val();
                var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
                window.open("/exports?page=work&view=ExCungLD&typeid=report-all&tp=" + tp + "&qh=" + qh + "&xp=" + px + "&tto=" + tto + "&ttu=" + ttu + "&tden=" + tden + "&year=" + year + "&total=" + total + "&dtype=" + dtype + "&typeex=1");
                return false;
            };
            function exportsttall() {
                var tp = $("#<%=drTinhTP.ClientID %>").val();
                var qh = $("#<%=drQuanHuyen.ClientID %>").val();
                var px = $("#<%=drPhuongXa.ClientID %>").val();
                var tto = $("#<%=drThonTo.ClientID %>").val();
                var ttu = $("#<%=DoTuoiTu.ClientID %>").val();
                var tden = $("#<%=DoTuoiDen.ClientID %>").val();
                var total = $("#<%=hidTotal.ClientID %>").val();
                var year = $("#<%=drYear.ClientID %>").val();
                var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
                window.open("/exports?page=work&view=ExCungLD&typeid=report-all&tp=" + tp + "&qh=" + qh + "&xp=" + px + "&tto=" + tto + "&ttu=" + ttu + "&tden=" + tden + "&year=" + year + "&total=" + total + "&dtype=" + dtype + "&typeex=2");
                return false;
            };
            function cmdRefresh_Click() { waiting(); $(".cmdRun").click(); }
        </script>

    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drTinhTP" />
        <asp:AsyncPostBackTrigger ControlID="drQuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="drPhuongXa" />
    </Triggers>
</asp:UpdatePanel>
