<%@ Control Language="vb" CodeFile="DTNGHE_HocVienEdit.ascx.vb" Inherits="Modules.DTNGHE_HocVienEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin học viên</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <h4>I. Thông tin cá nhân</h4>
                    <hr />
                    <div class="col-md-2 lb">Họ và tên</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="HoTen" runat="server" MaxLength="255" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>

                    <div class="col-md-2 txt-right lb">Số CCCD</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="SoCCCD" runat="server" MaxLength="12" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-2 lb">Ngày sinh<sup class="txt-red">*</sup></div>
                    <div class="col-md-4 rccalpopup">
                        <asp:TextBox ID="NgaySinh" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                    </div>

                     <div class="col-md-2 txt-right lb">Giới tính</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="drGioiTinh" CssClass="selectpicker" runat="server">
                            <asp:ListItem Value="Nam">Nam</asp:ListItem>
                            <asp:ListItem Value="Nữ">Nữ</asp:ListItem>
                            <asp:ListItem Value="Khác">Khác</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-2 lb">Số điện thoại</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="SoDienThoai" runat="server" MaxLength="15" CssClass="TextBox" />
                    </div>

                    <div class="col-md-2 txt-right lb">Email</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="Email" runat="server" MaxLength="255" CssClass="TextBox validate[custom[email]]" />
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-2 lb">Địa chỉ</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="DiaChi" runat="server" MaxLength="500" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-2 lb">Trình độ học vấn</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TrinhDoHocVan" runat="server" MaxLength="100" CssClass="TextBox" placeholder="Ví dụ: 12/12, Đại học..."/>
                    </div>

                    <div class="col-md-2 txt-right lb">Trình độ chuyên môn</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TrinhDoChuyenMon" runat="server" MaxLength="255" CssClass="TextBox" placeholder="Ví dụ: Kế toán, Lập trình viên..."/>
                    </div>
                    <div class="clear"></div>

                    <h4 style="margin-top: 20px;">II. Thông tin đào tạo</h4>
                    <hr />
                    
                    <div class="col-md-2 lb">Lớp theo học</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="drLopHoc" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-2 lb" title="Thông tin này tự động lấy theo lớp học" >Nghề đào tạo</div>
                    <div class="col-md-4">
                        <asp:DropDownList Enabled="false" ToolTip="Thông tin này tự động lấy theo lớp học" ID="drNgheDaoTao" CssClass="selectpicker validate[required]" runat="server" />
                    </div>
                    
                    <div class="col-md-2 txt-right lb"  title="Thông tin này tự động lấy theo lớp học">Thời gian đào tạo</div>
                    <div class="col-md-4">
                           <asp:DropDownList  Enabled="false" ToolTip="Thông tin này tự động lấy theo lớp học" ID="drThoiGianDaoTao" CssClass="selectpicker" runat="server" />
                          <div class="col-md-4 rccalpopup">
      <asp:TextBox ID="NgayKhaiGiang" Visible="false" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
  </div>
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-2 lb">Kết quả đào tạo</div>
                    <div class="col-md-10">
                       <asp:DropDownList ID="drKetQuaDaoTao" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>

                    <div class="col-md-2 lb">Ghi chú</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="80px" />
                    </div>
                    
               
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                    <hr />

              
                    <div id="pnlDiem" runat="server" visible="false">
                        <h4>III. Quản lý điểm của học viên</h4>
                         <asp:HiddenField ID="hiddenMaDiem" runat="server" Value="0" />
                  
                        <div class="form-inline" style="margin-bottom: 15px;">
                            <div class="form-group">
                                <label for="<%=txtMonHoc.ClientID%>" style="font-weight: normal; margin-right: 5px;">Môn học/Học phần:</label>
                                <asp:TextBox ID="txtMonHoc" runat="server" CssClass="form-control" placeholder="Tên môn học..."></asp:TextBox>
                            </div>
                            <div class="form-group" style="margin-left: 20px;">
                                <label for="<%=txtDiemSo.ClientID%>" style="font-weight: normal; margin-right: 5px;">Điểm số:</label>
                                <asp:TextBox ID="txtDiemSo" runat="server" CssClass="form-control" placeholder="Điểm..."></asp:TextBox>
                            </div>
                            <asp:Button ID="cmdAddDiem" runat="server" Text="Thêm điểm" CssClass="btn btn-primary btn-sm" style="margin-left: 20px;" />
                             <asp:Button ID="cmdCancelEditDiem" runat="server" Text="Hủy" CssClass="btn btn-default btn-sm" style="margin-left: 5px;" Visible="false" />
                        </div>

                   
                        <asp:Repeater ID="rptDiem" runat="server">
                            <HeaderTemplate>
                                <table class="table table-bordered table-striped">
                                    <thead>
                                        <tr>
                                            <th style="width: 60%;">Môn học/Học phần</th>
                                            <th style="width: 20%; text-align: center;">Điểm số</th>
                                            <th style="width: 20%; text-align: center;">Thao tác</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("MonHoc") %></td>
                                    <td style="text-align: center;"><%# Eval("DiemSo") %></td>
                                    <td style="text-align: center;">
                                        <asp:LinkButton ID="cmdDeleteDiem" runat="server" 
                                            CommandName="DeleteDiem" 
                                            CommandArgument='<%# Eval("ID") %>' 
                                            OnClientClick="return confirm('Bạn có chắc chắn muốn xóa điểm này?');"
                                            CssClass="text-danger"><i class="fa fa-trash"></i></asp:LinkButton> | 
                                          <asp:LinkButton ID="cmdEditDiem" runat="server"
                        CommandName="EditDiem"
                        CommandArgument='<%# Eval("ID") %>'
                        CssClass="text-primary" style="margin-right: 15px;"><i class="fa fa-pencil"></i></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                    </tbody>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>

                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>