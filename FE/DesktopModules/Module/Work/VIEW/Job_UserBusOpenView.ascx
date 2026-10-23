<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Job_UserBusOpenView.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Danh sách nhà tuyển dụng đã xem hồ sơ (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-2">
                    <asp:DropDownList ID="drSort" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-1">
                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-3">
                            <asp:DropDownList ID="TinhTP" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="XaPhuong" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-2 none">
                            <asp:DropDownList ID="Status_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-5">
                            <asp:DropDownList ID="Experience_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-7 ">
                            <asp:DropDownList ID="Business_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="Salary_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="Career_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsDelete" runat="server" CssClass="cs-select cDel" ToolTip="Chọn để xóa?" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="3%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thông tin hồ sơ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="JobWork" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="40%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thông tin nhà tuyển dụng" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Business" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Trạng thái hồ sơ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <div class="col-md-6">
                                            <asp:CheckBox ID="IsContact" Text="Đã liên hệ" CssClass="cblist" runat="server" />
                                        </div>
                                        <div class="col-md-6">
                                            <asp:CheckBox ID="IsInterview" Text="Đã phỏng vấn" CssClass="cblist" runat="server" />
                                        </div>
                                        <div class="col-md-6">
                                            <asp:CheckBox ID="IsTest" Text="Đã test" CssClass="cblist" runat="server" />
                                        </div>
                                        <div class="col-md-6">
                                            <asp:CheckBox ID="IsElect" Text="Trúng tuyển" CssClass="cblist" runat="server" />
                                        </div>
                                    </ItemTemplate>
                                    <HeaderStyle Width="22%" HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="IsSuper" runat="server" Visible="false" />
        <asp:HiddenField ID="IsActive" Value="True" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="XaPhuong" />
        <asp:AsyncPostBackTrigger ControlID="Status_ID" />
        <asp:AsyncPostBackTrigger ControlID="Business_ID" />
        <asp:AsyncPostBackTrigger ControlID="Experience_ID" />
        <asp:AsyncPostBackTrigger ControlID="Career_ID" />
    </Triggers>
</asp:UpdatePanel>



