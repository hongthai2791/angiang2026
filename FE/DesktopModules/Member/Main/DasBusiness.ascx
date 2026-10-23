<%@ Control Language="vb" Inherits="Home.Dashboad.View" CodeFile="DasBusiness.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<style>
    .modal-dialog {
        overflow-y: initial !important
    }

    .modal-body {
        height: 430px;
        overflow-y: auto;
    }
</style>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">BÀN LÀM VIỆC NHÀ TUYỂN DỤNG</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body bg-noti">
            <div class="col-md-4 col-sm-4 col-xs-12">
                <div class="info-box">
                    <span class="info-box-icon bg-red"><i class="fa fa-upload"></i></span>

                    <div class="info-box-content">
                        <span class="info-box-text" title="Số tin đã đăng">Số tin tuyển dụng đã đăng</span>
                        <span class="info-box-number"><%=VLDang %></span>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <div class="info-box">
                    <span class="info-box-icon bg-green"><i class="fa fa-sign-in"></i></span>

                    <div class="info-box-content">
                        <span class="info-box-text" title="Số ứng viên ứng tuyển">Số hồ sơ ứng tuyển</span>
                        <span class="info-box-number"><%=VLUngTuyen %></span>
                    </div>
                </div>
            </div>
            <div class="col-md-4 col-sm-4 col-xs-12">
                <div class="info-box">
                    <span class="info-box-icon bg-yellow"><i class="fa fa-download"></i></span>

                    <div class="info-box-content">
                       <%-- <span class="info-box-text" title="Số phiên giao dịch việc làm đã tham gia">Số phiên giao dịch đã tham gia</span>
                        <span class="info-box-number"><%=VLDaLuu %></span> --%>
                        <span class="info-box-text" title="Số việc làm mời ứng tuyển">Số hồ sơ mời ứng tuyển</span>
                        <span class="info-box-number"><%=VLDaMoi %></span>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:DataGrid ID="grdData" runat="server" AutoGenerateColumns="False" PageSize="35" Width="100%" CellPadding="3">
                        <ItemStyle BackColor="#f8f4f1" />
                        <AlternatingItemStyle BackColor="#ffffff" />
                        <Columns>
                            <asp:TemplateColumn HeaderText="STT" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="IsOrder" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="5%" HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Hồ sơ ứng viên phù hợp" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="Title" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:TemplateColumn HeaderText="Chức vụ" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="LevelDesired" runat="server" />
                                </ItemTemplate>
                                <HeaderStyle Width="18%" />
                                <ItemStyle Width="18%" />
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
                            <asp:TemplateColumn HeaderText="Ngày đăng tin" HeaderStyle-CssClass="hdTitle">
                                <ItemTemplate>
                                    <asp:Literal ID="StartDate" runat="server" />
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
            </div>
        </div>
    </div>
</div>
<asp:HiddenField ID="busID" runat="server" Visible="false" />
<script type="text/javascript">
    $('.info-box-number').each(function () { $(this).prop('Counter', 0).animate({ Counter: $(this).text() }, { duration: 2000, easing: 'swing', step: function (now) { $(this).text(Math.ceil(now)); } }); });
    function popDetailJob(pid, id) { waiting(); $.ajax({ type: 'GET', url: '/api/member/data.asmx/GetDetailJobUser?pid=' + pid + '&jobUser=' + id, success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".main-contents").html(json.data); removewaiting(); $("#showPopup").modal('show'); }; }, }); };
</script>
