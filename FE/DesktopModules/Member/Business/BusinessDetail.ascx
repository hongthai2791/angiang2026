<%@ Control Language="vb" AutoEventWireup="true" CodeFile="BusinessDetail.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<div class="box box-info ">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thông tin doanh nghiệp/người tuyển dụng</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <asp:Literal ID="lbMsg" runat="server" />
                <asp:Literal ID="lbLogo" runat="server" />
                <%--<div class="msgError" id="msgError" runat="server"></div>--%>
                <div class="clear"></div>
                <div class="col-md-12 lb  lb-main b">1. Thông tin người sử dụng lao động</div>
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
                    Chủ thể tuyển dụng
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9 pdb0">
                    <asp:DropDownList ID="Types" Width="50px" runat="server" CssClass="selectpicker validate[required] " />
                   <span class="required" title="Thông tin này bắt buộc không để trống"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb">
                    Mã số thuế/CMND/CCCD
                    
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9 pdb0">
                    <asp:TextBox ID="TaxCode" runat="server" onchange="taxcode(this);" MaxLength="15" CssClass="TextBox TaxCode validate[required,minSize[10]]" />
                     <span class="required" title="Thông tin này bắt buộc không để trống"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb">
                    Loại hình doanh nghiệp
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9 pdb0">
                    <asp:DropDownList ID="LoaiHinh_ID" runat="server" CssClass="selectpicker validate[required] " />
                     <span class="required" title="Thông tin này bắt buộc không để trống"></span>

                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb ">
                    Địa chỉ
                    <sup class="txt-red">*</sup>
                </div>
                <asp:UpdatePanel runat="server" ID="POP">
                    <ContentTemplate>
                        <div class="col-md-6 pdb0">
                            <asp:DropDownList ID="TinhTP" AutoPostBack="true" CssClass="selectpicker TinhTP validate[required]" runat="server" />
                    <span class="required" title="Thông tin này bắt buộc không để trống"></span>

                        </div>
                        <div class="col-md-6 pdb0">
                            <asp:DropDownList ID="XaPhuong" CssClass="selectpicker XaPhuong validate[required]" runat="server" />
                              <span class="required" title="Thông tin này bắt buộc không để trống"></span>
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                    </Triggers>
                </asp:UpdatePanel>
                <div class="clear"></div>
                <div class="col-md-3 lb ">
                    Địa chỉ cụ thể
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9 pdb0">
                    <asp:TextBox ID="Address" CssClass="TextBox Address validate[required]" runat="server" TextMode="MultiLine" Height="30px" />
                      <span class="required" title="Thông tin này bắt buộc không để trống"></span>
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
                    Điện thoại
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="Mobile" runat="server" CssClass="TextBox Mobile validate[required]" />
                      <span class="required" title="Thông tin này bắt buộc không để trống"></span>
                </div>
                <div class="col-md-3  lb">
                    Email 
                    <sup class="txt-red">*</sup>
                        <span class="required"></span>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="Email" runat="server" CssClass="TextBox Email validate[required,custom[email]]" />
                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb ">
                    Ngành kinh doanh chính
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9">
                    <asp:DropDownList ID="Career_ID" multiple="multiple" data-actions-box="true" CssClass="nganhnghe selectpicker validate[required]" runat="server" />
                      <span class="required" title="Thông tin này bắt buộc không để trống"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb ">
                    Mặt hàng/sản phẩm chính
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-9">
                    <asp:TextBox ID="SanPhamChinh" CssClass="TextBox validate[required,max[250]]" runat="server" />
                      <span class="required" title="Thông tin này bắt buộc không để trống"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-3 lb ">
                    Quy mô lao động
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList ID="QuyMoLaoDong" CssClass="QuyMoLaoDong selectpicker validate[required]" runat="server" />
                      <span class="required" title="Thông tin này bắt buộc không để trống"></span>
                </div>
                <div class="col-md-4 lb">
                    Số lao động tuyển dụng 6 tháng tới
                </div>
                <div class="col-md-2">
                    <asp:TextBox ID="SoLD6ThangToi" CssClass="SoLD6ThangToi TextBox  txt-right" runat="server" />
                </div>

                <div class="clear"></div>
                <div class="col-md-3 lb  lb-main b">
                    2. Đăng ký dịch vụ
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-4">
                    <asp:DropDownList ID="DichVuDangKy" CssClass="DichVuDangKy selectpicker validate[required]" runat="server" />
                      <span class="required" title="Thông tin này bắt buộc không để trống"></span>
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
                    Họ và tên
                    
                    <sup class="txt-red">*</sup>
                </div>
                <div class="col-md-4">
                    <asp:TextBox ID="ContactUser" runat="server" CssClass="TextBox ContactUser validate[required]" />
                      <span class="required" title="Thông tin này bắt buộc không để trống"></span>
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
                      <span class="required" title="Thông tin này bắt buộc không để trống"></span>
                </div>
                <div class="clear"></div>
                <div class="col-md-4 lb">Hình thức liên hệ khác (nếu có)</div>
                <div class="col-md-8">
                    <asp:TextBox ID="ContactLHKhac" runat="server" CssClass="TextBox ContactMobile " />
                </div>
            </div>

            <div class="clr clUp "></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <asp:UpdatePanel ID="pageView" runat="server">
            <ContentTemplate>
                <asp:HiddenField ID="_PortalID" runat="server" />
                <asp:HiddenField ID="DoanhNghiepID" runat="server" />
                <asp:HiddenField ID="ItemID" runat="server" />
                <asp:HiddenField ID="CareerID" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</div>
<div class="none">
    <asp:CheckBox ID="uIsActive" CssClass="cs-select" Enabled="false" runat="server" />
</div>
<div class="row text-center pd10">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate" OnClientClick="getMultiple();return checkinput(); " />
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
    function clearinput() {
        $(".Business_Vn").val(""); $(".Business_Vn").removeAttr("readonly");
        $(".NguoiNopEmail").val(""); $(".NguoiNopEmail").removeAttr("readonly");
        $(".Business_En").val(""); $(".Business_En").removeAttr("readonly");
        $(".Business_Sort").val(""); $(".Business_Sort").removeAttr("readonly");
        $(".Description").val(""); $(".Description").removeAttr("readonly");
        $(".TinhTP").val("").change(); $(".TinhTP").removeAttr("readonly");
        $(".QuanHuyen").val("").change(); $(".QuanHuyen").removeAttr("readonly");
        $(".Scale").val(""); $(".Scale").removeAttr("readonly");
        $(".Fax").val(""); $(".Fax").removeAttr("readonly");
        $(".Website").val(""); $(".Website").removeAttr("readonly");
        var checkBox = document.getElementById("IsApproval");
    };
    function taxcode(t) {
        var pid = "<%= Me.PortalId  %>"; $("#<%=DoanhNghiepID.ClientID %>").val(""); $("#<%=_PortalID.ClientID %>").val("0"); clearinput();
        $.ajax({
            type: "POST", url: '/api/work/check.asmx/taxcode',
            data: { id: $("#<%=ItemID.ClientID %>").val(), pid: pid, code: $(t).val() },
            success: function (res) {
                if (res.data == "error") { clearinput(); }
                else {
                    $("#<%=DoanhNghiepID.ClientID %>").val(res.data['0'].business_ID);
                     $("#<%=_PortalID.ClientID %>").val(res.data['0'].portalID);

                     $(".Business_Vn").val(res.data['0'].business_Vn);
                     $(".Business_Vn").attr("readonly", "readonly");

                     $(".NguoiNopEmail").val(res.data['0'].nguoiNopEmail);
                     $(".NguoiNopEmail").attr("readonly", "readonly");

                     $(".Business_En").val(res.data['0'].business_En);
                     $(".Business_En").attr("readonly", "readonly");

                     $(".Business_Sort").val(res.data['0'].business_Sort);
                     $(".Business_Sort").attr("readonly", "readonly");

                     $(".Address").val(res.data['0'].address);
                     $(".Address").attr("readonly", "readonly");

                     $(".Description").val(res.data['0'].description);
                     $(".Description").attr("readonly", "readonly");

                     $(".Mobile").val(res.data['0'].mobile);
                     $(".Mobile").attr("readonly", "readonly");

                     $(".Email").val(res.data['0'].email);
                     $(".Email").attr("readonly", "readonly");

                     $(".TinhTP").val(res.data['0'].tinhTP).change();
                     $(".TinhTP").attr("readonly", "readonly");

                     $(".QuanHuyen").val(res.data['0'].quanHuyen).change();
                     $(".QuanHuyen").attr("readonly", "readonly");

                     $(".Scale").val(res.data['0'].scale);
                     $(".Scale").attr("readonly", "readonly");

                     $(".Fax").val(res.data['0'].fax);
                     $(".Fax").attr("readonly", "readonly");

                     $(".Website").val(res.data['0'].website);
                     $(".Website").attr("readonly", "readonly");

                     $(".ContactUser").val(res.data['0'].contactUser);
                     $(".ContactUser").attr("readonly", "readonly");

                     $(".ContactMobile").val(res.data['0'].contactMobile);
                     $(".ContactMobile").attr("readonly", "readonly");

                     $(".ContactEmail").val(res.data['0'].contactEmail);
                     $(".ContactEmail").attr("readonly", "readonly");

                     var checkBox = document.getElementById("IsApproval");
                     checkBox.checked = res.data['0'].isApproval;

                     checkBox = document.getElementById("IsTop");
                     checkBox.checked = res.data['0'].isTop;

                     checkBox = document.getElementById("IsRep");
                     checkBox.checked = res.data['0'].isRep;

                     if (res.data['0'].contactEmail == "") { $(".ContactEmail").val("<%=Me.UserInfo.Email %>"); }
                }
            }
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

</script>
