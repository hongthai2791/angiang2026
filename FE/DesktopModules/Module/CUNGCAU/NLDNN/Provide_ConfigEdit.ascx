<%@ Control Language="vb" CodeFile="Provide_ConfigEdit.ascx.vb" Inherits="Modules.Child.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Cấu hình năm nhập liệu</h3>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-2 lb">Tỉnh/ thành phố</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drTinhTP" runat="server" Enabled="false" CssClass="selectpicker validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 lb">Kỳ nhập liệu</div>
                        <div class="col-md-4">
                            <asp:DropDownList AutoPostBack="true" runat="server" CssClass="selectpicker" ID="ProConfig_Value" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 lb">Kích hoạt</div>
                        <div class="col-md-6">
                            <asp:CheckBox runat="server" CssClass="Checkbox" ID="IsActive" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 lb">Khóa kỳ</div>
                        <div class="col-md-6">
                            <asp:CheckBox runat="server" CssClass="Checkbox" ID="IsLock" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-12 lb">Hướng dẫn</div>
                        <div class="col-md-12" style="line-height: 30px; font-weight: 700">
                            <asp:Literal runat="server" ID="ProConfig_Name" />
                        </div>
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate cbclick" OnClientClick="return retunwaiting();" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="ItemID" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="ProConfig_Value" />
    </Triggers>
</asp:UpdatePanel>
