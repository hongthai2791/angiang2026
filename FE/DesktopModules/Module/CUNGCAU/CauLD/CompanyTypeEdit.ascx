<%@ Control Language="vb" CodeFile="CompanyTypeEdit.ascx.vb" Inherits="Modules.CompanyType.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
       <div class="col-md-12" ><h3 class="box-title">Thông tin Loại hình doanh nghiệp</h3></div>
    </div>
    <asp:UpdatePanel runat="server" ID="pnCompanyType">
        <ContentTemplate>
            <div class="box-body">
                <div class="main-body">
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Mã loại hình</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="MaLoaiHinh" TabIndex="3" runat="server" CssClass="TextBox b txt-center  validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Tên loại hình</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="TenLoaiHinh" runat="server" TabIndex="4" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                   
                    <div class="col-md-2 lb ">Thứ tự</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="STT" runat="server" TabIndex="7" CssClass="TextBox center validate[required, custom[integer]]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" TabIndex="9" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" TabIndex="8" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" TabIndex="10" CssClass="cmsbut cmsbtdel" />
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
</div>
