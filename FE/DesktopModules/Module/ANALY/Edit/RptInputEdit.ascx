<%@ Control Language="vb" CodeFile="RptInputEdit.ascx.vb" Inherits="Modules.TempInput.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel runat="server" ID="pageView">
    <ContentTemplate>
        <div class="box box-info ">
            <div class="box-header with-border">
                <div class="col-md-9">
                    <h3 class="box-title">Thông tin mẫu nhập liệu đầu vào</h3>
                </div>
                <div class="col-md-3 txt-right">
                    <asp:Button ID="cmdPreview" runat="server" Text="Xem trước mẫu đã tạo" Visible="false" CssClass="cmsbut cmsbut_color cmdview" OnClientClick="$('#Form').validationEngine('detach');" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-12"><b class="col-b">I. THÔNG TIN BÁO CÁO</b></div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <asp:TextBox ID="Temp_Name" placeHolder="Nhập tên báo cáo" runat="server" CssClass="TextBox txt-center scroll validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-1 lb">Năm BC</div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="Years_ID" runat="server" AutoPostBack="true" CssClass="selectpicker validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="col-md-2 lb txt-center">Nhóm chỉ tiêu</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="drGroup" runat="server" AutoPostBack="true" CssClass="selectpicker validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="col-md-1 lb txt-center pdr0">Tỉnh/TP</div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="TinhTp" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="row">
                        <div class="col-md-12"><b class="col-b">II. CỘT BÁO CÁO</b></div>
                        <div class="clear"></div>
                    </div>
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
                                    <asp:TemplateColumn HeaderText="Chỉ tiêu dữ liệu đầu vào">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="Targets_ID" runat="server" CssClass="selectpicker " />
                                            <div class="toggle-row" onclick="toggleclick(this);" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <ItemStyle Width="30%" CssClass="column-primary" />
                                        <HeaderStyle Width="30%" CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Tên cột dữ liệu">
                                        <ItemTemplate>
                                            <asp:TextBox ID="Column_Name" placeHolder="Tiêu đề cột" runat="server" CssClass="TextBox ColumnName" />
                                        </ItemTemplate>
                                        <ItemStyle CssClass="cotExcel respo-view" />
                                        <HeaderStyle CssClass="cotExcel respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Cột excel">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="ExColum" placeHolder="Excel column" runat="server" CssClass="selectpicker " />
                                        </ItemTemplate>
                                        <ItemStyle Width="15%" CssClass="cotExcel respo-view" />
                                        <HeaderStyle Width="15%" CssClass="cotExcel respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Loại dữ liệu">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="ColType" placeHolder="ColType" runat="server" CssClass="selectpicker " />
                                        </ItemTemplate>
                                        <ItemStyle Width="15%" CssClass="ColType respo-view" />
                                        <HeaderStyle Width="15%" CssClass="ColType respo-title" />
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
                        <asp:Button ID="cmdOrder" runat="server" Text="Đánh lại thứ tự cột Excel" CssClass="cmsbut cmsbtsoso" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" Text="Xóa" runat="server" class="cmsbut cmsbtdel" />
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemID" runat="server" />
            <asp:HiddenField ID="hMlChitieu" runat="server" />

        </div>
        <script type="text/javascript">     
            function delColC(pid, id, t) {
                if (confirm("Bạn có muốn xóa dòng này đi không?")) {
                    $.ajax({
                        type: "GET", url: '/api/analy/data.asmx/delColC?pid=' + pid + "&id=" + id, success: function (data) {
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
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="drGroup" />
        <asp:AsyncPostBackTrigger ControlID="cmdAddRow" />
    </Triggers>
</asp:UpdatePanel>
