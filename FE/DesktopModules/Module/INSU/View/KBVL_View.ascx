<%@ Control Language="vb" CodeFile="KBVL_View.ascx.vb" Inherits="Modules.KBVL.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-9">
                    <h3 class="box-title">
                        <asp:Literal ID="litTitle" runat="server" />
                        (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-3 pdr0">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-2 lb">Đơn vị tiếp nhận</div>
                        <div class="col-md-5">
                            <asp:DropDownList ID="DonVi" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-1 txt-center lb">Cơ sở</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="VeTinh" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-2 lb">Thời gian nộp HS</div>
                        <div class="col-md-1">
                            <asp:DropDownList ID="drNam" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-1 lb txt-center">Tháng</div>
                        <div class="col-md-1">
                            <asp:DropDownList ID="drThang" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-1 lb txt-center">Ngày</div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="drNgay" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-1 txt-center lb">Tình trạng</div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="TinhTrang" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                            <PagerStyle PageButtonCount="5" HorizontalAlign="Right" NextPageText="Next"
                                PrevPageText="Previous" CssClass="pagG" Mode="NumericPages" />
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
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
                                    <ItemStyle Width="4%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn Visible="false" HeaderText="Mã hồ sơ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NoCode" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="10%" HorizontalAlign="Center" />
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Họ và tên" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="HoTen" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Số CMND" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="SoCMND" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="9%" HorizontalAlign="Center" />
                                    <HeaderStyle Width="9%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Số QĐ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="QD_So" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="10%" />
                                    <HeaderStyle Width="10%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Điện thoại" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DienThoai" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="9%" HorizontalAlign="Center" />
                                    <HeaderStyle Width="9%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="TT việc làm" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TinhTrangVL" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="10%" />
                                    <HeaderStyle Width="10%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày khai báo" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NgayNopHS" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="12%" HorizontalAlign="Center" />
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Vệ tinh" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="VeTinh" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="12%" HorizontalAlign="Center" />
                                    <HeaderStyle Width="12%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Đính kèm" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DinhKem" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="8%" HorizontalAlign="Center" />
                                    <HeaderStyle Width="8%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Nhận" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="TiepNhan" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle Width="7%" HorizontalAlign="Center" />
                                    <HeaderStyle Width="7%" HorizontalAlign="Center" />
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

        <asp:Panel runat="server" ID="pHot" CssClass="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdSetting" runat="server" Text="Thiết lập" CssClass="cmsbut cmdSettings" OnClientClick="return $('#Form').validationEngine('detach');" />
                <div class="clear"></div>
            </div>
        </asp:Panel>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="TINH_TRANG" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <script type="text/javascript">
            function tiepnhan(id, t) {
                $.ajax({
                    type: "GET", url: '/api/insu/bhtn.asmx/kbvl?pid=' + $("#<%=DonVi.ClientID%>").val() + "&id=" + id + "&tt=1",
                    success: function (data) {
                        var json = $.parseJSON($(data).find("string").text());
                        if (json.data == "1") {
                            $(t).parent("div").html("<img src='/image/icon_success_new.png?w=22' title='Đã tiếp nhận'>");
                            notify('success', 'Đã tiếp nhận hồ sơ khai báo việc làm thành công.', 'Thông báo', false);
                        };
                    },
                });
            }
            function tralai(id, t) {
                if (confirm("Bạn có chắc muốn trả lại hồ sơ khai báo này không?") == true) {
                    $.ajax({
                        type: "GET", url: '/api/insu/bhtn.asmx/kbvl?pid=' + $("#<%=DonVi.ClientID%>").val() + "&id=" + id + "&tt=2",
                        success: function (data) {
                            var json = $.parseJSON($(data).find("string").text());
                            if (json.data == "1") {
                                notify('info', 'Đã từ chối tiếp nhận hồ sơ khai báo việc làm.', 'Thông báo', false);
                                $(t).parent("div").html("<img src='/image/back-2.png?w=22' title='Trả lại'>");
                            };
                        },
                    });

                }
            }
        </script>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drNgay" />
        <asp:AsyncPostBackTrigger ControlID="drThang" />
        <asp:AsyncPostBackTrigger ControlID="drNam" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <asp:AsyncPostBackTrigger ControlID="VeTinh" />
        <asp:AsyncPostBackTrigger ControlID="DonVi" />
        <asp:AsyncPostBackTrigger ControlID="TinhTrang" />
    </Triggers>
</asp:UpdatePanel>
