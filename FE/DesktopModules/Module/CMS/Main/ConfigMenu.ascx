<%@ Control Language="vb" AutoEventWireup="false" ClientIDMode="Static" CodeFile="ConfigMenu.ascx.vb" Inherits="DesktopModules.Menu.MenuAdmin" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<script src="/js/jscolor/jscolor.js"></script>

<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THIẾT LẬP MENU WEBSITE</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <asp:Literal ID="lbmsg" runat="server"></asp:Literal>
            <div class="row">
                <div class="col-md-12">
                    <asp:DropDownList ID="ddlPortal" CssClass="selectpicker" runat="server" AutoPostBack="true"></asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6 pdl0 pdr0">
                    <div class="col-sm-8 col-xs-7">
                        <asp:DropDownList ID="drlMenu" runat="server" DataTextField="Text" DataValueField="Value" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                    </div>
                    <div class="col-sm-4 col-xs-5">
                        <asp:CheckBox ID="cbCopy" Text="Sao chép menu" runat="server" AutoPostBack="true" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="col-md-6">
                    <asp:Panel ID="pnCopy" runat="server" Visible="false">
                        <div class="col-sm-9 col-xs-7">
                            <asp:DropDownList ID="drCopy" runat="server" DataTextField="Text" DataValueField="Value" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-sm-3 col-xs-5">
                            <asp:Button ID="cmdCopy" Text="Sao chép" runat="server" CssClass="StandardButton" Width="70px" />
                        </div>
                    </asp:Panel>
                    <div class="clear"></div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <div style="overflow: auto; height: 450px; background-color: #fff; border: 1px solid #ddd">
                        <telerik:RadTreeView ID="catMenu" runat="server" OnContextMenuItemClick="HandleContextClick" OnClientContextMenuItemClicking="onClientContextMenuItemClicking"
                            SingleExpandPath="False" AutoPostBack="false" EnableDragAndDrop="True" OnNodeDrop="HandleDrop" EnableDragAndDropBetweenNodes="true" OnNodeClick="catMenu_NodeClick">
                            <ContextMenus>
                                <telerik:RadTreeViewContextMenu ID="MainContextMenu" runat="server">
                                    <Items>
                                        <telerik:RadMenuItem Value="addchildren" Text="Thêm chuyên mục con" ImageUrl="/image/12.gif"></telerik:RadMenuItem>
                                        <telerik:RadMenuItem Value="addsibling" Text="Thêm chuyên mục cùng cấp" ImageUrl="/image/12.gif"></telerik:RadMenuItem>
                                        <telerik:RadMenuItem IsSeparator="true"></telerik:RadMenuItem>
                                        <telerik:RadMenuItem Value="edit" Text="Sửa chi tiết" ImageUrl="/image/3Drafts.gif"></telerik:RadMenuItem>
                                        <telerik:RadMenuItem Value="Delete" Text="Xóa nút xử lý" ImageUrl="/image/7.gif"></telerik:RadMenuItem>
                                    </Items>
                                    <CollapseAnimation Type="none" />
                                </telerik:RadTreeViewContextMenu>
                            </ContextMenus>
                        </telerik:RadTreeView>
                    </div>
                </div>
                <div id="dialogEditParam" class="col-md-8 pdr0">
                    <div class="col-md-12 pdr0">
                        <div class="col-md-2 pdt5">Tên menu</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="txtNodeName" runat="server" CssClass="TextBox" EnableViewState="true" MaxLength="350"></asp:TextBox>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 pdt5">Link tới trang</div>
                        <div class="col-md-10">
                            <asp:DropDownList ID="drdLink" runat="server" DataTextField="IndentedTabName" DataValueField="TabId" AutoPostBack="true" CssClass="selectpicker" Width="100%" />
                            <br />
                            <asp:CheckBox ID="chkLinkPopup" runat="server" resourcekey="lblLinkPopup" Visible="false" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 pdt5">Đường link Url</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="txtUrl" runat="server" CssClass="TextBox" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 pdt5">Màu nền</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="txtBackground" runat="server" CssClass="color TextBox" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 pdt5">Thứ tự hiển thị</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox" />
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu thay đổi" CssClass="cmdbtt cmdSave" />
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
    </div>
</div>
<asp:HiddenField runat="server" ID="_MenuDID" />
<asp:HiddenField runat="server" ID="_ParentID" />
<script type="text/javascript">
    function onClientContextMenuShowing(sender, args) { var treeNode = args.get_node(); treeNode.set_selected(true); setMenuItemsState(args.get_menu().get_items(), treeNode); }
    function onClientContextMenuItemClicking(sender, args) { var menuItem = args.get_menuItem(); var treeNode = args.get_node(); menuItem.get_menu().hide(); switch (menuItem.get_value()) { case "Delete": var result = confirm("Bạn có chắc chắn muốn xóa nút xử lý: " + treeNode.get_text()); args.set_cancel(!result); break; } }
    function setMenuItemsState(menuItems, treeNode) { for (var i = 0; i < menuItems.get_count(); i++) { var menuItem = menuItems.getItem(i); switch (menuItem.get_value()) { case "Delete": formatMenuItem(menuItem, treeNode, 'Xóa "{0}"'); break; } } }
    function formatMenuItem(menuItem, treeNode, formatString) { var nodeValue = treeNode.get_value(); var newText = String.format(formatString, extractTitleWithoutMails(treeNode)); menuItem.set_text(newText); }
    function extractTitleWithoutMails(treeNode) { return treeNode.get_text().replace(/\s*\([\d]+\)\s*/ig, ""); }
</script>
