<%@ Control Language="vb" CodeFile="InputNLD2024List.ascx.vb" Inherits="Modules.Analy.Import.InputNLD2024List" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Danh sách phiếu thu thập thông tin sàn việc làm v2 (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-1 pdt5">Tháng:</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="ThangKhaoSat" Width="50px" runat="server" CssClass="selectpicker validate[required] " />
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="drYear" CssClass="selectpicker" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-2 none">
                    <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker " AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="drPageSize" Visible="false" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-3">
                            <asp:DropDownList ID="QuanHuyen" onchange="waiting();" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="PhuongXa" onchange="waiting();" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-3 none">
                            <asp:DropDownList ID="ThonTo" onchange="waiting();" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtkey" runat="server" placeholder="Họ tên, CMND/CCCD, SĐT, Email.." CssClass="timKiemD" Columns="20" Width="100%" />
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="cmdSearch" runat="server" Width="100%" OnClientClick="retunwaiting()" CausesValidation="False" Text=" Tìm kiếm" CssClass="cmsbut cbtk cmsbtSearch mgr5" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPageF" runat="server" />
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#fbf2ec" />
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
                                        <asp:Literal ID="MaPhieuTuDong" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="8%" HorizontalAlign="Center" />
                                    <ItemStyle Width="8%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>

                                <asp:TemplateColumn HeaderText="Họ tên" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="HoTen" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateColumn>

                                <asp:TemplateColumn HeaderText="Giới tính" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="GioiTinh" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    <ItemStyle Width="10%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Năm sinh" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NamSinh" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                    <ItemStyle Width="12%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="CMND/CCCD" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CCCD" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Số điện thoại" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="SoDienThoai" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Email" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Email" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày cập nhật" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NgayCapNhat" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày chỉnh sửa" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NgayChinhSua" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới phiếu" CssClass="cmsbut cmsbtnew cbclick" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa phiếu" CssClass="cmsbut cmsbtdel" />
               <%-- <a id="A1" runat="server" style="height: auto" onclick="retunwaiting();upfile();" title="Import dữ liệu" class="cmsbut cmdExcel">Nhập từ excel</a>
                <asp:LinkButton ID="cmdDownload" OnClientClick="popexp('exports');" runat="server" Text="Tải mẫu Import" CssClass="cmsbut cmsbtDownload cbclick" />--%>

            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="linkEdit" runat="server" Visible="false" />

         <div runat="server" id="pnHidValue" style="display: none">
            <asp:DropDownList runat="server" ID="drDanhToc" />
            <asp:DropDownList runat="server" ID="drTonGiao" />
            <asp:DropDownList runat="server" ID="drNganhDT" />
            <asp:DropDownList runat="server" ID="drViTriCV" />
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drPageSize" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <asp:AsyncPostBackTrigger ControlID="cmdNew" />
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="QuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="PhuongXa" />
    </Triggers>
</asp:UpdatePanel>
<asp:Button runat="server" ID="cmdUpfile" CssClass="none" />
<asp:HiddenField runat="server" ID="pathTemp" Visible="false" />
<asp:FileUpload ID="fileImages" onchange="upLoad()" accept=".xlsx,.xls" CssClass="none" AllowMultiple="false" runat="server" />

<script type="text/javascript">
    function upfile(t) { jQuery("#<%= fileImages.ClientID%>").click(); }; function upLoad() { jQuery("#" + '<%= cmdUpfile.ClientID%>').click(); };
    function exports() { var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" } window.open("/api/analy/reportsNLD.aspx?pid=0&tp=" + $("#<%=TinhTP.ClientID %>").val() + "&qh=" + $("#<%=QuanHuyen.ClientID %>").val()) };
</script>
