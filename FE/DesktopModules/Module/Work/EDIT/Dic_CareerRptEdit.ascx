<%@ Control Language="vb" CodeFile="Dic_CareerRptEdit.ascx.vb" Inherits="Modules.Career.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin ngành nghề kinh doanh</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 pdt5">Ngành nghề cấp 1</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="NganhCap1" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 pdt5">Ngành nghề cấp 2</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="NganhCap2" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 pdt5">Ngành nghề cấp 3</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="NganhCap3" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 pdt5">Mã ngành nghề</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="Career_Code" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 pdt5">Tên ngành nghề</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Career_Name" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 pdt5">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Career_Des" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 pdt5">Sử dụng </div>
                    <div class="col-md-10">
                        <asp:CheckBox ID="Career_IsActive" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 pdt5">Thứ tự</div>
                    <div class="col-md-1">
                        <asp:TextBox ID="Career_IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
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

