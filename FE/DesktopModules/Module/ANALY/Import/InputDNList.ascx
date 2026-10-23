<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="InputDNList.ascx.vb" Inherits="DesktopModules.Modules.InputDNList" %>
<asp:UpdatePanel runat="server" ID="poe">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Danh sách phiếu thu thập thông tin Doanh nghiệp (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drSort" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-1 pdt5">Tháng:</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="ThangKhaoSat" Width="50px" runat="server" CssClass="selectpicker validate[required] " />
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drYear" CssClass="selectpicker" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="drPageSize" Visible="false" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-3 col-xs-6 none">
                            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker TinhTP" />
                        </div>
                        <div class="col-md-3 col-xs-6">
                            <asp:DropDownList ID="QuanHuyen" runat="server" AutoPostBack="true" CssClass="selectpicker QuanHuyen" />
                            <asp:DropDownList ID="XaPhuong" runat="server" CssClass="selectpicker XaPhuong none" />
                        </div>
                        <div class="col-md-3 col-xs-6 none">
                            <asp:DropDownList ID="KCN" runat="server" AutoPostBack="true" CssClass="selectpicker KCN" />
                        </div>
                        <div class="col-md-6 col-xs-6">
                            <asp:TextBox ID="txtkey" runat="server" placeholder="Tên DN, Mã ĐKKD ..." CssClass="timKiemD" Columns="20" Width="100%" />
                            <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                        </div>
                        <div class="clear"></div>
                    </div>

                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsDelete" runat="server" CssClass="CheckBox cDel" ToolTip="Chọn để xóa?" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <img src="/portals/_default/skins/vbn/images/hover_edit.png?w" alt="Edit" title="Chỉnh sửa" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Literal ID="IsEdit" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Mã phiếu" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="MaDoanhNghiep" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="7%" HorizontalAlign="Center" />
                                    <ItemStyle Width="7%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Mã số ĐKKD" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="MaSDDKD" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    <ItemStyle Width="10%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tên doanh nghiệp" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TenDoanhNghiep" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DiaChi" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="30%" />
                                    <ItemStyle Width="30%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Email/ Điện thoại" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Email" runat="server" /><br />
                                        <asp:Literal ID="SoDienThoai" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="20%" />
                                    <ItemStyle Width="20%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày cập nhật" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NgayCapNhat" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    <ItemStyle Width="10%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <asp:Literal ID="lbMsg" runat="server"></asp:Literal>
                    <asp:HiddenField ID="currPage" runat="server" />
                    <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
                    <asp:HiddenField ID="YearPro" runat="server" />

                </div>
            </div>
        </div>

        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew cbclick" OnClientClick="return retunwaiting();" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa phiếu" CssClass="cmsbut cmsbtdel" />
                <%--<asp:Button ID="cmdImport" runat="server" Text="Import dữ liệu" CssClass="cmsbut cmdExcel cbclick" OnClientClick="return retunwaiting();" />--%>
                <a id="A1" runat="server" style="height: auto" onclick="retunwaiting();upfile();" title="Import dữ liệu" class="cmsbut cmdExcel">Nhập từ excel</a>
                <asp:LinkButton ID="cmdDownload" OnClientClick="popexp('exports');" runat="server" Text="Tải mẫu Import" CssClass="cmsbut cmsbtDownload cbclick" />
                <%--<asp:Button ID="cmdExport" OnClientClick="popexp('exports');" runat="server" Text="Xuất dữ liệu" CssClass="cmsbut cmdexcel" />--%>
            </div>
        </div>
        <div runat="server" id="pnHidValue" style="display: none">
            <asp:DropDownList runat="server" ID="drQuyMo" />
            <asp:DropDownList runat="server" ID="drKyNang" />
            <asp:DropDownList runat="server" ID="drMucDo" />
            <asp:DropDownList runat="server" ID="drTrinhDo" />
            <asp:DropDownList runat="server" ID="drNghe" />
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="QuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="KCN" />
    </Triggers>
</asp:UpdatePanel>
<asp:Button runat="server" ID="cmdUpfile" CssClass="none" />
<asp:HiddenField runat="server" ID="pathTemp" Visible="false" />
<asp:FileUpload ID="fileImages" onchange="upLoad()" accept=".xlsx,.xls" CssClass="none" AllowMultiple="false" runat="server" />

<script type="text/javascript">
    function upfile(t) { jQuery("#<%= fileImages.ClientID%>").click(); }; function upLoad() { jQuery("#" + '<%= cmdUpfile.ClientID%>').click(); };
    function exports() { var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" } window.open("/api/analy/reportsDN.aspx?pid=0&tp=" + $("#<%=TinhTP.ClientID %>").val() + "&qh=" + $("#<%=QuanHuyen.ClientID %>").val()) };
</script>
