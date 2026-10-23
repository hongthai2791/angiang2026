<%@ Control Language="vb" CodeFile="CateTarEdit.ascx.vb" Inherits="Modules.TempInput.Edit" AutoEventWireup="false" Explicit="True" %>
        <div class="box box-info ">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thiết lập danh mục cho chỉ tiêu</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">

                    <div class="row">
                        <div class="col-md-12">
                            <asp:DataGrid ID="grdData" runat="server" CssClass="table-bordered td0 respo-table" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                                <HeaderStyle CssClass="head hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#fbf2ec" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="STT">
                                        <ItemTemplate>
                                            <asp:TextBox ID="IsOrder" ReadOnly="true" runat="server" CssClass="TextBox txt-center " />
                                        </ItemTemplate>
                                        <HeaderStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                                        <ItemStyle Width="4%" HorizontalAlign="Center" CssClass="fix-column STT" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Mã danh mục">
                                        <ItemTemplate>
                                            <asp:TextBox ID="CodeCateTar" placeHolder="Mã danh mục" runat="server" CssClass="TextBox ColumnName " />
                                            <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <ItemStyle CssClass="column-primary" />
                                        <HeaderStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tên danh mục">
                                        <ItemTemplate>
                                            <asp:TextBox ID="CateName" placeHolder="Tên danh mục" runat="server" CssClass="TextBox ColumnName" />
                                        </ItemTemplate>
                                        <ItemStyle Width="65%" CssClass="CateName respo-view" />
                                        <HeaderStyle Width="65%" CssClass="CateName respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Xóa">
                                        <ItemTemplate>
                                            <asp:Literal ID="IsDelete" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="50px" HorizontalAlign="Center" CssClass="IsDelete respo-title" />
                                        <ItemStyle Width="50px" HorizontalAlign="Center" CssClass="IsDelete respo-view" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                            <table cellspacing="0" id="tblRow" runat="server" cellpadding="3" border="0" style="width: 100%; border-collapse: collapse; border-top: 0px!important">
                                <tbody>
                                    <tr style="border-top: 0px!important; background: #fff;">
                                        <td style="border-top: 0px!important; text-align: center; font-weight: bold;"></td>
                                        <td style="border-top: 0px!important; text-align: center; width: 50px">
                                            <asp:Button ID="cmdAddRow" runat="server" ToolTip="Thêm dòng" CssClass="cmsbut-td cmsbtnew" OnClientClick="return $('#Form').validationEngine('validate');" />
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <a id="cmdImport" runat="server" style="height: auto" onclick="upfile(0);" title="Import excel" class="cmsbut cmdexel">Nhập từ excel</a>
                        <asp:Button runat="server" ID="cmdUpfile" CssClass="none" />
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemID" runat="server" />
            <asp:HiddenField ID="GroupID" runat="server" />
            <asp:HiddenField ID="HidValue" runat="server" />
            <asp:HiddenField ID="InportEx" runat="server" />
            <asp:HiddenField runat="server" ID="pathTemp" Visible="false" />
            <asp:FileUpload ID="fileImages" onchange="upLoad()" accept=".xlsx" CssClass="none" AllowMultiple="false" runat="server" />
        </div>
        <script type="text/javascript">     
            function upfile(t) {
                if (t == 0) {
                    if (confirm("Dữ liệu đã nhập được lưu trong CSDL sẽ được thay thế toàn bộ bằng dữ liệu trong tệp excel. \nBạn có chắc muốn tiếp tục thực hiện hay không?")) {
                        waiting(); $("#<%=InportEx.ClientID %>").val(t); jQuery("#<%= fileImages.ClientID%>").click();
                    }
                }
                else {
                    waiting(); $("#<%=InportEx.ClientID %>").val(t); jQuery("#<%= fileImages.ClientID%>").click();
                }
            };
            function upLoad() { waiting(); jQuery('#<%= cmdUpfile.ClientID%>').click(); };

            function delColC(pid, id, t) {
                if (confirm("Bạn có muốn xóa dòng này đi không?")) {
                    $.ajax({
                        type: "GET", url: '/api/analy/data.asmx/delCateTar?pid=' + pid + "&id=" + id, success: function (data) {
                            var json = $.parseJSON($(data).find("string").text());
                            if (json.data == "1") {
                                $(t).parents("tr").remove();
                                notify('success', 'Đã xóa dòng lựa chọn thành công.', 'Thông báo', false);
                            };
                        },
                    });
                }
            };
            function layten(t) {
                var _text = $(t).children("option").filter(":selected").text();
                _text = _text.replace('- - - Chọn - - -', '');
                for (i = 0; i < _text.length; i++) {
                    _text = _text.replace('|-- ', '');
                }
                $(t).parents("td").parents("tr").find(".ColumnName").val(_text);
            };
        </script>
