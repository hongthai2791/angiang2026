<%@ Control Language="vb" CodeFile="MagazineEdit.ascx.vb" Inherits="Modules.Magazine.Edit" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin ấn phẩm</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="clear"></div>
            <div class="col-md-8">
                <div class="col-md-2 lb">Đơn vị</div>
                <div class="col-md-10">
                    <asp:DropDownList ID="drTinhTp" runat="server" CssClass="selectpicker validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="col-md-2 lb">Tên ấn phẩm</div>
                <div class="col-md-10">
                    <asp:TextBox ID="Magazine_Name" runat="server" CssClass="TextBox  validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 lb">Mã ấn phẩm</div>
                <div class="col-md-10">
                    <asp:TextBox ID="Magazine_Des" runat="server" CssClass="TextBox  validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2 lb ">Thứ tự</div>
                <div class="col-md-4">
                    <asp:TextBox ID="Magazine_IsOrder" runat="server" CssClass="TextBox center" />
                </div>
                <div class="clear"></div>
                <div class="col-md-2 lb ">Kích hoạt</div>
                <div class="col-md-4">
                    <asp:CheckBox ID="IsActive" runat="server" CssClass="CheckBox" />
                </div>
            </div>
            <div class="col-md-4">
                <div class="col-md-12 ">Ảnh đại diện</div>
                <div class="col-md-12 ist-img">
                    <div id="DivAvatar">
                        <div style="cursor: pointer;" class="seimgselect ImgView " onclick="changekey('avt'); insertavatar(900,550); return false;">
                            <div id="imgDD" class="list-img chon-dai-dien" runat="server">
                                <img class="vImg" src="/image/images/noimage.png?dpi=150&quality=100&w=145&h=120" title="Chọn ảnh đại diện khác" alt="Ảnh đại diện" />
                            </div>
                        </div>
                        <asp:HiddenField ID="LogoDN" runat="server" />
                    </div>
                </div>
            </div>


            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" TabIndex="9" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" TabIndex="8" CssClass="cmsbut cmsbtupdate" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" TabIndex="10" CssClass="cmsbut cmsbtdel" />
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
</div>
<script>
    var thnew;
    function insertavatar(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = 0;
        if (typeof (Worker) !== "undefined") {
            if (typeof (thnew) == "undefined") {
                thnew = new Worker("/js/worker.js");
                thnew.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        thnew.terminate(); thnew = undefined;
                        $('#<%= LogoDN.ClientID %>').val(result);;
                        $('.list-img img').remove();
                        $('.list-img').append('<img class="imgDd" src="<%=EPORTAL.flConnect.fileDomain%>' + result + '?dpi=150&quality=100&w=165&h=130" />');
                        $(".delimages").css("display", "block");
                        $(".IdKey").html();
                    }
                };
            }
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain%>/files/default.aspx?v=img&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
</script>

