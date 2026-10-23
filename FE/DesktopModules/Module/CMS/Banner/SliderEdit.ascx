<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" ClientIDMode="Static" CodeFile="SliderEdit.ascx.vb" Inherits="DesktopModules.Modules.Slider.Edit" %>
<%@ Register TagPrefix="dnn" Assembly="DotNetNuke.Web" Namespace="DotNetNuke.Web.UI.WebControls" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<style>
    td.reEditorModesCell {
        display: inline-block !important;
    }
</style>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">Biên tập nội dung Slider </h3>
        </div>
    </div>
    <div class="box-body qlte">
        <div class="main-body ">
                <div class="row">
                    <div class="col-md-2 b pdt5">Tiêu đề</div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="TextBox validate[required]" ID="TieuDe" runat="server"></asp:TextBox>
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5 ">Tên đề phụ</div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="TextBox " ID="TieuDePhu" runat="server"></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5 ">Mô tả </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="TextBox " ID="MoTa" TextMode="MultiLine" Height="70" runat="server"></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5 ">Links liên kết </div>
                    <div class="col-md-4">
                        <asp:TextBox CssClass="TextBox " ID="LienKet" runat="server"></asp:TextBox>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-12">
                        <div class="col-md-2 b pdt5">Ảnh Slider</div>
                        <div class="col-md-10 pd0">
                            <div class="col-md-9 dvimg">
                                <a title="Xóa ảnh" id="lbtDelImg" class="deleteavatar none" onclick="deleteimg('dvimg','lbtDelImg')"></a>
                                <div class="seimgselect" onclick="changekey('avt'); insertavatar(900,550); return false;">
                                    <asp:Image runat="server" ID="imgNew" ToolTip="Ảnh Slider" Width="120" ImageUrl="/image/images/noimage.png" />
                                </div>
                                <asp:HiddenField ID="ImagesHid" runat="server" />
                            </div>
                        </div>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 col-xs-6 b pdt5">Hoạt động?</div>
                    <div class="col-md-4 col-xs-6">
                        <asp:CheckBox ID="HoatDong" Checked="true" runat="server"></asp:CheckBox>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 col-xs-6 b pdt5">Thứ tự hiển thị</div>
                    <div class="col-md-4 col-xs-6">
                        <asp:TextBox ID="ThuTu" Text="1" runat="server" Width="50" CssClass="TextBox center " ReadOnly="true"> </asp:TextBox>
                    </div>
                </div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdDelete" runat="server" Visible="false" Text="Xóa" CssClass="cmdbtt cmdDel" />
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
<asp:HiddenField ID="GetTabPath" runat="server" />
<asp:HiddenField ID="ItemID" runat="server" Visible="false" />
<script type="text/javascript">
    var thd;
    function insertavatar(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = '<%= PortalId.ToString%>';
        if (typeof (Worker) !== "undefined") {
            if (typeof (thd) == "undefined") {
                thd = new Worker("/js/worker.js");
                thd.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        thd.terminate(); thd = undefined;
                        $('#<%= ImagesHid.ClientID %>').val("");
                        if (addValue('<%= ImagesHid.ClientID%>', result)) {
                            $('.seimgselect img').remove();
                            $('.seimgselect').append('<img class="imgDd" width="120" height="120" src="<%=EPORTAL.flConnect.fileDomain%>' + result + '" />');
                            $("#lbtDelImg").removeClass("none");
                        }
                    }
                };
            }
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain%>/files/default.aspx?v=img&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Chọn ảnh", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
    $(function () { settingval(); });
    function deleteimg(t, id) { $("." + t + " img").attr("src", "/image/images/noimage.png"); $("." + t + " input[type='hidden']").val(""); $("#" + id).addClass("none"); };
</script>
