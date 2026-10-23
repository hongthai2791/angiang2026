<%@ Control Language="vb" CodeFile="Provide_TVView.ascx.vb" Inherits="Modules.HoGD.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-7">
                    <h3 class="box-title">Danh sách thành viên (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-3">
                    <asp:Literal ID="txtYear" runat="server"></asp:Literal>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-3">
                            <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="QuanHuyen" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="PhuongXa" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="ThonTo" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="LoaiSo" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="LoaiHo" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:TextBox ID="txtkey" runat="server" placeholder="Mã hộ, họ tên chủ hộ..." CssClass="timKiemD" Columns="20" Width="100%" />
                        </div>
                        <div class="col-md-3">
                            <asp:Button ID="cmdSearch" runat="server" OnClientClick="retunwaiting()" CausesValidation="False" Text="Tìm danh sách hộ gia đình" CssClass="cmsbut cbtk cmsbtSearch" />
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
                                <asp:TemplateColumn HeaderText="Số sổ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="LoaiSo" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Mã hộ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="MaHo" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="8%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Họ tên chủ hộ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="HoTenHo" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DiaChi" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="40%" HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Số khẩu" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="SoThanhVien" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="7%" HorizontalAlign="Center" />
                                    <ItemStyle Width="7%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Loại hộ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="LoaiHo" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="7%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Loại biến động" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="LoaiBienDong" runat="server" />
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
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới hộ" CssClass="cmsbut cmsbtnew cbclick" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hidTotal" runat="server" />
        <asp:HiddenField ID="YearPro" runat="server" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drPageSize" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <asp:AsyncPostBackTrigger ControlID="cmdNew" />
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="QuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="PhuongXa" />
        <asp:AsyncPostBackTrigger ControlID="drQuanHuyenS" />
        <asp:AsyncPostBackTrigger ControlID="drPhuongXaS" />
    </Triggers>
</asp:UpdatePanel>
<!-- Modal -->
<div id="sapNhap" class="modal fade" role="dialog">
    <div class="modal-dialog " style="height:400px;overflow:hidden">
        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Sáp nhập Hộ sang địa bàn khác</h4>
            </div>
            <div class="modal-body">
                <asp:UpdatePanel ID="upSapNhap" UpdateMode="Conditional" ChildrenAsTriggers="true" runat="server">
                    <ContentTemplate>
                        <div class="col-md-2">Quận/Huyện</div>
                        <div class="col-md-10">
                            <asp:DropDownList ID="drQuanHuyenS" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-2">Phường/Xã</div>
                        <div class="col-md-10">
                            <asp:DropDownList ID="drPhuongXaS" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-2">Thôn/Tổ</div>
                        <div class="col-md-10">
                            <asp:DropDownList ID="drThonToS" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-2">Số nhà/Đường phố</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="DiaChi" runat="server" CssClass="TextBox" />
                        </div>
                        <div class="row strong" style="padding-bottom:70px">
                            Lưu ý: Vui lòng chọn đúng thôn/tổ để sáp nhập
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="drQuanHuyenS" />
                        <asp:AsyncPostBackTrigger ControlID="drPhuongXaS" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdSapNhap" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<!-- Modal -->
<div id="reIndexHo" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title titlereIndexHo">Đánh lại mã hộ cho thôn đang chọn</h4>
            </div>
            <div class="modal-body">
                <div class="col-md-4">Nhập giá trị bắt đầu</div>
                <div class="col-md-8">
                    <asp:TextBox runat="server" type="number" ID="txtIndex" CssClass="TextBox" />
                </div>
                <div class="col-md-4">Đánh mã cho toàn địa bàn</div>
                  <div class="col-md-8">
                    <asp:CheckBox runat="server" Checked="true" ID="chkIndexAll"  CssClass="CheckBox" /></div>
                <div class="row">
                      <div class="panel panel-warning pdl10 pdt10">
                        <p>Lưu ý: </p>
                             <p>- Chức năng này giúp cán bộ cập nhật lại toàn bộ mã hộ của một thôn</p>
                             <p>- Điền số dương để đánh mã tăng dần, điền số âm để đánh mã giảm dần</p>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cdmRunIndexHo" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtrun" />
            </div>
        </div>

    </div>
</div>
<!-- Modal -->

<div id="chuyenHo" class="modal fade" role="dialog">
    <div class="modal-dialog">

        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Chuyển hộ sang địa bàn khác</h4>
            </div>
            <div class="modal-body">
                <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" ChildrenAsTriggers="true" runat="server">
                    <ContentTemplate>
                        <div class="col-md-2">Quận/Huyện</div>
                        <div class="col-md-10">
                            <asp:DropDownList ID="drQuanHuyenM" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-2">Phường/Xã</div>
                        <div class="col-md-10">
                            <asp:DropDownList ID="drPhuongXaM" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-2">Thôn/Tổ</div>
                        <div class="col-md-10">
                            <asp:DropDownList ID="drThonToM" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-2">Số nhà/Đường phố</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="DiaChiMoi" runat="server" CssClass="TextBox" />
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="drQuanHuyenM" />
                        <asp:AsyncPostBackTrigger ControlID="drPhuongXaM" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdChuyen" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtdel" />
            </div>
        </div>

    </div>
</div>

<!-- Modal -->
<div id="upsoSo" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Cập nhật số sổ</h4>
            </div>
            <div class="modal-body">
                <div class="col-md-2">Chọn số sổ</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="drSo" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdUpSo" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<script>
    function exports() {
        var idso = $("#<%=LoaiSo.ClientID %>").val();
        var tp = $("#<%=TinhTP.ClientID %>").val();
        var qh = $("#<%=QuanHuyen.ClientID %>").val();
        var px = $("#<%=PhuongXa.ClientID %>").val();
         var tto = $("#<%=ThonTo.ClientID %>").val();
         var year = $("#<%=YearPro.ClientID %>").val();
        var total = $("#<%=hidTotal.ClientID %>").val();
        var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
        window.open("/exports?page=work&view=ExCungLD&typeid=exBook&tp=" + tp + "&qh=" + qh + "&xp=" + px + "&tto=" + tto + "&year=" + year + "&idso=" + idso + "&total=" + total + "&dtype=" + dtype);
        return false;
    };
    function reIndex() { $('.titlereIndexHo').html("Đánh lại mã hộ cho " + $('#<%=ThonTo.ClientID%> option:selected').text()); $('#reIndexHo').modal('show'); };
    function sapnhap() { $("#<%=grdData.ClientID%>").each(function () { var $checkbox = $(this).find("input[type='checkbox']"); if ($checkbox.is(':checked')) { $('#sapNhap').modal('show'); } else { notify('warning', "Không có hộ gia đình nào được chọn để thực hiện sáp nhập") } }); };
    function chuyenho() { $("#<%=grdData.ClientID%>").each(function () { var $checkbox = $(this).find("input[type='checkbox']"); if ($checkbox.is(':checked')) { $('#chuyenHo').modal('show'); } else { notify('warning', "Không có hộ gia đình nào được chọn để thực hiện chuyển hộ") } }); };
    function capnhatso() { $("#<%=grdData.ClientID%>").each(function () { var $checkbox = $(this).find("input[type='checkbox']"); if ($checkbox.is(':checked')) { $('#upsoSo').modal('show'); } else { notify('warning', "Không có hộ gia đình nào được chọn để cập nhật số sổ") } }); };
</script>
