<%@ Control Language="vb" AutoEventWireup="false" CodeFile="View.ascx.vb" Inherits="DesktopModules.Modules.FeedBack.view_comment" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">DANH SÁCH Ý KIẾN PHẢN HỒI CỦA ĐỘC GIẢ</h3>
            &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
            
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-8">
                <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="col-md-4">
                <asp:DropDownList ID="drlStatus" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                <asp:DropDownList ID="drlType" Visible="false" Width="100px" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="clear"></div>
            <div class="row">
                <div class="ctable-respo">
                    <asp:DataGrid ID="drgContent" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                        <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                        <ItemStyle BackColor="#f5f5f5" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderText="STT">
                                <ItemTemplate>
                                    <asp:Label ID="numberLabel" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="40px" HorizontalAlign="Center" CssClass="fix-column" />
                                <HeaderStyle Width="40px" HorizontalAlign="Center" CssClass="fix-column" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Thông tin bạn đọc">
                                <ItemTemplate>
                                    <div class="td-das-view">
                                        <div style="padding-bottom: 5px;">Họ tên: <span style="font-weight: bold;"><%# DataBinder.Eval(Container.DataItem, "FullName") %></span></div>
                                        <div style="padding-bottom: 5px;">Email: <span style="color: #074572"><%# DataBinder.Eval(Container.DataItem, "Email") %></span></div>
                                        <div style="padding-bottom: 0px;">Ngày gửi: <span style="font-weight: bold;"><%# EPORTAL.flReg.ReadDate(DataBinder.Eval(Container.DataItem, "Createdate"))%></span> </div>
                                    </div>
                                    <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                </ItemTemplate>
                                <HeaderStyle CssClass="column-primary" Width="20%" />
                                <ItemStyle CssClass="column-primary" Width="20%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Nội dung">
                                <ItemTemplate>
                                    <%#EPORTAL.flReg.RemoveHTML(Server.HtmlDecode(DataBinder.Eval(Container.DataItem, "Content"))) %>
                                </ItemTemplate>
                                <ItemStyle CssClass="Content respo-view" />
                                <HeaderStyle CssClass="respo-title" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Bài viết">
                                <ItemTemplate>
                                    <asp:Literal ID="Link" runat="server" />
                                </ItemTemplate>
                                <ItemStyle Width="30%" CssClass="Link respo-view" />
                                <HeaderStyle Width="30%" CssClass="Link respo-title" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Trạng thái">
                                <ItemTemplate>
                                    <%# StatusCm(Eval("Status")) %>
                                </ItemTemplate>
                                <ItemStyle Width="10%" CssClass="Status respo-view" />
                                <HeaderStyle Width="10%" CssClass="Status respo-title" />
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle Visible="false"></PagerStyle>
                    </asp:DataGrid>
                </div>
            </div>
            <div class="col-md-12">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <asp:HiddenField ID="CurrentPage" runat="server" />
        </div>
    </div>
</div>

