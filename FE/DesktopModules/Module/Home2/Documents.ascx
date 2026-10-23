<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Documents.ascx.vb" Inherits="DesktopModules.Home.Documents" %>
<asp:UpdatePanel runat="server" ID="pop">
    <ContentTemplate>
        <div class="col-md-12">
            <div class="vban-phapquy">
                <div class="row pdbt10">
                    <div class="col-md-3">
                        <asp:DropDownList CssClass="selectpicker" AutoPostBack="true" runat="server" ID="LinhVuc"></asp:DropDownList>
                    </div>
                    <div class="col-md-3">
                        <asp:DropDownList CssClass="selectpicker" AutoPostBack="true" runat="server" ID="LoaiVanBan"></asp:DropDownList>
                    </div>
                    <div class="col-md-3">
                        <asp:DropDownList CssClass="selectpicker" AutoPostBack="true" runat="server" ID="CoQuanBH"></asp:DropDownList>
                    </div>
                    <div class="col-md-3">
                        <asp:TextBox CssClass="TextBox timKiemD" placeHolder="Năm ban hành, Số ký hiệu" runat="server" ID="timKiem"></asp:TextBox>
                        <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="row pdbt10">
                    <div class="col-md-12 row-vb">
                        Tổng số văn bản pháp luật:<span class="lbtotal">
                            <asp:Literal ID="lbTotal" runat="server"></asp:Literal>
                        </span>
                    </div>
                </div>
                <div class="noidung-vb">
                    <table style="width: 100%;">
                        <thead>
                            <tr class="tieudeu-vb">
                                <td style="width: 15%; font-weight: 600; text-align: center;">Số hiệu</td>
                                <td class="hidden-xs" style="width: 15%; font-weight: 600; text-align: center;">Ngày ban hành</td>
                                <td style="width: 60%; font-weight: 600; text-align: center;"><span>Trích yếu</span></td>
                                <td style="width: 10%; font-weight: 600; text-align: center;">Tệp gốc</td>
                            </tr>
                        </thead>
                        <tbody class="table-body">
                            <asp:Literal ID="litRow" runat="server"></asp:Literal>
                        </tbody>
                    </table>
                </div>
                <div class="row pdbt10 phan-trang">
                    <asp:Literal ID="litPage" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
        <script src="/js/base64.js" type="text/javascript"></script>
        <script type="text/javascript">
            function clickButton(e, t) { var n = e ? e : window.event; var r = document.getElementById(t); if (r) { if (n.keyCode == 13) { r.click(); return false } } }
            function updateDownload(id, pid) { var link = "/api/cms/upDoc.ashx?id=" + id + "&pid=" + pid; var msg = $.ajax({ url: link, async: false }).responseText; if (msg != "nothing") { window.open(msg); } };
            function fnext(p) {
                var la = $("#<%=LoaiVanBan.ClientID %>").val(); var lv = $("#<%=LinhVuc.ClientID %>").val();
                var cq = $("#<%=CoQuanBH.ClientID %>").val(); var tx = $(".timKiemD").val();
                if ((tx != undefined) || (tx != "")) { tx = Base64.encode(tx); }

                $.ajax({
                    type: 'GET',
                    url: '/api/home/documentList.asmx/docList?page=' + p + "&la=" + la + "&lv=" + lv + "&cq=" + cq + "&tx=" + tx,
                    success: function (data) {
                        var json = $.parseJSON($(data).find("string").text());
                        if (json.message != "0") {
                            $(".table-body").html(json.data);
                            $(".phan-trang").html(json.message);
                        };
                    },
                });
                setTimeout(removewaiting(), 100);
            };

        </script>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="LinhVuc" />
        <asp:AsyncPostBackTrigger ControlID="LoaiVanBan" />
        <asp:AsyncPostBackTrigger ControlID="CoQuanBH" />
        <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
    </Triggers>
</asp:UpdatePanel>
