<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Mar_DSUngVien.ascx.vb" Inherits="Modules.SVL.Mar_DSUngVien.View" %>
<%@ Register Src="~/DesktopModules/Module/Work/POPUP/Mar_DSMoiUV.ascx" TagPrefix="uc1" TagName="Mar_DSMoiUV" %>

<link href="/js/mark/css/jquery.ui.dialog.css" rel="stylesheet" />
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="row">
            <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" CssClass="ungvienthamgia">
                <ItemStyle BackColor="#f8f4f1" />
                <AlternatingItemStyle BackColor="#ffffff" />
                <Columns>
                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="IsOrder" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="4%" HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Tên ứng viên" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="tenDayDu" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="20%" HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                  <%--  <asp:TemplateColumn HeaderText="Trình độ" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="TrinhDo" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="11%" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Ngành nghề" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="NganhNghe" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="15%" />
                    </asp:TemplateColumn>--%>
                    <asp:TemplateColumn HeaderText="Điện thoại/Email" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="Tel" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="11%" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:Literal ID="DiaChi" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="20%" />
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Thao tác" HeaderStyle-CssClass="hdTitle">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" ID="linkInfo" data-value='<%#Eval("tenDayDu") %>' OnClientClick="return showDialog(this);" CssClass="iconBox"
                                ToolTip="Xem kết quả" Style="margin: 0;" OnCommand="onCommandEvent" CommandArgument='<%#Eval("UngVien_Id") %>'>
                                    <img src="/image/images/view.png" alt="" />
                            </asp:LinkButton>&nbsp;|&nbsp;
                            <asp:Literal ID="IsDelete" runat="server"></asp:Literal>&nbsp;|&nbsp;  <asp:Literal ID="ThayThe" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle Width="8%" HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
        </div>
        <div class="row">
            <asp:Literal ID="litPage" runat="server" />
        </div>
        <asp:Button ID="cmdDSUngVien_Next" runat="server" CssClass="none" />
        <asp:HiddenField ID="DSUngVien_currPage" Value="1" runat="server" />
        <asp:HiddenField ID="DSUngVien_Total" Value="0" runat="server" />
        <asp:HiddenField ID="DSUngVien_ItemID" Value="" runat="server" />
        <script type="text/javascript">
            function nextpageuv(pa) {
                $("#<%=DSUngVien_currPage.ClientID %>").val(pa);
                $("#<%=cmdDSUngVien_Next.ClientID %>").click();
            };
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
<div id="DialogInfo" class="" style="display: none">
    <div style="min-height: 200px; max-height: 400px; overflow-y: auto">
        <asp:UpdatePanel runat="server" ID="panelDialog">
            <ContentTemplate>
                <asp:Label runat="server" ID="lblInfo"></asp:Label>
                <asp:GridView runat="server" ID="GridView1" Border="0" AutoGenerateColumns="false"
                    AllowPaging="false" DataKeyNames="UngVien_ID" Width="100%" CssClass="table-bordered">
                    <Columns>
                        <asp:TemplateField HeaderText="STT" HeaderStyle-Width="5%" HeaderStyle-CssClass="v-center" ItemStyle-CssClass="v-center">
                            <ItemTemplate>
                                <%#Container.DataItemIndex + 1%>
                            </ItemTemplate>
                            <ItemStyle Height="35px" CssClass="v-center" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tên doanh nghiệp" HeaderStyle-Width="70%">
                            <ItemTemplate>
                                <%#Eval("Business_Vn")%>
                                <br />
                                <span style="font-weight: bold; color: #900303">Việc làm: <%#Eval("tuyenDungName")%></span>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Kết quả phỏng vấn" HeaderStyle-Width="25%">
                            <ItemTemplate>
                                <%#FormatKetQuaPhongVan(Eval("KetQuaPhongVan"))%>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:Literal ID="DSUngVienKQ" runat="server"></asp:Literal>
                <asp:LinkButton runat="server" ID="ResetLink"></asp:LinkButton>

            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</div>
<uc1:Mar_DSMoiUV runat="server" id="Mar_DSMoiUV" />
<script type="text/javascript">
    $('#DialogInfo').dialog({ modal: true, autoOpen: false, width: 980, close: function (event, ui) { eval($('#<%=ResetLink.ClientID %>').attr('href')); }, open: function (event, ui) { $(this).parent().appendTo("form"); } });
    function showDialog(args) { var name = $(args).attr('data-value'); $('#DialogInfo').dialog("option", "title", "Kết quả ứng viên: " + name).dialog('open'); };
    function resetDialog() { };
    function xoaungvien(pid, id, t) {
        if (confirm("Bạn có chắc muốn xóa ứng viên này khỏi danh sách không?")) {
            $.ajax({ type: "GET", url: '/api/work/works.asmx/xoaungvien?pid=' + pid + "&id=" + id, success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data == "1") { $(t).parents("tr").remove(); notify('success', 'Đã xóa ứng viên khỏi danh sách thành công.', 'Thông báo', false);location.reload() }; }, });
        }
    };

</script>
<style>
    .v-center {
        line-height: 30px !important;
        text-align: center;
    }
</style>
