<%@ Control Language="VB" AutoEventWireup="false" CodeFile="JobUserList.ascx.vb" Inherits="Modules.PageWork.View" %>
<asp:UpdatePanel runat="server" ID="pUserProfile">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-9">
                    <h3 class="box-title">Danh sách hồ sơ ứng viên (<asp:Literal ID="litCount" runat="server" />)</h3>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtkey" runat="server" placeholder="Tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
                    <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs" />
                </div>
                <div class="clear"></div>
            </div>
            
            <div class="box-body">
                <div class="main-body box-search-job">
                    <div class="row">
                        <div class="col-md-4 ViTri">
                            <asp:DropDownList ID="ChucVu" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-4 NganhNghe">
                            <asp:DropDownList ID="NganhNghe" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-4 TinhTP">
                            <asp:DropDownList ID="TinhTP" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="clear">
                        </div>
                        <div class="col-md-3 MucLuong">
                            <asp:DropDownList ID="MucLuong" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3 TrinhDo">
                            <asp:DropDownList ID="TrinhDo" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="col-md-3 KinhNghiem">
                            <asp:DropDownList ID="KinhNghiem" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                         <div class="col-md-3 GioiTinh">
                            <asp:DropDownList ID="GioiTinh" AutoPostBack="true" runat="server" CssClass="selectpicker"></asp:DropDownList>
                        </div>
                        <div class="clear"></div>
                        <div class="row">
                            <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                                <ItemStyle BackColor="#f8f4f1" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="IsOrder" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                        <ItemStyle Width="4%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="CV ứng viên" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="CVUngVien" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Mức lương" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="MucLuong" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" HorizontalAlign="Center" />
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />

                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Ngành nghề" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="NganhNghe" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="17%" />
                                        <HeaderStyle Width="17%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                       <asp:TemplateColumn HeaderText="Trình độ" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="TrinhDo" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" />
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                        <asp:TemplateColumn HeaderText="Ngày đăng" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="NgayDang" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="10%" HorizontalAlign="Center" />
                                        <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Địa chỉ" HeaderStyle-CssClass="hdTitle">
                                        <ItemTemplate>
                                            <asp:Literal ID="DiaChi" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="18%" />
                                        <HeaderStyle Width="18%" HorizontalAlign="Center" />
                                    </asp:TemplateColumn>
                                </Columns>
                            </asp:DataGrid>
                        </div>
                        <div class="row">
                            <asp:Literal ID="litPage" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
        <asp:HiddenField ID="usName" runat="server" />

        <div id="myDetailUserProfile" class="modal fade" role="dialog">
            <div class="modal-dialog modal-lg">
                <div class="modal-content" style="width: 950px">
                    <div class="modal-header1">
                        <h4 class="modal-title">&nbsp;Thông tin hồ sơ ứng viên</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    <div class="modal-body" data-spy="scroll" data-target="#myScrollspy" style="overflow: auto; max-height: calc(100vh - 40px);">
                        <div class="row" style="top: 0px !important">
                            <div class="myDetailUserProfile">
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <div id="myDetailVLUV3" class="modal fade" role="dialog">
            <div class="modal-dialog modal-lg">
                <div class="modal-content" style="width: 400px">
                    <div class="modal-header1">
                        <h4 class="modal-title">&nbsp;Thông Báo</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    <div class="modal-body" data-spy="scroll" data-target="#myScrollspy" style="overflow: auto; max-height: calc(100vh - 40px);">
                        <div class="row" style="top: 0px !important">
                            <div class="center">
                                <span id="content_popup ">
                                    <h1 style="margin-bottom: 25px; line-height: 18px;" class="text_green_new font18 center">
                                        <i class="icon icon-xs icon-success_new"></i>BẠN ĐÃ LƯU HỒ SƠ THÀNH CÔNG!
                                    </h1>
                                </span>
                            </div>
                            <div class="center">
                                <button type="button" class="btn-big btn-danger w260 font16" style="padding-left: 0px; padding-right: 0px;" onclick="location.href='/business/view/bus-jobuser'">Xem danh sách hồ sơ ứng viên khác</button>
                            </div>
                            <div class="center">
                                <button type="button" class="btn-big btn-primary2 w260 font16" onclick="location.href='/business/view/bus-profile-save'">Về tủ hồ sơ đã lưu</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div id="thongbaodn" class="modal fade" role="dialog">
            <div class="modal-dialog modal-lg">
                <div class="modal-content" style="width: 200px">
                    <div class="modal-header1">
                        <h4 class="modal-title">&nbsp;Thông Báo</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    <div class="modal-body" data-spy="scroll" data-target="#myScrollspy" style="overflow: auto; max-height: calc(100vh - 40px);">
                        <div class="row" style="top: 0px !important">
                            <div class="center">
                                <span id="content_thongbao ">
                                    <h1 style="margin-bottom: 25px; line-height: 18px;" class="text_green_new font18 center">
                                        <i class="icon icon-xs icon-success_new"></i>BẠN ĐÃ LƯU HỒ SƠ THÀNH CÔNG!
                                    </h1>
                                </span>
                            </div>
                            <div class="center">
                                <button type="button" class="btn-big btn-danger w260 font16" style="padding-left: 0px; padding-right: 0px;" onclick="refreshPage();">Xem hồ sơ phù hợp khác</button>
                            </div>
                            <div class="center">
                                <button type="button" class="btn-big btn-primary2 w260 font16" onclick="location.href='/employers/view/bus-profile-save'">Về tủ hồ sơ đã lưu</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
  
        
        <script type="text/javascript">
        function popDetailJobuser(pid, id, us) {
            waiting();
            $.ajax({
                type: 'GET', url: '/api/work/works.asmx/DetailJobUser?pid=' + pid + '&id=' + id + '&us=' + us,
                success: function (data) {
                    var json = $.parseJSON($(data).find("string").text());
                    if (json.data) {
                        $(".myDetailUserProfile").html(json.data);
                        removewaiting();
                        $("#myDetailUserProfile").modal('show');
                    };
                },
            });
         };

            function addClassModal() {
                $("#myDetailUserProfile").addClass("modal fade in");
                $("#myDetailUserProfile").css("display", "block");
            };
            function LuuUngVien(pid, id) {
                var username = $("#<%=usName.ClientID%>").val();
                $.ajax({
                    type: 'GET', url: '/api/work/works.asmx/LuuUngVien1?pid=' + pid + '&id=' + id + '&username=' + username,
                    success: function (data) {
                        var json = $.parseJSON($(data).find("string").text());
                        if (json.message = "Success") { $("#myDetailUserProfile").modal('hide'); $("#myDetailVLUV3").modal('show'); };
                    },
                });
            };

            function danhsachden(pid, id) {
                var username = $("#<%=usName.ClientID%>").val();
                $.ajax({
                    type: 'GET', url: '/api/member/data.asmx/JobBlackList?pid=' + pid + '&id=' + id + '&use=' + username,
                    success: function (data) {
                        var json = $.parseJSON($(data).find("string").text());
                        if (json.message = "Success") { $("#myDetailUserProfile").modal('hide'); notify('success', 'Báo cáo hồ sơ danh sách đen thành công!', 'Thông báo', false); };
                    },
                });
            };
       
            function xemthongtin() {
                if ($(".Xacthuchoso").hasClass("kt") == false) {
                     $(".Xacthuchoso").removeClass("none");$(".Xacthuchoso").addClass("kt");
                  }
                    else {
                        $(".Xacthuchoso").removeClass("kt"); $(".Xacthuchoso").addClass("none");
                    }
                //$(".contentjobuser").addClass("none");
            }; function xemlienhe() {
                  if ($(".Xacthuclienhe").hasClass("kt") == false) {
                     $(".Xacthuclienhe").removeClass("none");$(".Xacthuclienhe").addClass("kt");
                  }
                    else {
                        $(".Xacthuclienhe").removeClass("kt"); $(".Xacthuclienhe").addClass("none");
                    }
                //$(".Xacthuclienhe").removeClass("none");
                //$(".contentjobuser").addClass("none");
            };
            //function toogleModal(modal, status) { if (status == true) { $('.remodal-overlay').css("display", "block"); $('.remodal-wrapper').css("display", "none"); $(modal).css("display", "block"); } else { $('.remodal-overlay').css("display", "none"); $('.remodal-wrapper').css("display", "none"); } };
  
        </script>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="ChucVu" />
        <asp:AsyncPostBackTrigger ControlID="NganhNghe" />
        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
        <asp:AsyncPostBackTrigger ControlID="MucLuong" />
        <asp:AsyncPostBackTrigger ControlID="TrinhDo" />
        <asp:AsyncPostBackTrigger ControlID="KinhNghiem" />
    </Triggers>
</asp:UpdatePanel>

