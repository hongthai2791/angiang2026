<%@ Control Language="vb" CodeFile="LopEdit.ascx.vb" Inherits="Modules.LopEdit.Edit" AutoEventWireup="false" Explicit="True" %>


<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin lớp bản đồ</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-1 lb">Tỉnh/Thành phố</div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="drTinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker drTinhTP validate[required]" />
                        <span class="required"></span>
                    </div>
                   <%-- <div class="col-md-1 lb">Quận/Huyện</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="drQuanHuyen" runat="server" AutoPostBack="true" CssClass="selectpicker drQuanHuyen validate[required]" />
                        <span class="required"></span>
                    </div>--%>
                    <div class="col-md-1 lb">Phường/Xã</div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="drPhuongXa" runat="server" AutoPostBack="true" CssClass="selectpicker drPhuongXa" />
                    </div>
                    <div class="col-md-1 lb">Thôn/Tổ</div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="drThonTo" runat="server" AutoPostBack="true" CssClass="selectpicker drThonTo" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Tên lớp bản đồ</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TenThucThe" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 txt-center lb">Màu sắc</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropMauSac" runat="server" AutoPostBack="true" CssClass="selectpicker drTinhTP" />
                    </div>
                    <div class="clr"></div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Vĩ độ (Latitude)</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="ViDo" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Kinh độ (Longitude)</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="KinhDo" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Thứ tự hiển thị</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                    </div>
                    <div class="col-md-2 txt-center lb">Sử dụng </div>
                    <div class="col-md-4">
                        <asp:CheckBox ID="IsActive" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="clr clUp"></div>
                    <div class="col-md-12 lb txt-center">Lấy thông tin VĨ ĐỘ và KINH ĐỘ <a href="https://www.latlong.net/" rel="nofollow" target="_blank"><b>TẠI ĐÂY</b></a></div>
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
            <asp:HiddenField ID="ItemView" runat="server" Visible="false" />
            <asp:HiddenField ID="ItemTP" runat="server" Visible="false" />
            <%--<asp:HiddenField ID="ItemQH" runat="server" Visible="false" />--%>
            <asp:HiddenField ID="ItemPX" runat="server" Visible="false" />
            <asp:HiddenField ID="ItemTT" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
