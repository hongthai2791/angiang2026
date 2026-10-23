<%@ Control Language="vb" CodeFile="ThonToEdit.ascx.vb" Inherits="Modules.Regional.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin địa danh Tỉnh/Thành phố</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tỉnh/ thành phố</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="col-md-2 txt-center lb">Quận/ huyện</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="QuanHuyen" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Xã/ phường</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="XaPhuong" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="col-md-2 txt-center lb">Mã địa danh</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="Regional_Code" ReadOnly="true" runat="server" CssClass="TextBox ReadOnly txt-center validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Tên địa danh</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="Regional_Name" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 txt-center lb">Khu vực</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="drArea" runat="server" CssClass="selectpicker " />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Regional_Des" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb none">Sử dụng </div>
                    <div class="col-md-10 none">
                        <asp:CheckBox ID="Regional_IsActive" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Thứ tự hiển thị</div>
                    <div class="col-md-1">
                        <asp:TextBox ID="Regional_IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                    </div>
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
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

