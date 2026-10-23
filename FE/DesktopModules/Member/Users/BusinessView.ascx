<%@ Control Language="vb" AutoEventWireup="true" CodeFile="BusinessView.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin hồ sơ nhà tuyển dụng</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2">Mã số thuế</div>
                <div class="col-md-4">
                    <asp:TextBox ID="TaxCode" runat="server" Enabled="false" onchange="taxcode(this);" MaxLength="15" CssClass="TextBox TaxCode" />

                </div>
                <div class="col-md-6 msgError" id="msgError" runat="server" enabled="false"></div>
                <div class="clear"></div>
                <div class="col-md-2">Tên doanh nghiệp</div>
                <div class="col-md-10">
                    <asp:TextBox ID="Business_Vn" runat="server" Enabled="false" CssClass="TextBox Business_Vn" />

                </div>
                <div class="clear"></div>
                <div class="col-md-2">Tên tiếng anh</div>
                <div class="col-md-10">
                    <asp:TextBox ID="Business_En" runat="server" Enabled="false" CssClass="TextBox Business_En" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2">Tên viết tắt</div>
                <div class="col-md-10">
                    <asp:TextBox ID="Business_Sort" runat="server" Enabled="false" CssClass="TextBox Business_Sort" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2">Địa chỉ</div>
                <div class="col-md-10">
                    <asp:TextBox ID="Address" CssClass="TextBox Address" runat="server" Enabled="false" TextMode="MultiLine" Height="30px" />

                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-sm-6 ">
                    <div class="col-md-4 pdl0">Giới thiệu về doanh nghiệp</div>
                    <div class="col-md-8">
                        <asp:TextBox ID="Description" runat="server" Enabled="false" CssClass="TextBox Description" TextMode="MultiLine" Height="245" />

                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdl0">Điện thoại</div>
                    <div class="col-md-8">
                        <asp:TextBox ID="Mobile" runat="server" Enabled="false" CssClass="TextBox Mobile" />

                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdl0">Email</div>
                    <div class="col-md-8">
                        <asp:TextBox ID="Email" runat="server" Enabled="false" CssClass="TextBox Email validate[custom[email]]" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="col-sm-6">
                    <div class="col-md-3 txt-right">Logo doanh nghiệp</div>
                    <div class="col-md-9 ist-img">
                        <div id="imgDD" runat="server">
                            <img class="vImg" src="/image/images/noimage.png?dpi=150&quality=100&w=145&h=120" title="Chọn ảnh đại diện khác" alt="Ảnh đại diện" />
                        </div>
                        <asp:HiddenField ID="LogoDN" runat="server" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3 txt-right">Tỉnh/ thành phố</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="TinhTP" CssClass="selectpicker TinhTP" runat="server" Enabled="false" />

                    </div>
                    <div class="col-md-3 txt-right">Quận/ huyện</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="QuanHuyen" CssClass="selectpicker QuanHuyen" runat="server" Enabled="false" />

                    </div>

                    <div class="col-md-3 txt-right">Quy mô đơn vị</div>
                    <div class="col-md-9">
                        <asp:TextBox ID="Scale" runat="server" Enabled="false" CssClass="TextBox Scale" />
                    </div>
                    <div class="col-md-3 txt-right">Số Fax</div>
                    <div class="col-md-9">
                        <asp:TextBox ID="Fax" runat="server" Enabled="false" CssClass="TextBox Fax" />
                    </div>
                    <div class="col-md-3 txt-right">Website</div>
                    <div class="col-md-9">
                        <asp:TextBox ID="Website" runat="server" Enabled="false" CssClass="TextBox Website" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row none">
                <div class="col-md-12">
                    <h3 class="box-title mgt0">Thông tin người liên hệ</h3>
                </div>
            </div>
            <div class="row none">
                <div class="col-sm-6">
                    <div class="col-md-4">Họ và tên</div>
                    <div class="col-md-8">
                        <asp:TextBox ID="ContactUser" runat="server" Enabled="false" CssClass="TextBox" />

                    </div>
                    <div class="col-md-4">Số điện thoại</div>
                    <div class="col-md-8">
                        <asp:TextBox ID="ContactMobile" runat="server" Enabled="false" CssClass="TextBox ContactMobile" />

                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="col-md-12 pdt10">Địa chỉ email liên hệ</div>
                    <div class="col-md-12">
                        <asp:TextBox ID="ContactEmail" runat="server" Enabled="false" CssClass="TextBox ContactEmail validate[required, custom[email]]" />

                    </div>

                </div>
                <div class="clear"></div>
            </div>

            <div class="clr clUp "></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <asp:HiddenField ID="_PortalID" runat="server" />
        <asp:HiddenField ID="ItemID" runat="server" />
    </div>
</div>
<div class="none">
    <asp:CheckBox ID="IsApproval" CssClass="cs-select" runat="server" Enabled="false" />
</div>
<div class="row text-center pd10">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
