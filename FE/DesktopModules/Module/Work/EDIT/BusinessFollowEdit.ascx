<%@ Control Language="vb" CodeFile="BusinessFollowEdit.ascx.vb" Inherits="Modules.BusinessFollowEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin theo dõi nhà tuyển dụng</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên nhà tuyển dụng</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="Work_Title" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Đường dẫn nhà tuyển dụng</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="Work_Url" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb none">Tiêu đề</div>
                    <div class="col-md-10 none">
                        <asp:TextBox ID="TieuDe" runat="server" MaxLength="100" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                     <div class="clear"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="MoTa" runat="server" Height="150" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Hủy theo dõi" CssClass="cmsbut cmsbtdel" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

