<%@ Control Language="vb" CodeFile="UserConfigEdit.ascx.vb" Inherits="Modules.UserConfig.Edit" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="dnn" TagName="ImgUser" Src="~/controls/filepickeruploader.ascx" %>
<asp:HiddenField ID="ItemId" runat="server" Visible="false" />

<style>
    .tbCheckList {
        width: 100%;
    }
</style>
<div class="box box-info">

    <asp:Label runat="server" ID="lblDownLoad" Style="display: none;"></asp:Label>
    <div class="box-header with-border">
        <div class="col-md-7">
            <h3 class="box-title">Thông tin người tìm việc</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="row">
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;1. Thông tin cá nhân
            </div>
        </div>
        <div class="row">
            <div class="clr"></div>
            <div class="col-md-2 lb">Họ tên<sup class="txt-red">*</sup></div>
            <div class="col-md-4">
                <asp:TextBox ID="DisplayName" runat="server" CssClass="TextBox validate[required,maxSize[128]]"></asp:TextBox>
            </div>
            <div class="col-md-2 lb">CMND/CCCD<sup class="txt-red">*</sup></div>
            <div class="col-md-4">
                <asp:TextBox ID="CMND" runat="server" CssClass="txt txtonly validate[required,minSize[12]]" MaxLength="12" placeholder="Nhập Chứng minh nhân dân/ căn cước công dân"></asp:TextBox>
                <span class="required"></span>
            </div>

            <div class="clr"></div>
            <div class="col-md-2 lb none">Mã số BHXH</div>
            <div class="col-md-4 none">
                <asp:TextBox ID="BHXH" runat="server" CssClass="txt txtonly" placeholder=""></asp:TextBox>
            </div>
            <div class="col-md-2 lb">Ngày sinh<sup class="txt-red">*</sup></div>
            <div class="col-md-4">
                <asp:TextBox ID="DateOfBirth" placeholder="dd/mm/yyyy" data-mask="00/00/0000" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="col-md-2 lb">Giới tính<sup class="txt-red">*</sup></div>
            <div class="col-md-1">
                <asp:DropDownList ID="Gender" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                <span class="required"></span>
            </div>

            <div class="clr"></div>
            <div class="col-md-2 lb">Dân tộc<sup class="txt-red">*</sup></div>
            <div class="col-md-4">
                <%--<asp:TextBox ID="DanToc" runat="server" CssClass="txt txtonly" placeholder=""></asp:TextBox>--%>
                <asp:DropDownList ID="drNation" CssClass="selectpicker validate[required]" runat="server" />
                <span class="required"></span>
            </div>
            <div class="col-md-2 lb">Tôn giáo</div>
            <div class="col-md-4">
                <%--<asp:TextBox ID="TonGiao" runat="server" CssClass="txt txtonly" placeholder=""></asp:TextBox>--%>
                <asp:DropDownList ID="drReligion" CssClass="selectpicker" runat="server" />
            </div>

            <asp:UpdatePanel runat="server" ID="POP">
                <ContentTemplate>
                    <div class="col-md-2  lb">Nơi thường trú:<sup class="txt-red">*</sup></div>
                    <div class="col-md-4 ">
                        <asp:DropDownList ID="TinhTP" AutoPostBack="true" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>

                    <div class="col-md-2  lb">Xã</div>
                    <div class="col-md-4 ">
                        <asp:DropDownList ID="XaPhuong" AutoPostBack="true" CssClass="selectpicker" runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Địa chỉ cụ thể<sup class="txt-red">*</sup></div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Address" onkeyup="changeAddress()" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                        <span class="required"></span>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    <asp:AsyncPostBackTrigger ControlID="XaPhuong" />
                </Triggers>
            </asp:UpdatePanel>

            <asp:UpdatePanel runat="server" ID="POP2">
                <ContentTemplate>
                    <div class="col-md-2  lb">Nơi ở hiện nay:<sup class="txt-red">*</sup></div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="TinhTP2" AutoPostBack="true" CssClass="selectpicker" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2  lb">Xã</div>
                    <div class="col-md-4 ">
                        <asp:DropDownList ID="XaPhuong2" CssClass="selectpicker" runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Địa chỉ cụ thể</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Address2" runat="server" CssClass="TextBox"></asp:TextBox>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    <asp:AsyncPostBackTrigger ControlID="XaPhuong" />
                </Triggers>
            </asp:UpdatePanel>

            <div class="clr"></div>
            <div class="none">
                <div class="col-md-2 lb">Tên tài khoản<sup class="txt-red">*</sup></div>
                <div class="col-md-4">
                    <asp:TextBox ID="Username" runat="server" CssClass="TextBox validate[required,maxSize[99]]"></asp:TextBox>
                </div>
                <div class="clr"></div>
                <div class="clr"></div>
                <div class="col-md-3 lb">Ngày đăng ký</div>
                <div class="col-md-9">
                    <asp:TextBox ID="CreatedOnDate" ReadOnly="true" runat="server" CssClass="TextBox txtonly"></asp:TextBox>
                </div>
                <div class="clr"></div>
                <div class="col-md-3 lb">Thay đổi MK lần cuối</div>
                <div class="col-md-9">
                    <asp:TextBox ID="LastPasswordChangeDate" ReadOnly="true" runat="server" CssClass="TextBox txtonly"></asp:TextBox>
                </div>
                <div class="clr"></div>
                <div class="col-md-3 lb">Đăng nhập lần cuối</div>
                <div class="col-md-9">
                    <asp:TextBox ID="LastLoginDate" ReadOnly="true" runat="server" CssClass="TextBox txtonly"></asp:TextBox>
                </div>
                <div class="clr"></div>
                <asp:Panel ID="pnaView" CssClass="div100" runat="server" Visible="false">
                    <div class="col-md-3 lb">Ảnh đại diện</div>
                    <div class="col-md-9">
                        <asp:Literal ID="litLogo" runat="server" />
                    </div>
                </asp:Panel>
                <div class="clr"></div>
                <div class="col-md-3 lb">Đăng nhập lần cuối</div>
                <div class="col-md-9">
                    <asp:TextBox ID="NganHang" ReadOnly="true" runat="server" CssClass="TextBox txtonly"></asp:TextBox>
                </div>
            </div>
            <div class="clr"></div>
        </div>
        <div class="row">
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin liên lạc
            </div>
            <div class="col-md-2 lb">Điện thoại<sup class="txt-red">*</sup></div>
            <div class="col-md-4">
                <asp:TextBox ID="Telephone" runat="server" CssClass="txt validate[required]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="col-md-2 lb">Email</div>
            <div class="col-md-4">
                <asp:TextBox ID="Email" ReadOnly="true" runat="server" CssClass="TextBox txtonly validate[email]"></asp:TextBox>
            </div>
            <div class="col-md-2 lb">Liên hệ khác (nếu có)</div>
            <div class="col-md-10">
                <asp:TextBox ID="LienHeKhac" runat="server" CssClass="txt"></asp:TextBox>
            </div>
            <div class="clr"></div>
        </div>
        <div class="row">
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;Đối tượng ưu tiên (nếu có)
            </div>
            <div class="col-md-2 lb">Đối tượng ưu tiên</div>
            <div class="col-md-4">
                <asp:DropDownList runat="server" ID="DTUuTien" CssClass="selectpicker DTUuTien" multiple="multiple" data-actions-box="true"></asp:DropDownList>
                <asp:HiddenField ID="hidDTUuTien" runat="server" />
            </div>
            <div class="col-md-2 lb">Khác (ghi rõ)</div>
            <div class="col-md-4">
                <asp:TextBox ID="DTUuTienKhac" runat="server" CssClass="txt"></asp:TextBox>
            </div>
            <div class="clr"></div>
        </div>

        <div class="row">
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;2. Trình độ học vấn, chuyên môn kỹ thuật
            </div>
        </div>

        <div class="row">

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Trình độ học vấn<sup class="txt-red">*</sup></div>
            <div class="col-sm-8 col-md-9 col-lg-10">
                <asp:DropDownList ID="Level_ID" CssClass="selectpicker validate[required]" runat="server" />
                <span class="required"></span>
            </div>
            <div class="clear"></div>

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Trình độ CMKT cao nhất<sup class="txt-red">*</sup></div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:DropDownList ID="TrinhDoChuyenMon" CssClass="selectpicker validate[required]" runat="server" />
                <span class="required"></span>
            </div>

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Chuyên ngành đào tạo</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:TextBox ID="txtChuyenNganhDaoTao" runat="server" Text="" CssClass="TextBox" placeholder="Chuyên ngành đào tạo" />
            </div>

            <div class="clear"></div>
            <div class="col-sm-4 col-md-3 col-lg-2 lb">Trình độ CMKT khác</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:DropDownList ID="TrinhDoChuyenMonKhac" CssClass="selectpicker" runat="server" />
            </div>
            <div class="col-sm-4 col-md-3 col-lg-2 lb">Chuyên môn đào tạo</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:TextBox ID="txtChuyenNganhDaoTaoKhac" runat="server" Text="" CssClass="TextBox" placeholder="Chuyên môn đào tạo" />
            </div>

            <div class="clear"></div>
        </div>

        <div class="row">
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;Trình độ khác
            </div>
        </div>

        <div class="row">
            <div class="col-sm-4 col-md-3 col-lg-2 lb">Trình độ khác 1.</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:TextBox ID="txtTrinhDoKhac" runat="server" Text="" CssClass="TextBox" placeholder="" />
            </div>

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Trình độ khác 2.</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:TextBox ID="txtTrinhDoKhac2" runat="server" Text="" CssClass="TextBox" placeholder="" />
            </div>

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Trình độ kỹ năng nghề</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:TextBox ID="txtKyNangNghe" runat="server" Text="" CssClass="TextBox" placeholder="" />
            </div>

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Kỹ năng nghề bậc</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:TextBox ID="txtKyNangNgheBac" runat="server" Text="" CssClass="TextBox" placeholder="" />
            </div>
            <div class="clear"></div>
        </div>

        <div class="row">
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;Trình độ ngoại ngữ
            </div>
        </div>

        <div class="row">
            <div class="col-sm-4 col-md-3 col-lg-2 lb">Ngoại ngữ 1</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:TextBox ID="txtNgoaiNgu1" runat="server" Text="" CssClass="TextBox" placeholder="" />
            </div>

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Chứng chỉ</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:TextBox ID="txtNgoaiNgu1ChungChi" runat="server" Text="" CssClass="TextBox" placeholder="" />
            </div>

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Khả năng sử dụng</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:DropDownList ID="drTrinhDoNgoaiNgu1" CssClass="selectpicker" runat="server" />
            </div>
            <div class="clear"></div>
        </div>

        <div class="row">
            <div class="col-sm-4 col-md-3 col-lg-2 lb">Ngoại ngữ 2</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:TextBox ID="txtNgoaiNgu2" runat="server" Text="" CssClass="TextBox" placeholder="" />
            </div>

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Chứng chỉ</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:TextBox ID="txtNgoaiNgu2ChungChi" runat="server" Text="" CssClass="TextBox" placeholder="" />
            </div>

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Khả năng sử dụng</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:DropDownList ID="drTrinhDoNgoaiNgu2" CssClass="selectpicker" runat="server" />
            </div>
            <div class="clear"></div>
        </div>

        <div class="row">
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;Trình độ tin học
            </div>
        </div>

        <div class="row">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="col-sm-4 col-md-3 col-lg-2 lb">
                        Tin học văn phòng
                    </div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:TextBox ID="txtTrinhDoTinHoc" runat="server" Text="" CssClass="TextBox" placeholder="Word, Powerpoint,..." />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2 lb">Khả năng sử dụng</div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:DropDownList ID="drTrinhDoTinHoc_KhaNang" CssClass="selectpicker" runat="server" />
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="txtTrinhDoTinHoc" />
                </Triggers>
            </asp:UpdatePanel>
            <div class="clear"></div>
        </div>

        <div class="row">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="col-sm-4 col-md-3 col-lg-2 lb">
                        Trình độ tin học khác
                    </div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:TextBox ID="txtTrinhDoTinHoc_Khac" runat="server" Text="" CssClass="TextBox" placeholder="Photoshop, Canva, Powerpoint..." />
                    </div>

                    <div class="col-sm-4 col-md-3 col-lg-2 lb">Khả năng sử dụng</div>
                    <div class="col-sm-8 col-md-9 col-lg-4">
                        <asp:DropDownList ID="drTrinhDoTinHoc_Khac_KhaNang" CssClass="selectpicker" runat="server" />
                    </div>
                    <div class="clear"></div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="txtTrinhDoTinHoc_Khac" />
                </Triggers>
            </asp:UpdatePanel>
            <div class="clear"></div>
        </div>

        <div class="row">
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;Kỹ năng mềm
            </div>
        </div>

        <div class="row">
            <div class="col-sm-4 col-md-3 col-lg-2 lb">Kỹ năng mềm</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:DropDownList ID="drKyNangMem" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="kynangmem selectpicker" runat="server" />
                <asp:HiddenField ID="HidKyNangMem" runat="server" />
            </div>

            <div class="col-sm-4 col-md-3 col-lg-2 lb">Kỹ năng mềm khác</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <%--<asp:DropDownList ID="Experience_ID" CssClass="selectpicker validate[required]" runat="server" />--%>
                <asp:TextBox ID="txtKyNangMemKhac" runat="server" Text="" CssClass="TextBox" placeholder="Kỹ năng mềm khác" />
            </div>
            
            <div class="clear"></div>
            <div class="col-sm-4 col-md-3 col-lg-2 lb">Nhu cầu làm việc</div>
            <div class="col-sm-8 col-md-9 col-lg-4">
                <asp:DropDownList ID="drNhuCauLamViec" CssClass="drNhuCauLamViec selectpicker" runat="server" />
            </div>
        </div>

        <div class="row">
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;3. Kinh nghiệm làm việc (nếu có)
            </div>
        </div>

        <div class="row">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>

                    <div class="col-sm-12 col-md-12 col-lg-12">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <img src="/Portals/_default/Skins/vbn/images/hover_trash.png" alt="Del" title="Xóa nội dung?" class="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsDeleted" runat="server" CssClass="cs-select cDel" ToolTip="Đánh dấu để xóa" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="3%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tên đơn vị" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:TextBox ID="TenDonVi" Width="100%" runat="server" CssClass="grdtxt TextBox" Placeholder="..." />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Chức vụ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:TextBox ID="ChucVu" Width="100%" runat="server" CssClass="grdtxt TextBox" Placeholder="..." />
                                    </ItemTemplate>
                                    <HeaderStyle Width="15%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Công việc chính" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:TextBox ID="CongViecChinh" Width="100%" runat="server" CssClass="grdtxt TextBox" Placeholder="..." />
                                    </ItemTemplate>
                                    <HeaderStyle Width="35%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thời gian" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <div class="col-md-12">
                                            <div class="col-md-6">
                                                <asp:TextBox ID="FromDate" runat="server" Width="40%" CssClass="std med datepicker validate[required]" PlaceHolder="dd/MM/yyyy" />
                                            </div>
                                            <div class="col-md-6">
                                                <asp:TextBox ID="ToDate" runat="server" Width="40%" CssClass="std med datepicker validate[required]" PlaceHolder="dd/MM/yyyy" />
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                            <HeaderStyle HorizontalAlign="Center" CssClass="head1" />
                        </asp:DataGrid>

                    </div>
                    <div class="col-sm-12 ">
                        <asp:Button ID="cmdAddRow" runat="server" Text="Thêm dòng" CssClass="cmsbut cmsAnew cmsbAdd" />
                        <asp:Button ID="cmdDeleteRow" runat="server" Text="Xóa dòng" CssClass="cmsbut cmsbtdel" />

                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="grdData" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <div class="clear"></div>
        <div class="row pdt10">
            <div class="col-sm-4 col-md-3 col-lg-2 lb">Đã từng làm việc ở nước ngoài tại</div>
            <div class="col-sm-8 col-md-9 col-lg-10">
                <asp:TextBox ID="National" runat="server" Text="" CssClass="TextBox" placeholder="" />
                <%--<asp:DropDownList ID="drNational" CssClass="selectpicker" runat="server" />--%>
            </div>
        </div>
        <div class="row">
            <div class="title5">
                <img src="/image/note_edit.png" alt="logo" />&nbsp;4. Đăng ký dịch vụ
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4 col-md-3 col-lg-2 lb">Dịch vụ</div>
            <div class="col-sm-10 col-md-9 col-lg-10">
                <asp:DropDownList runat="server" onchange="getMultiple();" multiple="multiple" data-actions-box="true" CssClass="selectpicker DichVu" ID="DichVu" />
                <asp:HiddenField ID="HidDichVuDangKy" runat="server" />
            </div>
            <div class="clear"></div>
            <div class="col-sm-4 col-md-3 col-lg-2 lb">Khác</div>
            <div class="col-sm-8 col-md-9 col-lg-10">
                <%--<asp:DropDownList ID="Experience_ID" CssClass="selectpicker validate[required]" runat="server" />--%>
                <asp:TextBox ID="DichVuKhac" runat="server" Text="" CssClass="TextBox" placeholder="Dịch vụ khác" />
            </div>
        </div>
        <div class="clear" style="padding: 0 0 50px;"></div>
    </div>
    <asp:HiddenField ID="_PortalID" runat="server" Visible="false" />
    <asp:HiddenField ID="UsTinh" runat="server" Visible="false" />
    <asp:HiddenField ID="UsHuyen" runat="server" Visible="false" />
    <asp:HiddenField ID="UsXa" runat="server" Visible="false" />
    <asp:HiddenField ID="UsSubMod" runat="server" Visible="false" />
    <asp:HiddenField ID="UsVaiTro" runat="server" Visible="false" />
    <asp:HiddenField ID="hdUserName" runat="server" Visible="false" />
    <asp:HiddenField ID="HF_ID" runat="server" Visible="false" />
    <asp:HiddenField ID="HF_CreatedDate" runat="server" Visible="false" />

</div>

<div class="clr"></div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" OnClientClick=" return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick=" getMultiple();return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdExND23" runat="server" Text="Xuất dữ liệu" CssClass="cmsbut cmdword" OnClientClick="$('#Form').validationEngine('detach');" />
    </div>
</div>

<script>
    function changeAddress() {
        document.getElementById("<%=Address2.ClientID%>").value = document.getElementById("<%=Address.ClientID%>").value;
    }
    function setMultiple() {
        var vdata = $('#<%= HidKyNangMem.ClientID%>').val(); $.each(vdata.split(','), function (index, element) {
            $('#<%= drKyNangMem.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= drKyNangMem.ClientID%>").trigger('selectpicker:updated');
        });
        var values = $('#<%=HidDichVuDangKy.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=DichVu.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=DichVu.ClientID %>").trigger('selectpicker:updated');
        });
        var dtut = $('#<%=hidDTUuTien.ClientID%>').val(); $.each(dtut.split(','), function (index, element) {
            $("#<%=DTUuTien.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=DTUuTien.ClientID %>").trigger('selectpicker:updated');
        });
    };
    function getMultiple() {
        $('#<%=HidKyNangMem.ClientID%>').val($("#<%=drKyNangMem.ClientID %>").val());
        $('#<%=HidDichVuDangKy.ClientID%>').val($("#<%=DichVu.ClientID %>").val());
        $('#<%=hidDTUuTien.ClientID%>').val($("#<%=DTUuTien.ClientID %>").val());
    };
</script>
