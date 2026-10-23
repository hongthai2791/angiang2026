<%@ Control Language="vb" CodeFile="DonHangXKLDEdit.ascx.vb" Inherits="Modules.DonHangXKLDEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin đơn hàng xuất khẩu lao động</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên đơn hàng</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="TieuDe" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Ngày bắt đầu<sup class="txt-red">*</sup></div>
                    <div class="col-md-2 rccalpopup">
                        <asp:TextBox ID="NgayBatDau" autocomplete="off" placeholder="dd/mm/yyyy" CssClass=" datepicker TuNgay TextBox validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 txt-right lb">Số lượng<sup class="txt-red">*</sup></div>
                    <div class="col-md-2">
                        <asp:TextBox ID="SoLuong" autocomplete="off" CssClass="DenNgay TextBox validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 txt-right lb">Mức lương<sup class="txt-red">*</sup></div>
                    <div class="col-md-2">
                        <asp:TextBox ID="MucLuong" autocomplete="off" CssClass="DenNgay TextBox validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Địa điểm (nếu trực tiếp)</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="DiaDiem" runat="server" MaxLength="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Mô tả công việc</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="MoTa" runat="server" Height="100" CssClass="TextBox" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Trạng thái</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="drTrangThai" CssClass="selectpicker" runat="server">
                            <asp:ListItem Value="1">Lên lịch</asp:ListItem>
                            <asp:ListItem Value="2">Dang diễn ra</asp:ListItem>
                            <asp:ListItem Value="3">Đã hoàn thành</asp:ListItem>
                            <asp:ListItem Value="4">Hủy</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-9">
                        <h3 class="box-title">Danh sách lao động (<asp:Literal ID="litCount" runat="server" />)</h3>
                    </div>
                    <div class="col-md-3 pdr0">
                        <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm lao động ..." CssClass="timKiemD" Columns="20" Width="100%" />
                        <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-12">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsDelete" runat="server" CssClass="cs-select cDel" ToolTip="Chọn để xóa?" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="#" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="ID" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" />
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tên tài khoản" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Username" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="20%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Họ và tên" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DisplayName" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Số điện thoại" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Telephone" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày đăng ký" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CreatedDate" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                     Đã giới thiệu
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsIntroduce" runat="server" CssClass="cs-select cDel" ToolTip="Chọn để đánh dấu đã được giới thi?" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="8%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                        <asp:Button ID="cmdDeleteNLD" runat="server" Text="Xóa NLD" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpIntroduce" runat="server" ToolTip="Đánh dấu những lao động đã được giới thiệu" Text="Đánh dấu giới thiệu" CssClass="cmsbut cmdactive" OnClientClick="$('#Form').validationEngine('detach');" />
                        <a class="copy_text cmsbut"  data-toggle="tooltip" title="Chia sẻ đơn hàng người lao động" href="<%=DotNetNuke.EPORTAL.flReg.WebConfig("WorkDomain") %>/work/edit/job-orderxkld/itemid/<%=ItemId.Value %>">Chia sẻ đơn hàng</a>
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

<script>
    $('.copy_text').click(function (e) {
        e.preventDefault();
        var copyText = $(this).attr('href');

        document.addEventListener('copy', function (e) {
            e.clipboardData.setData('text/plain', copyText);
            e.preventDefault();
        }, true);

        document.execCommand('copy');
        notify('success', 'Chia sẻ đường dẫn đơn hàng người lao động thành công.', 'Thông báo', false);
    });
</script>