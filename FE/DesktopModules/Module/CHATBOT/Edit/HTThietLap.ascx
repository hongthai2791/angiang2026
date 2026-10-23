<%@ Control Language="vb" CodeFile="HTThietLap.ascx.vb" Inherits="Modules.HTThietLap.Edit" AutoEventWireup="false" Explicit="True" %>
<style>
    .CheckBox {
        padding: 0 !important;
    }
</style>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Thông tin giao diện hiển thị</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="col-md-2 lb">Tiêu đề khung chat</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtTieuDe" runat="server" CssClass="TextBox validate[required]" />
                        <span class="required"></span>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Văn bản khung</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtVanBan" Height="100px" TextMode="MultiLine" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Nền khung chat</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="txtNenKhungChat" Placeholder="#000000" runat="server" CssClass="TextBox" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Nền chuyển màu</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="txtNenChuyenMau" Placeholder="#FCFCFC" runat="server" CssClass="TextBox" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 lb">Nền đơn sắc</div>
                    <div class="col-md-2">
                        <asp:TextBox ID="txtNenDonSac" Placeholder="#CCCCCC" runat="server" CssClass="TextBox" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 lb">Icon</div>
                    <div class="col-md-4 dvimg">
                        <a title="Xóa ảnh" id="lbtDelImg" class="deleteavatar none" onclick="deleteimg('dvimg','lbtDelImg')"></a>
                        <div class="seimgselect" onclick="changekey('avt'); insertavatar(900,550); return false;">
                            <asp:Image runat="server" ID="imgNew" ToolTip="Ảnh đại diện" Width="80" ImageUrl="/image/images/noimage.png" />
                        </div>
                        <asp:HiddenField ID="ImagesHid" runat="server" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-12">
                        <h3 class="box-title">Thông tin vị trí hiển thị</h3>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Nơi hiển thị</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropNoiHienThi" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="Right">Bên phải</asp:ListItem>
                            <asp:ListItem Value="Left">Bên trái</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Kiểu thanh chat</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropKieuThanhChat" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="Nho">Nhỏ</asp:ListItem>
                            <asp:ListItem Value="Vua">Vừa</asp:ListItem>
                            <asp:ListItem Value="To">To</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Vị trí hiển thị icon</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropViTriIcon" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="Right">Bên phải</asp:ListItem>
                            <asp:ListItem Value="Left">Bên trái</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Khoảng cách icon</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropKhoangCachIcon" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="10px">10 Pixels</asp:ListItem>
                            <asp:ListItem Value="20px">20 Pixels</asp:ListItem>
                            <asp:ListItem Value="30px">30 Pixels</asp:ListItem>
                            <asp:ListItem Value="40px">40 Pixels</asp:ListItem>
                            <asp:ListItem Value="50px">50 Pixels</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2 lb">Tỷ lệ</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="dropTyLe" runat="server" CssClass="selectpicker">
                            <asp:ListItem Value="100%">100%</asp:ListItem>
                            <asp:ListItem Value="125%">125%</asp:ListItem>
                            <asp:ListItem Value="150%">150%</asp:ListItem>
                            <asp:ListItem Value="200%">200%</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-12">
                        <h3 class="box-title">Thông tin cài đặt nâng cao</h3>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Chặn từ ngữ xấu</div>
                    <div class="col-md-4">
                        <asp:CheckBox ID="IsTuXau" ToolTip="Chặn từ ngữ xấu" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Những từ ngữ xấu</div>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtTuXau" TextMode="MultiLine" Height="100" Placeholder="đù má, chó ghẻ" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Chat trực tiếp</div>
                    <div class="col-md-2">
                        <asp:CheckBox ID="IsLiveChat" ToolTip="Yêu cầu chat trực tiếp" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="col-md-2 lb">Tự động mở cửa sổ</div>
                    <div class="col-md-2">
                        <asp:CheckBox ID="IsOpenChat" ToolTip="Tự động mở cửa sổ chat sau khoảng thời gian người dùng truy cập trang" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="col-md-2 lb">Gọi trực tiếp</div>
                    <div class="col-md-2">
                        <asp:CheckBox ID="IsCallChat" ToolTip="Yêu cầu gọi trực tiếp" CssClass="CheckBox" runat="server" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-12">
                        <h3 class="box-title">Thông tin NLP</h3>
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-2 lb">Trọng số tối thiểu ý hiểu của câu</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtSoYHieu" runat="server" CssClass="TextBox" />
                    </div>
                    <div class="col-md-2 lb">Trọng số tối thiểu trích xuất giá trị</div>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtSoTrichXuat"  runat="server" CssClass="TextBox" />
                    </div>

                    <div class="clr clUp"></div>
                    <asp:Literal ID="litUpdate" runat="server" />
                </div>
                <div class="fix-btt-toolbar">
                    <div>
                        <asp:Button ID="cmdBack" runat="server" TabIndex="7" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                        <asp:Button ID="cmdUpdate" runat="server" TabIndex="8" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="return retunwaiting();" />
                        <div class="clr"></div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="ItemId" runat="server" Visible="false" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>


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
                            $('.seimgselect').append('<img class="imgDd" width="80" height="80" src="<%=EPORTAL.flConnect.fileDomain%>' + result + '" />');
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
