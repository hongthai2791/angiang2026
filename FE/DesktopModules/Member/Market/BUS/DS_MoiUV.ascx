<%@ Control Language="VB" AutoEventWireup="false" CodeFile="DS_MoiUV.ascx.vb" Inherits="Modules.SVL.DSMoiUV.View" %>
<asp:UpdatePanel runat="server" ID="DSMoiUV_Panel">
    <ContentTemplate>
        <div class="row">
            <div class="col-md-8">
                <asp:DropDownList AutoPostBack="true" ID="tinTuyenDung" CssClass="selectpicker" runat="server" />
            </div>
            <div class="col-md-2">
                <asp:Button ID="cmdDSMoiUV_Active" CssClass="da-button blue large" runat="server" OnCommand="ActiveUV" CommandName="InviteUV" Text="Mời ứng viên" />

                <asp:Button ID="cmdDSMoiUV_News" Visible="false" CssClass="da-button blue large " runat="server" OnClientClick="$('#themUngVien').modal('show');return false;" Text="Thêm mới ứng viên" />
            </div>
            <div class="col-md-2">
                <asp:DropDownList AutoPostBack="true" Visible="false" ID="drtrangthai"  CssClass="selectpicker" runat="server" />
            </div>
            <div class="clear"></div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:DataGrid ID="gdUv" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                    <ItemStyle BackColor="#f8f4f1" />
                    <AlternatingItemStyle BackColor="#ffffff" />
                    <Columns>
                        <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                            <HeaderTemplate>
                                <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="IsCheck" runat="server" CssClass="cs-select cDel" ToolTip="Chọn" />
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
                        <asp:TemplateColumn HeaderText="Tên ứng viên" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="tenDayDu" runat="server" />
                            </ItemTemplate>
                             <HeaderStyle Width="15%" />
                        </asp:TemplateColumn>   
                       <asp:TemplateColumn Visible="false" HeaderText="Việc làm" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="TuyenDung_Name" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Điện thoại" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="Tel" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="12%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Email liên hệ" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="UserName" Visible="false" runat="server" />
                                <asp:Literal ID="Email" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="12%" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Tình trạng" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="TrangThai" runat="server"></asp:Literal>
                            </ItemTemplate>
                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                            <ItemStyle Width="10%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
            <div class="col-md-12">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <div class="clear"></div>
        </div>
        <asp:HiddenField ID="DSMoiUV_currPage" Value="1" runat="server" />
        <asp:HiddenField ID="DSMoiUV_ItemID" Value="" runat="server" />
        <asp:HiddenField ID="BusID" runat="server" />
        <asp:HiddenField ID="hidBusiness_ID" Value="" runat="server" />
        <asp:Button ID="cmdDSMoiUV_Next" runat="server" CssClass="none" />

        <script type="text/javascript">
            function nextpage_uv(pa) {
                $("#<%=DSMoiUV_currPage.ClientID %>").val(pa);
                $("#<%=cmdDSMoiUV_Next.ClientID %>").click();
            }
        </script>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="tinTuyenDung" />
        <asp:AsyncPostBackTrigger ControlID="cmdDSMoiUV_Active" />
    </Triggers>
</asp:UpdatePanel>

<div class="modal fade " id="themUngVien" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-md">
        <div class="modal-content" style="width: 700px">
            <div class="modal-header">
                <h5 class="modal-title">Thông tin ứng viên</h5>
            </div>
            <div class="moda-body">
                <div class="col-md-3 pdt5">Địa chỉ email</div>
                <div class="col-md-9">
                    <asp:TextBox ID="N_Email" runat="server" CssClass="TextBox validate[required,custom[email]]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 pdt5">Tên ứng viên</div>
                <div class="col-md-9">
                    <asp:TextBox ID="N_TenUngVien" runat="server" CssClass="TextBox  validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 pdt5">Ngày sinh</div>
                <div class="col-md-3">
                    <asp:TextBox ID="N_NgaySinh" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="col-md-3 txt-right pdt5">Giới tính</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="N_GioiTinh" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 pdt5">Điện thoại</div>
                <div class="col-md-3">
                    <asp:TextBox ID="N_DienThoai" runat="server" CssClass="TextBox  validate[required]"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="col-md-3 txt-right pdt5">Số năm kinh nghiệm</div>
                <div class="col-md-3">
                    <asp:TextBox ID="N_NamKinhNghiem" runat="server" CssClass="TextBox validate[custom[number]]"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 pdt5">Địa chỉ liên hệ</div>
                <div class="col-md-9">
                    <asp:TextBox ID="N_DiaChi" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 pdt5">Ngành nghề</div>
                <div class="col-md-9">
                    <asp:DropDownList ID="N_NganhNghe" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 pdt5">Chuyên môn</div>
                <div class="col-md-9">
                    <asp:DropDownList ID="N_ChuyenMon" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng lại</button>
                <button type="button" onclick="waiting();saveuv();" class="btn btn-primary">Thêm ứng viên</button>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    function saveuv() {
        var icount = parseInt($(".soungvien").text()) + 1;
        if ($('#Form').validationEngine('validate')) {
            var phien, email, tel, hten, nkm, nghe, cmon, dchi, gtinh, nsinh;
            phien = "<%=PhienGD_ID%>";
            dnghiep = $("#<%=BusID.ClientID%>").val();
            email = $("#<%=N_Email.ClientID %>").val();
            tel = $("#<%=N_DienThoai.ClientID %>").val();
            hten = $("#<%=N_TenUngVien.ClientID %>").val();
            nkm = $("#<%=N_NamKinhNghiem.ClientID %>").val();
            nghe = $("#<%=N_NganhNghe.ClientID %>").val();
            cmon = $("#<%=N_ChuyenMon.ClientID %>").val();
            dchi = $("#<%=N_DiaChi.ClientID %>").val();
            gtinh = $("#<%=N_GioiTinh.ClientID %>").val();
            nsinh = $("#<%=N_NgaySinh.ClientID %>").val();
            $.ajax({
                type: 'GET', url: '/api/work/works.asmx/saveUV?pid=0&phien=' + phien + '&dnghiep=' + phien + '&email=' + email + '&tel=' + tel + '&hten=' + hten + '&nkm=' + nkm + '&nghe=' + nghe + '&cmon=' + cmon + '&dchi=' + dchi + '&gtinh=' + gtinh + '&nsinh=' + nsinh,
                success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data) {
                        if (json.data = "Success") {
                            $('#themUngVien').modal('hide'); notify('success', 'Đã thêm ứng viên vào phiên thành công.', 'Thông báo', false); removewaiting();
                            var hml = "<tr style='background-color: #fff;'>";
                            hml += "<td align='center'>" + icount + "</td>";
                            hml += "<td>" + hten + "</td>";
                            hml += "<td>" + tel + "</td>";
                            hml += "<td>" + email + "</td>";
                            hml += "<td align='center'><a href='javascript:;'><img src='/image/images/view.png'></a>";
                            hml += '&nbsp;|&nbsp;<a herf="javascript:;" onclick="xoaungvien(0,' + "'" + json.data + "'" + ',this);">';
                            hml += "<img src='/portals/_default/skins/vbn/images/delete.png' title='Xóa dòng này'></a></td>";
                            hml += "</tr>";
                            $("table.ungvienthamgia tbody").append(hml);
                            $(".soungvien").text(icount);
                            $(".lblSoUngVien").text(icount);
                            location.reload();
                        }
                        else {
                            $('#themUngVien').modal('hide'); notify('info', 'Yêu cầu của bạn hệ thống chưa kịp xử lý.', 'Thông báo', false); removewaiting()

                        }
                    }
                }
            });
        }
        else {
            //$('#themUngVien').modal('hide'); notify('info', 'Bạn chưa nhập đầy đủ thông tin ứng viên.', 'Thông báo', false); removewaiting();
        }
    };
</script>
