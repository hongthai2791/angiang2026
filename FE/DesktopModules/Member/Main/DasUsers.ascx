<%@ Control Language="vb" Inherits="Home.Dashboad.View" CodeFile="DasUsers.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">BÀN LÀM VIỆC NGƯỜI TÌM VIỆC</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body bg-noti">
            <div class="col-md-4 col-sm-4 col-xs-12">
                <div class="info-box">
                    <span class="info-box-icon bg-red"><i class="fa fa-upload"></i></span>

                    <div class="info-box-content">
                        <span class="info-box-text" title="Việc làm đã đăng">Hồ sơ xin việc đã đăng</span>
                        <span class="info-box-number"><%=VLDang %></span>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <div class="info-box">
                    <span class="info-box-icon bg-green"><i class="fa fa-sign-in"></i></span>

                    <div class="info-box-content">
                        <span class="info-box-text" title="Việc làm đã ứng tuyển">Việc làm đã ứng tuyển</span>
                        <span class="info-box-number"><%=VLUngTuyen %></span>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <div class="info-box">
                    <span class="info-box-icon bg-yellow"><i class="fa fa-download"></i></span>

                    <div class="info-box-content">
                        <span class="info-box-text" title="Việc làm đã lưu">Việc làm đã lưu</span>
                        <span class="info-box-number"><%=VLDaLuu %></span>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3" OnItemDataBound="grdData_ItemDataBound">
                        <ItemStyle BackColor="#f8f4f1" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="IsOrder" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="4%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Việc làm phù hợp" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Title" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Chức vụ" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="LevelDesired" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="15%" />
                                <ItemStyle Width="15%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Kinh nghiệm" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Experience_ID" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="12%" />
                                <ItemStyle Width="12%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Mức lương" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Salary_ID" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="12%" />
                                <ItemStyle Width="12%" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Hạn nộp hồ sơ" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="ExpiredDate" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Chi tiết" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Edit" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="10%" HorizontalAlign="Center" />
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </div>
                <div class="col-md-12">
                    <div id="homeworks" class="home-works">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="works-title">
                                    <div class="box-w-title">
                                        <a onclick="homework(0, this);" class="wactive" title="Việc làm tốt nhất">Việc làm tốt nhất</a>
                                        <a onclick="homework(1, this);" class="" title="Việc làm mới nhất">Việc làm mới nhất</a>
                                        <a onclick="homework(2, this);" class="" title="Việc làm lương cao">Việc làm lương cao</a>
                                        <a onclick="homework(3, this);" class="" title="Tuyển gấp">Tuyển gấp</a>
                                        <div class="clear"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row datawork_home">
                            <div class="clear"></div>
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    $('.info-box-number').each(function () { $(this).prop('Counter', 0).animate({ Counter: $(this).text() }, { duration: 2000, easing: 'swing', step: function (now) { $(this).text(Math.ceil(now)); } }); });
    function popDetailJob(pid, id) { waiting(); $.ajax({ type: 'GET', url: '/api/member/data.asmx/GetDetailJob?pid=' + pid + '&idWork=' + id, success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".main-contents").html(json.data); removewaiting(); $("#showPopup").modal('show'); }; }, }); };
    function homework(flag, t) {
        $("#homeworks").attr("class", "").addClass("home-works hw-" + flag);
        $.ajax({ type: 'GET', url: '/api/work/works.asmx/values?pid=' + <%= Me.PortalId  %> + "&isflag=" + flag + "&tinhTp=", success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".datawork_home").html(json.data); }; }, });
        $(".box-w-title a").removeClass("wactive"); $(t).addClass("wactive");
    };
    jQuery(document).ready(function () { $.ajax({ type: 'GET', url: '/api/work/works.asmx/values?pid=' + <%= Me.PortalId  %> + "&isflag=0&tinhTp=", success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".datawork_home").html(json.data); }; }, }); });

</script>
<style>
    .modal-dialog {
        overflow-y: initial !important
    }

    .modal-body {
        height: 430px;
        overflow-y: auto;
    }
</style>
