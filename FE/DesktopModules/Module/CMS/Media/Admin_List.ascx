<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Admin_List.ascx.vb" Inherits="DesktopModules.Media.Manage.Admin_List" %>

<asp:UpdatePanel ID="udpContent" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">
                        <asp:Literal ID="litTitle" runat="server"></asp:Literal></h3>
                    &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
                    
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-7 pdl0 pdbt0 mgbt0">
                            <div class="col-md-6">
                                <asp:DropDownList ID="ddlPortal" runat="server" Width="100%" CssClass="selectpicker" AutoPostBack="true" />
                            </div>
                            <div class="col-md-3 col-xs-6">
                                <div class="rccalpopup">
                                    <asp:TextBox ID="FromDate" runat="server" CssClass="datepicker" PlaceHolder="Từ ngày"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-3 col-xs-6">
                                <div class="rccalpopup">
                                    <asp:TextBox ID="ToDate" runat="server" CssClass="datepicker" PlaceHolder="Đến ngày"></asp:TextBox>
                                </div>
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="col-md-5 pdr0 pdbt0 mgbt0">
                            <div class="col-md-6 pdt5 col-xs-6">
                                <asp:CheckBox ID="chkHome" CssClass="csHot" runat="server" AutoPostBack="true" Text="Tin nóng trang chủ"></asp:CheckBox>
                            </div>
                            <div class="col-md-6 pdt5 col-xs-6 pdr0">
                                <asp:CheckBox ID="chkYoutobe" CssClass="csHotCat" runat="server" AutoPostBack="true" Text="Nguồn từ youtobe"></asp:CheckBox>
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-7 pdl0 pdbt0 mgbt0">
                            <div class="col-md-12">
                                <asp:DropDownList ID="ddlCategory" CssClass="selectpicker cmcoption" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-5 pdr0 pdbt0 mgbt0">
                            <div class="col-md-12 ">
                                <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                                <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                            </div>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-12 pdl0">
                            <asp:Literal runat="server" ID="ltMyNewsCount"></asp:Literal>
                        </div>
                    </div>
                    <div class="row">
                        <div class="ctable-respo">
                            <asp:DataGrid ID="drgDataViewer" DataKeyField="Id" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:BoundColumn DataField="id" HeaderText="M&#227; tin" Visible="False"></asp:BoundColumn>
                                    <asp:TemplateColumn>
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','check-dash');" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkItems" runat="server" CssClass="check-dash" />
                                        </ItemTemplate>
                                        <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tiêu đề video, audio">
                                        <ItemTemplate>
                                            <div class="td-das-view">
                                                <asp:HyperLink ID="hplTitle" CssClass="a-list" runat="server" Font-Underline="false">
                                       <%# Highlight(Eval("Name"), "<span class='highlight'>", "</span>")%>
                                       <%# CMS.Ultis.ViewImageByType(Eval("IsHome"), False) %>
                                                </asp:HyperLink>
                                            </div>
                                            <div class="td-das-view-ch">
                                                <asp:Literal ID="litDate" runat="server" />
                                            </div>
                                            <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Chuyên mục">
                                        <ItemTemplate>
                                            <%# CMS.Ultis.GetCategoryName(Eval("PortalId"), Eval("CategoryId"))%>
                                        </ItemTemplate>
                                        <ItemStyle Width="20%" CssClass="chuyenmuc respo-view" />
                                        <HeaderStyle Width="20%" CssClass="chuyenmuc respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Lượt xem">
                                        <ItemTemplate><%# Eval("ViewCount")%></ItemTemplate>
                                        <ItemStyle Width="8%" CssClass="luotxem respo-view" />
                                        <HeaderStyle Width="8%" CssClass="luotxem respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Xem" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <a onclick="previewM(<%# Eval("Id")%>,<%# Eval("PortalId")%>)" title="Xem" class="printview">
                                                <asp:Image ID="imgImage" ImageUrl="~/images/view.gif" AlternateText="Xem" runat="server" />
                                            </a>
                                        </ItemTemplate>
                                        <ItemStyle Width="5%" CssClass="xem respo-view" />
                                        <HeaderStyle Width="5%" CssClass="xem respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Lịch sử" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:Literal ID="litProcess" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="8%" CssClass="lichsu respo-view" />
                                        <HeaderStyle Width="8%" CssClass="lichsu respo-title" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                </div>
            </div>
            <div class="fix-btt-toolbar">
                <div>
                    <asp:Button Visible="false" CssClass="cmdbtt cmdRestore" ID="lbtShowNews" runat="server" Text="Khôi phục"></asp:Button>
                    <asp:Button Text="Xóa khỏi CSDL" Visible="false" CssClass="cmdbtt cmdDelete" ID="cmdDelDB" runat="server" OnClientClick="javascript: return confirm('Bạn có thực sự muốn xóa?');"></asp:Button>
                    <asp:Button CssClass="cmdbtt cmdDel" ID="cmdDel" runat="server" OnClientClick="javascript: return confirm('Bạn có thực sự muốn xóa?');" Text="Xóa tin"></asp:Button>
                    <asp:Button ID="cmdSettings" runat="server" CssClass="cmdbtt cmdSettings" Text="Thiết lập" Visible="false" />
                </div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="lbtFind" />
        <asp:AsyncPostBackTrigger ControlID="ddlCategory" />
    </Triggers>
</asp:UpdatePanel>
<asp:HiddenField ID="CurrentPage" Visible="false" Value="1" runat="server" />
<asp:HiddenField ID="WF_Status" Visible="false" Value="0" runat="server" />
<asp:HiddenField ID="WF_TYPE" runat="server" Value="0" Visible="false" />

<script>$(".cmcoption  option:not(:contains('--'))").addClass("strongtxt");</script>
