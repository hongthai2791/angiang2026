<%@ Control Language="vb" CodeFile="Provide_ThanhVienView.ascx.vb" Inherits="Modules.ThanhVien.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Danh sách đối tượng (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-3">
                    <asp:Literal ID="txtYear" runat="server"></asp:Literal>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                    <asp:DropDownList ID="drPageSize" Visible="false" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-1 txt-right">
                    <asp:Button ID="cmdDelete" runat="server" Text="Xóa đối tượng" CssClass="cmsbut cmsbtdel" />
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
                        <div class="col-md-3 ">
                            <asp:DropDownList ID="ThonTo" onchange="waiting();" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:TextBox ID="txtkey" runat="server" placeholder="Mã doanh nghiệp, họ tên đối tượng..." CssClass="timKiemD" Columns="20" Width="100%" />
                        </div>
                        
                        <div class="col-md-3">
                            <asp:DropDownList runat="server" ID="drYearCreated" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList runat="server" ID="drQuocTich" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-2">
                            <asp:DropDownList runat="server" ID="drGioiTinh" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3">
                            <asp:Button ID="cmdSearch" runat="server" OnClientClick="retunwaiting()" CausesValidation="False" Text="Tìm kiếm" CssClass="cmsbut cbtk cmsbtSearch mgr5" />
                            <asp:Button  ID="cmdExport" OnClientClick="popexp('exports');" runat="server" Text="Xuất dữ liệu" CssClass="btn btn-info" />
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
                                <asp:TemplateColumn HeaderText="Họ tên đối tượng" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="HoTenHo" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Giới tính" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="GioiTinh" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" HorizontalAlign="Left" />
                                    <ItemStyle Width="10%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày sinh" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NgaySinh" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                    <ItemStyle Width="15%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Số hộ chiếu" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CCCD" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="18%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Mã doanh nghiệp" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="MaDoanhNghiep" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="20%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngày cập nhật" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NgayCapNhat" runat="server" />
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
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới đối tượng" CssClass="cmsbut cmsbtnew cbclick" />
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
        <asp:AsyncPostBackTrigger ControlID="cmdDelete" />
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="QuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="PhuongXa" />
        <asp:AsyncPostBackTrigger ControlID="drQuanHuyenS" />
        <asp:AsyncPostBackTrigger ControlID="drPhuongXaS" />
    </Triggers>
</asp:UpdatePanel>
<!-- Modal -->
<div id="sapNhapToanThon" class="modal fade" role="dialog">
    <div class="modal-dialog ">
        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Sáp nhập toàn bộ dữ liệu hộ của Thôn/tổ sang địa bàn khác</h4>
            </div>
            <div class="modal-body qlte ">
                    <fieldset style="margin-top: 0px">
                        <legend>Thôn/tổ lấy dữ liệu</legend>
                        <div class="sndatare">
                        </div>
                    </fieldset>
                    <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" ChildrenAsTriggers="true" runat="server">
                        <ContentTemplate>
                            <fieldset>
                                <legend>Chọn địa bàn nhận dữ liệu</legend>
                                <div class="col-md-2">Quận/Huyện</div>
                                <div class="col-md-10">
                                    <asp:DropDownList ID="drQuanHuyenSF" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                                </div>
                                <div class="col-md-2">Phường/Xã</div>
                                <div class="col-md-10">
                                    <asp:DropDownList ID="drPhuongXaSF" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                                </div>
                                <div class="col-md-2">Thôn/Tổ</div>
                                <div class="col-md-10">
                                    <asp:DropDownList ID="drThonToSF" runat="server" CssClass="selectpicker" ></asp:DropDownList>
                                </div>

                            </fieldset>
                            <div class="row strong red pdt10 pdb10 mgt20">
                                Lưu ý:
                            <p>- Toàn bộ hộ của Thôn/tổ được chọn sẽ được chuyển sang địa bàn khác. </p>
                                <p>- Thông tin Thôn/tổ được giữ nguyên khi sang địa bàn mới </p>
                            </div>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="drQuanHuyenS" />
                            <asp:AsyncPostBackTrigger ControlID="drPhuongXaS" />
                        </Triggers>
                    </asp:UpdatePanel>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdSapNhapFull" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<!-- Modal -->
<div id="sapNhap" class="modal fade" role="dialog">
    <div class="modal-dialog " style="height: 400px; overflow: hidden">
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
                        <div class="row strong" style="padding-bottom: 70px">
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
<asp:HiddenField ID="hidNow" runat="server" />
<asp:HiddenField ID="hidTotal" runat="server" />
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
                    <asp:CheckBox runat="server" Checked="true" ID="chkIndexAll" CssClass="CheckBox" />
                </div>
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
            <div class="modal-body" style="height: 200px;">
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
    function getDataRe() {
        $(".sndatare").html("Quận/Huyện: " + $("#<%=QuanHuyen.ClientID%> option:selected").text() + "<br/> Phường/Xã: " + $("#<%=PhuongXa.ClientID%> option:selected").text() + "<br/>Thôn/Tổ: " + $("#<%=ThonTo.ClientID%> option:selected").text())
    }
    $(function () {
        getDataRe()
    })
    function reIndex() { $('.titlereIndexHo').html("Đánh lại mã hộ cho " + $('#<%=ThonTo.ClientID%> option:selected').text()); $('#reIndexHo').modal('show'); };
    function sapnhap() { $("#<%=grdData.ClientID%>").each(function () { var $checkbox = $(this).find("input[type='checkbox']"); if ($checkbox.is(':checked')) { $('#sapNhap').modal('show'); } else { notify('warning', "Không có hộ gia đình nào được chọn để thực hiện sáp nhập") } }); };
    function chuyenho() { $("#<%=grdData.ClientID%>").each(function () { var $checkbox = $(this).find("input[type='checkbox']"); if ($checkbox.is(':checked')) { $('#chuyenHo').modal('show'); } else { notify('warning', "Không có hộ gia đình nào được chọn để thực hiện chuyển hộ") } }); };
    function capnhatso() { $("#<%=grdData.ClientID%>").each(function () { var $checkbox = $(this).find("input[type='checkbox']"); if ($checkbox.is(':checked')) { $('#upsoSo').modal('show'); } else { notify('warning', "Không có hộ gia đình nào được chọn để cập nhật số sổ") } }); };
    function exports() {
        var tp = $("#<%=TinhTP.ClientID %>").val();
        var qh = $("#<%=QuanHuyen.ClientID %>").val();
        var px = $("#<%=PhuongXa.ClientID %>").val();
        var tto = $("#<%=ThonTo.ClientID %>").val();
        var iNow = $("#<%=hidNow.ClientID %>").val();
        var total = $("#<%=hidTotal.ClientID %>").val();
        var year = $("#<%=YearPro.ClientID %>").val();
        var cryear = $("#<%=drYearCreated.ClientID %>").val();
        var qtich = $("#<%=drQuocTich.ClientID %>").val();
        var gtinh = $("#<%=drGioiTinh.ClientID %>").val();
        var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
        window.open("/exports?page=work&view=ExNLDNN&typeid=exBook&tp=" + tp + "&qh=" + qh + "&xp=" + px + "&tto=" + tto + "&year=" + year + "&cryear=" + cryear + "&qtich=" + qtich + "&gtinh=" + gtinh + "&total=" + total + "&iNow=" + iNow + "&dtype=" + dtype);
        return false;
    };
</script>
