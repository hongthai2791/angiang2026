<%@ Control Language="vb" Inherits="DesktopModules.FAQ.Question_List" CodeFile="QuestionList.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="PP" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">DANH SÁCH CÂU HỎI</h3>
                    &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-4 pdl0 none">
                        <asp:DropDownList ID="ddlPortal" runat="server" Width="100%" CssClass="selectpicker" AutoPostBack="true" />
                    </div>
                    <div class="col-md-12 col-xs-12 pdr0">
                        <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm theo nội dung câu hỏi......" CssClass="timKiemD" Columns="20" Width="100%" />
                        <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                    </div>
                    <div class="clear"></div>
                    <div class="row">
                        <div class="ctable-respo">
                            <asp:DataGrid ID="grdTab1" Width="100%" DataKeyField="Id" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="STT">
                                        <ItemTemplate>
                                            <asp:TextBox ID="OrderNo" Width="40px" runat="server" CssClass="grdtxt center" />
                                        </ItemTemplate>
                                        <ItemStyle Width="40" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Họ tên" Visible="false">
                                        <ItemTemplate>
                                            <asp:Literal ID="Name" runat="server" />
                                            <div class="toggle-row" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Nội dung" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                        <ItemTemplate>
                                            <asp:Literal ID="Contents" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle  CssClass="noidung respo-view" />
                                        <HeaderStyle CssClass="noidung respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Email" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                        <ItemTemplate>
                                            <asp:Literal ID="Email" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="15%" CssClass="chuyenmuc respo-view" />
                                        <HeaderStyle CssClass="chuyenmuc respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Số điện thoại" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                        <ItemTemplate>
                                            <asp:Literal ID="Phone" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" CssClass="Phone respo-view" />
                                        <HeaderStyle CssClass="Phone respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Ngày gửi" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                        <ItemTemplate>
                                            <asp:Literal ID="SendDate" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" CssClass="Phone respo-view" />
                                        <HeaderStyle CssClass="Phone respo-title" />
                                    </asp:TemplateColumn>
                                    
                                    <asp:TemplateColumn HeaderText="Trạng thái" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                        <ItemTemplate>
                                            <asp:Literal ID="TrangThai" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" CssClass="TrangThai respo-view" />
                                        <HeaderStyle CssClass="TrangThai respo-title" />
                                    </asp:TemplateColumn>

                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                </div>
            </div>
            <div class="fix-btt-toolbar">
                <div>
                    <asp:Button ID="cmdNew" runat="server" CssClass="cmdbtt cmdNew" Text="Thêm mới" />
                    <asp:Button ID="cmdDel" Visible="false" runat="server" CssClass="cmdbtt cmdDel" Text="Xóa " />
                </div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="lbtFind" />
        <asp:AsyncPostBackTrigger ControlID="cmdDel" />
    </Triggers>
</asp:UpdatePanel>
<asp:HiddenField ID="CurrentPage" Visible="false" runat="server" />
