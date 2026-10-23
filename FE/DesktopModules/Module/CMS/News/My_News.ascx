<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="My_News.ascx.vb" Inherits="DesktopModules.Modules.My_News" %>
<%--<%=strCssCn%>--%>
<asp:UpdatePanel ID="udpContent" runat="server">
    <ContentTemplate>
        <div class="box box-info vbContent">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">DANH SÁCH TIN BÀI CỦA TÔI</h3>
                    &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-7 pdl0">
                            <div class="row">
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
                        </div>
                        <div class="col-md-5 pdr0">
                            <div class="row">
                                <div class="col-md-6 pdt5 col-xs-6">
                                    <asp:CheckBox ID="chkCare" CssClass="csHot" runat="server" AutoPostBack="true" Text="Tin nóng trang chủ"></asp:CheckBox>
                                </div>
                                <div class="col-md-6 pdt5 col-xs-6 pdr0">
                                    <asp:CheckBox ID="chkHotCat" CssClass="csHotCat" runat="server" AutoPostBack="true" Text="Nóng chuyên mục"></asp:CheckBox>
                                </div>
                                <div class="clear"></div>
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-7 pdl0">
                            <div class="row">
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlCategory" CssClass="selectpicker cmcoption" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-5 pdr0">
                            <div class="row">
                                <div class="col-md-12 ">
                                    <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                                    <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                                </div>
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
                            <asp:DataGrid ID="drgDataViewer" DataKeyField="NewId" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
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
                                    <asp:TemplateColumn HeaderText="Tin bài">
                                        <ItemTemplate>
                                            <div class="td-das-view">
                                                <asp:HyperLink ID="hplTitle" runat="server" CssClass="a-list" Font-Underline="false">
                                                    <%# CMS.Ultis.ImagePath(Eval("ImagePath"))%>
                                                    <%# Highlight(Eval("Title"), "<span class='highlight'>", "</span>")%>
                                                    <%# CMS.Ultis.ViewImageByType(Eval("Hotcat"), Eval("IsCare")) %>
                                                </asp:HyperLink>
                                            </div>
                                            <div class="td-das-view-ch">
                                                <asp:Literal ID="litDate" runat="server" /><br />
                                                <asp:Label ID="lblEdittedBy" runat="server" Text='<%# CMS.Ultis.FormatEdittedBy(PortalId, Eval("EditedUser"), Eval("EditedTime"), Eval("IsEdited"), Eval("NewID"))%>' ForeColor="Red"></asp:Label>
                                                <asp:ImageButton ID="cmdUnlock" CommandName="cmdUnlock" CommandArgument='<%# Eval("newid")%>' ToolTip="Mở khóa" ImageUrl="~/images/icons/lock_break.png" runat="server"
                                                    Visible='<%# CMS.Ultis.FormatLockByUser(Eval("PortalId"), Eval("IsEdited"), Me.UserInfo.Username, Eval("EditedUser"), Eval("EditedTime"), Eval("NewID"))%>' />
                                            </div>
                                            <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Chuyên mục">
                                        <ItemTemplate>
                                            <%# HighlightCM(Eval("CategoryParentName"), Eval("CategoryName")) %>
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
                                            <a onclick="preview(<%# Eval("NewId")%>,<%# Eval("PortalId")%>)" title="Xem" class="printview">
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
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdDel" OnClientClick="javascript:return confirm('Bạn có chắc chắn muốn xóa bản ghi này?');" runat="server" CssClass="cmdbtt cmdDel" Text="Xóa tin"></asp:Button>
                <asp:Button ID="lbAddNewsTop" runat="server" CssClass="cmdbtt cmdNew" Text="Thêm mới" Font-Bold="true"></asp:Button>
                <asp:Button ID="cmdRun" runat="server" CssClass="cmdbtt cmdRun" Text="Gửi trực ban" Font-Bold="true"></asp:Button>
                <asp:Button ID="cmdSettings" runat="server" CssClass="cmdbtt cmdSettings" Text="Thiết lập" Visible="false" />
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
<asp:HiddenField ID="WF_FROM" runat="server" Value="0" Visible="false" />
