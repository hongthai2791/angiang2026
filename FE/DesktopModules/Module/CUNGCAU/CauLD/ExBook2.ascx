<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="ExBook2.ascx.vb" Inherits="DesktopModules.Modules.Reports.Reports1" %>
           <asp:Label runat="server" ID="lblDownLoad" Style="display: none;"></asp:Label>

        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">SỔ DOANH NGHIỆP (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-2 txt-center lb">
                    Kỳ nhập liệu
                </div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drYear" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                    <asp:DropDownList Visible="false" ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm theo tên, email, sđt..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row none">
                        <div class="col-md-12">
                            <fieldset>
                                <legend>Gửi thông báo yêu cầu doanh nghiệp cập nhật thông tin</legend>
                                <div class="col-md-12">
                                    <div class="col-md-2 pdt5 pdr0">Yêu cầu cập nhật từ</div>
                                    <div class="col-md-2">
                                        <div class="rccalpopup">
                                            <asp:TextBox ID="tbTuNgay" Placeholder="dd/mm/yyyy" CssClass="datepicker std med validate[required]" runat="server" />
                                        </div>
                                    </div>
                                    <div class="col-md-2 pdt5 txt-right">Đến hết ngày</div>
                                    <div class="col-md-2">
                                        <div class="rccalpopup">
                                            <asp:TextBox ID="tbDenNgay" Placeholder="dd/mm/yyyy" CssClass="datepicker std med validate[required]" runat="server" />
                                        </div>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:CheckBox runat="server" ID="SendMail" Checked="true" Text="Gửi email nhắc thông báo?" CssClass="CheckBox" />
                                    </div>
                                    <div class="col-md-2 center">
                                        <asp:Button CssClass="cbSendMail" runat="server" ID="cmdSend" Text="Gửi thông báo" />
                                    </div>
                                </div>
                            </fieldset>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3 col-xs-6">
                            <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker TinhTP" />
                        </div>
                        <div class="col-md-3 col-xs-6">
                            <asp:DropDownList ID="PhuongXa" runat="server" AutoPostBack="true" CssClass="selectpicker PhuongXa" />
                        </div>
                        <div class="col-md-3 col-xs-6">
                            <asp:DropDownList ID="ThonTo" runat="server" AutoPostBack="true" CssClass="selectpicker ThonTo" />
                        </div>
                        <div class="col-md-3 col-xs-6">
                               <asp:DropDownList ID="NganhNghe" AutoPostBack="true" inext="SanPhamChinh" runat="server" CssClass="selectpicker NganhNghe" />
                        </div>
                        <div class="col-md-4 none">
                            <asp:DropDownList ID="TrangThai" runat="server" AutoPostBack="true" CssClass="selectpicker Years_ID" />
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
                                        <asp:CheckBox ID="IsDelete" runat="server" CssClass="CheckBox cDel" ToolTip="Chọn để xuất?" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="STT" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle Width="5%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Mã DN" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="MaDoanhNghiep" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="7%" HorizontalAlign="Center" />
                                    <ItemStyle Width="7%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Mã số ĐKKD" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TaxCode" runat="server" />
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
                                        <asp:Literal ID="DienThoai" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="15%" />
                                    <ItemStyle Width="15%" />
                                </asp:TemplateColumn>
                                 <asp:TemplateColumn HeaderText="Tình trạng" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TbDaCapNhat" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="120px" HorizontalAlign="Center" />
                                    <ItemStyle Width="120px" HorizontalAlign="Center" />
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

                </div>
            </div>
        </div>

        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" Visible="false" runat="server" Text="Đóng lại" CssClass="cmsbut cmsback cbclick" />
                <asp:LinkButton ID="cmdExport" runat="server" Text="Xuất sổ" ToolTip="Xuất những doanh nghiệp được chọn"  CssClass="cmsbut cmsbtExport cbclick" />
                <asp:LinkButton ID="cmdExportAll" runat="server" Text="Xuất toàn bộ"  CssClass="cmsbut cmsbtExport cbclick" />

            </div>
        </div>
  