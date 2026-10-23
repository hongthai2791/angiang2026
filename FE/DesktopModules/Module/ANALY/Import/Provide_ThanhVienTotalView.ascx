<%@ Control Language="vb" CodeFile="Provide_ThanhVienTotalView.ascx.vb" Inherits="Modules.ThanhVienTotal.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Tổng hợp phiếu thu thập thông tin Người lao động (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-1 pdt5">Tháng:</div>
                <div class="col-md-2">
                    <asp:DropDownList ID="ThangKhaoSat"  runat="server" CssClass="selectpicker validate[required] " />
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="NamKhaoSat" runat="server" CssClass="selectpicker validate[required] " />
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
                            <asp:Button Visible="false" ID="cmdExport" OnClientClick="popexp('exports');" runat="server" Text="Xuất dữ liệu" CssClass="btn btn-info" />
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
                                        <asp:Literal ID="MaPhieu" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="7%" HorizontalAlign="Center" />
                                    <ItemStyle Width="7%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>

                                <asp:TemplateColumn HeaderText="Họ tên" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="HoTenHo" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateColumn>

                                <asp:TemplateColumn HeaderText="Giới tính" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="GioiTinh" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="7%" HorizontalAlign="Center" />
                                    <ItemStyle Width="7%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày sinh" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NgaySinh" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                    <ItemStyle Width="12%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="CMND/CCCD" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CMND" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="7%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Số ĐT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="SDT" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="8%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Email" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="EMAIL" runat="server" />
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
                                <asp:TemplateColumn HeaderText="Người cập nhật" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NguoiCapNhat" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
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
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="YearPro" runat="server" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="linkEdit" runat="server" Visible="false" />
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
