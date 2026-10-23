<%@ Control Language="vb" CodeFile="KichBanAdvanceView.ascx.vb" Inherits="Modules.KichBanAdvanceView.View" AutoEventWireup="false" Explicit="True" %>
<link href="/Portals/_default/chatbot.css?cdv=11" type="text/css" rel="stylesheet" />
<style>
    .card-body-content {
        display: none;
    }

    .item-with-toggle.expanded .card-body-content {
        display: block;
    }

    .item-with-toggle.expanded .toggle-btn {
        transform: rotate(180deg);
    }

    .toggle-btn {
        background: none;
        border: none;
        cursor: pointer;
        font-size: 1.5em;
        transition: transform 0.3s ease;
    }
</style>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-7 pdl0">
                    <h3 class="box-title">Danh sách kịch bản nâng cao</h3>
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
                        <asp:DropDownList ID="dropKichBan" AutoPostBack="true" runat="server" CssClass="selectpicker" />
                    </div>
                </div>
                <div class="main-body">
                    <div class="col-md-6">
                        <h3 class="box-title">Tin nhắn kịch bản</h3>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-12 text-center">
                        <ul id="list1" class="list-group">
                            <asp:Repeater ID="repData1" runat="server">
                                <ItemTemplate>
                                    <li data-itemid='<%# Eval("Id") %>' class="list-group-item item-with-toggle" style="border: 0px; padding: 0 0 5px;">
                                        <div class="t_ndtentinnhansub">
                                            <div class="itemKb blockCard">
                                                <div class="cdk-drag-handle headerHandle p-16">
                                                    <div class="cdk-drag-item">
                                                        <div class="iconCardType">
                                                            <%#Eval("IsOrder") %>.&nbsp;&nbsp;<img fxflex="35px" alt="Icon" src="/portals/_default/skins/chatbot/images/message_<%#Eval("PhanLoai") %>.png" class="ng-star-inserted">
                                                        </div>
                                                        <div style="margin: 0 0 0 20px;"><b class="f-13"><%#Eval("TenPhanLoai") %></b></div>
                                                        <button type="button" class="toggle-btn" style="float: right;">▼</button>
                                                    </div>
                                                </div>
                                                <div class="bodyCard card-body-content">
                                                    <%#Eval("NoiDung") %>
                                                    <br />
                                                    <%#Eval("NoiDungButton") %> <%#Eval("NoiDungSlide") %>
                                                </div>
                                            </div>
                                        </div>
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
                <asp:Button ID="cmdBack" runat="server" Text="Chế độ cơ bản" CssClass="cmsbut cmsback cbclick" />
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

<script type="text/javascript" src="/js/drag/jquery.dragsort.js"></script>
<script>
    function initToggleFunctionality() {
        $('.toggle-btn').off('click').on('click', function (e) {
            e.stopPropagation();
            var listItem = $(this).closest('.item-with-toggle');
            listItem.toggleClass('expanded');
        });
    }
    $(function () {
        loaddargsort();
        initToggleFunctionality();
    });

    var prm = Sys.WebForms.PageRequestManager.getInstance();
    prm.add_endRequest(function () {
        loaddargsort();
        initToggleFunctionality();
    });
</script>
<script>
    var vrtimeout = 2000;
    function saveOrder() {
        var data = $("#list1 li").map(function () {
            return $(this).data("itemid");
        }).get();
    }

    function saveOrderKichBan() {
        retunwaiting();
        var data = $("#list1 li").map(function () {
            return $(this).data("itemid");
        }).get();
        var _kichBan = $('#<%= dropKichBan.ClientID %>').val();
        var _idStr = '';
        if (data.length > 0) {
            _idStr = data.join("|");
        }

        $.ajax({
            type: 'POST',
            url: '/API/chatbot/common.asmx/tinnhan_updateorderby',
            data: { idStr: _idStr, idKichBan: _kichBan },
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
        $("#list1").dragsort({
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
</script>
