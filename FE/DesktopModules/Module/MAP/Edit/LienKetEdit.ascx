<%@ Control Language="vb" CodeFile="LienKetEdit.ascx.vb" Inherits="Modules.LienKetEdit.Edit" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin liên kết</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tên liên kết</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="TenThucThe" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Vị trí</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropViTri" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="-1">--- Chọn vị trí hiển thị ---</asp:ListItem>
                            <asp:ListItem Value="TOP">Trên đầu</asp:ListItem>
                            <asp:ListItem Value="CENTER">Trung tâm</asp:ListItem>
                            <asp:ListItem Value="BOTTON">Phía dưới</asp:ListItem>
                            <asp:ListItem Value="RIGHT">Bên phải</asp:ListItem>
                            <asp:ListItem Value="LEFT">Bên trái</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Liên kết</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="LinkURL" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Hình ảnh</div>
                    <div class="col-md-10">
                        <div class="dvimg">
                            <a title="Xóa ảnh" id="lbtDelImg" class="deleteavatar none" onclick="deleteimg('dvimg','lbtDelImg')"></a>
                            <div class="seimgselect" onclick="changekey('avt'); insertavatar(900,550); return false;">
                                <asp:Image runat="server" ID="imgNew" ToolTip="Ảnh đại diện" Width="120" ImageUrl="/image/images/noimage.png" />
                            </div>
                            <asp:HiddenField ID="ImagesHid" runat="server" />
                        </div>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Mô tả</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="GhiChu" runat="server" CssClass="TextBox" Height="100px" TextMode="MultiLine" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Thứ tự hiển thị</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                    </div>
                    <div class="col-md-2 txt-center lb">Sử dụng </div>
                    <div class="col-md-4">
                        <asp:CheckBox ID="IsActive" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="cmdDelete" runat="server" TabIndex="9" Text="Xóa" CssClass="cmsbut cmsbtdel" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
            <asp:HiddenField ID="ItemView" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

<script type="text/javascript">
    var _tyleMessage = 0;
    var vrtimeout = 2000;
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
    function deleteimg(t, id) { $("." + t + " img").attr("src", "/image/images/noimage.png"); $("." + t + " input[type='hidden']").val(""); $("#" + id).addClass("none"); };

</script>
