<%@ Control Language="vb" Inherits="Dotnetnuke.Modules.View" CodeFile="Doc_List.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="DicPP" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-9">
                    <h3 class="box-title">
                        <asp:Literal ID="litTitle" runat="server"></asp:Literal>
                    </h3>
                    &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-4">
                            <asp:DropDownList ID="ddlPortal" CssClass="selectpicker" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList></td>
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drDocField" CssClass="selectpicker" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList></td>
                        </div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drDocType" CssClass="selectpicker" runat="server" Width="100%" AutoPostBack="true"></asp:DropDownList></td>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="clear"></div>
                    <div class="row">
                        <div class="col-md-12">
                            <asp:DataGrid ID="grdData" runat="server" CssClass="table-bordered respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#fbf2ec" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn>
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','check-dash');" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkItems" runat="server" CssClass="check-dash" />
                                        </ItemTemplate>
                                        <ItemStyle Width="40px" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="40px" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="IsOrder" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Số văn bản" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="NoCode" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="15%" CssClass="NoCode respo-view" />
                                        <HeaderStyle Width="15%" CssClass="NoCode respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tên văn bản" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="Document_Name" runat="server"></asp:Literal>
                                            <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Loại văn bản" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="DocType" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="20%" CssClass="docType respo-view" />
                                        <HeaderStyle Width="20%" CssClass="docType respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Lượt tải" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="IsDownload" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" HorizontalAlign="Center" CssClass="IsDownload respo-view" />
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" CssClass="IsDownload respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tệp" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="DocFile" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <ItemStyle Width="5%" CssClass="DocFile respo-view" HorizontalAlign="Center" />
                                        <HeaderStyle Width="5%" CssClass="DocFile respo-title" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                        <asp:Literal ID="litPage" runat="server" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmdbtt cmdNew" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmdbtt cmdDel" />
                <asp:Button ID="cmdSettings" runat="server" Visible="false" CssClass="cmdbtt cmdSettings" Text="Thiết lập" />
            </div>
        </div>
        <asp:HiddenField ID="DOC_LIST_GROUP" runat="server" Visible="false" />
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
    </ContentTemplate>
</asp:UpdatePanel>
<script type="text/javascript">
    function updateDownload(id, pid) {
        var link = "/api/cms/upDoc.ashx?id=" + id + "&pid=" + pid;
        var msg = $.ajax({ url: link, async: false }).responseText;
        if (msg != "nothing") { window.open(msg); }
    };
</script>
