<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Emp_BusinessEdit.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin doanh nghiệp/người tuyển dụng</h3>
        </div>
    </div>
    <div class="box-body">

        <asp:Label runat="server" ID="lblDownLoad" Style="display: none;"></asp:Label>
        <div class="main-body">
            <div class="row">
                <asp:Literal ID="lbMsg" runat="server" />
                <asp:Literal ID="lbLogo" runat="server" />
                <div class="msgError" id="msgError" runat="server"></div>
                <div class="clear"></div>
                <div class="col-md-12 lb lb-main b">1. Thông tin người sử dụng lao động</div>
                <div class="col-md-4 lb">
                    Tên doanh nghiệp/người tuyển dụng:
                  <sup class="txt-red">*</sup>

                </div>
                <div class="col-md-8 pdb0">
                    <asp:TextBox ID="Business_Vn" runat="server" CssClass="TextBox Business_Vn validate[required,minSize[10]]" />
                    <span class="required" title="Thông tin này bắt buộc không để trống"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb">
                    Chủ thể tuyển dụng<sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9 pdb0">
                    <asp:DropDownList ID="Types" Width="50px" runat="server" CssClass="selectpicker validate[required] " />
                    <span class="required"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb">
                    Mã số thuế/CMND/CCCD
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9 pdb0">
                    <asp:TextBox ID="TaxCode" runat="server" onchange="taxcode(this);" MaxLength="15" CssClass="TextBox TaxCode validate[required,minSize[10]]" />
                    <span class="required"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb">
                    Loại hình doanh nghiệp<sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9 pdb0">
                    <asp:DropDownList ID="LoaiHinh_ID" runat="server" CssClass="selectpicker validate[required] " />
                    <span class="required"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb ">
                    Địa chỉ<sup class="txt-red">*</sup>
                </div>
                <asp:UpdatePanel runat="server" ID="POP">
                    <ContentTemplate>
                        <div class="col-md-4 pdb0">
                            <asp:DropDownList ID="TinhTP" AutoPostBack="true" CssClass="selectpicker TinhTP validate[required]" runat="server" />
                            <span class="required"></span>

                        </div>
                        <div class="col-md-5 pdb0">
                            <asp:DropDownList ID="XaPhuong" CssClass="selectpicker XaPhuong  validate[required]" runat="server" />
                            <span class="required"></span>

                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    </Triggers>
                </asp:UpdatePanel>
                <div class="clear"></div>
                <div class="col-md-3 lb ">
                    Địa chỉ cụ thể<sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9 pdb0">
                    <asp:TextBox ID="Address" CssClass="TextBox Address validate[required]" runat="server" TextMode="MultiLine" Height="30px" />
                    <span class="required"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb pdt10">
                    <asp:CheckBox ID="KCN" Text="Thuộc KCN" runat="server" CssClass="Checbox dflex" />
                </div>
                <div class="col-md-9 pdb0">
                    <asp:DropDownList ID="KCN_ID" runat="server" CssClass="selectpicker  " />
                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb">
                    Điện thoại<sup class="txt-red">*</sup>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="Mobile" runat="server" CssClass="TextBox Mobile validate[required]" />
                    <span class="required"></span>

                </div>
                <div class="col-md-3  lb">
                    Email <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="Email" runat="server" CssClass="TextBox Email validate[required,custom[email]]" />
                    <span class="required"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb ">
                    Ngành kinh doanh chính<sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9">
                    <asp:DropDownList ID="Career_ID" multiple="multiple" data-actions-box="true" CssClass="nganhnghe selectpicker validate[required]" runat="server" />
                    <span class="required"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb ">
                    Mặt hàng/sản phẩm chính<sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9">
                    <asp:TextBox ID="SanPhamChinh" CssClass="TextBox validate[required,max[250]]" runat="server" />
                    <span class="required"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb ">
                    Quy mô lao động<sup class="txt-red">*</sup>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="QuyMoLaoDong" CssClass="QuyMoLaoDong selectpicker validate[required]" runat="server" />
                    <span class="required"></span>

                </div>
                <div class="col-md-4 lb">
                    Số lao động tuyển dụng 6 tháng tới
                </div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoLD6ThangToi" CssClass="SoLD6ThangToi TextBox  txt-right" runat="server" />
                </div>

                <div class="clear"></div>
                <div class="col-md-3 lb  lb-main b">
                    2. Đăng ký dịch vụ<sup class="txt-red">*</sup>
                </div>
                <div class="col-md-4">
                    <asp:DropDownList ID="DichVuDangKy" multiple="multiple" data-actions-box="true" CssClass="DichVuDangKy selectpicker validate[required]" runat="server" />
                    <span class="required"></span>
                    <asp:HiddenField ID="HidDichVuDangKy" runat="server" />
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="DichVuDangKyKhac" placeholder="Dịch vụ đăng ký khác" CssClass="DichVuDangKyKhac Textbox" runat="server" />
                </div>

                <div class="clear"></div>
                <div class="col-md-3 lb  lb-main b">
                    3. Thời gian đăng ký
                </div>
                <div class="col-md-9">
                    <asp:TextBox ID="CreatedDate" Enabled="false" ToolTip="Bạn không thể chỉnh sửa thông tin này" CssClass="CreatedDate TextBox" runat="server" />
                </div>
                <div class="col-md-12 lb  lb-main b">
                    4. Thông tin người đại diện doanh nghiệp
                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb">
                    Họ và tên<sup class="txt-red">*</sup>

                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="ContactUser" runat="server" CssClass="TextBox ContactUser validate[required]" />
                    <span class="required"></span>

                </div>
                <div class="col-md-3 lb">Chức vụ</div>
                <div class="col-md-2">
                    <asp:TextBox ID="ContactChucVu" runat="server" CssClass="TextBox ContactChucVu " />
                </div>

                <div class="col-md-3 lb">
                    Điện thoại
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9">
                    <asp:TextBox ID="ContactMobile" runat="server" CssClass="TextBox ContactMobile validate[required]" />
                    <span class="required"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-4 lb">Hình thức liên hệ khác (nếu có)</div>
                <div class="col-md-8">
                    <asp:TextBox ID="ContactLHKhac" runat="server" CssClass="TextBox ContactMobile " />
                </div>

                <div class="clear"></div>
                <div class="col-md-3 lb">Đang hoạt động</div>
                <div class="col-md-3">
                    <asp:CheckBox ID="IsApproval" CssClass="cs-select" runat="server" />
                </div>
                <div class="col-md-3 lb">Tin cậy</div>
                <div class="col-md-3">
                    <asp:CheckBox ID="IsTinCay" CssClass="cs-select" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <h3 class="box-title mgt0">Thông tin vị trí trên bản đồ</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    <div class="col-md-4 lb">Lat</div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtLat" runat="server" CssClass="TextBox " />
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="col-md-3  lb">Lng </div>
                    <div class="col-md-9 pdt5">
                        <asp:TextBox ID="txtLng" runat="server" CssClass="TextBox " />
                    </div>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Literal ID="LitDN" runat="server"></asp:Literal>
                    <%--<h3 class="box-title mgt0">Danh sách tài khoản quản trị doanh nghiệp</h3>--%>
                </div>
            </div>
            <div class="row">
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
                        <asp:TemplateColumn HeaderText="Tài khoản quản trị" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:DropDownList ID="UserAdmin" runat="server" CssClass="selectpicker" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Ngày đăng ký" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="CreatedDate" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="15%" HorizontalAlign="Center" />
                            <ItemStyle Width="15%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Ngày duyệt" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:Literal ID="ApprovalDate" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="15%" HorizontalAlign="Center" />
                            <ItemStyle Width="15%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Quản trị" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <asp:RadioButton runat="server" onclick="javascript:CheckOtherIsCheckedByGVID(this);" ID="IsAdmin" CssClass="CheckBox" />
                            </ItemTemplate>
                            <HeaderStyle Width="8%" HorizontalAlign="Center" />
                            <ItemStyle Width="8%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Duyệt" HeaderStyle-CssClass="hdTitle">
                            <ItemTemplate>
                                <%--   <asp:Literal ID="IsActive" runat="server" />
                                <asp:TextBox ID="Duyet" runat="server"></asp:TextBox>--%>
                                <asp:CheckBox runat="server" ID="IsActive" CssClass="CheckBox" />
                            </ItemTemplate>
                            <HeaderStyle Width="8%" HorizontalAlign="Center" />
                            <ItemStyle Width="8%" HorizontalAlign="Center" />
                        </asp:TemplateColumn>
                    </Columns>
                </asp:DataGrid>
            </div>
            <div class="clr clUp "></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <asp:HiddenField ID="ItemID" runat="server" Visible="true" />
        <asp:HiddenField ID="HF_ID" runat="server" Visible="true" />
        <asp:HiddenField ID="HF_CreatedDate" runat="server" Visible="true" />
        <asp:HiddenField ID="IsSuper" runat="server" Visible="false" />
        <asp:HiddenField ID="valError" runat="server" />
        <asp:HiddenField ID="CareerID" runat="server" />
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="getMultiple();return checkinput(); " />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel" OnClientClick="$('#Form').validationEngine('detach');" />
        <asp:LinkButton ID="cmdNewWork" runat="server" ToolTip="Thêm mới tin tuyển dụng cho doanh nghiệp này" Text="Tạo tin tuyển dụng" Visible="false" CssClass="cmsbut cmdNew" />
        <asp:Button ID="cmdExTT11" Visible="false" runat="server" Text="Xuất theo TT11" CssClass="cmsbut cmdexcel" OnClientClick="$('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdExND23" OnClick="cmdExND23_Click" runat="server" Text="Xuất dữ liệu" CssClass="cmsbut cmdword" OnClientClick="$('#Form').validationEngine('detach');" />
    </div>
</div>
<script type="text/javascript">
    function setMultiple() {

        var vdata = $('#<%= CareerID.ClientID%>').val(); $.each(vdata.split(','), function (index, element) {
                $('#<%= Career_ID.ClientID%>').find('option[value="' + element + '"]').attr('selected', 'selected');
            $("#<%= Career_ID.ClientID%>").trigger('selectpicker:updated');
        });
            var values = $('#<%= HidDichVuDangKy.ClientID%>').val(); $.each(values.split(','), function (index, element) {
                $("#<%=DichVuDangKy.ClientID %>").find('option[value="' + element + '"]').attr('selected', 'selected');
             $("#<%=DichVuDangKy.ClientID %>").trigger('selectpicker:updated');
         });

    };
    function getMultiple() {
        $('#<%= CareerID.ClientID%>').val($("#<%= Career_ID.ClientID%>").val());
        $('#<%= HidDichVuDangKy.ClientID%>').val($("#<%=DichVuDangKy.ClientID %>").val());
    };
    function CheckOtherIsCheckedByGVID(rb) {
        var isChecked = rb.checked;
        var row = rb.parentNode.parentNode;

        var currentRdbID = rb.id;
        parent = document.getElementById("<%= grdData.ClientID %>");
        var items = parent.getElementsByTagName('input');

        for (i = 0; i < items.length; i++) {
            if (items[i].id != currentRdbID && items[i].type == "radio") {
                if (items[i].checked) {
                    items[i].checked = false;
                }
            }
        }
    }
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

                        $('.list-img img').remove();
                        $('.list-img').append('<img class="imgDd" src="<%=EPORTAL.flConnect.fileDomain%>' + result + '?dpi=150&quality=100&w=165&h=130" />');
                        $(".delimages").css("display", "block");
                        $(".IdKey").html();
                    }
                };
            }
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=img&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
    function taxcode(t) {
        $(".msgError").html(""); $("#<%=valError.ClientID %>").val(""); $.ajax({
            type: "GET", url: '/api/work/check.asmx/checkcode?&id=' + $("#<%=ItemID.ClientID %>").val() + '&pid=<%= Me.PortalId  %>&code=' + $(t).val(), success: function (data) {
                var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                    if (json.data == "DONE") {
                        $(".msgError").html("Bạn có thể sử dụng mã này."); $("#<%=valError.ClientID %>").val("DONE");
                    } else {
                        $(".msgError").html(json.data); $("#<%=valError.ClientID %>").val("ERROR");
                    }
                };
            },
        });
    };
    function checkinput() {
        var tcode = $(".TaxCode").val(); tcode = tcode.replace(/\s/g, '');
        if (tcode.length < 10) {
            $(".TaxCode").val(tcode); $('#Form').validationEngine('validate');
            notify('info', 'Mã số doanh nghiệp không hợp lệ! <i style="color:yellow"><br/>Lưu ý: MST không bao gồm các ký tự trống, vui lòng kiểm tra lại!</i>', 'Thông báo', false);
            return false;
        }
        else { return $('#Form').validationEngine('validate'); }
    };
    function activeAdmin(d, t) {
        var cs = $(t).attr("cs"); var id = $(t).attr("id"); var link = "/api/work/unlock.ashx?uid=" + id + "&a=" + d + "&p=<%=Me.PortalId%>"; var msg = $.ajax({ url: link, async: false }).responseText;
        if (d == "1") {//Active
            $(".cs_" + cs).val('True'); $(t).attr('src', '/image/images/select.png');
            $(t).attr("onclick", "waiting();activeAdmin(0,this);"); $(t).parent("td").parent("tr").removeClass("red");
            notify('success', 'Đã duyệt tài khoản thành công!.', 'Thông báo', false); removewaiting()
            location.reload();
        }
        else {//UnActive
            $(".cs_" + cs).val('False'); $(t).attr('src', '/image/images/unselect.png');
            $(t).attr("onclick", "waiting();activeAdmin(1,this);"); $(t).parent("td").parent("tr").addClass("red");
            notify('info', 'Đã hủy duyệt tài khoản thành công!.', 'Thông báo', false); removewaiting();
        }
    };
    function isAdmin(t) {
        waiting();
        $(".quantri").attr('src', '/image/images/unRadio.png'); $(".quantri").attr("onclick", "waiting();isAdmin(this);");
        var id = $(t).attr("id"); var buid = $("#<%=ItemID.ClientID %>").val();
        var link = "/api/work/unAdmin.ashx?uid=" + id + "&buid=" + buid + "&p=<%=Me.PortalId%>"; var msg = $.ajax({ url: link, async: false }).responseText;
        $(t).attr('src', '/image/images/Radio.png'); $(t).attr("onclick", "waiting();isAdmin(0,this);");
        notify('success', 'Đã thiết lập tài khoản quản trị khoản thành công!.', 'Thông báo', false); removewaiting();
    };
</script>
