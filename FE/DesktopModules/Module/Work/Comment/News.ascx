<%@ Control Language="vb" AutoEventWireup="false" CodeFile="News.ascx.vb" Inherits="DesktopModules.Modules.FeedBack.new_comment" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-8">
            <h3 class="box-title">DANH SÁCH PHẢN HỒI MỚI NHẬN</h3>
            &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
        </div>
        <div class="col-md-4">
            <asp:DropDownList ID="drlStatus" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
            <asp:DropDownList ID="drlType" Visible="false" Width="100px" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-12">
                <asp:DropDownList ID="ddlPortal" Visible="false" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="clear"></div>
            <div class="row">
                <div class="ctable-respo">
                    <asp:DataGrid ID="drgContent" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                        <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                        <ItemStyle BackColor="#f5f5f5" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderText="STT">
                                <ItemTemplate>
                                    <asp:Label ID="numberLabel" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Thông tin bạn đọc">
                                <ItemTemplate>
                                    <div class="td-das-view">
                                        <div style="padding-bottom: 5px;">Họ tên: <span style="font-weight: bold;"><%# DataBinder.Eval(Container.DataItem, "FullName") %></span></div>
                                        <div style="padding-bottom: 5px;">Email: <span style="color: #074572"><%# DataBinder.Eval(Container.DataItem, "Email") %></span></div>
                                        <div style="padding-bottom: 0px;">Ngày gửi: <span style="font-weight: bold;"><%# EPORTAL.flReg.ReadDate(DataBinder.Eval(Container.DataItem, "Createdate"))%></span> </div>
                                    </div>
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                </ItemTemplate>
                                <HeaderStyle CssClass="column-primary" Width="20%" />
                                <ItemStyle CssClass="column-primary" Width="20%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Nội dung">
                                <ItemTemplate>
                                    <a title="Chi tiết" href="/<%= Me.PortalSettings.ActiveTab.TabName %>/edit/<%= Request.Item("view") %>/idfeed/<%# Eval("NewsFeedbackId") %>/editid/<%# Eval("NewsFeedbackId") %>/type/<%# Eval("type")%>/itemid/<%# Eval("itemid") %>/pid/<%# Eval("PortalId")%>">
                                        <%# EPORTAL.flReg.RemoveHTML(Server.HtmlDecode(DataBinder.Eval(Container.DataItem, "Content"))) %>
                                    </a>
                                </ItemTemplate>
                                <ItemStyle CssClass="Content respo-view" />
                                <HeaderStyle CssClass="respo-title" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Tin bài">
                                <ItemTemplate>
                                    <asp:Literal ID="Link" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="30%" CssClass="Link respo-view" />
                                <HeaderStyle Width="30%" CssClass="Link respo-title" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Xóa">
                                <ItemTemplate>
                                    <dnn:CommandButton ID="cmdDelete" runat="server" BorderStyle="none" ImageUrl="/image/7.gif"
                                        ToolTip="Delete" CommandName="Delete" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "NewsFeedbackId") %>'></dnn:CommandButton>
                                </ItemTemplate>
                                <ItemStyle Width="5%" HorizontalAlign="Center" CssClass="Delete respo-view" />
                                <HeaderStyle Width="5%" HorizontalAlign="Center" CssClass="Delete respo-title" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
            </div>
            <div class="col-md-12">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <asp:HiddenField ID="CurrentPage" runat="server" />
        </div>
    </div>
</div>
