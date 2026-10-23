<%@ Control Language="vb" CodeFile="HomeSetting.ascx.vb" Inherits="Modules.Group.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">Cấu hình hiển thị trang chủ</h3>
                </div>
                <div class="col-md-2 none">
                    <asp:DropDownList ID="drSort" CssClass="selectpicker" AutoPostBack="true" runat="server" />
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
         <asp:Literal runat="server" ID="litData" />
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                            <ItemStyle BackColor="#fbf2ec" />
                            <AlternatingItemStyle BackColor="#ffffff" />
                            <Columns>
                                <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="chkItemsTop" runat="server"  ToolTip="Chọn/bỏ chọn toàn bộ?" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="IsHome" runat="server" CssClass="CheckBox cDel" ToolTip="Chọn để hiển thị?" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="IsOrder" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Mã " HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Group_Code" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateColumn>
                                <asp:TemplateColumn HeaderText="Tên khối thông tin" HeaderStyle-CssClass="hdTitle">
                                    <ItemTemplate>
                                        <asp:Literal ID="Group_Name" runat="server" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateColumn>
                            </Columns>

                        </asp:DataGrid>
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
                <asp:Button ID="cmdUpdate" runat="server" Text="Cập nhật" CssClass="cmsbut cmdsave" OnClientClick="$('#Form').validationEngine('detach');"/>
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="drSort" />
        <asp:AsyncPostBackTrigger ControlID="drPageSize" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
    </Triggers>
</asp:UpdatePanel>
