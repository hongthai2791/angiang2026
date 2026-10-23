<%@ Control Language="vb" CodeFile="Provide_FixView.ascx.vb" Inherits="Modules.HoGD.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-8">
                    <h3 class="box-title">Kiểm tra dữ liệu lỗi (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-3">
                    <asp:Literal ID="txtYear" runat="server"></asp:Literal>
                </div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-4">
                            <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="QuanHuyen" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="PhuongXa" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>

                        <div class="col-md-4">
                            <asp:DropDownList ID="ThonTo" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-2 lb txt-center">
                            Loại dữ liệu lỗi
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drErrorType" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="cmdSearch" OnClientClick="retunwaiting()"  runat="server" CausesValidation="False" Text="Tìm kiếm thành viên" CssClass="cbtk cmsbut cmsbtSearch" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
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
                                <asp:TemplateColumn Visible="false" HeaderText="Số sổ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IdSo" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thôn/Tổ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DiaChi" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Họ tên" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="HoTen" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateColumn>

                                <asp:TemplateColumn HeaderText="Học vấn" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="HocVan" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="10%" HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Trình độ CMKT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="CMKT" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="12%" HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Ngành nghề" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="NganhNghe" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="10%" HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Việc làm" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="ViecLam" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="10%" HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thất nghiệp" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="ThatNghiep" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="10%" HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Không HĐKT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="KHDKT" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                    <HeaderStyle Width="10%" HorizontalAlign="Left" />
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
                <asp:Literal runat="server" ID="ltrFix"></asp:Literal>
            </div>
        </div>

        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="YearPro" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />

    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drPageSize" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="QuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="PhuongXa" />
    </Triggers>
</asp:UpdatePanel>
<!-- TDHV -->
<div id="TDHV" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Sửa lỗi trình độ học vấn không có dữ liệu</h4>
            </div>
            <div class="modal-body">
                <div class="row ">
                    <div class="col-md-12 lb" id="countFix"></div>
                    <div class="col-md-4">Trình độ học vấn</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="drTrinhDo" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdTDHV" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<!-- CMKT -->
<div id="CMKT" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Sửa lỗi chuyên môn kỹ thuật không có dữ liệu</h4>
            </div>
            <div class="modal-body">
                <div class="row ">
                    <div class="col-md-4">Trình độ chuyên môn</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="drCMKT" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdCMKT" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<!-- TDGD -->
<div id="TDGD" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Sửa lỗi chưa tốt nghiệp 12 nhưng có trình độ từ trung cấp trở lên</h4>
            </div>
            <div class="modal-body">
                <div class="row ">
                    <div class="col-md-4">Trình độ chuyên môn</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="drCMKT2" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdCMKT2" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<!-- KVLKTNKHDKT -->
<div id="KVLKTNKHDKT" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Sửa lỗi không có việc làm, không thất nghiệp, không HĐKT</h4>
            </div>
            <div class="modal-body">
                <div class="row ">
                    <div class="col-md-4">Công việc tham gia</div>
                    <div class="col-md-8">
                        <asp:DropDownList onchange="removethatnghiep();removektg();" ID="drCongViec2" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                    <div class="col-md-4">Loại thất nghiệp</div>
                    <div class="col-md-8">
                        <asp:DropDownList onchange="removecvl();removektg();" ID="drLoaiThatNghiep2" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>

                    <div class="col-md-4">Lý do không HĐKT</div>
                    <div class="col-md-8">
                        <asp:DropDownList onchange="removethatnghiep();removecvl();" ID="drKhongThamGia" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdKVLKTNKHDKT" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<!-- TNKHDKT -->
<div id="TNKHDKT" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Sửa lỗi vừa thất nghiệp, vừa HĐKT</h4>
            </div>
            <div class="modal-body">
                <div class="row ">
                    <div class="col-md-4">Loại thất nghiệp</div>
                    <div class="col-md-8">
                        <asp:DropDownList onchange="removektg();" ID="drLoaiThatNghiep3" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                    <div class="col-md-4">Lý do không HĐKT</div>
                    <div class="col-md-8">
                        <asp:DropDownList onchange="removethatnghiep();" ID="drKtg3" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdTNKHDKT" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<!-- CVLKHDKT -->
<div id="CVLKHDKT" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Sửa lỗi vừa có việc làm, vừa không HĐKT</h4>
            </div>
            <div class="modal-body">
                <div class="row ">
                    <div class="col-md-4">Công việc tham gia</div>
                    <div class="col-md-8">
                        <asp:DropDownList onchange="removektg();" ID="drCongViec3" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                    <div class="col-md-4">Lý do không HĐKT</div>
                    <div class="col-md-8">
                        <asp:DropDownList onchange="removecvl();" ID="drKtg4" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdCVLKHDKT" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<!-- NganhNghe -->
<div id="NganhNghe" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Sửa lỗi ngành nghề không có dữ liệu</h4>
            </div>
            <div class="modal-body">
                <div class="row ">
                    <div class="col-md-4">Ngành nghề</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="drNganhNghe" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdNganhNghe" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<!-- CVLTN -->
<div id="CVLTN" class="modal fade" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Sửa lỗi thành viên vừa có việc làm vừa thất nghiệp</h4>
            </div>
            <div class="modal-body">
                <div class="row ">
                    <div class="col-md-4">Công việc tham gia</div>
                    <div class="col-md-8">
                        <asp:DropDownList onchange="removethatnghiep();" ID="drCongViec" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>

                    <div class="col-md-4">Loại thất nghiệp</div>
                    <div class="col-md-8">
                        <asp:DropDownList onchange="removecvl();" ID="drLoaiThatNghiep" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="cmdCVLTN" runat="server" Text="Thực hiện" CssClass="cmsbut cmsbtsend" />
            </div>
        </div>

    </div>
</div>
<script>
    function removethatnghiep() {
        $("#<%=drLoaiThatNghiep.ClientID%>").val(""); $("#<%=drLoaiThatNghiep.ClientID%>").selectpicker('refresh');
        $("#<%=drLoaiThatNghiep2.ClientID%>").val(""); $("#<%=drLoaiThatNghiep2.ClientID%>").selectpicker('refresh');
        $("#<%=drLoaiThatNghiep3.ClientID%>").val(""); $("#<%=drLoaiThatNghiep3.ClientID%>").selectpicker('refresh');
    };
    function removecvl() {
        $("#<%=drCongViec2.ClientID%>").val(""); $("#<%=drCongViec2.ClientID%>").selectpicker('refresh');
        $("#<%=drCongViec.ClientID%>").val(""); $("#<%=drCongViec.ClientID%>").selectpicker('refresh');
        $("#<%=drCongViec3.ClientID%>").val(""); $("#<%=drCongViec3.ClientID%>").selectpicker('refresh');
    };

    function removektg() {
        $("#<%=drKhongThamGia.ClientID%>").val(""); $("#<%=drKhongThamGia.ClientID%>").selectpicker('refresh');
        $("#<%=drKtg3.ClientID%>").val(""); $("#<%=drKtg3.ClientID%>").selectpicker('refresh');
        $("#<%=drKtg4.ClientID%>").val(""); $("#<%=drKtg4.ClientID%>").selectpicker('refresh');
    };
    function fixEr(t) {
        var i = 0
      <%--  $("#<%=grdData.ClientID%>").each(function () {
            var $checkbox = $(this).find("input[type='checkbox']"); if ($checkbox.is(':checked')) {
                alert(1);
                i ++;
            }
        });
        $('#countFix').html('Số thành viên cập nhật: ' + i);--%>
        $("#<%=grdData.ClientID%>").each(function () {
            var $checkbox = $(this).find("input[type='checkbox']"); if ($checkbox.is(':checked')) {
                $(t).modal('show');
            } else { notify('warning', "Không có thành viên nào được chọn để sửa lỗi") }
        });
    };
</script>
