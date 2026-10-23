<%@ Control Language="vb" Inherits="DesktopModules.Home.Album_List" CodeFile="Ab_List.ascx.vb" AutoEventWireup="false" Explicit="True" %>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">
                        <asp:Literal ID="litTitle" runat="server"></asp:Literal>
                    </h3>
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
                                <asp:CheckBox ID="chkCare" CssClass="csHot" runat="server" AutoPostBack="true" Text="Tin nóng trang chủ"></asp:CheckBox>
                            </div>
                            <div class="col-md-6 pdt5 col-xs-6 pdr0">
                                <asp:CheckBox ID="chkHotCat" CssClass="csHotCat" runat="server" AutoPostBack="true" Text="Nóng chuyên mục"></asp:CheckBox>
                            </div>
                            <div class="none">
                                <asp:CheckBox ID="chkIsFocus" CssClass="csFocus" Visible="false" runat="server" AutoPostBack="true" Text="Tin thời sự"></asp:CheckBox>
                                <asp:CheckBox ID="chkIsEvent" CssClass="csEvent" Visible="false" runat="server" AutoPostBack="true" Text="Tin nóng thời sự"></asp:CheckBox>
                                <asp:CheckBox ID="chkHotSite" CssClass="csHotSite" Visible="false" runat="server" AutoPostBack="true" Text="Nổi bật trang chủ"></asp:CheckBox>
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
                    <div class="clear"></div>
                    <div class="row">
                        <div class="ctable-respo">
                            <asp:DataGrid ID="grdTab1" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
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
                                            <span class="scmchinh"><%# Eval("CategoryName")%></span>
                                        </ItemTemplate>
                                        <ItemStyle Width="20%" CssClass="chuyenmuc respo-view" />
                                        <HeaderStyle Width="20%" CssClass="chuyenmuc respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Lượt xem">
                                        <ItemTemplate><%# Eval("ViewCount")%></ItemTemplate>
                                        <ItemStyle Width="10%" CssClass="luotxem respo-view" />
                                        <HeaderStyle Width="10%" CssClass="luotxem respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Xem" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:Literal ID="View" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="5%" CssClass="xem respo-view" />
                                        <HeaderStyle Width="5%" CssClass="xem respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Lịch sử" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:Literal ID="litProcess" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="7%" CssClass="lichsu respo-view" />
                                        <HeaderStyle Width="7%" CssClass="lichsu respo-title" />
                                    </asp:TemplateColumn>
                                </Columns>

                            </asp:DataGrid>
                        </div>
                        <div class="row">
                            <asp:Literal ID="litPage" runat="server" />
                        </div>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdNew" runat="server" CssClass="cmdbtt cmdNew" Text="Thêm mới" Visible="false" />
                <asp:Button ID="cmdStop" runat="server" CssClass="cmdbtt cmdStop" Text="Ngừng xuất bản" Visible="false" />

                <asp:Button ID="cmdPUBNOW" runat="server" CssClass="cmdbtt cmdPUBNOW" Text="Xuất bản ngay" Visible="false" />
                <asp:Button ID="cmdRun1" runat="server" CssClass="cmdbtt cmdRun1" Text="Thực hiện 1" Visible="false" />
                <asp:Button ID="cmdRun2" runat="server" CssClass="cmdbtt cmdRun2" Text="Thực hiện 2" Visible="false" />
                <asp:Button ID="cmdRun3" runat="server" CssClass="cmdbtt cmdRun3" Text="Thực hiện 3" Visible="false" />

                <asp:Button ID="cmdBack1" runat="server" CssClass="cmdbtt cmdBack" Text="Trả lại 1" Visible="false" />
                <asp:Button ID="cmdBack2" runat="server" CssClass="cmdbtt cmdBack2" Text="Trả lại 2" Visible="false" />
                <asp:Button ID="cmdBack3" runat="server" CssClass="cmdbtt cmdBack3" Text="Trả lại 3" Visible="false" />
                <asp:Button ID="cmdBack4" runat="server" CssClass="cmdbtt cmdBack4" Text="Trả lại 4" Visible="false" />

                <asp:Button ID="cmdDel" runat="server" CssClass="cmdbtt cmdDel" Text="Xóa tin" Visible="false" />
                <asp:Button ID="cmdPage" runat="server" CssClass="cmdbtt cmdPage" Text="Trang tiếp" Visible="false" />
                <asp:Button ID="cmdPageNext" runat="server" CssClass="cmdbtt cmdPageNext" Text="Trang tiếp" Visible="false" />
                <asp:Button ID="cmdSettings" runat="server" CssClass="cmdbtt cmdSettings" Text="Thiết lập" Visible="false" />
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="lbtFind" />
        <asp:AsyncPostBackTrigger ControlID="cmdRun1" />
        <asp:AsyncPostBackTrigger ControlID="cmdRun2" />
        <asp:AsyncPostBackTrigger ControlID="cmdRun3" />
        <asp:AsyncPostBackTrigger ControlID="cmdBack1" />
        <asp:AsyncPostBackTrigger ControlID="cmdBack2" />
        <asp:AsyncPostBackTrigger ControlID="cmdBack3" />
        <asp:AsyncPostBackTrigger ControlID="cmdDel" />
    </Triggers>
</asp:UpdatePanel>

<div>
    <asp:HiddenField ID="WF_STEP" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WfID" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_FROM" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_PUBNOW" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_RETURN" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_TO1" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_TO2" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_TO3" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_BACK4" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_BACK3" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_BACK2" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_BACK1" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_NEW" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_PAGE" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_PAGENEXT" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_PUBLIC" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="WF_ROLE" runat="server" Value="Flase" Visible="false" />
    <asp:HiddenField ID="WF_STOP" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="Status" runat="server" Value="0" Visible="false" />
    <asp:HiddenField ID="CurrentPage" runat="server" Value="0" Visible="false" />
</div>
