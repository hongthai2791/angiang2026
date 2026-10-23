<%@ Control Language="vb" AutoEventWireup="false" CodeFile="News_Progress.ascx.vb" Inherits="DesktopModules.Modules.News_Admin" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke" Namespace="DotNetNuke.UI.WebControls" %>
<%--<%=strCssCn%>--%>

<asp:UpdatePanel ID="udpContent" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">DANH SÁCH TIN BÀI ĐÃ THAO TÁC</h3>
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
                                <div class="col-md-3">
                                    <div class="rccalpopup date-pub-list">
                                        <asp:TextBox ID="FromDate" runat="server" CssClass="datepicker" PlaceHolder="Từ ngày"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="rccalpopup date-pub date-pub-list">
                                        <asp:TextBox ID="ToDate" runat="server" CssClass="datepicker" PlaceHolder="Đến ngày"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="clear"></div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlCategory" CssClass="selectpicker cmcoption" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-5 pdr0">
                            <div class="col-md-12 pdr0">
                                <div class="col-md-6 col-xs-6 pdl0">
                                    <asp:CheckBox ID="chkCare" CssClass="csHot" runat="server" AutoPostBack="true" Text="Tin nóng trang chủ"></asp:CheckBox>
                                </div>
                                <div class="col-md-6 col-xs-6 pdr0">
                                    <asp:CheckBox ID="chkHotCat" CssClass="csHotCat" runat="server" AutoPostBack="true" Text="Nóng chuyên mục"></asp:CheckBox>
                                </div>
                                <div class="none">
                                    <asp:CheckBox ID="chkIsFocus" CssClass="csFocus" Visible="false" runat="server" AutoPostBack="true" Text="Tin thời sự"></asp:CheckBox>
                                    <asp:CheckBox ID="chkIsEvent" CssClass="csEvent" Visible="false" runat="server" AutoPostBack="true" Text="Tin nóng thời sự"></asp:CheckBox>
                                    <asp:CheckBox ID="chkHotSite" CssClass="csHotSite" Visible="false" runat="server" AutoPostBack="true" Text="Nổi bật trang chủ"></asp:CheckBox>
                                </div>
                            </div>
                            <div class="col-md-12 ">
                                <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                                <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="clear"></div>
                    <div class="row">
                        <div class="ctable-respo">
                            <asp:DataGrid ID="grdData" DataKeyField="NewId" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="STT">
                                        <ItemTemplate>
                                            <asp:Literal ID="STT" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tin bài">
                                        <ItemTemplate>
                                            <div class="td-das-view">
                                                <%# CMS.Ultis.ImagePath(Eval("ImagePath"))%>
                                                <%# Highlight(Eval("Title"), "<span class='highlight'>", "</span>")%>
                                                <%# CMS.Ultis.ViewImageByType(Eval("HotSite"), Eval("IsCare")) %>
                                            </div>
                                            <div class="td-das-view-ch">
                                                <asp:Literal ID="litDate" runat="server" /><br />
                                                <asp:Label ID="lblEdittedBy" runat="server" Text='<%# CMS.Ultis.FormatEdittedBy(PortalId, Eval("EditedUser"), Eval("EditedTime"), Eval("IsEdited"), Eval("NewID"))%>' ForeColor="Red"></asp:Label>
                                                <asp:ImageButton ID="ImageButton1" CommandName="cmdUnlock" CommandArgument='<%# Eval("newid")%>' ToolTip="Mở khóa" ImageUrl="~/images/icons/lock_break.png" runat="server"
                                                    Visible='<%#  Eval("IsEdited")%>' />
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
                                        <ItemStyle Width="10%" CssClass="luotxem respo-view" />
                                        <HeaderStyle Width="10%" CssClass="luotxem respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Trạng thái" >
                                        <ItemTemplate>
                                            <asp:Literal ID="StatusName" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" CssClass="StatusName respo-view" />
                                        <HeaderStyle Width="10%" CssClass="StatusName respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Xem" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <a onclick="preview(<%# Eval("NewId")%>, <%# Eval("PortalId")%>)" title="Xem" class="printview">
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

    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="lbtFind" />
        <asp:AsyncPostBackTrigger ControlID="ddlCategory" />
    </Triggers>
</asp:UpdatePanel>
<asp:HiddenField ID="CurrentPage" Visible="false" Value="1" runat="server" />
