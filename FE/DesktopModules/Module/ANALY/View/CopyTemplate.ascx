<%@ Control Language="vb" CodeFile="CopyTemplate.ascx.vb" Inherits="Modules.CopyTemplate.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-9">
                    <h3 class="box-title">Sao chép mẫu báo cáo</h3>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <asp:Literal runat="server" ID="ltrTemplate"></asp:Literal>
                        <div class="clear"></div>
                        <div class="title5">Điền các thông tin mới để thực hiện sao chép</div>
                        <div class="col-md-2 lb">Tỉnh/thành phố</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="TinhTP" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-2 txt-center lb">Năm báo cáo mới</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="Year_ID" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 lb">Tiêu đề báo cáo mới</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="txtTitleNew" runat="server" CssClass="TextBox txt-center"></asp:TextBox>
                        </div>

                        <div class="clear"></div>
                    </div>

                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdCopy" runat="server" Text="Sao chép mẫu báo cáo" CssClass="cmsbut cmsbtsend" OnClientClick="getmultile();retunwaiting();" />
            </div>
        </div>
        <asp:HiddenField ID="ItemID" runat="server" Visible="false" />
        <asp:HiddenField ID="ItemType" runat="server" Visible="false" />
        <asp:HiddenField ID="TinhOld" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdCopy" />
    </Triggers>
</asp:UpdatePanel>

