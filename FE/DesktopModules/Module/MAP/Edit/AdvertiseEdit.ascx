<%@ Control Language="vb" Inherits="Modules.CMS_AdvertiseEdit.Edit" CodeFile="AdvertiseEdit.ascx.vb" ClientIDMode="Static" AutoEventWireup="false" Explicit="True" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:HiddenField ID="ItemId" runat="server" Visible="false" />
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">THÔNG TIN NỘI DUNG BANNER QUẢNG CÁO</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-12">
                <div class="col-md-3 b pdt5">Chọn phân hệ</div>
                <div class="col-md-9">
                    <asp:DropDownList ID="ddlPortal" Enabled="false" runat="server" CssClass="selectpicker validate[required]" AutoPostBack="true"></asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Vị trí quảng cáo</div>
                <div class="col-md-9">
                    <asp:DropDownList onchange="settingval();" ID="PageLoca_ID" runat="server" CssClass="selectpicker PageLoca_ID validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Nội dung quảng cáo</div>
                <div class="col-md-9">
                    <asp:TextBox ID="Advertise_Name" runat="server" Height="60px" TextMode="MultiLine" CssClass="TextBox validate[required,maxSize[249]]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Thể loại</div>
                <div class="col-md-9">
                    <asp:DropDownList ID="ImgType" runat="server" CssClass="selectpicker validate[required]" Width="93%">
                    </asp:DropDownList>
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Chiều rộng (W)</div>
                <div class="col-md-9">
                    <asp:TextBox ID="IsWith" runat="server" CssClass="TextBox isT" Text="auto"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Chiều cao (H)</div>
                <div class="col-md-9">
                    <asp:TextBox ID="IsHeight" runat="server" CssClass="TextBox isT" Text="100%"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Ảnh banner</div>
                <div class="col-md-9 dvimg">
                    <a title="Xóa ảnh" id="lbtDelImg" class="deleteavatar none" onclick="deleteimg('dvimg','lbtDelImg')"></a>
                    <div class="seimgselect" onclick="changekey('avt'); insertavatar(900,550); return false;">
                        <asp:Image runat="server" ID="imgNew" ToolTip="Ảnh đại diện" Width="120" ImageUrl="/image/images/noimage.png" />
                    </div>
                    <asp:HiddenField ID="ImagesHid" runat="server" />
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Kiểu mở liên kết</div>
                <div class="col-md-9">
                    <asp:DropDownList ID="Target" runat="server" CssClass="selectpicker" Width="93%">
                        <asp:ListItem Value="_self" Selected="True">Mở ở trang hiện tại</asp:ListItem>
                        <asp:ListItem Value="_blank">Mở sang một trang mới</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Địa chỉ liên kết</div>
                <div class="col-md-9">
                    <asp:TextBox ID="IsUrl" runat="server" CssClass="TextBox"></asp:TextBox>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Ngày đăng</div>
                <div class="col-md-3">
                    <div class="rccalpopup">
                        <asp:TextBox ID="StartDate" Placeholder="dd/mm/yyyy hh:mm" Width="150" CssClass="timepicker TextBox" runat="server" />
                    </div>
                </div>
                <div class="col-md-3 b pdt5 txt-right">Ngày hết hạn</div>
                <div class="col-md-3">
                    <div class="rccalpopup">
                        <asp:TextBox ID="EndDate" Placeholder="dd/mm/yyyy hh:mm" Width="150" CssClass="timepicker TextBox" runat="server" />
                    </div>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Thứ tự</div>
                <div class="col-md-3">
                    <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox center validate[required, custom[integer]]" />
                </div>
                <div class="col-md-3 txt-right b pdt5">Duyệt đăng</div>
                <div class="col-md-3 pdt5">
                    <asp:CheckBox ID="IsActive" CssClass="checkative" runat="server" />
                </div>
                <div class="clear"></div>
                <div class="col-md-3 b pdt5">Ảnh mô tả vị trí</div>
                <div class="col-md-9 img-settings">
                </div>
            </div>
            <div class="clear"></div>
        </div>
    </div>
</div>
<div class="clr clUp"></div>
<asp:Literal ID="litUpdate" runat="server" />
<asp:HiddenField ID="hdf_subCategories" runat="server" />
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa quảng cáo" CssClass="cmdbtt cmdDel" OnClientClick="return $('#Form').validationEngine('detach'); " />
        <div class="clear"></div>
    </div>
</div>
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
    function settingval() { $.ajax({ type: "GET", url: '/api/admin/settings.asmx/PageLocal?pid=' + <%= Me.PortalId  %> + "&id=" + $("#<%=PageLoca_ID.ClientID %>").val(), success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".img-settings").html(json.data); } } }); };
</script>

