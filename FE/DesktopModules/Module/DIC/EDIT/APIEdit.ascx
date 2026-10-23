<%@ Control Language="vb" CodeFile="APIEdit.ascx.vb" Inherits="Modules.APIEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin Api</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên Api</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TenAPI" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Kiểu Api</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="dropKieu" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="POST">POST</asp:ListItem>
                            <asp:ListItem Value="GET">GET</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Link Api</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="LinkAPI" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Authorization</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="Author" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Body</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Body" runat="server" CssClass="TextBox" Height="400px" TextMode="MultiLine" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Thứ tự</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                    </div>
                    <div class="col-md-2 txt-center lb">Ghi dữ liệu </div>
                    <div class="col-md-2">
                        <asp:CheckBox ID="IsGhiDuLieu" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="col-md-2 txt-center lb">Sử dụng </div>
                    <div class="col-md-2">
                        <asp:CheckBox ID="IsActive" CssClass="CheckBox" runat="server" />
                    </div>

                    <div class="clr"></div>
                    <div class="col-md-10 lstMessage">
                        <h3 class="box-title">Thông tin cấu hình</h3>
                    </div>
                    <div class="col-md-2 text-center">
                    </div>
                    <div class="col-md-12 lstMessage">
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th scope="col" class="text-center">#</th>
                                    <th scope="col">Key</th>
                                    <th scope="col">Value</th>
                                    <th scope="col"></th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="repMessage" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <th scope="row" class="text-center"><%#Eval("IsOrder") %></th>
                                            <td><%#Eval("APIKey") %></td>
                                            <td><%#Eval("APIValue") %></td>
                                            <td class="text-center">
                                                <asp:LinkButton OnClientClick="javascript:return confirm('Bạn có muốn xóa tham số này không?');" ClientIDMode="AutoID" ID="lnkChinhSua" runat="server" ToolTip="Xóa tham số"
                                                    OnCommand="_ProcessCommand" CommandName="XoaMessage" CommandArgument='<%# Eval("Id")%>'>
                                                        <img src="/portals/_default/skins/vbn/images/close.png?w=20" alt="edit" title="Xóa tham số">
                                                </asp:LinkButton>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                    <div class="clr clUp"></div>
                    <div class="col-md-12">
                        <asp:Literal ID="litUpdate" runat="server" />
                    </div>
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <button type="button" class="cmsbut cmsbtnew cbclick btnAddMessageSub" data-toggle="modal" data-target="#popMessage">Cấu hình</button>
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
            <asp:HiddenField ID="OrderAPIHeader" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>


<!-- Modal -->
<div class="modal fade" id="popMessage" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel" style="display: contents">Thông tin cấu hình</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <i class="fa fa-times" aria-hidden="true"></i>
                </button>
            </div>
            <div class="modal-body">
                <form>
                    <div class="form-group m_tentinnhan">
                        <label for="recipient-name" class="col-form-label lbl_title">Key:</label>
                        <asp:TextBox ID="txtKey" runat="server" CssClass="form-control i_tieude" />
                    </div>
                    <div class="form-group m_kichbanlienket i_duongdan">
                        <label for="recipient-name" class="col-form-label ">Value:</label>
                        <asp:TextBox ID="txtValue" runat="server" CssClass="form-control i_urlsub" />
                    </div>
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
                <button type="button" class="btn btn-primary" onclick="return validateMessage();">Lưu lại</button>
                <asp:Button ID="btnSaveMessage" runat="server" Text="Lưu lại" CssClass="btn btn-savemessage btn-primary none" OnClientClick="return retunwaiting();" />
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    function openMessage(isActive) {
        $('.btnAddMessageSub').addClass("none");
        $('.lstMessage').addClass("none");
        if (isActive > 0) {
            $('.btnAddMessageSub').removeClass("none");
            $('.lstMessage').removeClass("none");
        }
    }

    function validateMessage() {
        var _noidung = $('.i_tieude').val();
        var _urlsub = $('.i_urlsub').val();
        if (_noidung == "") {
            notify('warning', 'Vui lòng nhập key tham số ?', 'Thông báo', false);
            return;
        }
        if (_urlsub == "") {
            notify('warning', 'Vui lòng nhập giá trị tham số ?', 'Thông báo', false);
            return;
        }
        else
            $('.btn-savemessage').click();
    }

</script>
