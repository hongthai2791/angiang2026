<%@ Control Language="vb" CodeFile="TargetsView.ascx.vb" Inherits="Modules.Targets.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9">
            <h3 class="box-title">Danh mục bộ chỉ tiêu báo cáo</h3>
        </div>
        <div class="col-md-1 none">
            <asp:DropDownList ID="drPageSize" CssClass="selectpicker" AutoPostBack="true" runat="server" />
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
            <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-6">
                    <asp:DropDownList ID="Group_ID" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>

            <asp:UpdatePanel ID="pageView" runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-md-6">
                            <telerik:RadTreeView ID="catTarget" CssClass="scroll" Height="500" runat="server" OnContextMenuItemClick="HandleContextClick" OnClientContextMenuItemClicking="onClientContextMenuItemClicking" Skin="Simple"
                                SingleExpandPath="False" OnClientLoad="scrollToNode" AutoPostBack="false" EnableDragAndDrop="false" OnNodeDrop="HandleDrop" EnableDragAndDropBetweenNodes="true" OnNodeClick="catTarget_NodeClick">
                                <ContextMenus>
                                    <telerik:RadTreeViewContextMenu ID="MainContextMenu" runat="server">
                                        <Items>
                                            <telerik:RadMenuItem Value="addchildren" Text="Thêm chỉ tiêu con" ImageUrl="/image/12.gif"></telerik:RadMenuItem>
                                            <telerik:RadMenuItem Value="addsibling" Text="Thêm chỉ tiêu cùng cấp" ImageUrl="/image/12.gif"></telerik:RadMenuItem>
                                            <telerik:RadMenuItem IsSeparator="true"></telerik:RadMenuItem>
                                            <telerik:RadMenuItem Value="Delete" Text="Xóa chỉ tiêu" ImageUrl="/image/7.gif"></telerik:RadMenuItem>
                                        </Items>
                                        <CollapseAnimation Type="none" />
                                    </telerik:RadTreeViewContextMenu>
                                </ContextMenus>
                            </telerik:RadTreeView>
                        </div>
                        <div class="col-md-6">
                            <div class="main-body">
                                <div class="col-md-3 lb">Chỉ tiêu cha</div>
                                <div class="col-md-9">
                                    <asp:TextBox ID="Parent_ID" Enabled="false" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-3 lb">Mã chỉ tiêu</div>
                                <div class="col-md-9">
                                    <asp:TextBox ID="Targets_Code" runat="server" CssClass="TextBox Targets_Code txt-center validate[required]" />
                                    <span class="required"></span>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-3 lb">Tên chỉ tiêu</div>
                                <div class="col-md-9">
                                    <asp:TextBox ID="Targets_Name" runat="server" CssClass="TextBox validate[required]" />
                                    <span class="required"></span>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-3 lb">Tên viết tắt</div>
                                <div class="col-md-9">
                                    <asp:TextBox ID="Targets_Sort" runat="server" CssClass="TextBox" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-3 lb">Mô tả</div>
                                <div class="col-md-9">
                                    <asp:TextBox ID="Targets_Des" runat="server" CssClass="TextBox" Height="50px" TextMode="MultiLine" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-3 lb">Dẫn nguồn</div>
                                <div class="col-md-9">
                                    <asp:TextBox ID="Targets_Src" runat="server" CssClass="TextBox" Height="50px" TextMode="MultiLine" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-3 lb">Công thức</div>
                                <div class="col-md-9">
                                    <asp:TextBox ID="Targets_Caculator" runat="server" CssClass="TextBox" Height="50px" TextMode="MultiLine" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-3 col-xs-6 lb">Đơn vị tính</div>
                                <div class="col-md-4 col-xs-6">
                                    <asp:DropDownList ID="drUnitType" CssClass="selectpicker" runat="server" />
                                </div>
                                <div class="col-md-3 col-xs-6 txt-center lb">Thứ tự</div>
                                <div class="col-md-2 col-xs-6">
                                    <asp:TextBox ID="Targets_IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-4 col-xs-6 pdt5">
                                    <asp:CheckBox ID="IsSum" CssClass="CheckBox" Text="Nhập tổng số" runat="server" />
                                </div>
                                <div class="col-md-4 col-xs-6 pdt5">
                                    <asp:CheckBox ID="IsHome" Text="Chỉ tiêu phân tích" CssClass="CheckBox" runat="server" />
                                </div>
                                <div class="col-md-4 col-xs-6 pdt5">
                                    <asp:CheckBox ID="IsMain" Text="Chỉ tiêu chính" CssClass="CheckBox" runat="server" />
                                </div>
                                  <div class="clear"></div>
                                <div class="col-md-12 col-xs-6 pdt5">
                                    <asp:CheckBox ID="IsGroup" Text="Chỉ tiêu so sánh nhóm" CssClass="CheckBox" runat="server" />
                                </div>
                                <div class="clear"></div>
                                <div class="row">
                                    <div class="col-md-12 "><b>Lưu ý:</b></div>
                                    <div class="col-md-12">
                                        - Nhập thông tin "<b>Tên viết tắt</b>" để hiển thị trong biểu đồ phân tích
                                    </div>
                                    <div class="col-md-12">
                                        - Nhập thông tin "<b>Mô tả</b>" để hiển thị trong menu chức năng
                                    </div>
                                    <div class="col-md-12">
                                        - Nhập công thức #"<b>Mã chỉ tiêu</b>@Toán hạng"#"<b>Mã chỉ tiêu</b>..."
                                    </div>
                                </div>
                                <div class="clr clUp"></div>
                                <asp:Literal ID="litUpdate" runat="server" />
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Group_ID" />
                    <asp:AsyncPostBackTrigger ControlID="drPageSize" />
                    <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
                    <asp:AsyncPostBackTrigger ControlID="cmdSave" />
                </Triggers>
            </asp:UpdatePanel>
            <div class="row">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <div class="clear"></div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate cbclick " OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdExcel" runat="server" Text="Xuất ra excel" CssClass="cmsbut cmsbtExport" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdSetting" runat="server" Text="Thiết lập danh mục" CssClass="cmsbut cmdSettings" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
<asp:HiddenField ID="TotalParent" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
<asp:HiddenField ID="_TargetsID" Value="0" runat="server" Visible="false" />
<asp:HiddenField ID="_ParentID" Value="-1" runat="server" Visible="false" />
<asp:HiddenField ID="_isOrderOld" runat="server" Visible="false" />
<asp:HiddenField ID="_targetCodeOld" runat="server" Visible="false" />
<asp:HiddenField ID="_ParentIDOLd" runat="server" Visible="false" />
<asp:HiddenField ID="hdnScrollPos" runat="server" />

<script type="text/javascript">
    function scrollToNode() {
        var tree = $find('<%=catTarget.ClientID %>');
        var node = tree.get_selectedNode();
        if (node) {
            var nodeElement = node.get_element();
            nodeElement.scrollIntoView();
        }
    };
    function onClientContextMenuShowing(sender, args) { var treeNode = args.get_node(); treeNode.set_selected(true); setMenuItemsState(args.get_menu().get_items(), treeNode); }
    function onClientContextMenuItemClicking(sender, args) { var menuItem = args.get_menuItem(); var treeNode = args.get_node(); menuItem.get_menu().hide(); switch (menuItem.get_value()) { case "Delete": var result = confirm("Bạn có chắc chắn muốn xóa nút xử lý: " + treeNode.get_text()); args.set_cancel(!result); break; } }
    function setMenuItemsState(menuItems, treeNode) { for (var i = 0; i < menuItems.get_count(); i++) { var menuItem = menuItems.getItem(i); switch (menuItem.get_value()) { case "Delete": formatMenuItem(menuItem, treeNode, 'Xóa "{0}"'); break; } } }
    function formatMenuItem(menuItem, treeNode, formatString) { var nodeValue = treeNode.get_value(); var newText = String.format(formatString, extractTitleWithoutMails(treeNode)); menuItem.set_text(newText); }
    function extractTitleWithoutMails(treeNode) { return treeNode.get_text().replace(/\s*\([\d]+\)\s*/ig, ""); }
</script>
