<%@ Control Language="vb" CodeFile="InputDataNew.ascx.vb" Inherits="Modules.ExDistrict.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info " style="background: #fff!important">
    <div class="box-header with-border fix-top">
        <div class="col-md-5">
            <asp:Literal ID="litTitle" runat="server"></asp:Literal>
        </div>
        <div class="col-md-7 txt-center">
            <a id="cmdImport" runat="server" style="height: auto" onclick="upfile(0);" class="cmsbut cmdexel" title="Xóa toàn bộ dữ liệu và nhập lại qua excel" >Nhập mới từ excel</a>
            <a id="cmdImport1" runat="server" style="height: auto" onclick="upfile(1);"  class="cmsbut cmsbtImport" title="Bổ sung thêm dữ liệu qua file excel" >Nhập thêm từ excel</a>
            <asp:Button ID="cmdExcel" runat="server" Text="Xuất ra excel" CssClass="cmsbut cmsbtExport" OnClientClick="saveAlldata(1); popexp('exports'); return false;" />
            <asp:Button ID="cmdAdd" Visible="false" runat="server" Text="Thêm dòng" CssClass="cmsbut cmsbAdd" OnClientClick="savedata(1);" />
        </div>
    </div>
    <div class="box-body">
        <div class="main-body mgt30">
            <div class="row">
                <asp:Literal ID="litTraLai" runat="server"></asp:Literal>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Literal ID="litData" runat="server"></asp:Literal>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Literal ID="litPage" runat="server"></asp:Literal>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <asp:Literal ID="litUpdate" runat="server" />
                <div class="clear"></div>
            </div>
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <a class="cmsbut cmsbtupdate" onclick="waiting(); return saveAlldata(0);">Lưu lại</a>
                <asp:Button ID="cmdSend" runat="server" Text="Nộp báo cáo " OnClientClick="saveAlldata(0);" CssClass="cmsbut cmsbtsend none" />
                <asp:Button ID="cmdDelete" data-toggle="tooltip" ToolTip="Xóa toàn bộ dữ liệu đã nhập vào" runat="server" Text="Xóa dữ liệu" CssClass="cmsbut cmsbtdel" />
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="CurrPage" runat="server" />
    <asp:HiddenField ID="TinhTP" runat="server" />
    <asp:HiddenField ID="Group_ID" runat="server" />
    <asp:HiddenField ID="Years_ID" runat="server" />
    <asp:HiddenField ID="TempRpt_ID" runat="server" />
    <asp:HiddenField ID="Temp_Name" runat="server" />
    <asp:HiddenField ID="InportEx" runat="server" />
    <asp:HiddenField ID="ItemId" runat="server" />
    <asp:FileUpload ID="fileImages" onchange="upLoad()" accept=".xlsx" CssClass="none" AllowMultiple="false" runat="server" />
    <asp:Button runat="server" ID="cmdUpfile" CssClass="none" />
    <asp:HiddenField runat="server" ID="pathTemp" Visible="false" />
</div>
<script type="text/javascript">
    function upfile(t) {
        if (t == 0) {
            if (confirm("Dữ liệu đã nhập được lưu trong CSDL sẽ được thay thế toàn bộ bằng dữ liệu trong tệp excel. \nBạn có chắc muốn tiếp tục thực hiện hay không?")) {
               $("#<%=InportEx.ClientID %>").val(t); jQuery("#<%= fileImages.ClientID%>").click();
            }
        }
        else {
            $("#<%=InportEx.ClientID %>").val(t); jQuery("#<%= fileImages.ClientID%>").click();
        }
    };
    function upLoad() { jQuery('#<%= cmdUpfile.ClientID%>').click(); };
    function exports() {
        var itemid = $("#<%=ItemId.ClientID %>").val();
        var tempid = $("#<%=TempRpt_ID.ClientID %>").val();
        var dtype = $("#xlsx:checked").val(); if (dtype == "true") { dtype = ".xlsx" } else { dtype = ".xls" }
        window.open("/api/analy/reports.aspx?pid=0&tid=3&id=" + itemid + "&tempid=" + tempid + "&type=" + dtype);
        return false;
    };
    function savedata(silent) {
        var itemid = $("#<%=ItemId.ClientID %>").val();
        var tempRptid = $("#<%=TempRpt_ID.ClientID %>").val();
        $("tr.row-input").each(function (e) {
            var rowID = $(this).attr("rowid");
            var noiDung = $(this).find("td").find("input.noiDung").val();
            if ((noiDung != "") && (noiDung != undefined)) {
                noiDung = noiDung;
                var inputrptc = $(this).find("td").find("input").attr("inputrptc");
                var iTT = $(this).attr("order");
                $.ajax({
                    type: 'GET', url: '/api/analy/data.asmx/InDataRow?pid=0&rowID=' + rowID
                        + '&itemid=' + itemid
                        + '&inputrptc=' + inputrptc
                        + '&noiDung=' + noiDung
                        + '&iTT=' + iTT,
                    success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { } }
                });

                $(this).find("td").find("input.gData").each(function (e) {
                    var gText = ""; var gSo = "";
                    if ($(this).hasClass("gtText")) {
                        gText = $(this).val(); if ((gText != "") && (gText != undefined)) { gText = Base64.encode(gText); }
                    }
                    else {
                        gSo = $(this).val(); if ((gSo != "") && (gSo != undefined)) { gSo = Base64.encode(gSo); }
                    }
                    var inputrptc = $(this).attr("inputrptc");
                    var coltype = $(this).attr("coltype");
                    var targets = $(this).attr("targets");
                    var inT = $(this).attr("stt");
                    $.ajax({
                        type: 'GET', url: '/api/analy/data.asmx/InDataRowC?pid=0&rowID=' + rowID
                            + '&itemid=' + itemid
                            + '&inputrptc=' + inputrptc
                            + '&targets=' + targets
                            + '&colType=' + coltype
                            + '&gText=' + gText
                            + '&gSo=' + gSo
                            + '&inT=' + inT,
                        success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { } }
                    });
                });
            }
            else {
                $.ajax({
                    type: 'GET', url: '/api/analy/data.asmx/delInDataRow?pid=0&rowID=' + rowID,
                    success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { } }
                });
            }
        });
        if (silent == 0) {
            notify('success', 'Đã cập nhật lại thông tin thành công.', 'Thông báo', false);
            removewaiting();
        }
        return false;
    };
    function saveAlldata(silent) {
        var itemid = $("#<%=ItemId.ClientID %>").val();
        var tempRptid = $("#<%=TempRpt_ID.ClientID %>").val();
        var rowID = "";
        var noiDung = "";
        var inputrptc = "";
        var iTT = "";
        var gText = ""; var gSo = ""; var inT = "";
        var inputRptCG = ""; var colType = ""; var targets = "";
        $("tr.row-input").each(function (e) {
            rowID += $(this).attr("rowid") + "#";
            noiDung += $(this).find("td").find("input.noiDung").val() + "#";
            inputrptc += $(this).find("td").find("input").attr("inputrptc") + "#";
            iTT += $(this).attr("order") + "#";
            $(this).find("td").find("input.gData").each(function (e) {
                if ($(this).hasClass("gtText")) {
                    gText += $(this).val() + "#";
                    gSo += "#"
                }
                else {
                    gSo += $(this).val() + "#";
                    gText += "#"
                }
                inputRptCG += $(this).attr("inputrptc") + "#";
                colType += $(this).attr("coltype") + "#";
                targets += $(this).attr("targets") + "#";
                inT += $(this).attr("stt") + "#";
            });
        });
        var dto = {
            pid: 0,
            rowID: rowID,
            itemid: itemid,
            noidung: noiDung,
            inputRptC: inputrptc,
            itt: iTT,
            inputRptCG: inputRptCG,
            targets: targets,
            colType: colType,
            gText: gText,
            gSo: gSo,
            inT: inT,
            colCount: <%=ColCount%>,
        }
        $.ajax({
            type: 'POST', url: '/api/analy/data.asmx/SaveData',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(dto),
            success: function (response) {
                if (silent == 0) {
                    notify('success', 'Đã cập nhật dữ liệu thành công.', 'Thông báo', false);
                    removewaiting();
                }
            },
            failure: function (response) {
                notify('info', 'Dữ liệu chưa được lưu lại.', 'Thông báo', false);
                removewaiting();
            }

        });

    };
</script>

