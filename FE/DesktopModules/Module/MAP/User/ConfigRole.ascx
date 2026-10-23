<%@ Control Language="vb" CodeFile="ConfigRole.ascx.vb" Inherits="Modules.UserConfigEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Phân quyền tác nghiệp sử dụng chức năng</h3>
                </div>

            </div>
            <div class="box-body">
                <div class="col-md-2 pdt5">Tỉnh/ thành phố</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="drTinhTP" AutoPostBack="true" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-4">
                    <asp:DropDownList ID="drVaiTro" AutoPostBack="true" CssClass="selectpicker" runat="server" />
                </div>
                <div class="col-md-2 txt-right count">
                    <asp:Literal ID="litCount" runat="server"></asp:Literal>
                </div>
                <div class="clear"></div>
                <div class="main-body">
                    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                        <ItemStyle BackColor="#fbf2ec" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="IsOrder" runat="server"></asp:Literal>
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Mã chức năng" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="ModuleSrc" runat="server"></asp:Literal>
                                </ItemTemplate>
                                <HeaderStyle Width="30%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Chức năng tác nghiệp" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="ModuleName" runat="server"></asp:Literal>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <img src="/Portals/_default/Skins/vbn/images/hover_edit.png" alt="news" title="Sử dụng" class="bCur bNew" onclick="clickSelect('bNew','cNew');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsCheck" runat="server" CssClass="cs-select cNew" ToolTip="Sử dụng" />
                                </ItemTemplate>
                                <HeaderStyle Width="7%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
                <div class="clr"></div>
            </div>
        </div>
        <div class="clr"></div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate cbclick" />
            </div>
        </div>
        <asp:Literal ID="litUpdate" runat="server" />
        <script type="text/javascript">
            function clickSelect(i, c) { if ($("." + i).hasClass("select")) { $("." + i).removeClass("select"); $("." + c).each(function (e) { if ($(this).find("input").attr("disabled") != "disabled") { $(this).find("input").attr("checked", false); } }); } else { $("." + i).addClass("select"); $("." + c).each(function (e) { if ($(this).find("input").attr("disabled") != "disabled") { $(this).find("input").attr("checked", true); } }); } };
            function clickbyparent(i) { if ($("." + i).is(":checked")) { $("." + i).attr("checked", false); } else { $("." + i).attr("checked", true); }; };
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
