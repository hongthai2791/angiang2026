<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Emp_WorkEdit_Cu.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin tin tuyển dụng việc làm</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-2">Hồ sơ đã duyệt</div>
                <div class="col-md-1">
                    <asp:CheckBox ID="IsApproval" CssClass="cs-select" runat="server" />
                </div>
                <div class="col-md-1 txt-right" title="Chọn làm tin nổi bật trên trang chủ">Tin nổi bật</div>
                <div class="col-md-1">
                    <asp:CheckBox ID="IsHot" CssClass="cs-select" runat="server" />
                </div>
                <div class="col-md-2 txt-right" title="Thông tin doanh nghiệp sẽ được ẩn đi và thay thế bằng thông tin của trung tâm DVVL">Dấu thông tin DN</div>
                <div class="col-md-1">
                    <asp:CheckBox ID="IsFast" ToolTip="Thông tin doanh nghiệp sẽ được ẩn đi và thay thế bằng thông tin của trung tâm DVVL" CssClass="cs-select" runat="server" />
                </div>
                <div class="col-md-1 txt-right" title="Chọn làm tin đăng gấp ngoài trang chủ">Đăng gấp</div>
                <div class="col-md-1">
                    <asp:CheckBox ID="IsUrgent" CssClass="cs-select" runat="server" />
                </div>
                <div class="col-md-1 txt-right" title="Ghim tin này lên đầu ngoài trang chủ">Ghim tin</div>
                <div class="col-md-1">
                    <asp:CheckBox ID="IsGhim" ToolTip="Ghim tin này lên đầu ngoài trang chủ" CssClass="cs-select" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-2">Đăng từ ngày</div>
                <div class="col-md-2 rccalpopup">
                    <asp:TextBox ID="StartDate" autocomplete="off" placeholder="dd/mm/yyyy" CssClass=" datepicker TuNgay TextBox validate[required]" runat="server" />
                    <span class="required"></span>
                </div>
                <div class="col-md-2 txt-right">Đến hết ngày</div>
                <div class="col-md-2 rccalpopup">
                    <asp:TextBox ID="EndDate" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker DenNgay TextBox validate[required]" runat="server" />
                    <span class="required"></span>
                </div>
                <div class="col-md-2 txt-right">Hạn nộp hồ sơ</div>
                <div class="col-md-2 rccalpopup">
                    <asp:TextBox ID="ExpiredDate" autocomplete="off" placeholder="dd/mm/yyyy" CssClass="datepicker NopHS TextBox validate[required]" runat="server" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>

            <div class="row pdt10">
                <div class="col-md-2">Tiêu đề tin tuyển dụng</div>
                <div class="col-md-10">
                    <asp:TextBox ID="Title" runat="server" MaxLength="250" CssClass="TextBox validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <asp:UpdatePanel runat="server" ID="uptinh">
                    <ContentTemplate>
                        <div class="col-md-2">
                            Nơi làm việc
                             <asp:CheckBox CssClass="chkMultiple Checkbox right" AutoPostBack="true" runat="server" ID="chkMultiple" ToolTip="Tích để chọn nhiều tỉnh thành phố" />
                        </div>
                        <div class="col-md-3" runat="server" id="divSelectTP">
                            <asp:DropDownList ID="TinhTP" AutoPostBack="true" CssClass="selectpicker TinhTP validate[required]" runat="server" />
                            <asp:DropDownList ID="TinhTPMulti" onchange="getMultiple(); " multiple="multiple" data-actions-box="true" CssClass="none selectpicker TinhTP2 validate[required]" runat="server" />
                            <span class="required"></span>
                        </div>
                        <div class="col-md-7" runat="server" id="divSelectQH">
                            <asp:DropDownList ID="QuanHuyen" multiple="multiple" data-actions-box="true" CssClass="selectpicker QuanHuyen" runat="server" />
                            <asp:HiddenField ID="HidQuanHuyen" runat="server" />
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    </Triggers>
                </asp:UpdatePanel>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin tuyển dụng
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="col-md-4 pdl0">Mức lương</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="Salary_ID" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdl0">Kinh nghiệm làm việc</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="Experience_ID" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-12 pdl0 none">Hình thức nộp</div>
                    <div class="col-md-12 pdl0">
                        <asp:TextBox ID="SubmissionSend" Visible="false" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="127px" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdl0">Chức vụ</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="LevelDesired" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdl0">Trình độ </div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="Level_ID" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4">Vị trí tuyển dụng</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="JobPlace" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                </div>
                <div class="col-md-6 pdr0">
                    <div class="col-md-3">Số lượng tuyển</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="Quantity" runat="server" Text="1" CssClass="TextBox center validate[required, custom[number]]" Width="87%" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-2 txt-right">Giới tính</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="Gender" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3">Độ tuổi</div>
                    <div class="col-md-9">
                        <asp:TextBox ID="Ages" runat="server" Text="Từ 18 đến 35" CssClass="TextBox " />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3" style="padding: 10px 5px">Tính chất công việc</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="TypeOf_ID" CssClass="selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3" style="padding: 0px 7px">Ngành nghề</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="Career_ID" multiple="multiple" data-actions-box="true" CssClass="nganhnghe selectpicker validate[required]" runat="server" />
                        <span class="required"></span>
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-3">Thời gian làm việc</div>
                    <div class="col-md-9">
                        <asp:TextBox ID="WorkTime" runat="server" Text="Từ 8h đến 17h hàng ngày" CssClass="TextBox " />
                    </div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin yêu cầu
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="col-md-12">Mô tả công việc</div>
                    <div class="col-md-12">
                        <asp:TextBox ID="Description" runat="server" CssClass="TextBox validate[required]" TextMode="MultiLine" Height="100px" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-12">Quyền lợi người lao động</div>
                    <div class="col-md-12">
                        <asp:TextBox ID="Benefit" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="100px" />
                    </div>
                </div>
                <div class="col-md-6 pdr0">
                    <div class="col-md-12">Yêu cầu công việc</div>
                    <div class="col-md-12">
                        <asp:TextBox ID="Requirement" runat="server" CssClass="TextBox validate[required]" TextMode="MultiLine" Height="100px" />
                        <span class="required"></span>
                    </div>
                    <div class="col-md-12">Yêu cầu hồ sơ</div>
                    <div class="col-md-12">
                        <asp:TextBox ID="RequirementsProfile" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="100px" />
                    </div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="title5">
                    <img src="/image/note_edit.png" alt="logo" />&nbsp;Thông tin liên hệ
                </div>
            </div>
            <div class="row">
                <div class="col-md-2">Doanh nghiệp tuyển dụng</div>
                <div class="col-md-10">
                    <asp:TextBox ID="Business_Name" onchange="setBusiness()" runat="server" CssClass="TextBox validate[required]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-2">Địa chỉ liên hệ</div>
                <div class="col-md-7">
                    <asp:TextBox ID="ContactAddress" runat="server" CssClass="TextBox" />
                </div>
                <div class="col-md-1 txt-center">MST</div>
                <div class="col-md-2">
                    <asp:TextBox ID="TaxCode" runat="server" CssClass="TextBox validate[required,minSize[10]]" />
                    <span class="required"></span>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="row">
                        <div class="col-md-4 pdl0">Người liên hệ</div>
                        <div class="col-md-8">
                            <asp:TextBox ID="ContactUser" runat="server" CssClass="TextBox validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-4 pdl0">Điện thoại</div>
                        <div class="col-md-8">
                            <asp:TextBox ID="ContactMobile" runat="server" CssClass="TextBox validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="col-md-4 pdl0">Email liên hệ</div>
                        <div class="col-md-8">
                            <asp:TextBox ID="ContactEmail" runat="server" CssClass="TextBox validate[required, custom[email]]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>
                <div class="col-md-6 pdr0">
                    <div class="row">
                        <div class="col-md-12">Ghi chú nội dung đăng tin tuyển dụng</div>
                        <div class="col-md-12">
                            <asp:TextBox ID="ContactDes" runat="server" CssClass="TextBox" TextMode="MultiLine" Height="88" />
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>
                <div class="clear"></div>
            </div>

        </div>
        <div class="clr clUp "></div>
        <asp:Literal ID="litUpdate" runat="server" />
    </div>
    <asp:HiddenField ID="ItemID" runat="server" Visible="true" />
    <asp:HiddenField ID="IsSuper" runat="server" Visible="false" />
    <asp:HiddenField ID="hidBusinessID" runat="server" />
    <asp:HiddenField ID="CareerID" runat="server" />
    <asp:HiddenField ID="HidTinhTP" runat="server" />
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" ToolTip="Lưu và đóng màn hình nhập tin này lại" Text="Lưu và đóng" CssClass="cmsbut cmsbtupdate" OnClientClick="getMultiple(); return checkThongTin();" />
        <asp:Button ID="cmdUpdateAndNew" runat="server" ToolTip="Lưu và thêm mới một tin khác, thông tin doanh nghiệp liên hệ được giữ nguyên" Text="Lưu và thêm mới" CssClass="cmsbut cmsbtsave" OnClientClick="getMultiple(); return checkThongTin();" />
        <asp:Button ID="cmdIntroduce" runat="server" Text="Chắp nối ứng viên" ToolTip="Giới thiệu các ứng viên cho doanh nghiệp đăng tin tuyển dụng này" CssClass="cmsbut cmsbtchange" />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');" />
        <div class="clr"></div>
    </div>
</div>
<script>
    $(document).ready(function () {
        $("#<%=Business_Name.ClientID %>").change(function () {
            setBusiness()
        });
        $("#<%=Business_Name.ClientID %>").keyup(function () {
            setBusiness()
        });
    });
    function setBusiness() {
        var tp = $(".TinhTP").val();
        var qh = $(".QuanHuyen").val();
        $("#<%=hidBusinessID.ClientID %>").val("");
        $("#<%=ContactEmail.ClientID %>").val("");
        $("#<%=ContactMobile.ClientID %>").val("");
        $("#<%=ContactUser.ClientID %>").val("");
        $("#<%=ContactAddress.ClientID %>").val("");
        $("#<%=TaxCode.ClientID %>").val("");
        $("#<%=Business_Name.ClientID %>").autocomplete({
            source: function (request, response) {
                $.ajax({
                    dataType: "json", type: "POST", url: '/api/work/search.asmx/findBusiness',
                    data: "{'search': '" + request.term + "','tp':'" + tp + "','qh':'" + qh + "'}", contentType: "application/json; charset=utf-8",
                    success: function (data) {
                        response($.map(data.d, function (item) {
                            return {
                                label: item.Business_Vn,
                                val: item.Business_ID,
                                ContactUser: item.ContactUser,
                                ContactMobile: item.ContactMobile,
                                ContactEmail: item.ContactEmail,
                                TaxCode: item.TaxCode,
                                Address: item.Address
                            }
                        }))
                    }
                });
            },
            select: function (e, i) {
                $("#<%=hidBusinessID.ClientID %>").val(i.item.val);
                $("#<%=ContactEmail.ClientID %>").val(i.item.ContactEmail);
                $("#<%=ContactMobile.ClientID %>").val(i.item.ContactMobile);
                $("#<%=ContactUser.ClientID %>").val(i.item.ContactUser);
                $("#<%=TaxCode.ClientID %>").val(i.item.TaxCode);
                $("#<%=ContactAddress.ClientID %>").val(i.item.Address);
            },
            minLength: 0,
        }).focus(function () { $(this).autocomplete('search', $(this).val()) });
    };
    function checkThongTin() {
        if ($('#Form').validationEngine('validate') == true) {

            if ($(".TuNgay").val() == "") {
                notify('info', 'Bạn chưa nhập ngày đăng tin.', 'Thông báo', false);
                $(".TuNgay").focus(); return false;
            }

            if ($(".DenNgay").val() == "") {
                notify('info', 'Bạn chưa nhập ngày hết hạn đăng tin.', 'Thông báo', false);
                $(".DenNgay").focus(); return false;
            }
            else {
                var kq = $(".TuNgay").val().split("/");
                var date1 = new Date(kq[1] + "/" + kq[0] + "/" + kq[2]).setHours(0, 0, 0, 0);

                kq = $(".DenNgay").val().split("/");
                var date2 = new Date(kq[1] + "/" + kq[0] + "/" + kq[2]).setHours(0, 0, 0, 0);
                if (date1.valueOf() > date2.valueOf()) {
                    notify('info', 'Ngày hết hạn đăng tin phải lớn hơn ngay đăng tin.', 'Thông báo', false);
                    $(".DenNgay").focus(); return false;
                }
            }
            if ($(".NopHS").val() == "") {
                notify('info', 'Bạn chưa nhập ngày hết hạn nộp hồ sơ.', 'Thông báo', false);
                $(".NopHS").focus(); return false;
            }
            else {
                var kq = $(".TuNgay").val().split("/");
                var date1 = new Date(kq[1] + "/" + kq[0] + "/" + kq[2]).setHours(0, 0, 0, 0);

                kq = $(".NopHS").val().split("/");
                var date2 = new Date(kq[1] + "/" + kq[0] + "/" + kq[2]).setHours(0, 0, 0, 0);
                if (date1.valueOf() > date2.valueOf()) {
                    notify('info', 'Ngày hết hạn nộp hồ sơ phải lớn hơn ngày đăng tin.', 'Thông báo', false);
                    $(".NopHS").focus(); return false;
                }
            }
            return true;
        }
        else {
            return false
        }
    };
    function setMultiple() {
        var vdata = $('#<%= HidTinhTP.ClientID%>').val(); $.each(vdata.split(','), function (index, element) {
            $('#<%= TinhTPMulti.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= TinhTPMulti.ClientID%>").trigger('selectpicker:updated');
        });
        values = $('#<%= CareerID.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=Career_ID.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=Career_ID.ClientID %>").trigger('selectpicker:updated');
        });
        values = $('#<%= HidQuanHuyen.ClientID%>').val(); $.each(values.split(','), function (index, element) {
            $("#<%=QuanHuyen.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%=QuanHuyen.ClientID %>").trigger('selectpicker:updated');
        });
    };
    function getMultiple() {
        $('#<%=HidTinhTP.ClientID%>').val($("#<%= TinhTPMulti.ClientID%>").val()); $('#<%= CareerID.ClientID%>').val($("#<%=Career_ID.ClientID %>").val()); $('#<%=HidQuanHuyen.ClientID%>').val($("#<%=QuanHuyen.ClientID %>").val());
    };
</script>

