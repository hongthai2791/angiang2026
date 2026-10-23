<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="Weblink_Edit.ascx.vb" Inherits="DesktopModules.Weblinks.Weblink_Edit" EnableViewState="true" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THÔNG TIN LIÊN KẾT WEBSITE</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div id="newContent" runat="server">
                <div class="col-md-9">
                    <div class="col-md-2 b pdt5">Đơn vị</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Loại liên kết</div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="WebLinkType" CssClass="selectpicker cmcoption validate[required]" runat="server" Width="100%"></asp:DropDownList>
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Tên liên kết</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Name" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Địa chỉ liên kết</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Url" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="Description" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="100"></asp:TextBox>
                    </div>

                    <div class="clear"></div>
                    <div class="col-md-2 b pdt5">Thứ tự</div>
                    <div class="col-md-1">
                        <asp:TextBox ID="OrderNo" Text="1" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                        <span class="required"></span>
                    </div>

                    <div class="clear"></div>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lbm"></asp:Label>
                    <div id="DivAvatar" style="width: 150px">
                        <div>
                            <p style="float: left;">Ảnh đại diện</p>
                            <span style="float: right;">
                                <a title="Xóa ảnh" id="lbtDelImg" runat="server" class="delimages" onclick="DelAvatar()" style="display: none;"></a>
                            </span>
                        </div>
                        <asp:HiddenField ID="txtImagePath" runat="server" />
                        <div id="imgDD" style="cursor: pointer;" runat="server" class="seimgselect ImgView list-img" onclick="changekey('avt'); insertavatar(900,550); return false;">
                            <img class="vImg" src="/image/images/noimage.png?w=120" alt="Ảnh đại diện" />
                        </div>
                    </div>
                </div>
                <div class="clear"></div>
                <asp:HiddenField ID="User_Name" runat="server" />
                <asp:HiddenField ID="ItemID" runat="server" />

            </div>
        </div>
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return retunwaiting();" />
        <asp:Button ID="cmdDel" runat="server" Visible="false" Text="Xóa" CssClass="cmdbtt cmdDel" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />

    </div>
</div>
<script type="text/javascript">
    var thd; $(document).ready(function () { if ($("#DivAvatar img").attr("src") == "" || $("#DivAvatar img").attr("src") == null) { $("#DivAvatar img").attr("src", "/image/images/noimage.png?w=120"); } var n = document.getElementById('<%=ItemID.ClientID %>').value; if (n.length > 3) { $(".delimages").css("display", "block"); } });
    function DelAvatar() { $("#DivAvatar img").attr("src", "/image/images/noimage.png?w=120"); $("#DivAvatar input[type='hidden']").val(""); $(".delimages").css("display", "none"); };
    function insertavatar(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID%>').val();
        if (typeof (Worker) !== "undefined") {
            if (typeof (thd) == "undefined") {
                thd = new Worker("/js/worker.js");
                thd.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        thd.terminate(); thd = undefined;
                        if (addValue('<%= txtImagePath.ClientID %>', result)) {
                            $('.list-img img').remove();
                            $('.list-img').append('<img class="imgDd" width="120" height="120" src="<%=EPORTAL.flConnect.fileDomain %>' + result + '" />');
                            $(".delimages").css("display", "block");
                        }
                    }
                };
            }
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=img&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "Related news", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
</script>
