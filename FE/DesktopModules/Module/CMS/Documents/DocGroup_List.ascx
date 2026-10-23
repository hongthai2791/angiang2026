<%@ Control Language="vb" CodeFile="DocGroup_List.ascx.vb" Inherits="Modules.Roles.View" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9">
            <h3 class="box-title">Quản lý nhóm văn bản
                <asp:Literal ID="litCount" runat="server" Visible="false" /></h3>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-5">
                    <telerik:RadTreeView ID="docGroupTree" CssClass="scroll" Height="500" runat="server" OnContextMenuItemClick="HandleContextClick" OnClientContextMenuItemClicking="onClientContextMenuItemClicking" Skin="Simple"
                        SingleExpandPath="False" AutoPostBack="false" EnableDragAndDrop="false" OnNodeDrop="HandleDrop" EnableDragAndDropBetweenNodes="true" OnNodeClick="docGroupTree_NodeClick">
                        <ContextMenus>
                            <telerik:RadTreeViewContextMenu ID="MainContextMenu" runat="server">
                                <Items>
                                    <telerik:RadMenuItem Value="addchildren" Text="Thêm nhóm văn bản con" ImageUrl="/image/12.gif"></telerik:RadMenuItem>
                                    <telerik:RadMenuItem Value="addsibling" Text="Thêm nhóm văn bản cùng cấp" ImageUrl="/image/12.gif"></telerik:RadMenuItem>
                                    <telerik:RadMenuItem IsSeparator="true"></telerik:RadMenuItem>
                                    <telerik:RadMenuItem Value="Delete" Text="Xóa nhóm văn bản" ImageUrl="/image/7.gif"></telerik:RadMenuItem>
                                </Items>
                                <CollapseAnimation Type="none" />
                            </telerik:RadTreeViewContextMenu>
                        </ContextMenus>
                    </telerik:RadTreeView>
                </div>
                <div class="col-md-7">

                    <div class="col-md-3 lb">Nhóm cấp cha</div>
                    <div class="col-md-9">
                        <asp:HiddenField ID="Parent_ID" runat="server" />
                        <asp:TextBox ID="Parent_Name" Enabled="false" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3 b pdt5 lb">Tên nhóm văn bản</div>
                    <div class="col-md-9">
                        <asp:TextBox ID="DocGroup_Name" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3 b pdt5 lb">Mô tả nội dung</div>
                    <div class="col-md-9">
                        <asp:TextBox ID="DocGroup_Des" runat="server" TextMode="MultiLine" Height="100" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3 b pdt5 lb  ">Thứ tự</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="IsOrder"  runat="server" TabIndex="7" CssClass="TextBox center validate[ custom[integer]]" />
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
            <div class="row">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate cbclick " OnClientClick="return retunwaiting();" />

    </div>
</div>
<asp:HiddenField ID="currPage" runat="server" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
<asp:HiddenField ID="itemID" Value="0" runat="server" Visible="false" /> 
<asp:HiddenField ID="_ParentIDOLd" runat="server" Visible="false" />
<script>

    function scrollToNode() {
        var tree = $find('<%=docGroupTree.ClientID %>');
        var node = tree.get_selectedNode();
        if (node) {
            var nodeElement = node.get_element();
            nodeElement.scrollIntoView();
        }
    };
    function onClientContextMenuShowing(sender, args) { var treeNode = args.get_node(); treeNode.set_selected(true); setMenuItemsState(args.get_menu().get_items(), treeNode); }
    function onClientContextMenuItemClicking(sender, args) { var menuItem = args.get_menuItem(); var treeNode = args.get_node(); menuItem.get_menu().hide(); switch (menuItem.get_value()) { case "Delete": var result = confirm("Bạn có chắc chắn muốn xóa nhóm: " + treeNode.get_text()); args.set_cancel(!result); break; } }
    function setMenuItemsState(menuItems, treeNode) { for (var i = 0; i < menuItems.get_count(); i++) { var menuItem = menuItems.getItem(i); switch (menuItem.get_value()) { case "Delete": formatMenuItem(menuItem, treeNode, 'Xóa "{0}"'); break; } } }
    function formatMenuItem(menuItem, treeNode, formatString) { var nodeValue = treeNode.get_value(); var newText = String.format(formatString, extractTitleWithoutMails(treeNode)); menuItem.set_text(newText); }
    function extractTitleWithoutMails(treeNode) { return treeNode.get_text().replace(/\s*\([\d]+\)\s*/ig, ""); }
</script>
