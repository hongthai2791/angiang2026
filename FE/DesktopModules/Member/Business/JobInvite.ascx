<%@ Control Language="vb" AutoEventWireup="true" CodeFile="JobInvite.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info ">
            <div class="box-header with-border">
                <div class="col-md-5">
                    <h3 class="box-title">Chọn tin tuyển dụng để mời ứng tuyển (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-4 ">
                    <asp:TextBox ID="Business_Name" CssClass="TextBox" Enabled="false" runat="server" />
                    <asp:HiddenField ID="Business_ID" runat="server" Visible="false" />
                </div>
                <div class="col-md-2 none">
                    <asp:DropDownList ID="drSort" Visible="false" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-1 none">
                    <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body qlte">
                <div class="main-body">
                    <div class="col-md-12">
                        <fieldset class="mgt0">
                            <legend>Thông tin hồ sơ đã chọn</legend>
                            <div class="col-md-3 pdl0 logo-jobus">
                                <div class="row">
                                    <asp:Literal ID="JobUser_Img" runat="server"></asp:Literal>
                                    <div class="clear "></div>
                                </div>
                            </div>
                            <div class="col-md-4 pdl0 pdr0">
                                <p class="title-jobus">
                                    <asp:Literal ID="JobUser_Vn" runat="server"></asp:Literal>
                                </p>
                                <div class="clear"></div>
                                <div class="info-comdetail">
                                    <asp:Literal ID="litInfo" runat="server"></asp:Literal>
                                </div>
                            </div>
                            <div class="col-md-5 pdl0 pdr0">
                                <asp:Literal ID="litCin" runat="server"></asp:Literal>
                            </div>
                        </fieldset>
                    </div>
                    <div class="clear"></div>
                    <div class="row">
                        <div class="col-md-2">
                            <asp:DropDownList ID="drInvite" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="Salary_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-3">
                            <asp:DropDownList ID="Status_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="Experience_ID" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                        </div>

                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#f8f4f1" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsDelete" runat="server" CssClass="cs-select cDel" ToolTip="Chọn tin để mời?" />
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
                                <asp:TemplateColumn HeaderText="Thông tin hồ sơ" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <div class="col-md-6">
                                            <asp:CheckBox ID="IsApproval" Text="Đã duyệt" CssClass="cblist" runat="server" />
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
                            </Columns>
                        </asp:DataGrid>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
            <div class="row text-center pd10">
                <div>
                    <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
                    <asp:Button ID="cmdChoise" runat="server" Text="Mời ứng tuyển" CssClass="cmsbut cmsbtcheck" />
                </div>
            </div>
            <asp:HiddenField ID="currPage" runat="server" Visible="false" />
            <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
            <asp:HiddenField ID="JobID" runat="server" Visible="false" />
            <asp:HiddenField ID="TinhTP" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdChoise" />
        <asp:AsyncPostBackTrigger ControlID="cmdBack" />
    </Triggers>
</asp:UpdatePanel>
