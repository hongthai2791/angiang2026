<%@ Control Language="vb" CodeFile="ConfigTarget.ascx.vb" Inherits="Modules.RegTarProvin.View" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-9">
                    <h3 class="box-title">Cấu hình chỉ tiêu cho đơn vị</h3>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="TinhTP" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-6">
                        <telerik:RadTextBox ClientEvents-OnLoad="clientLoad" ID="txtkey" runat="server" placeholder="Nhập vào chỉ tiêu cần tìm kiếm ..." CssClass="findadv" Columns="20" Width="100%" />
                    </div>
                    <div class="row">
                        <telerik:RadTreeView ID="TargetsID" CssClass="scroll" runat="server" CheckBoxes="True" Height="500px" Width="100%" TriStateCheckBoxes="True" CheckChildNodes="False">
                            <DataBindings>
                                <telerik:RadTreeNodeBinding Expanded="True" />
                            </DataBindings>
                        </telerik:RadTreeView>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate cbclick " OnClientClick="return retunwaiting();" />
                <%--<asp:Button ID="cmdExcel" runat="server" Text="Xuất ra excel" CssClass="cmsbut cmsbtExport" OnClientClick="popexp('exports');return false;" />--%>
            </div>
        </div>
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdSave" />
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
    </Triggers>
</asp:UpdatePanel>

<script>
      var timer = null; function clientLoad(sender) { $telerik.$("#<%= txtkey.ClientID %>", sender.get_element().parentNode).bind("keydown", valueChanging); } function valueChanging(sender, args) { if (timer) { clearTimeout(timer); } timer = setTimeout(function () { var tree = $find("<%= TargetsID.ClientID %>"); var textbox = $find("<%= txtkey.ClientID %>"); var searchString = textbox.get_element().value; for (var i = 0; i < tree.get_nodes().get_count(); i++) { findNodes(tree.get_nodes().getNode(i), searchString); } }, 200); } function findNodes(node, searchString) { node.set_expanded(true); var hasFoundChildren = false; for (var i = 0; i < node.get_nodes().get_count(); i++) { hasFoundChildren = findNodes(node.get_nodes().getNode(i), searchString) || hasFoundChildren; } if (hasFoundChildren || node.get_text().toLowerCase().indexOf(searchString.toLowerCase()) != -1) { node.set_visible(true); return true; } else { node.set_visible(false); return false; } }
</script>