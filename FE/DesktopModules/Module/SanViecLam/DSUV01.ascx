<%@ Control Language="VB" AutoEventWireup="false" CodeFile="DSUV01.ascx.vb" Inherits="DesktopModules.Modules.DSUV01" %>

<div class="row">
    <div class="col-md-12">
        <div class="a2-head">
            <asp:GridView runat="server" ID="dgrDanhSachUngVien" Border="0" CssClass="svl_table" AutoGenerateColumns="false" AllowPaging="false" DataKeyNames="UngVien_ID" Width="100%">
                <Columns>
                    <asp:TemplateField HeaderText="STT">
                        <ItemTemplate>
                            <%#Container.DataItemIndex + 1%>
                        </ItemTemplate>
                        <ItemStyle Width="5%" HorizontalAlign="Center" />
                        <HeaderStyle Width="5%" HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tên ứng viên">
                        <ItemTemplate>
                            <b><%# DataBinder.Eval(Container.DataItem, "tenDayDu")%></b>
                        </ItemTemplate>
                        <ItemStyle Width="25%" HorizontalAlign="Left" />
                        <HeaderStyle Width="25%" HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Giới tính">
                        <ItemTemplate>
                            <%# WORK.flCheck.GioiTinh(DataBinder.Eval(Container.DataItem, "GioiTinh"))%>
                        </ItemTemplate>
                        <ItemStyle Width="15%" HorizontalAlign="Left" />
                        <HeaderStyle Width="15%" HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Địa chỉ">
                        <ItemTemplate>
                            <%#DataBinder.Eval(Container.DataItem, "DiaChi")%>
                        </ItemTemplate>
                        <ItemStyle Width="35%" HorizontalAlign="Left" />
                        <HeaderStyle Width="35%" HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Kết quả">
                        <ItemTemplate>
                            <a title="Kết quả phỏng vấn" onclick="showview(<%=Me.PortalId  %>,'<%#Eval("UngVien_Id") %>');" href="javascript:;">
                                <img src="/image/svl/zoom_in.png" alt="xem kết quả" /></a>
                        </ItemTemplate>
                        <ItemStyle Width="8%" HorizontalAlign="Center" />
                        <HeaderStyle Width="8%" HorizontalAlign="Center" />
                    </asp:TemplateField>
                </Columns>
                <HeaderStyle CssClass="svl_header" />
                <RowStyle CssClass="svl_row" />
                <FooterStyle CssClass="svl_row" />
                <AlternatingRowStyle CssClass="svl_altrow" />
            </asp:GridView>
        </div>
    </div>
    <div class="col-md-12">
        <asp:Literal ID="litPage" runat="server" />
    </div>
    <div class="none">
        <asp:HiddenField ID="ItemID" runat="server" />
        <asp:HiddenField ID="curentPage" Value="1" runat="server" />
        <asp:Button ID="cmdNext" runat="server" CssClass="none" />
        <script type="text/javascript">
            function nextpage_uv(p) { $("#<%=curentPage.ClientID  %>").val(p); $("#<%=cmdNext.ClientID  %>").click(); };
            function showview(pid, id) {
                var phid = $("#<%=ItemID.ClientID %>").val();
                $.ajax({
                    type: 'GET', url: '/api/home/works.asmx/UngTuyen?pid=' + pid + '&phid=' + phid + '&id=' + id, success: function (data) {
                        var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                            $(".main-contents").html(json.data);
                            ; $("#myModal").modal('show');
                        };
                    },
                });
            };
        </script>
    </div>

    <div id="myModal" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content ">
                <div class="main-contents">
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Đóng</button>
                </div>
            </div>
        </div>
    </div>
</div>

