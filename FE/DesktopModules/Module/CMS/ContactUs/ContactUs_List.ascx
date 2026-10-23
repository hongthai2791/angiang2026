<%@ Control Language="vb" Inherits="DesktopModules.Home.ContactUs" CodeFile="ContactUs_List.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">DANH SÁCH LIÊN HỆ</h3>
                    &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)                    
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-3 pdl0">
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
                        <div class="col-md-3 pdr0">
                            <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                            <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="ctable-respo">
                            <asp:DataGrid ID="grdData" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="Ngày gửi">
                                        <ItemTemplate>
                                            <asp:Literal ID="CreatedDate" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="15%" CssClass="CreatedDate respo-view" />
                                        <HeaderStyle Width="15%" CssClass="CreatedDate respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Người liên hệ">
                                        <ItemTemplate>
                                            <asp:Literal ID="FirstName" runat="server" />
                                            <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle Width="20%" CssClass="column-primary" />
                                        <ItemStyle Width="20%" CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Nội dung liên hệ">
                                        <ItemTemplate>
                                            <asp:Literal ID="Contents" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle CssClass="Contents respo-view" />
                                        <HeaderStyle CssClass="Contents respo-title" />
                                    </asp:TemplateColumn>

                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <asp:HiddenField ID="CurrentPage" runat="server" Visible="false" />
                </div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="lbtFind" />
    </Triggers>
</asp:UpdatePanel>

