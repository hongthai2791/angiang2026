<%@ Control Language="vb" CodeFile="DieuTraDN.ascx.vb" Inherits="Modules.DieuTraDN.View" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-6">
            <h3 class="box-title">Phiếu điều tra doanh nghiệp (<asp:Literal ID="litCount" runat="server" />)</h3>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm doanh nghiệp ..." CssClass="timKiemD" Columns="20" Width="100%" />
            <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
        </div>
        <div class="col-md-1 txt-center lb">Kỳ BC</div>
        <div class="col-md-2">
            <asp:DropDownList ID="drYear" CssClass="selectpicker" AutoPostBack="true" runat="server" />
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body qlte">
        <div class="main-body">
            <div class="row">
                <div class="col-md-1 txt-center lb">Tỉnh/TP</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="TinhTP" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-4">
                    <asp:DropDownList ID="QuanHuyen" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
                <div class="col-md-1 txt-center lb">Tình trạng</div>
                <div class="col-md-3">
                    <asp:DropDownList ID="TrangThai" CssClass="selectpicker" AutoPostBack="true" runat="server" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                        <ItemStyle BackColor="#f8f4f1" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle">
                                <HeaderTemplate>
                                    <asp:CheckBox ID="chkItemsTop" runat="server" CssClass="bCur bDel" onclick="clickSelect('bDel','cDel');" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="IsSelect" runat="server" CssClass="cs-select cDel" ToolTip="Chọn để tải?" />
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle Width="5%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="IsOrder" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle Width="5%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Xã/ phường" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="TenXP" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="35%" HorizontalAlign="Left" />
                                <ItemStyle Width="35%" HorizontalAlign="Left" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Tên phiếu" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Paths" Visible="false" runat="server" />
                                    <asp:Literal ID="PhieuDT" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Ngày tạo phiếu" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="CreatedDate" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="15%" HorizontalAlign="Center" />
                                <ItemStyle Width="15%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderStyle-CssClass="hdTitle" HeaderText="Tải phiếu">
                                <ItemTemplate>
                                    <asp:Literal ID="Download" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
                <div class="row">
                    <asp:Literal ID="litPage" runat="server" />
                </div>
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdExport" runat="server" Text="Xuất phiếu" CssClass="cmsbut cmdword" OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdDownload" runat="server" Text="Tải xuống" CssClass="cmsbut cmsbtDownload" />
    </div>
</div>
<asp:HiddenField ID="hidFileName" runat="server" />
<asp:HiddenField ID="hidPaths" runat="server" />
<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
<asp:Button ID="cmdTaiNhanh" runat="server" Text="Tải nhanh" CssClass="none cmdTaiNhanh" />

<script>
    function taiTep(id, name) {
        $("#<%=hidPaths.ClientID%>").val(id);
        $("#<%=hidFileName.ClientID%>").val(name);
        $(".cmdTaiNhanh").click();
    };
</script>
