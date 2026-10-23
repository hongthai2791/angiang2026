<%@ Control Language="vb" Inherits="DesktopModules.Weblinks.Weblink_List" CodeFile="RssNews_List.ascx.vb" AutoEventWireup="false" Explicit="True" %>

<asp:UpdatePanel ID="PP" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">QUẢN LÝ TIN BÀI RSS</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-4 pdl0">
                        <asp:DropDownList ID="ddlPortal" runat="server" Width="100%" CssClass="selectpicker" AutoPostBack="true" />
                    </div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="ddlRssSource" runat="server" Width="100%" CssClass="selectpicker" AutoPostBack="true" />
                    </div>
                    <div class="col-md-4 pdr0">
                        <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                        <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                    </div>
                    <div class="clear"></div>
                    <div class="ctable rsslist">
                        <div class="col-md-12 pdt20 b pdl0">
                            DANH SÁCH LẤY TIN TỪ NGUỒN RSS  (<asp:Label ID="lbGetTin" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)
                        </div>
                        <div class="row">
                            <div class="ctable-respo">
                                <asp:DataGrid ID="grdTab1" Width="100%" DataKeyField="ID" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                    <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                    <ItemStyle BackColor="#f5f5f5" />
                                    <AlternatingItemStyle BackColor="#ffffff" />
                                    <Columns>
                                        <asp:TemplateColumn>
                                            <HeaderTemplate>
                                                <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','check-dash');" />
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkItems" runat="server" CssClass="check-dash" />
                                            </ItemTemplate>
                                            <ItemStyle Width="40" HorizontalAlign="Center" CssClass="fix-column" />
                                            <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="STT">
                                            <ItemTemplate>
                                                <asp:TextBox ID="OrderNo" Width="40px" runat="server" CssClass="grdtxt center" />
                                            </ItemTemplate>
                                            <ItemStyle Width="40" HorizontalAlign="Center" CssClass="fix-column" />
                                            <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Tên bài viết">
                                            <ItemTemplate>
                                                <asp:Literal ID="Name" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle CssClass="column-primary" />
                                            <ItemStyle Width="15%" CssClass="column-primary" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Mô tả">
                                            <ItemTemplate>
                                                <asp:Literal ID="Mota" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle CssClass="column-primary" />
                                            <ItemStyle Width="35%" CssClass="column-primary" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Ngày" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                            <ItemTemplate>
                                                <asp:Literal ID="NgayThang" runat="server" />
                                            </ItemTemplate>
                                            <ItemStyle Width="100" CssClass="diachi respo-view" />
                                            <HeaderStyle CssClass="diachi respo-title" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Link" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                            <ItemTemplate>
                                                <asp:Literal ID="Url" runat="server" />
                                                <asp:HiddenField ID="hUrl" runat="server" />
                                            </ItemTemplate>
                                            <ItemStyle CssClass="diachi respo-view" />
                                            <HeaderStyle CssClass="diachi respo-title" />
                                        </asp:TemplateColumn>

                                    </Columns>
                                </asp:DataGrid>
                            </div>
                        </div>
                        <div class="col-md-12 pdt20 b pdl0">
                            DANH SÁCH TIN ĐÃ LƯU (<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>) 
                        </div>
                        <div class="row ">
                            <div class="ctable-respo">
                                <asp:DataGrid ID="dgList" Width="100%" DataKeyField="ID" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                    <HeaderStyle Font-Bold="true" ForeColor="White" BackColor="#006699" CssClass="head"></HeaderStyle>
                                    <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                                    <ItemStyle CssClass="TRgrid" BackColor="#F7FBFB" />
                                    <AlternatingItemStyle BackColor="#ffffff" />
                                    <Columns>
                                        <asp:TemplateColumn>
                                            <HeaderTemplate>
                                                <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','check-dash');" />
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkItems" runat="server" CssClass="check-dash" />
                                            </ItemTemplate>
                                            <ItemStyle Width="40" HorizontalAlign="Center" CssClass="fix-column" />
                                            <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="STT">
                                            <ItemTemplate>
                                                <asp:TextBox ID="OrderNo" Width="40px" runat="server" CssClass="grdtxt center" />
                                            </ItemTemplate>
                                            <ItemStyle Width="40" HorizontalAlign="Center" CssClass="fix-column" />
                                            <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Tên bài viết">
                                            <ItemTemplate>
                                                <asp:Literal ID="Name" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle CssClass="column-primary" />
                                            <ItemStyle Width="15%" CssClass="column-primary" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Ngày" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                            <ItemTemplate>
                                                <asp:Literal ID="NgayThang" runat="server" />
                                            </ItemTemplate>
                                            <ItemStyle Width="100" CssClass="diachi respo-view" />
                                            <HeaderStyle CssClass="diachi respo-title" />
                                        </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Link" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                            <ItemTemplate>
                                                <asp:Literal ID="Url" runat="server" />
                                                <asp:HiddenField ID="hUrl" runat="server" />
                                            </ItemTemplate>
                                            <ItemStyle CssClass="diachi respo-view" />
                                            <HeaderStyle CssClass="diachi respo-title" />
                                        </asp:TemplateColumn>

                                    </Columns>
                                </asp:DataGrid>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <asp:Literal ID="litPage" runat="server" />
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdNew" runat="server" CssClass="cmdbtt cmdNew" Text="Thêm mới" />
                <asp:Button ID="cmdDel" runat="server" CssClass="cmdbtt cmdDel" Text="Xóa liên kết" />
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="lbtFind" />
        <asp:AsyncPostBackTrigger ControlID="cmdDel" />
    </Triggers>
</asp:UpdatePanel>
<asp:HiddenField ID="CurrentPage" Visible="false" runat="server" />
