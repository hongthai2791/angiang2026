<%@ Control Language="vb" CodeFile="DKXH_View.ascx.vb" Inherits="Modules.DKXH.View" AutoEventWireup="false" Explicit="True" %>

<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9">
            <h3 class="box-title">Danh sách đăng ký xếp hàng online (<asp:Literal ID="litCount" runat="server" />)</h3>
        </div>
        <div class="col-md-3 pdr0">
            <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
            <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2 lb">Đơn vị tiếp nhận</div>
                <div class="col-md-4">
                    <asp:DropDownList Enabled="false" ID="DonVi" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-2 lb">Vệ tinh trung tâm</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="VeTinh" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>
                <div class="col-md-2 lb">Dịch vụ</div>
                <div class="col-md-4">
                    <asp:DropDownList ID="DichVu" runat="server" CssClass="selectpicker" AutoPostBack="true"></asp:DropDownList>
                </div>

                <div class="col-md-2 lb">Ngày đăng ký</div>
                <div class="col-md-4">
                    <asp:TextBox ID="NgayDangKy" runat="server" CssClass="datepicker full" AutoPostBack="true"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class=" pd0 " style="display:flex; float:right">
                    <div class="col-md-3 pd0  lb" style="width:200px">Chọn Quầy/Bàn trước khi gọi: </div>
                    <div class="col-md-4 pd0">
                        <asp:DropDownList Width="200px" runat="server" ID="drBanQuay">
                            <asp:ListItem Text="Quầy/Bàn 1" Value="1" />
                            <asp:ListItem Text="Quầy/Bàn 2" Value="2" />
                            <asp:ListItem Text="Quầy/Bàn 3" Value="3" />
                            <asp:ListItem Text="Quầy/Bàn 4" Value="4" />
                        </asp:DropDownList>
                    </div>
                </div>
                <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="20" Width="100%" CellPadding="3">
                    <PagerStyle PageButtonCount="5" HorizontalAlign="Right" NextPageText="Next"
                        PrevPageText="Previous" CssClass="pagG" Mode="NumericPages" />
                    <ItemStyle BackColor="#f8f4f1" />
                    <AlternatingItemStyle BackColor="#ffffff" />
                    <Columns>
                        <asp:TemplateColumn HeaderText="Số TT" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="IsOrder" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="7%" HorizontalAlign="Center" />
                            <ItemStyle Width="7%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Mã đăng ký" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="NoCode" runat="server" />
                            </ItemTemplate>
                            <ItemStyle Width="10%" HorizontalAlign="Center" />
                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Họ và tên" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="HoTen" runat="server" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Left" />
                            <HeaderStyle HorizontalAlign="Left" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Ngày sinh" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="NgaySinh" runat="server" />
                            </ItemTemplate>
                            <ItemStyle Width="10%" HorizontalAlign="Center" />
                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Điện thoại" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="DienThoai" runat="server" />
                            </ItemTemplate>
                            <ItemStyle Width="10%" HorizontalAlign="Center" />
                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Số sổ BHXH" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="SoBHXH" runat="server" />
                            </ItemTemplate>
                            <ItemStyle Width="10%" HorizontalAlign="Center" />
                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Ngày đăng ký" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="NgayDangKy" runat="server" />
                            </ItemTemplate>
                            <ItemStyle Width="10%" HorizontalAlign="Center" />
                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Dịch vụ" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="DichVu" runat="server" />
                            </ItemTemplate>
                            <ItemStyle Width="15%" HorizontalAlign="Center" />
                            <HeaderStyle Width="15%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Trạng thái" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="TinhTrang" runat="server" />
                            </ItemTemplate>
                            <ItemStyle Width="8%" HorizontalAlign="Center" />
                            <HeaderStyle Width="8%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Gọi số" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:LinkButton ID="cmdCallNumber" runat="server" CommandName="CallNumber" CommandArgument='<%#Eval("ThuTu") %>' CssClass="btn btn-info btn-sm">
                                            <i class="fa fa-volume-up"></i> Gọi số
                                </asp:LinkButton>
                            </ItemTemplate>
                            <ItemStyle Width="10%" HorizontalAlign="Center" />
                            <HeaderStyle Width="10%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
            <div class="row">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>
<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
<asp:HiddenField ID="TinhTrang" runat="server" />
<asp:HiddenField ID="ItemID" runat="server" />
<audio controls="controls" id="_soudPlayer" class="none" runat="server" height="100" width="100">
</audio>
<asp:Button ID="cmdUpdate" runat="server" OnClientClick="waiting();" CssClass="none cmdUpdate" />
<script type="text/javascript">
    function uptinhTrang(id, t) {
        $("#<%=ItemID.ClientID %>").val(id);
                $("#<%=TinhTrang.ClientID %>").val(t);
        $(".cmdUpdate").click();
    };
    // Hàm JavaScript mới để phát chuỗi file âm thanh
    var audioQueue = [];
    var audioPlayer = document.getElementById('<%=_soudPlayer.ClientID%>');

    function playAudioSequence(files) {
        // Xóa hàng đợi cũ và thêm các file mới
        audioQueue = files;
        playNextAudio();
    }

    function playNextAudio() {
        if (audioQueue.length > 0) {
            var nextFile = audioQueue.shift();
            audioPlayer.src = nextFile;
            audioPlayer.load();
            audioPlayer.play();
        }
    }

    // Lắng nghe sự kiện khi một file âm thanh kết thúc
    audioPlayer.addEventListener('ended', function () {
        playNextAudio();
    });
</script>

