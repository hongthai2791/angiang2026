<%@ Control Language="vb" CodeFile="GroupEdit.ascx.vb" Inherits="Modules.Group.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
       <div class="col-md-12" ><h3 class="box-title">Thông tin nhóm chỉ tiêu báo cáo</h3></div>
    </div>
    <asp:UpdatePanel runat="server" ID="pnChiTieuGroup">
        <ContentTemplate>
            <div class="box-body">
                <div class="main-body">
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Nhóm chỉ tiêu cha</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="_ParentID"  runat="server" TabIndex="2" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Mã nhóm</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="Group_Code" TabIndex="3" runat="server" CssClass="TextBox b txt-center  validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Tên nhóm</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Group_Name" runat="server" TabIndex="4" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Group_Des" runat="server" TabIndex="5" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="col-md-2 lb ">Loại</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="drGroupType"  runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="col-md-2 lb ">Thứ tự</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="Group_IsOrder" runat="server" TabIndex="7" CssClass="TextBox center validate[required, custom[integer]]" />
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
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="_ParentID" />
        </Triggers>
    </asp:UpdatePanel>
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
</div>
