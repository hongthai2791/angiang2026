<%@ Control Language="vb" CodeFile="KichBanSortView.ascx.vb" Inherits="Modules.KichBanSortView.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-7 pdl0">
                    <h3 class="box-title">Kéo thả thay đổi kịch bản</h3>
                </div>
                <div class="col-md-2 pdr0 none">
                    <asp:Button ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="row">
                    <div class="col-md-4 pdl0">
                        <asp:DropDownList ID="dropBot" AutoPostBack="true" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-6 pdl0">
                        <asp:DropDownList ID="dropNhomKichBan" AutoPostBack="true" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="col-md-6 pdl0">
                        <asp:DropDownList ID="dropNhomKichBan2" AutoPostBack="true" runat="server" CssClass="selectpicker" />
                    </div>
                </div>
                <div class="main-body">
                    <div class="col-md-6">
                        <h3 class="box-title">
                            <asp:Literal ID="Literal1" runat="server" /></h3>
                    </div>
                    <div class="col-md-6">
                        <h3 class="box-title">
                            <asp:Literal ID="Literal2" runat="server" /></h3>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-6">
                        <ul id="list1" class="list-group">
                            <asp:Repeater ID="repData1" runat="server">
                                <ItemTemplate>
                                    <li data-itemid='<%# Eval("Id") %>' class="list-group-item">
                                        <div class="t_ndtentinnhansub"><%#Eval("IsOrder") %>: <%#Eval("TenKichBan") %></div>
                                        <a onclick="findWork(<%# Eval("Id") %>)" class="card shadow" style="margin:-20px 0 0 0; float:right;"><i class="fa fa-eye" aria-hidden="true"></i></a>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <div class="col-md-6">
                        <ul id="list2" class="list-group">
                            <asp:Repeater ID="repData2" runat="server">
                                <ItemTemplate>
                                    <li data-itemid='<%# Eval("Id") %>' class="list-group-item">
                                        <div class="t_ndtentinnhansub"><%#Eval("IsOrder") %>: <%#Eval("TenKichBan") %></div>
                                        <a onclick="findWork(<%# Eval("Id") %>)" class="card shadow" style="margin:-20px 0 0 0; float:right;"><i class="fa fa-eye" aria-hidden="true"></i></a>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback cbclick" />
                <button type="button" class="cmsbut cmsbtupdate" onclick="return saveOrderKichBan();">Lưu lại</button>
                <asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew cbclick none" />
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="IdKichBan" runat="server" />
        <asp:HiddenField ID="TypeSetting" runat="server" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdNew" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
    </Triggers>
</asp:UpdatePanel>
<div class="modal fade" id="dynamicModal" tabindex="-1" role="dialog" aria-labelledby="dynamicModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="dynamicModalLabel">Trình tìm kiếm việc làm</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                <iframe id="modalIframe" src="" frameborder="0" style="width: 100%; height: 80vh;"></iframe>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript" src="/js/drag/jquery.dragsort.js"></script>

<script>
    var vrtimeout = 2000;
    function saveOrder() {
        var data = $("#list1 li").map(function () {
            return $(this).data("itemid");
        }).get();
        var data2 = $("#list2 li").map(function () {
            return $(this).data("itemid");
        }).get();
    }

    function saveOrderKichBan() {
        retunwaiting();
        var data = $("#list1 li").map(function () {
            return $(this).data("itemid");
        }).get();
        var data2 = $("#list2 li").map(function () {
            return $(this).data("itemid");
        }).get();
        var _nhomKichBan = $('#<%= dropNhomKichBan.ClientID %>').val();
        var _nhomKichBan2 = $('#<%= dropNhomKichBan2.ClientID %>').val();
        var _idStr = ''; var _idStr2 = ''
        if (data.length > 0) {
            _idStr = data.join("|");
        }
        if (data2.length > 0) {
            _idStr2 = data2.join("|");
        }

        $.ajax({
            type: 'POST',
            url: '/API/chatbot/common.asmx/kichban_updateorderby',
            data: { idStr: _idStr, idStr2: _idStr2, idNhomKichBan: _nhomKichBan, idNhomKichBan2: _nhomKichBan2 },
            success: function (res) {
                setTimeout(function () {
                    if (res.status == 2) {
                        $('.btTkiemD').click();
                        notify('success', 'Thay đổi thứ tự thành công!', 'Thông báo', false);
                    }
                    else { notify('warning', 'Vui lòng thử lại', 'Thông báo', false); };
                }, vrtimeout);
            }
        });
        removewaiting();
    }
    function loaddargsort() {
        $("#list1, #list2").dragsort({
            dragSelector: "div",
            dragBetween: true,
            dragEnd: saveOrder,
            placeHolderTemplate: "<li class='list-group-item'><div></div></li>",
            cursor: "move"
        });
    }
    $(function () {
        loaddargsort();
    });
    function findWork(id) {
        $("#dynamicModalLabel").html("Thông tin chi tiết nhóm kịch bản");
        var url = "/chatbot/edit/nhomkichban-list/itemid/" + id;
        $("#modalIframe").attr("src", url);
        $("#dynamicModal").modal('show');
        return false;
    }
    $('#dynamicModal').on('hidden.bs.modal', function (e) {
        $("#modalIframe").attr("src", "");
    })
</script>
