<%@ Control Language="vb" AutoEventWireup="true" CodeFile="WorksChose.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">NGUỒN NHÂN LỰC || TIN TUYỂN DỤNG (<asp:Literal ID="litCount" runat="server" />)</h3>
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
                        <div class="col-md-2">
                            <asp:DropDownList ID="TinhTP" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="QuanHuyen" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-2">
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
                        <div class="col-md-5">
                            <asp:DropDownList ID="Salary_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tin tuyển dụng" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Title" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="25%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thông tin tuyển dụng" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Infomation" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Thời hạn" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="DateTime" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="15%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle" HeaderText="Trạng thái">
                                    <ItemTemplate>
                                        <div class="col-md-6">
                                            <asp:CheckBox ID="IsApproval" Text="Đã duyệt" CssClass="cblist cs-select cIsApproval" runat="server" />
                                        </div>
                                        <div class="col-md-6 pdr0 pdl0">
                                            <asp:CheckBox ID="IsHot" Text="Tin nổi bật" CssClass="cblist" runat="server" />
                                        </div>
                                        <div class="clear"></div>
                                        <div class="col-md-6">
                                            <asp:CheckBox ID="IsUrgent" Text="Tuyển gấp" CssClass="cblist" runat="server" />
                                        </div>
                                        <div class="col-md-6 pdr0 pdl0">
                                            <asp:CheckBox ID="IsFast" Text="Dấu thông tin" CssClass="cblist" runat="server" />
                                        </div>
                                        <div class="clear"></div>
                                    </ItemTemplate>
                                    <HeaderStyle Width="23%" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <img src="/portals/_default/skins/vbn/images/hover_check.png?w" alt="Active" class="bCur bAct select" onclick="clickSelect('bAct','cAct');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsSelect" runat="server" CssClass="cs-select cAct" ToolTip="Chọn liên kết" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
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
            <div class="fix-btt-toolbar">
                <div>
                    <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmdbtt cmdExit" />
                    <asp:Button ID="cmdUpdate" OnClientClick="waiting();" runat="server" Text="Lấy tin tuyển dụng" CssClass="cmdbtt cmdSave" />
                </div>
            </div>
            <asp:HiddenField ID="currPage" runat="server" Visible="false" />
            <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
            <asp:HiddenField ID="IsActive" Value="True" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="QuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="Status_ID" />
        <asp:AsyncPostBackTrigger ControlID="Business_ID" />
        <asp:AsyncPostBackTrigger ControlID="Experience_ID" />
    </Triggers>
</asp:UpdatePanel>
