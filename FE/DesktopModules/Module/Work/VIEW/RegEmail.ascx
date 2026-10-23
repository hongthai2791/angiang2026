<%@ Control Language="vb" Inherits="Modules.RegEmail.View" AutoEventWireup="false" CodeFile="RegEmail.ascx.vb" Explicit="True" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border pdb0">
                <div class="col-sm-12">
                    <h3 class="box-title">Danh sách email đăng ký nhận tin (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row mgb5">
                        <div class="col-md-12 lb">Nội dung gửi thông báo</div>
                        <div class="col-md-12">
                            <asp:TextBox ID="Contents" runat="server" CssClass="txt" TextMode="MultiLine" Height="50px" Width="100%"></asp:TextBox>
                            <asp:LinkButton ID="cmdSearch" runat="server" ToolTip="Gửi thông báo tới email đăng ký" CausesValidation="False" CssClass="btTSend cs cbclick" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                                <ItemStyle BackColor="#f8f4f1" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="IsOrder" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                        <ItemStyle Width="5%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Email đăng ký nhận thông tin" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="RegEmail" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Ngày đăng ký" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="RegDate" runat="server"></asp:Literal>
                                        </ItemTemplate>
                                        <HeaderStyle Width="25%" />
                                        <ItemStyle Width="25%" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                        <HeaderTemplate>
                                            <img src="/portals/_default/skins/vbn/images/hover_check.png?w" alt="Active" class="bCur bAct select" onclick="clickSelect('bAct','cAct');" />
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="IsActive" runat="server" CssClass="cs-select cMen" ToolTip="Chọn gửi mail?" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                        <ItemStyle Width="5%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <asp:Literal ID="lbMsg" runat="server" />
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
</asp:UpdatePanel>
