<%@ Control Language="vb" CodeFile="CaiDatMaNhung.ascx.vb" Inherits="Modules.CaiDatMaNhung.Edit" AutoEventWireup="false" Explicit="True" %>
<style>
    .waiting {
        z-index: 99999;
    }
    iframe{width:100%;height:600px;}
    .modal-body{padding:0;}
</style>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin cài đặt mã nhúng</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">ChatBot</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropBot" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Mã nhúng website</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" ReadOnly="true" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Mã nhúng app</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="LinkApp" runat="server" CssClass="TextBox"/>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2"></div>
                    <div class="col-md-10">
                        <button type="button" class="btn btn-secondary btn-demochat">Xem thử nghiệm</button>
                        <button type="button" class="btn btn-info btn-copyma">Sao chép mã nhúng</button>
                        <asp:Button ID="cmdMaNhung" runat="server" Text="Tạo mã nhúng" CssClass="btn btn-primary" OnClientClick="return retunwaiting();" />
                    </div>
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <%-- <asp:Button ID="cmdCopy" runat="server" Text="Xem demo" CssClass="cmsbut cmsbtcheck" />--%>
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

<!-- Modal -->
<div class="modal fade" id="popMessage" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-body">
                 <iframe id="iframeModalWindow" name="iframe_modal"></iframe>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
                <button type="button" class="btn btn-primary" onclick="return readloadPop();">Chạy lại</button>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        var phantomSelect = function () {
            $('textarea').select();
        };
        $(document).on('keydown', function (ev) {
            if ((ev.ctrlKey || ev.metaKey) && ev.keyCode == 67) {
                phantomSelect();
            }
        });

        $(document).on('copy', function (ev) {
            if (window.clipboardData) {
                window.clipboardData.setData('Text', $('textarea').val());
            } else if (ev.originalEvent.clipboardData) {
                ev.originalEvent.clipboardData.setData('text/plain', $('textarea').val());
            } else {
                alert('Clipboard Data are not supported in this browser. Sorry.');
            }
            ev.preventDefault();
        });

        $('.btn-copyma').on('click', function (ev) {
            try {
                phantomSelect();
                if (!document.execCommand('copy')) {
                    throw "Not supported";
                } else { /* alert('3') */ }
            } catch (ex) {
                //alert('This is not supported in current browser');
            }
        });

        $('.btn-demochat').on('click', function (ev) {
            try {
                $('#popMessage').modal({
                    show: 'false'
                });
                $('#iframeModalWindow').attr('src', '/chatbot-demo?id=' + $('#<%= dropBot.ClientID%>').val());
            } catch (ex) {
            }
        });
    });
    function readloadPop() {
        $('#iframeModalWindow').attr('src', '/chatbot-demo?id=' + $('#<%= dropBot.ClientID%>').val());
    }
</script>