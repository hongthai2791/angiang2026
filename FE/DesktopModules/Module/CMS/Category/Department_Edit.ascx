<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Department_Edit.ascx.vb" Inherits="DesktopModules.DanhMuc.PhongBan.inc_Edit" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">BIÊN TẬP NỘI DUNG PHÒNG BAN</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 b pdt5">Chọn phân hệ</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Tên phòng ban</div>
                <div class="col-md-10">
                    <asp:TextBox CssClass="TextBox validate[required]" ID="txtGiaTri" runat="server"></asp:TextBox>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Tên viết tắt</div>
                <div class="col-md-10">
                    <asp:TextBox CssClass="TextBox" ID="txtTenVietTat" runat="server"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5 none">Ảnh đại diện</div>
                <div class="col-md-10 none">
                    <asp:FileUpload ID="FileUpload_Image" runat="server" CssClass="TextInput" Width="350px" />&nbsp;
                    <asp:LinkButton ID="cmdUpload_Image" runat="server" CssClass="Button" CausesValidation="False" ToolTip="Select a file"><img src="/images/action_up.gif" border="0" alt="" />Upload</asp:LinkButton>
                    <br />
                    <asp:Image ID="imgDaidien" runat="server" Width="150px" Visible="false" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Thuộc phòng ban</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="ddlPhongBanCha" runat="server" CssClass="selectpicker"></asp:DropDownList>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Mô tả</div>
                <div class="col-md-10">
                    <asp:TextBox CssClass="TextBox" ID="txtMoTa" TextMode="MultiLine" Height="60px" runat="server"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Đường dẫn</div>
                <div class="col-md-10">
                    <asp:TextBox CssClass="TextBox" ID="IsUrl" runat="server"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Sử dụng?</div>
                <div class="col-md-10">
                    <asp:CheckBox ID="chkIsActive" ToolTip="Is active" runat="server" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2 b pdt5">Thứ tự hiển thị</div>
                <div class="col-md-1">
                    <asp:TextBox ID="txtOrderNumber" Text="1" CssClass="TextBox center validate[required,custom[integer]]" runat="server"></asp:TextBox>
                    <span class="required"></span>
                </div>

            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdDelete" runat="server" Visible="false" Text="Xóa" CssClass="cmdbtt cmdDel" />
        <asp:Button ID="cmdCancel" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />

    </div>
</div>
