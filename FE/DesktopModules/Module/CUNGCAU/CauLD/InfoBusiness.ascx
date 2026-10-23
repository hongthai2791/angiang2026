<%@ Control Language="vb" AutoEventWireup="true" CodeFile="InfoBusiness.ascx.vb" Inherits="Modules.EPORTAL.View" %>

<div class="box box-info content-pks box-infoHo">
    <div class="box-header with-border ">
        <div class="col-md-8">
            <h3 class="box-title">Thông tin nhu cầu tuyển dụng lao động của người sử dụng lao động</h3>
        </div>
        <div class="col-md-1 txt-right pdt5">
            Kỳ nhập liệu
        </div>
        <div class="col-md-1">
            <asp:TextBox ID="KyNhapLieu" ReadOnly="true" runat="server" CssClass="TextBox txt-center" />
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtkey" runat="server" placeholder="Nhập Mã số ĐKKD để tìm kiếm ..." CssClass="timKiemD" Columns="20" Width="100%" />
            <asp:LinkButton ID="cmdSearch" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-12">
                <asp:UpdatePanel runat="server" ID="p">
                    <ContentTemplate>
                        <div class="col-md-12 lb bold">1. Thông tin người sử dụng lao động</div>
                        <div class="col-md-3 lb">Tên người sử dụng lao động</div>
                        <div class="col-md-9">
                            <asp:TextBox ID="TenDoanhNghiep" onkeypress="return keydownfocus(event,'TaxCode',0);" runat="server" CssClass="TextBox std med TenDoanhNghiep validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-4 lb none">Mã doanh nghiệp</div>
                        <div class="col-md-3 none">
                            <asp:TextBox ID="MaDoanhNghiep" onkeypress="return keydownfocus(event,'TaxCode',0);" runat="server" CssClass="TextBox std med center timKiemD bold MaDoanhNghiep validate[required]" />
                            <asp:LinkButton ID="cmdMDN" Visible="false" runat="server" CausesValidation="False" CssClass="btTkiemD cs cbclick" />
                            <span class="required"></span>
                        </div>
                        <div class="col-md-3 lb ">Mã số ĐKKD/MST/CCCD/CMND</div>
                        <div class="col-md-9">
                            <asp:TextBox ID="TaxCode" onkeypress="return keydownfocus(event,'LoaiHinh_ID',0);" runat="server" CssClass="TextBox std med TaxCode validate[required,custom[number]]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 lb">Loại hình</div>
                        <div class="col-md-10">
                            <asp:DropDownList ID="LoaiHinh_ID" inext="Mobile" runat="server" CssClass="selectpicker LoaiHinh_ID validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 lb ">Địa chỉ: Tỉnh/TP</div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="TinhTP" inext="XaPhuong" AutoPostBack="true" runat="server" CssClass="selectpicker TinhTP validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="col-md-2 lb center">Xã/Phường</div>
                        <div class="col-md-2">
                            <asp:DropDownList ID="XaPhuong" inext="SoNha" runat="server" CssClass="selectpicker XaPhuong validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 lb">Địa chỉ cụ thể</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="SoNha" runat="server" CssClass="TextBox std med SoNha" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-4 lb none ">- Tình trạng hoạt động</div>
                        <div class="col-md-3 none">
                            <asp:DropDownList ID="TinhTrang" inext="TinhTP" runat="server" CssClass="selectpicker TinhTrang validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 lb">Khu công nghiệp/KKT</div>
                        <div class="col-md-10">
                            <asp:DropDownList ID="KhuCN_ID" inext="LoaiHinh_ID" runat="server" CssClass="selectpicker KhuCN_ID" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 lb">Số điện thoại</div>
                        <div class="col-md-4">
                            <asp:TextBox ID="Mobile" onkeypress="return keydownfocus(event,'Email',0);" runat="server" CssClass="TextBox std med Mobile validate[custom[number]]" />
                        </div>
                        <div class="col-md-2 lb center">Email</div>
                        <div class="col-md-4">
                            <asp:TextBox ID="Email" onkeypress="return keydownfocus(event,'TinhTP',0);" runat="server" CssClass="TextBox std med Email validate[custom[email]]" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-3 lb">Ngành sản xuất - kinh doanh chính</div>
                        <div class="col-md-9">
                            <asp:DropDownList ID="NganhNghe" inext="SanPhamChinh" runat="server" CssClass="selectpicker NganhNghe validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-3 lb">Mặt hàng/sản phẩm dịch vụ chính</div>
                        <div class="col-md-9">
                            <asp:TextBox ID="SanPhamChinh" onkeypress="return keydownfocus(event,'QuyMoLaoDong',0);" runat="server" CssClass="TextBox std med SanPhamChinh" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-3 lb bold">2. Quy mô lao động (người)</div>
                        <div class="col-md-9">
                            <asp:DropDownList ID="QuyMoLaoDong" inext="LD_TongSo" runat="server" CssClass="selectpicker QuyMoLaoDong validate[required]" />
                            <span class="required"></span>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-4 lb ">3. Tổng số lao động (người)</div>
                        <div class="col-md-2  ">
                            <asp:TextBox type="number" ID="LD_TongSo" onkeypress="return keydownfocus(event,'LD_Nu',0);" runat="server" CssClass="txt-center LD_TongSo TextBox std med validate[custom[integer,min[0]]]" />
                        </div>
                        <div class="col-md-4 lb center ">- Lao động nữ (người)</div>
                        <div class="col-md-2 ">
                            <asp:TextBox type="number" ID="LD_Nu" runat="server" onkeypress="return keydownfocus(event,'LD_HD_Tong',0);" CssClass="txt-center TextBox std med validate[custom[integer,min[0]]]" />
                        </div>
                        <div class="col-md-12 lb none">8. Số lao động theo nhóm nghề:</div>
                        <div class="col-md-12 none">
                            <table class="ta02" cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                                <tbody>
                                    <tr style="background: #ffcfb7">
                                        <td style="width: 10%; text-align: center">Mã nghề cấp 2</td>
                                        <td style="width: 50%; text-align: center">Tên gọi nghề nghiệp</td>
                                        <td style="width: 20%; text-align: center">Số lượng</td>
                                        <td style="width: 20%; text-align: center">Trong đó: Nữ</td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">72</td>
                                        <td style="line-height: 20px">Thợ luyện kim, cơ khí và thợ có liên quan</td>
                                        <td>
                                            <asp:TextBox ID="C8_72" onkeypress="return keydownfocus(event,'C8_72_Nu',0);" runat="server" CssClass="txt-center C8_72 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_72_Nu" onkeypress="return keydownfocus(event,'C8_73',0);" runat="server" CssClass="txt-center C8_72_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">73</td>
                                        <td style="line-height: 20px">Thợ thủ công và thợ liên quan đến in</td>
                                        <td>
                                            <asp:TextBox ID="C8_73" onkeypress="return keydownfocus(event,'C8_73_Nu',0);" runat="server" CssClass="txt-center C8_73 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_73_Nu" onkeypress="return keydownfocus(event,'C8_74',0);" runat="server" CssClass="txt-center C8_73_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">74</td>
                                        <td style="line-height: 20px">Thợ điện và thợ điện tử</td>
                                        <td>
                                            <asp:TextBox ID="C8_74" onkeypress="return keydownfocus(event,'C8_74_Nu',0);" runat="server" CssClass="txt-center C8_74 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_74_Nu" onkeypress="return keydownfocus(event,'C8_75',0);" runat="server" CssClass="txt-center C8_74_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">75</td>
                                        <td style="line-height: 20px">Thợ chế biến thực phẩm, gia công gỗ, may mặc, đồ thủ công và thợ có liên quan khác</td>
                                        <td>
                                            <asp:TextBox ID="C8_75" onkeypress="return keydownfocus(event,'C8_75_Nu',0);" runat="server" CssClass="txt-center C8_75 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_75_Nu" onkeypress="return keydownfocus(event,'C8_81',0);" runat="server" CssClass="txt-center C8_75_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">81</td>
                                        <td style="line-height: 20px">Thợ vận hành máy móc và thiết bị</td>
                                        <td>
                                            <asp:TextBox ID="C8_81" onkeypress="return keydownfocus(event,'C8_81_Nu',0);" runat="server" CssClass="txt-center C8_81 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_81_Nu" onkeypress="return keydownfocus(event,'C8_82',0);" runat="server" CssClass="txt-center C8_81_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">82</td>
                                        <td style="line-height: 20px">Thợ lắp ráp</td>
                                        <td>
                                            <asp:TextBox ID="C8_82" onkeypress="return keydownfocus(event,'C8_82_Nu',0);" runat="server" CssClass="txt-center C8_82 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_82_Nu" onkeypress="return keydownfocus(event,'C8_83',0);" runat="server" CssClass="txt-center C8_82_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">83</td>
                                        <td style="line-height: 20px">Lái xe và thợ vận hành thiết bị chuyển động</td>
                                        <td>
                                            <asp:TextBox ID="C8_83" onkeypress="return keydownfocus(event,'C8_83_Nu',0);" runat="server" CssClass="txt-center C8_83 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_83_Nu" onkeypress="return keydownfocus(event,'C8_91',0);" runat="server" CssClass="txt-center C8_83_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">91</td>
                                        <td style="line-height: 20px">Người quét dọn và giúp việc</td>
                                        <td>
                                            <asp:TextBox ID="C8_91" onkeypress="return keydownfocus(event,'C8_91_Nu',0);" runat="server" CssClass="txt-center C8_91 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_91_Nu" onkeypress="return keydownfocus(event,'C8_92',0);" runat="server" CssClass="txt-center C8_91_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">92</td>
                                        <td style="line-height: 20px">Lao động giản đơn trong NN, lâm nghiệp và thủy sản</td>
                                        <td>
                                            <asp:TextBox ID="C8_92" onkeypress="return keydownfocus(event,'C8_92_Nu',0);" runat="server" CssClass="txt-center C8_92 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_92_Nu" onkeypress="return keydownfocus(event,'C8_93',0);" runat="server" CssClass="txt-center C8_92_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">93</td>
                                        <td style="line-height: 20px">Lao động trong ngành khai khoáng, xây dựng, công nghiệp chế biến, chế tạo và giao thông vận tải</td>
                                        <td>
                                            <asp:TextBox ID="C8_93" onkeypress="return keydownfocus(event,'C8_93_Nu',0);" runat="server" CssClass="txt-center C8_93 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_93_Nu" onkeypress="return keydownfocus(event,'C8_94',0);" runat="server" CssClass="txt-center C8_93_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">94</td>
                                        <td style="line-height: 20px">Người phụ giúp chuẩn bị thực phẩm</td>
                                        <td>
                                            <asp:TextBox ID="C8_94" onkeypress="return keydownfocus(event,'C8_94_Nu',0);" runat="server" CssClass="txt-center C8_94 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_94_Nu" onkeypress="return keydownfocus(event,'C8_95',0);" runat="server" CssClass="txt-center C8_94_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">95</td>
                                        <td style="line-height: 20px">Lao động trên đường phố và lao động có liên quan đến bán hàng</td>
                                        <td>
                                            <asp:TextBox ID="C8_95" onkeypress="return keydownfocus(event,'C8_95_Nu',0);" runat="server" CssClass="txt-center C8_95 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_95_Nu" onkeypress="return keydownfocus(event,'C8_96',0);" runat="server" CssClass="txt-center C8_95_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">96</td>
                                        <td style="line-height: 20px">Người thu dọn vật thải và lao động giản đơn khác</td>
                                        <td>
                                            <asp:TextBox ID="C8_96" onkeypress="return keydownfocus(event,'C8_96_Nu',0);" runat="server" CssClass="txt-center C8_96 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_96_Nu" onkeypress="return keydownfocus(event,'TL_BinhQuan',0);" runat="server" CssClass="txt-center C8_96_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-12 lb ">3.1 Số lao động theo loại lao động:</div>
                        <div class="col-md-12 ">
                            <table class="ta02" cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                                <tbody>
                                    <tr style="background: #ffcfb7">
                                        <td style="width: 60%; text-align: center">Chia theo loại lao động</td>
                                        <td style="width: 20%; text-align: center">Số lượng</td>
                                        <td style="width: 20%; text-align: center">Trong đó: Nữ</td>
                                    </tr>
                                    <tr style="display:none">
                                        <td style="padding-left: 15px!important; line-height: 20px">- Số lao động ngoại tỉnh
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_NgoaiTinh" onkeypress="return keydownfocus(event,'LD_NgoaiTinh_Nu',0);" runat="server" CssClass="txt-center LD_NgoaiTinh TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_NgoaiTinh_Nu" onkeypress="return keydownfocus(event,'LD_TrucTiep',0);" runat="server" CssClass="txt-center LD_NgoaiTinh_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr style="display:none">
                                        <td style="padding-left: 15px!important; line-height: 20px">- Số lao động trực tiếp
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_TrucTiep" onkeypress="return keydownfocus(event,'LD_TrucTiep_Nu',0);" runat="server" CssClass="txt-center LD_TrucTiep TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_TrucTiep_Nu" onkeypress="return keydownfocus(event,'LD_GianTiep',0);" runat="server" CssClass="txt-center LD_TrucTiep_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr style="display:none">
                                        <td style="padding-left: 15px!important; line-height: 20px">- Số lao động gián tiếp
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_GianTiep" onkeypress="return keydownfocus(event,'LD_GianTiep_Nu',0);" runat="server" CssClass="txt-center LD_GianTiep TextBox std med validate[custom[integer,min[0]]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_GianTiep_Nu" onkeypress="return keydownfocus(event,'LD_HD_Tong',0);" runat="server" CssClass="txt-center LD_GianTiep_Nu TextBox std med validate[custom[integer,min[0]]]" />
                                        </td>
                                    </tr>
                                    <tr style="display:none">
                                        <td style="padding-left: 15px!important; line-height: 20px">- Số lao động đã ký hợp đồng
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_HD_Tong" onkeypress="return keydownfocus(event,'LD_HD_Nu',0);" runat="server" CssClass="txt-center LD_HD_Tong TextBox std med validate[custom[integer,min[0]]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_HD_Nu" onkeypress="return keydownfocus(event,'LD_BHXH',0);" runat="server" CssClass="txt-center LD_HD_Nu TextBox std med validate[custom[integer,min[0]]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Số lao động tham gia BHXH bắt buộc
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_BHXH" onkeypress="return keydownfocus(event,'LD_BHXH_Nu',0);" runat="server" CssClass="txt-center LD_BHXH TextBox std med validate[custom[integer,min[0]]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_BHXH_Nu" onkeypress="return keydownfocus(event,'LD_TREN35',0);" runat="server" CssClass="txt-center LD_BHXH_Nu TextBox std med validate[custom[integer,min[0]]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Số lao động trên 35 tuổi
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_TREN35" onkeypress="return keydownfocus(event,'LD_TREN35_Nu',0);" runat="server" CssClass="txt-center LD_TREN35 TextBox std med validate[custom[integer,min[0]]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="LD_TREN35_Nu" onkeypress="return keydownfocus(event,'LD_NuocNgoai_Tong',0);" runat="server" CssClass="txt-center LD_TREN35_Nu TextBox std med validate[custom[integer,min[0]]]" />
                                        </td>
                                    </tr>
                                    <tr style="display:none">
                                        <td style="padding-left: 15px!important; line-height: 20px">- Số lao động là người nước ngoài
                                        </td>
                                        <td>
                                            <asp:TextBox ID="LD_NuocNgoai_Tong" onkeypress="return keydownfocus(event,'LD_NuocNgoai_Nu',0);" runat="server" CssClass="txt-center LD_NuocNgoai_Tong TextBox std med validate[custom[integer,min[0]]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="LD_NuocNgoai_Nu" onkeypress="return keydownfocus(event,'LD_PhoThong',0);" runat="server" CssClass="txt-center LD_NuocNgoai_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr style="display:none">
                                        <td style="padding-left: 15px!important; line-height: 20px">- Số lao động đã tốt nghiệp phổ thông
                                        </td>
                                        <td>
                                            <asp:TextBox ID="LD_PhoThong" onkeypress="return keydownfocus(event,'LD_PhoThong_Nu',0);" runat="server" CssClass="txt-center LD_PhoThong TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="LD_PhoThong_Nu" onkeypress="return keydownfocus(event,'VT_NhaQuanLy',0);" runat="server" CssClass="txt-center LD_PhoThong_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>

                                </tbody>
                            </table>
                        </div>

                        <div class="col-md-12 lb ">3.2 Số lao động theo vị trí việc làm:</div>
                        <div class="col-md-12 ">
                            <table class="ta02" cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                                <tbody>
                                    <tr style="background: #ffcfb7">
                                        <td style="width: 60%; text-align: center">Chia theo vị trí việc làm</td>
                                        <td style="width: 20%; text-align: center">Số lượng</td>
                                        <td style="width: 20%; text-align: center">Trong đó: Nữ</td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Nhà quản lý
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="VT_NhaQuanLy" onkeypress="return keydownfocus(event,'VT_NhaQuanLy_Nu',0);" runat="server" CssClass="txt-center VT_NhaQuanLy TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="VT_NhaQuanLy_Nu" onkeypress="return keydownfocus(event,'VT_CMKT_Cao',0);" runat="server" CssClass="txt-center VT_NhaQuanLy_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Chuyên môn kỹ thuật bậc cao
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="VT_CMKT_Cao" onkeypress="return keydownfocus(event,'VT_CMKT_Cao_Nu',0);" runat="server" CssClass="txt-center VT_CMKT_Cao TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="VT_CMKT_Cao_Nu" onkeypress="return keydownfocus(event,'VT_CMKT_Trung',0);" runat="server" CssClass="txt-center VT_CMKT_Cao_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Chuyên môn kỹ thuật bậc trung
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="VT_CMKT_Trung" onkeypress="return keydownfocus(event,'VT_CMKT_Trung_Nu',0);" runat="server" CssClass="txt-center VT_CMKT_Trung TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="VT_CMKT_Trung_Nu" onkeypress="return keydownfocus(event,'VT_CMKT_Khac',0);" runat="server" CssClass="txt-center VT_CMKT_Trung_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Khác
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="VT_CMKT_Khac" onkeypress="return keydownfocus(event,'VT_CMKT_Khac_Nu',0);" runat="server" CssClass="txt-center VT_CMKT_Khac TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox type="number" ID="VT_CMKT_Khac_Nu" onkeypress="return keydownfocus(event,'CMKT_Khong',0);" runat="server" CssClass="txt-center VT_CMKT_Khac_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>

                        <div class="col-md-12 lb none">6. Số lao động theo trình độ chuyên môn kỹ thuật:</div>
                        <div class="col-md-12 none">
                            <table class="ta02" cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                                <tbody>
                                    <tr style="background: #ffcfb7">
                                        <td style="width: 60%; text-align: center">Trình độ chuyên môn kỹ thuật</td>
                                        <td style="width: 20%; text-align: center">Số lượng</td>
                                        <td style="width: 20%; text-align: center">Trong đó: Nữ</td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Không có trình độ chuyên môn kỹ thuật
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_Khong" onkeypress="return keydownfocus(event,'CMKT_Khong_Nu',0);" runat="server" CssClass="txt-center CMKT_Khong TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_Khong_Nu" onkeypress="return keydownfocus(event,'CMKT_BangCap',0);" runat="server" CssClass="txt-center CMKT_Khong_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Công nhân kỹ thuật không bằng/ chứng chỉ
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_BangCap" onkeypress="return keydownfocus(event,'CMKT_BangCap_Nu',0);" runat="server" CssClass="txt-center CMKT_BangCap TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_BangCap_Nu" onkeypress="return keydownfocus(event,'CMKT_DaoTao',0);" runat="server" CssClass="txt-center CMKT_BangCap_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Đào tạo thường xuyên
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_DaoTao" onkeypress="return keydownfocus(event,'CMKT_DaoTao_Nu',0);" runat="server" CssClass="txt-center CMKT_DaoTao TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_DaoTao_Nu" onkeypress="return keydownfocus(event,'CMKT_SoCap',0);" runat="server" CssClass="txt-center CMKT_DaoTao_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Sơ cấp nghề
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_SoCap" onkeypress="return keydownfocus(event,'CMKT_SoCap_Nu',0);" runat="server" CssClass="txt-center TextBox std med CMKT_SoCap validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_SoCap_Nu" onkeypress="return keydownfocus(event,'CMKT_TrungCap',0);" runat="server" CssClass="txt-center CMKT_SoCap_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Trung cấp
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_TrungCap" onkeypress="return keydownfocus(event,'CMKT_TrungCap_Nu',0);" runat="server" CssClass="txt-center CMKT_TrungCap TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_TrungCap_Nu" onkeypress="return keydownfocus(event,'CMKT_CaoDang',0);" runat="server" CssClass="txt-center CMKT_TrungCap_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Cao đẳng
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_CaoDang" onkeypress="return keydownfocus(event,'CMKT_CaoDang_Nu',0);" runat="server" CssClass="txt-center CMKT_CaoDang TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_CaoDang_Nu" onkeypress="return keydownfocus(event,'CMKT_DaiHoc',0);" runat="server" CssClass="txt-center CMKT_CaoDang_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Đại học trở lên
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_DaiHoc" onkeypress="return keydownfocus(event,'CMKT_DaiHoc_Nu',0);" runat="server" CssClass="txt-center CMKT_DaiHoc TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="CMKT_DaiHoc_Nu" onkeypress="return keydownfocus(event,'CMKT_DaiHoc',0);" runat="server" CssClass="txt-center CMKT_DaiHoc_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class="clear"></div>
                        <div class="clear"></div>
                        <div class="col-md-12 lb none">7. Số lao động theo lĩnh vực giáo dục - đào tạo:</div>
                        <div class="col-md-12 none">
                            <table class="ta02" cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                                <tbody>
                                    <tr style="background: #ffcfb7">
                                        <td style="width: 60%; text-align: center">Lĩnh vực giáo dục - đào tạo</td>
                                        <td style="width: 20%; text-align: center">Số lượng</td>
                                        <td style="width: 20%; text-align: center">Trong đó: Nữ</td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Kinh tế - xã hội
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_KTXH" onkeypress="return keydownfocus(event,'GDDT_KTXH_Nu',0);" runat="server" CssClass="txt-center GDDT_KTXH TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_KTXH_Nu" onkeypress="return keydownfocus(event,'GDDT_KHTN',0);" runat="server" CssClass="txt-center GDDT_KTXH_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Khoa học tự nhiên
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_KHTN" onkeypress="return keydownfocus(event,'GDDT_KHTN_Nu',0);" runat="server" CssClass="txt-center GDDT_KHTN TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_KHTN_Nu" onkeypress="return keydownfocus(event,'GDDT_KTCN',0);" runat="server" CssClass="txt-center GDDT_KHTN_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Kỹ thuật và công nghệ
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_KTCN" onkeypress="return keydownfocus(event,'GDDT_KTCN_Nu',0);" runat="server" CssClass="txt-center GDDT_KTCN TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_KTCN_Nu" onkeypress="return keydownfocus(event,'GDDT_NongNghiep',0);" runat="server" CssClass="txt-center GDDT_KTCN_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Nông nghiệp, lâm nghiệp, thủy sản và thu y
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_NongNghiep" onkeypress="return keydownfocus(event,'GDDT_NongNghiep_Nu',0);" runat="server" CssClass="txt-center GDDT_NongNghiep TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_NongNghiep_Nu" onkeypress="return keydownfocus(event,'GDDT_YTe',0);" runat="server" CssClass="txt-center GDDT_NongNghiep_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Y tế, môi trường và các dịch vụ khác
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_YTe" onkeypress="return keydownfocus(event,'GDDT_YTe_Nu',0);" runat="server" CssClass="txt-center GDDT_YTe TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_YTe_Nu" onkeypress="return keydownfocus(event,'GDDT_Khac',0);" runat="server" CssClass="txt-center GDDT_YTe_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding-left: 15px!important; line-height: 20px">- Chưa qua đào tạo
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_Khac" onkeypress="return keydownfocus(event,'GDDT_Khac_Nu',0);" runat="server" CssClass="txt-center GDDT_Khac TextBox std med validate[custom[integer]]" />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="GDDT_Khac_Nu" onkeypress="return keydownfocus(event,'Nhom_LanhDao',0);" runat="server" CssClass="txt-center GDDT_Khac_Nu TextBox std med validate[custom[integer]]" />
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class="col-md-12 lb none">8. Số lao động theo nhóm nghề:</div>
                        <div class="col-md-12 none">
                            <table class="ta02" cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                                <tbody>
                                    <tr style="background: #ffcfb7">
                                        <td style="width: 10%; text-align: center">Mã nghề cấp 2</td>
                                        <td style="width: 50%; text-align: center">Tên gọi nghề nghiệp</td>
                                        <td style="width: 20%; text-align: center">Số lượng</td>
                                        <td style="width: 20%; text-align: center">Trong đó: Nữ</td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">17</td>
                                        <td style="line-height: 20px">Nhà quản lý của các cơ quan Tập đoàn, Tổng công ty và tương đương (chuyên trách)</td>
                                        <td>
                                            <asp:TextBox ID="C8_17" onkeypress="return keydownfocus(event,'C8_17_Nu',0);" runat="server" CssClass="txt-center C8_17 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_17_Nu" onkeypress="return keydownfocus(event,'C8_21',0);" runat="server" CssClass="txt-center C8_17_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">21</td>
                                        <td style="line-height: 20px">Nhà chuyên môn trong lĩnh vực khoa học và kỹ thuật</td>
                                        <td>
                                            <asp:TextBox ID="C8_21" onkeypress="return keydownfocus(event,'C8_21_Nu',0);" runat="server" CssClass="txt-center C8_21 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_21_Nu" onkeypress="return keydownfocus(event,'C8_22',0);" runat="server" CssClass="txt-center C8_21_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">22</td>
                                        <td style="line-height: 20px">Nhà chuyên môn về sức khỏe</td>
                                        <td>
                                            <asp:TextBox ID="C8_22" onkeypress="return keydownfocus(event,'C8_22_Nu',0);" runat="server" CssClass="txt-center C8_22 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_22_Nu" onkeypress="return keydownfocus(event,'C8_23',0);" runat="server" CssClass="txt-center C8_22_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">23</td>
                                        <td style="line-height: 20px">Nhà chuyên môn về giảng dạy</td>
                                        <td>
                                            <asp:TextBox ID="C8_23" onkeypress="return keydownfocus(event,'C8_23_Nu',0);" runat="server" CssClass="txt-center C8_23 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_23_Nu" onkeypress="return keydownfocus(event,'C8_24',0);" runat="server" CssClass="txt-center C8_23_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">24</td>
                                        <td style="line-height: 20px">Nhà chuyên môn về kinh doanh và quản lý</td>
                                        <td>
                                            <asp:TextBox ID="C8_24" onkeypress="return keydownfocus(event,'C8_24_Nu',0);" runat="server" CssClass="txt-center C8_24 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_24_Nu" onkeypress="return keydownfocus(event,'C8_25',0);" runat="server" CssClass="txt-center C8_24_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">25</td>
                                        <td style="line-height: 20px">Nhà chuyên môn trong lĩnh vực CNTT và truyền thông</td>
                                        <td>
                                            <asp:TextBox ID="C8_25" onkeypress="return keydownfocus(event,'C8_25_Nu',0);" runat="server" CssClass="txt-center C8_25 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_25_Nu" onkeypress="return keydownfocus(event,'C8_26',0);" runat="server" CssClass="txt-center C8_25_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">26</td>
                                        <td style="line-height: 20px">Nhà chuyên môn về luật pháp, văn hóa, xã hội</td>
                                        <td>
                                            <asp:TextBox ID="C8_26" onkeypress="return keydownfocus(event,'C8_26_Nu',0);" runat="server" CssClass="txt-center C8_26 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_26_Nu" onkeypress="return keydownfocus(event,'C8_31',0);" runat="server" CssClass="txt-center C8_26_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">31</td>
                                        <td style="line-height: 20px">Kỹ thuật viên khoa học và kỹ thuật</td>
                                        <td>
                                            <asp:TextBox ID="C8_31" onkeypress="return keydownfocus(event,'C8_31_Nu',0);" runat="server" CssClass="txt-center C8_31 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_31_Nu" onkeypress="return keydownfocus(event,'C8_32',0);" runat="server" CssClass="txt-center C8_31_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">32</td>
                                        <td style="line-height: 20px">Kỹ thuật viên sức khỏe</td>
                                        <td>
                                            <asp:TextBox ID="C8_32" onkeypress="return keydownfocus(event,'C8_32_Nu',0);" runat="server" CssClass="txt-center C8_32 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_32_Nu" onkeypress="return keydownfocus(event,'C8_33',0);" runat="server" CssClass="txt-center C8_32_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">33</td>
                                        <td style="line-height: 20px">Nhân viên về kinh doanh và quản lý</td>
                                        <td>
                                            <asp:TextBox ID="C8_33" onkeypress="return keydownfocus(event,'C8_33_Nu',0);" runat="server" CssClass="txt-center C8_33 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_33_Nu" onkeypress="return keydownfocus(event,'C8_34',0);" runat="server" CssClass="txt-center C8_33_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">34</td>
                                        <td style="line-height: 20px">Nhân viên luật pháp, văn hóa, xã hội</td>
                                        <td>
                                            <asp:TextBox ID="C8_34" onkeypress="return keydownfocus(event,'C8_34_Nu',0);" runat="server" CssClass="txt-center C8_34 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_34_Nu" onkeypress="return keydownfocus(event,'C8_35',0);" runat="server" CssClass="txt-center C8_34_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">35</td>
                                        <td style="line-height: 20px">Kỹ thuật viên thông tin và truyền thông</td>
                                        <td>
                                            <asp:TextBox ID="C8_35" onkeypress="return keydownfocus(event,'C8_35_Nu',0);" runat="server" CssClass="txt-center C8_35 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_35_Nu" onkeypress="return keydownfocus(event,'C8_36',0);" runat="server" CssClass="txt-center C8_35_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">36</td>
                                        <td style="line-height: 20px">Giáo viên bậc trung</td>
                                        <td>
                                            <asp:TextBox ID="C8_36" onkeypress="return keydownfocus(event,'C8_36_Nu',0);" runat="server" CssClass="txt-center C8_36 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_36_Nu" onkeypress="return keydownfocus(event,'C8_41',0);" runat="server" CssClass="txt-center C8_36_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">41</td>
                                        <td style="line-height: 20px">Nhân viên tổng hợp và NV làm các công việc bàn giấy</td>
                                        <td>
                                            <asp:TextBox ID="C8_41" onkeypress="return keydownfocus(event,'C8_41_Nu',0);" runat="server" CssClass="txt-center C8_41 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_41_Nu" onkeypress="return keydownfocus(event,'C8_42',0);" runat="server" CssClass="txt-center C8_41_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">42</td>
                                        <td style="line-height: 20px">Nhân viên dịch vụ khách hàng</td>
                                        <td>
                                            <asp:TextBox ID="C8_42" onkeypress="return keydownfocus(event,'C8_42_Nu',0);" runat="server" CssClass="txt-center C8_42 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_42_Nu" onkeypress="return keydownfocus(event,'C8_43',0);" runat="server" CssClass="txt-center C8_42_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">43</td>
                                        <td style="line-height: 20px">Nhân viên ghi chép số liệu và vật liệu</td>
                                        <td>
                                            <asp:TextBox ID="C8_43" onkeypress="return keydownfocus(event,'C8_43_Nu',0);" runat="server" CssClass="txt-center C8_43 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_43_Nu" onkeypress="return keydownfocus(event,'C8_44',0);" runat="server" CssClass="txt-center C8_43_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">44</td>
                                        <td style="line-height: 20px">Nhân viên hỗ trợ văn phòng khác</td>
                                        <td>
                                            <asp:TextBox ID="C8_44" onkeypress="return keydownfocus(event,'C8_44_Nu',0);" runat="server" CssClass="txt-center C8_44 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_44_Nu" onkeypress="return keydownfocus(event,'C8_51',0);" runat="server" CssClass="txt-center C8_44_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">51</td>
                                        <td style="line-height: 20px">Nhân viên dịch vụ cá nhân</td>
                                        <td>
                                            <asp:TextBox ID="C8_51" onkeypress="return keydownfocus(event,'C8_51_Nu',0);" runat="server" CssClass="txt-center C8_51 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_51_Nu" onkeypress="return keydownfocus(event,'C8_52',0);" runat="server" CssClass="txt-center C8_51_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">52</td>
                                        <td style="line-height: 20px">Nhân viên bán hàng</td>
                                        <td>
                                            <asp:TextBox ID="C8_52" onkeypress="return keydownfocus(event,'C8_52_Nu',0);" runat="server" CssClass="txt-center C8_52 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_52_Nu" onkeypress="return keydownfocus(event,'C8_53',0);" runat="server" CssClass="txt-center C8_52_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">53</td>
                                        <td style="line-height: 20px">Nhân viên chăm sóc cá nhân</td>
                                        <td>
                                            <asp:TextBox ID="C8_53" onkeypress="return keydownfocus(event,'C8_53_Nu',0);" runat="server" CssClass="txt-center C8_53 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_53_Nu" onkeypress="return keydownfocus(event,'C8_54',0);" runat="server" CssClass="txt-center C8_53_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">54</td>
                                        <td style="line-height: 20px">Nhân viên dịch vụ bảo vệ</td>
                                        <td>
                                            <asp:TextBox ID="C8_54" onkeypress="return keydownfocus(event,'C8_54_Nu',0);" runat="server" CssClass="txt-center C8_54 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_54_Nu" onkeypress="return keydownfocus(event,'C8_61',0);" runat="server" CssClass="txt-center C8_54_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">61</td>
                                        <td style="line-height: 20px">Lao động có kỹ năng trong nông nghiệp có sản phẩm chủ yếu để bán</td>
                                        <td>
                                            <asp:TextBox ID="C8_61" onkeypress="return keydownfocus(event,'C8_61_Nu',0);" runat="server" CssClass="txt-center C8_61 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_61_Nu" onkeypress="return keydownfocus(event,'C8_62',0);" runat="server" CssClass="txt-center C8_61_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">62</td>
                                        <td style="line-height: 20px">Lao động có kỹ năng trong lâm nghiệp, thủy sản và săn bắn có sản phẩm chủ yếu để bán</td>
                                        <td>
                                            <asp:TextBox ID="C8_62" onkeypress="return keydownfocus(event,'C8_62_Nu',0);" runat="server" CssClass="txt-center C8_62 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_62_Nu" onkeypress="return keydownfocus(event,'C8_63',0);" runat="server" CssClass="txt-center C8_62_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">63</td>
                                        <td style="line-height: 20px">Lao động tự cung tự cấp trong NN, lâm nghiệp và thủy sản</td>
                                        <td>
                                            <asp:TextBox ID="C8_63" onkeypress="return keydownfocus(event,'C8_63_Nu',0);" runat="server" CssClass="txt-center C8_63 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_63_Nu" onkeypress="return keydownfocus(event,'C8_71',0);" runat="server" CssClass="txt-center C8_63_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align: center;">71</td>
                                        <td style="line-height: 20px">Lao động xây dựng và lao động có liên quan đến nghề xây dựng (trừ thợ điện)</td>
                                        <td>
                                            <asp:TextBox ID="C8_71" onkeypress="return keydownfocus(event,'C8_71_Nu',0);" runat="server" CssClass="txt-center C8_71 TextBox std med validate[custom[integer]]" /></td>
                                        <td>
                                            <asp:TextBox ID="C8_71_Nu" onkeypress="return keydownfocus(event,'C8_72',0);" runat="server" CssClass="txt-center C8_71_Nu TextBox std med validate[custom[integer]]" /></td>
                                    </tr>

                                </tbody>
                            </table>
                        </div>
                        <div class="clear"></div>

                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="TinhTP" />
                        <asp:AsyncPostBackTrigger ControlID="XaPhuong" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
            <div class="col-md-12">
                <div class="clear"></div>
                <div class="col-md-12 lb none">9. Tiền lương: (1.000đ/người/tháng)</div>
                <div class="col-md-12 none">
                    <table class="ta02" cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                        <tbody>
                            <tr>
                                <td style="padding-left: 15px!important; line-height: 20px">- Tiền lương bình quân 6 tháng đầu năm
                                </td>
                                <td>
                                    <asp:TextBox ID="TL_BinhQuan" onkeypress="return keydownfocus(event,'TL_ThapNhat',0);" runat="server" CssClass="txt-center TL_BinhQuan TextBox std med validate[custom[integer]]" />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding-left: 15px!important; line-height: 20px">- Tiền lương thấp nhất trong 6 tháng đầu năm
                                </td>
                                <td>
                                    <asp:TextBox ID="TL_ThapNhat" onkeypress="return keydownfocus(event,'TL_CaoNhat',0);" runat="server" CssClass="txt-center TextBox std med validate[custom[integer]]" />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding-left: 15px!important; line-height: 20px">- Tiền lương cao nhất trong 6 tháng đầu năm
                                </td>
                                <td>
                                    <asp:TextBox ID="TL_CaoNhat" onkeypress="return keydownfocus(event,'C10_LaoDong',0);" runat="server" CssClass="txt-center TextBox std med validate[custom[integer]]" />
                                </td>
                            </tr>

                        </tbody>
                    </table>
                </div>
                <div class="clear"></div>
                <div class="col-md-4 lb bold">3. Số lao động tuyển dụng 6 tháng tới (người)</div>
                <div class="col-md-8 ">
                    <asp:TextBox ID="C10_LaoDong" onkeypress="return keydownfocus(event,'C11_17',0);" runat="server" CssClass="txt-center C10_LaoDong TextBox std med validate[custom[integer]]" />
                </div>
                <div class="clear"></div>
                <div class="col-md-12 lb bold">4. Nhu cầu tuyển dụng lao động theo nghề, trình độ trong 6 tháng tới</div>
                <div class="clear"></div>
                <div class="col-md-12 lb none">11.1. Nhu cầu tuyển dụng lao động theo nghề</div>
                <div class="col-md-12">
                    <table class="ta02" cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                        <tbody>
                            <tr style="background: #ffcfb7">
                                <td style="width: 10%; text-align: center">Mã nghề cấp 2</td>
                                <td style="width: 50%; text-align: center">Tên gọi nghề nghiệp</td>
                                <td style="width: 20%; text-align: center">Số lượng</td>
                                <td style="width: 20%; text-align: center">Trong đó: Nữ</td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">17</td>
                                <td style="line-height: 20px">Nhà quản lý của các cơ quan Tập đoàn, Tổng công ty và tương đương (chuyên trách)</td>
                                <td>
                                    <asp:TextBox ID="C11_17" type="number"  onkeypress="return keydownfocus(event,'C11_17_Nu',0);" runat="server" CssClass="txt-center C11_17 C11_SLTONG TextBox std med validate[custom[integer,min[0],doiChieuDuLieuMuc4[]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_17_Nu" type="number"  onkeypress="return keydownfocus(event,'C11_21',0);" runat="server" CssClass="txt-center C11_17_Nu C11_SLNU TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">21</td>
                                <td style="line-height: 20px">Nhà chuyên môn trong lĩnh vực khoa học và kỹ thuật</td>
                                <td>
                                    <asp:TextBox ID="C11_21" type="number"  onkeypress="return keydownfocus(event,'C11_21_Nu',0);" runat="server" CssClass="txt-center C11_21 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_21_Nu" type="number"  onkeypress="return keydownfocus(event,'C11_22',0);" runat="server" CssClass="txt-center C11_21_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">22</td>
                                <td style="line-height: 20px">Nhà chuyên môn về sức khỏe</td>
                                <td>
                                    <asp:TextBox ID="C11_22" type="number" onkeypress="return keydownfocus(event,'C11_22_Nu',0);" runat="server" CssClass="txt-center C11_22 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_22_Nu" type="number" onkeypress="return keydownfocus(event,'C11_23',0);" runat="server" CssClass="txt-center C11_22_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">23</td>
                                <td style="line-height: 20px">Nhà chuyên môn về giảng dạy</td>
                                <td>
                                    <asp:TextBox ID="C11_23" type="number" onkeypress="return keydownfocus(event,'C11_23_Nu',0);" runat="server" CssClass="txt-center C11_23 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_23_Nu" type="number" onkeypress="return keydownfocus(event,'C11_24',0);" runat="server" CssClass="txt-center C11_23_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">24</td>
                                <td style="line-height: 20px">Nhà chuyên môn về kinh doanh và quản lý</td>
                                <td>
                                    <asp:TextBox ID="C11_24" type="number" onkeypress="return keydownfocus(event,'C11_24_Nu',0);" runat="server" CssClass="txt-center C11_24 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_24_Nu" type="number" onkeypress="return keydownfocus(event,'C11_25',0);" runat="server" CssClass="txt-center C11_24_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">25</td>
                                <td style="line-height: 20px">Nhà chuyên môn trong lĩnh vực CNTT và truyền thông</td>
                                <td>
                                    <asp:TextBox ID="C11_25" type="number" onkeypress="return keydownfocus(event,'C11_25_Nu',0);" runat="server" CssClass="txt-center C11_25 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_25_Nu" type="number" onkeypress="return keydownfocus(event,'C11_26',0);" runat="server" CssClass="txt-center C11_25_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">26</td>
                                <td style="line-height: 20px">Nhà chuyên môn về luật pháp, văn hóa, xã hội</td>
                                <td>
                                    <asp:TextBox ID="C11_26" type="number" min="0" onkeypress="return keydownfocus(event,'C11_26_Nu',0);" runat="server" CssClass="txt-center C11_26 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_26_Nu" type="number" min="0" onkeypress="return keydownfocus(event,'C11_31',0);" runat="server" CssClass="txt-center C11_26_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">31</td>
                                <td style="line-height: 20px">Kỹ thuật viên khoa học và kỹ thuật</td>
                                <td>
                                    <asp:TextBox ID="C11_31" type="number" min="0" onkeypress="return keydownfocus(event,'C11_31_Nu',0);" runat="server" CssClass="txt-center C11_31 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_31_Nu" type="number" min="0" onkeypress="return keydownfocus(event,'C11_32',0);" runat="server" CssClass="txt-center C11_31_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">32</td>
                                <td style="line-height: 20px">Kỹ thuật viên sức khỏe</td>
                                <td>
                                    <asp:TextBox ID="C11_32" type="number" onkeypress="return keydownfocus(event,'C11_32_Nu',0);" runat="server" CssClass="txt-center C11_32 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_32_Nu" type="number" onkeypress="return keydownfocus(event,'C11_33',0);" runat="server" CssClass="txt-center C11_32_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">33</td>
                                <td style="line-height: 20px">Nhân viên về kinh doanh và quản lý</td>
                                <td>
                                    <asp:TextBox ID="C11_33" type="number" onkeypress="return keydownfocus(event,'C11_33_Nu',0);" runat="server" CssClass="txt-center C11_33 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_33_Nu" type="number" onkeypress="return keydownfocus(event,'C11_34',0);" runat="server" CssClass="txt-center C11_33_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">34</td>
                                <td style="line-height: 20px">Nhân viên luật pháp, văn hóa, xã hội</td>
                                <td>
                                    <asp:TextBox ID="C11_34" type="number" onkeypress="return keydownfocus(event,'C11_34_Nu',0);" runat="server" CssClass="txt-center C11_34 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_34_Nu" type="number" onkeypress="return keydownfocus(event,'C11_35',0);" runat="server" CssClass="txt-center C11_34_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">35</td>
                                <td style="line-height: 20px">Kỹ thuật viên thông tin và truyền thông</td>
                                <td>
                                    <asp:TextBox ID="C11_35" type="number" onkeypress="return keydownfocus(event,'C11_35_Nu',0);" runat="server" CssClass="txt-center C11_35 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_35_Nu" type="number" onkeypress="return keydownfocus(event,'C11_36',0);" runat="server" CssClass="txt-center C11_35_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">36</td>
                                <td style="line-height: 20px">Giáo viên bậc trung</td>
                                <td>
                                    <asp:TextBox ID="C11_36" type="number" onkeypress="return keydownfocus(event,'C11_36_Nu',0);" runat="server" CssClass="txt-center C11_36 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_36_Nu" type="number" onkeypress="return keydownfocus(event,'C11_41',0);" runat="server" CssClass="txt-center C11_36_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">41</td>
                                <td style="line-height: 20px">Nhân viên tổng hợp và NV làm các công việc bàn giấy</td>
                                <td>
                                    <asp:TextBox ID="C11_41" type="number" onkeypress="return keydownfocus(event,'C11_41_Nu',0);" runat="server" CssClass="txt-center C11_41 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_41_Nu" type="number" onkeypress="return keydownfocus(event,'C11_42',0);" runat="server" CssClass="txt-center C11_41_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">42</td>
                                <td style="line-height: 20px">Nhân viên dịch vụ khách hàng</td>
                                <td>
                                    <asp:TextBox ID="C11_42" type="number" onkeypress="return keydownfocus(event,'C11_42_Nu',0);" runat="server" CssClass="txt-center C11_42 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_42_Nu" type="number" onkeypress="return keydownfocus(event,'C11_43',0);" runat="server" CssClass="txt-center C11_42_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">43</td>
                                <td style="line-height: 20px">Nhân viên ghi chép số liệu và vật liệu</td>
                                <td>
                                    <asp:TextBox ID="C11_43" type="number" onkeypress="return keydownfocus(event,'C11_43_Nu',0);" runat="server" CssClass="txt-center C11_43 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_43_Nu" type="number" onkeypress="return keydownfocus(event,'C11_44',0);" runat="server" CssClass="txt-center C11_43_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">44</td>
                                <td style="line-height: 20px">Nhân viên hỗ trợ văn phòng khác</td>
                                <td>
                                    <asp:TextBox ID="C11_44" type="number" onkeypress="return keydownfocus(event,'C11_44_Nu',0);" runat="server" CssClass="txt-center C11_44 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_44_Nu" type="number" onkeypress="return keydownfocus(event,'C11_51',0);" runat="server" CssClass="txt-center C11_44_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">51</td>
                                <td style="line-height: 20px">Nhân viên dịch vụ cá nhân</td>
                                <td>
                                    <asp:TextBox ID="C11_51" type="number" onkeypress="return keydownfocus(event,'C11_51_Nu',0);" runat="server" CssClass="txt-center C11_51 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_51_Nu" type="number" onkeypress="return keydownfocus(event,'C11_52',0);" runat="server" CssClass="txt-center C11_51_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">52</td>
                                <td style="line-height: 20px">Nhân viên bán hàng</td>
                                <td>
                                    <asp:TextBox ID="C11_52" type="number" onkeypress="return keydownfocus(event,'C11_52_Nu',0);" runat="server" CssClass="txt-center C11_52 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_52_Nu" type="number" onkeypress="return keydownfocus(event,'C11_53',0);" runat="server" CssClass="txt-center C11_52_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">53</td>
                                <td style="line-height: 20px">Nhân viên chăm sóc cá nhân</td>
                                <td>
                                    <asp:TextBox ID="C11_53" type="number" onkeypress="return keydownfocus(event,'C11_53_Nu',0);" runat="server" CssClass="txt-center C11_53 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_53_Nu" type="number" onkeypress="return keydownfocus(event,'C11_54',0);" runat="server" CssClass="txt-center C11_53_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">54</td>
                                <td style="line-height: 20px">Nhân viên dịch vụ bảo vệ</td>
                                <td>
                                    <asp:TextBox ID="C11_54" type="number" onkeypress="return keydownfocus(event,'C11_54_Nu',0);" runat="server" CssClass="txt-center C11_54 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_54_Nu" type="number" onkeypress="return keydownfocus(event,'C11_61',0);" runat="server" CssClass="txt-center C11_54_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">61</td>
                                <td style="line-height: 20px">Lao động có kỹ năng trong nông nghiệp có sản phẩm chủ yếu để bán</td>
                                <td>
                                    <asp:TextBox ID="C11_61" type="number" onkeypress="return keydownfocus(event,'C11_61_Nu',0);" runat="server" CssClass="txt-center C11_61 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_61_Nu" type="number" onkeypress="return keydownfocus(event,'C11_62',0);" runat="server" CssClass="txt-center C11_61_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">62</td>
                                <td style="line-height: 20px">Lao động có kỹ năng trong lâm nghiệp, thủy sản và săn bắn có sản phẩm chủ yếu để bán</td>
                                <td>
                                    <asp:TextBox ID="C11_62" type="number" onkeypress="return keydownfocus(event,'C11_62_Nu',0);" runat="server" CssClass="txt-center C11_62 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_62_Nu" type="number" onkeypress="return keydownfocus(event,'C11_63',0);" runat="server" CssClass="txt-center C11_62_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">63</td>
                                <td style="line-height: 20px">Lao động tự cung tự cấp trong NN, lâm nghiệp và thủy sản</td>
                                <td>
                                    <asp:TextBox ID="C11_63" type="number" onkeypress="return keydownfocus(event,'C11_63_Nu',0);" runat="server" CssClass="txt-center C11_63 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_63_Nu" type="number" onkeypress="return keydownfocus(event,'C11_71',0);" runat="server" CssClass="txt-center C11_63_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">71</td>
                                <td style="line-height: 20px">Lao động xây dựng và lao động có liên quan đến nghề xây dựng (trừ thợ điện)</td>
                                <td>
                                    <asp:TextBox ID="C11_71" type="number" onkeypress="return keydownfocus(event,'C11_71_Nu',0);" runat="server" CssClass="txt-center C11_71 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_71_Nu" type="number" onkeypress="return keydownfocus(event,'C11_72',0);" runat="server" CssClass="txt-center C11_71_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">72</td>
                                <td style="line-height: 20px">Thợ luyện kim, cơ khí và thợ có liên quan</td>
                                <td>
                                    <asp:TextBox ID="C11_72" type="number" onkeypress="return keydownfocus(event,'C11_72_Nu',0);" runat="server" CssClass="txt-center C11_72 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_72_Nu" type="number" onkeypress="return keydownfocus(event,'C11_73',0);" runat="server" CssClass="txt-center C11_72_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">73</td>
                                <td style="line-height: 20px">Thợ thủ công và thợ liên quan đến in</td>
                                <td>
                                    <asp:TextBox ID="C11_73" type="number" onkeypress="return keydownfocus(event,'C11_73_Nu',0);" runat="server" CssClass="txt-center C11_73 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_73_Nu" type="number" onkeypress="return keydownfocus(event,'C11_74',0);" runat="server" CssClass="txt-center C11_73_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">74</td>
                                <td style="line-height: 20px">Thợ điện và thợ điện tử</td>
                                <td>
                                    <asp:TextBox ID="C11_74" type="number" onkeypress="return keydownfocus(event,'C11_74_Nu',0);" runat="server" CssClass="txt-center C11_74 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_74_Nu" type="number" onkeypress="return keydownfocus(event,'C11_75',0);" runat="server" CssClass="txt-center C11_74_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">75</td>
                                <td style="line-height: 20px">Thợ chế biến thực phẩm, gia công gỗ, may mặc, đồ thủ công và thợ có liên quan khác</td>
                                <td>
                                    <asp:TextBox ID="C11_75" type="number" onkeypress="return keydownfocus(event,'C11_75_Nu',0);" runat="server" CssClass="txt-center C11_75 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_75_Nu" type="number" onkeypress="return keydownfocus(event,'C11_81',0);" runat="server" CssClass="txt-center C11_75_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">81</td>
                                <td style="line-height: 20px">Thợ vận hành máy móc và thiết bị</td>
                                <td>
                                    <asp:TextBox ID="C11_81" type="number" onkeypress="return keydownfocus(event,'C11_81_Nu',0);" runat="server" CssClass="txt-center C11_81 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_81_Nu" type="number" onkeypress="return keydownfocus(event,'C11_82',0);" runat="server" CssClass="txt-center C11_81_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">82</td>
                                <td style="line-height: 20px">Thợ lắp ráp</td>
                                <td>
                                    <asp:TextBox ID="C11_82" type="number" onkeypress="return keydownfocus(event,'C11_82_Nu',0);" runat="server" CssClass="txt-center C11_82 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_82_Nu" type="number" onkeypress="return keydownfocus(event,'C11_83',0);" runat="server" CssClass="txt-center C11_82_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">83</td>
                                <td style="line-height: 20px">Lái xe và thợ vận hành thiết bị chuyển động</td>
                                <td>
                                    <asp:TextBox ID="C11_83" type="number" onkeypress="return keydownfocus(event,'C11_83_Nu',0);" runat="server" CssClass="txt-center C11_83 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_83_Nu" type="number" onkeypress="return keydownfocus(event,'C11_91',0);" runat="server" CssClass="txt-center C11_83_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">91</td>
                                <td style="line-height: 20px">Người quét dọn và giúp việc</td>
                                <td>
                                    <asp:TextBox ID="C11_91" type="number" onkeypress="return keydownfocus(event,'C11_91_Nu',0);" runat="server" CssClass="txt-center C11_91 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_91_Nu" type="number" onkeypress="return keydownfocus(event,'C11_92',0);" runat="server" CssClass="txt-center C11_91_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">92</td>
                                <td style="line-height: 20px">Lao động giản đơn trong NN, lâm nghiệp và thủy sản</td>
                                <td>
                                    <asp:TextBox ID="C11_92" type="number" onkeypress="return keydownfocus(event,'C11_92_Nu',0);" runat="server" CssClass="txt-center C11_92 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_92_Nu" type="number" onkeypress="return keydownfocus(event,'C11_93',0);" runat="server" CssClass="txt-center C11_92_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">93</td>
                                <td style="line-height: 20px">Lao động trong ngành khai khoáng, xây dựng, công nghiệp chế biến, chế tạo và giao thông vận tải</td>
                                <td>
                                    <asp:TextBox ID="C11_93" type="number" onkeypress="return keydownfocus(event,'C11_93_Nu',0);" runat="server" CssClass="txt-center C11_93 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_93_Nu" type="number" onkeypress="return keydownfocus(event,'C11_94',0);" runat="server" CssClass="txt-center C11_93_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">94</td>
                                <td style="line-height: 20px">Người phụ giúp chuẩn bị thực phẩm</td>
                                <td>
                                    <asp:TextBox ID="C11_94" type="number" onkeypress="return keydownfocus(event,'C11_94_Nu',0);" runat="server" CssClass="txt-center C11_94 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_94_Nu" type="number" onkeypress="return keydownfocus(event,'C11_95',0);" runat="server" CssClass="txt-center C11_94_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">95</td>
                                <td style="line-height: 20px">Lao động trên đường phố và lao động có liên quan đến bán hàng</td>
                                <td>
                                    <asp:TextBox ID="C11_95" type="number" onkeypress="return keydownfocus(event,'C11_95_Nu',0);" runat="server" CssClass="txt-center C11_95 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_95_Nu" type="number" onkeypress="return keydownfocus(event,'C11_96',0);" runat="server" CssClass="txt-center C11_95_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">96</td>
                                <td style="line-height: 20px">Người thu dọn vật thải và lao động giản đơn khác</td>
                                <td>
                                    <asp:TextBox ID="C11_96" type="number" onkeypress="return keydownfocus(event,'C11_96_Nu',0);" runat="server" CssClass="txt-center C11_96 TextBox std med validate[custom[integer,min[0]]]" /></td>
                                <td>
                                    <asp:TextBox ID="C11_96_Nu" type="number" onkeypress="return keydownfocus(event,'Chia_Khong',0);" runat="server" CssClass="txt-center C11_96_Nu TextBox std med validate[custom[integer,min[0]]]" /></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class="clear"></div>
                <div class="col-md-12 lb none">11.2. Nhu cầu tuyển dụng theo trình độ</div>
                <div class="col-md-12 none">
                    <table class="ta02" cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                        <tbody>
                            <tr style="background: #ffcfb7">
                                <td style="width: 60%; text-align: center">Trình độ chuyên môn kỹ thuật</td>
                                <td style="width: 20%; text-align: center">Số lượng</td>
                                <td style="width: 20%; text-align: center">Trong đó: Nữ</td>
                            </tr>
                            <tr>
                                <td style="padding-left: 15px!important; line-height: 20px">- Không có trình độ chuyên môn kỹ thuật
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_Khong" onkeypress="return keydownfocus(event,'Chia_Khong_Nu',0);" runat="server" CssClass="txt-center Chia_Khong TextBox std med validate[custom[integer]]" />
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_Khong_Nu" onkeypress="return keydownfocus(event,'Chia_BangCap',0);" runat="server" CssClass="txt-center Chia_Khong_Nu TextBox std med validate[custom[integer]]" />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding-left: 15px!important; line-height: 20px">- Công nhân kỹ thuật không bằng/ chứng chỉ
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_BangCap" onkeypress="return keydownfocus(event,'Chia_BangCap_Nu',0);" runat="server" CssClass="txt-center Chia_BangCap TextBox std med validate[custom[integer]]" />
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_BangCap_Nu" onkeypress="return keydownfocus(event,'Chia_DaoTao',0);" runat="server" CssClass="txt-center Chia_BangCap_Nu TextBox std med validate[custom[integer]]" />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding-left: 15px!important; line-height: 20px">- Đào tạo thường xuyên
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_DaoTao" onkeypress="return keydownfocus(event,'Chia_SoCap_Nu',0);" runat="server" CssClass="txt-center Chia_SoCap TextBox std med validate[custom[integer]]" />
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_DaoTao_Nu" onkeypress="return keydownfocus(event,'Chia_SoCap',0);" runat="server" CssClass="txt-center Chia_DaoTao_Nu TextBox std med validate[custom[integer]]" />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding-left: 15px!important; line-height: 20px">- Sơ cấp nghề
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_SoCap" onkeypress="return keydownfocus(event,'Chia_SoCap_Nu',0);" runat="server" CssClass="txt-center Chia_SoCap TextBox std med validate[custom[integer]]" />
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_SoCap_Nu" onkeypress="return keydownfocus(event,'Chia_TrungCap',0);" runat="server" CssClass="txt-center Chia_SoCap_Nu TextBox std med validate[custom[integer]]" />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding-left: 15px!important; line-height: 20px">- Trung cấp
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_TrungCap" onkeypress="return keydownfocus(event,'Chia_TrungCap_Nu',0);" runat="server" CssClass="txt-center Chia_TrungCap TextBox std med validate[custom[integer]]" />
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_TrungCap_Nu" onkeypress="return keydownfocus(event,'Chia_CaoDang',0);" runat="server" CssClass="txt-center Chia_TrungCap_Nu TextBox std med validate[custom[integer]]" />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding-left: 15px!important; line-height: 20px">- Cao đẳng
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_CaoDang" onkeypress="return keydownfocus(event,'Chia_CaoDang_Nu',0);" runat="server" CssClass="txt-center Chia_CaoDang TextBox std med validate[custom[integer]]" />
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_CaoDang_Nu" onkeypress="return keydownfocus(event,'Chia_DaiHoc',0);" runat="server" CssClass="txt-center Chia_CaoDang_Nu TextBox std med validate[custom[integer]]" />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding-left: 15px!important; line-height: 20px">- Đại học trở lên
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_DaiHoc" onkeypress="return keydownfocus(event,'Chia_DaiHoc_Nu',1);" runat="server" CssClass="txt-center Chia_DaiHoc TextBox std med validate[custom[integer]]" />
                                </td>
                                <td>
                                    <asp:TextBox ID="Chia_DaiHoc_Nu" onkeypress="return keydownfocus(event,'cmsbtupdate',1);" runat="server" CssClass="txt-center Chia_DaiHoc_Nu TextBox std med validate[custom[integer]]" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class="clear"></div>
            </div>
            <div class="clr clUp  pdt5"></div>
            <asp:Literal ID="litUpdate" runat="server" />
        </div>
        <asp:HiddenField ID="ItemID" runat="server" Visible="true" />
    </div>
</div>
<div class="fix-btt-toolbar pdt5">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Đóng lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdReset" runat="server" Text="Làm mới" CssClass="cmsbut Refresh" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdCancel" runat="server" Text="Hủy" CssClass="cmsbut cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="cmsbut cmsbtupdate " OnClientClick="return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdUpdateClose" runat="server" ToolTip="Lưu lại thông tin và tự động đóng form" data-toggle="tooltip" Text="Lưu và Đóng" CssClass="cmsbut cmsbtsave " OnClientClick="return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdAdd" runat="server" toogle="tooltip" Text="Thêm mới" CssClass="cmsbut cmsbtnew " OnClientClick="return $('#Form').validationEngine('detach'); " />
        <asp:LinkButton ID="cmdExport" runat="server" Text="Tải phiếu điều tra" OnClientClick="popdoc('exports'); return false;" CssClass="cmsbut cmsbtDownload cbclick" />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmdDel cbclick" />
        <div class="clr pdt5"></div>
    </div>
</div>
<script type="text/javascript">

    $(".C11_SLNU").on("keyup change", function (e) {
        doiChieuDuLieuMuc4()
    })
    function doiChieuDuLieuMuc4(slTong,slNu) {
        if (slTong - slNu < 0) {
            notify("warning", "Số lượng Nữ không thể lớn hơn cột Số lượng tổng - Mục 4.Nhu cầu tuyển dụng lao động theo nghề, trình độ trong 6 tháng tới,");
            return false;
        }
    }
    function exports() {
        var bcID = $("#<%=ItemID.ClientID %>").val(); var year = $("#<%=KyNhapLieu.ClientID %>").val()
        var dtype = $("#docx:checked").val(); if (dtype == "true") { dtype = ".docx" } else { dtype = ".pdf" }
        window.open("/exports?page=work&view=ExCauLD&typeid=PhieuDTDN&bcID=" + bcID + "&year=" + year + "&dtype=" + dtype);
    };
</script>
<asp:TextBox ID="Website" Visible="false" onkeypress="return keydownfocus(event,'TinhTrang',0);" runat="server" CssClass="TextBox std med Website" />
<asp:TextBox ID="MaDN1" Visible="false" runat="server" onkeypress="return keydownfocus(event,'MaDN2',0);" MaxLength="5" CssClass="txt-center MaDN1 TextBox std med validate[required]" />
<asp:TextBox ID="MaDN2" Visible="false" runat="server" onkeypress="return keydownfocus(event,'MaDN3',0);" MaxLength="5" CssClass="txt-center MaDN2 TextBox std med validate[required]" />
<asp:TextBox ID="MaDN3" Visible="false" runat="server" onkeypress="return keydownfocus(event,'MaDN4',0);" MaxLength="5" CssClass="txt-center MaDN3 TextBox std med validate[required]" />
<asp:TextBox ID="MaDN4" Visible="false" runat="server" onkeypress="return keydownfocus(event,'TenDoanhNghiep',0);" MaxLength="5" CssClass="txt-center MaDN4 TextBox std med validate[required]" />
<asp:TextBox ID="Fax" Visible="false" onkeypress="return keydownfocus(event,'Email',0);" runat="server" CssClass="TextBox std med medFax" />
<asp:DropDownList ID="TT_NT" Visible="false" inext="SoNha" runat="server" CssClass="selectpicker TT_NT validate[required]" />
<asp:TextBox Visible="false" ID="Nhom_LanhDao" onkeypress="return keydownfocus(event,'Nhom_ChuyenMon',0);" runat="server" CssClass="txt-center Nhom_LanhDao TextBox std med validate[custom[integer]]" />
<asp:TextBox Visible="false" ID="Nhom_ChuyenMon" onkeypress="return keydownfocus(event,'Nhom_TroLy',0);" runat="server" CssClass="txt-center Nhom_ChuyenMon TextBox std med validate[custom[integer]]" />
<asp:TextBox Visible="false" ID="Nhom_TroLy" onkeypress="return keydownfocus(event,'Nhom_DichVu',0);" runat="server" CssClass="txt-center Nhom_TroLy TextBox std med validate[custom[integer]]" />
<asp:TextBox Visible="false" ID="Nhom_DichVu" onkeypress="return keydownfocus(event,'Nhom_NongNghiep',0);" runat="server" CssClass="txt-center Nhom_DichVu TextBox std med validate[custom[integer]]" />
<asp:TextBox Visible="false" ID="Nhom_NongNghiep" onkeypress="return keydownfocus(event,'Nhom_ThuCong',0);" runat="server" CssClass="txt-center Nhom_NongNghiep TextBox std med validate[custom[integer]]" />
<asp:TextBox Visible="false" ID="Nhom_ThuCong" onkeypress="return keydownfocus(event,'Nhom_Tho',0);" runat="server" CssClass="txt-center Nhom_ThuCong TextBox std med validate[custom[integer]]" />
<asp:TextBox Visible="false" ID="Nhom_Tho" onkeypress="return keydownfocus(event,'Nhom_DonGian',0);" runat="server" CssClass="txt-center TextBox std med validate[custom[integer]]" />
<asp:TextBox Visible="false" ID="Nhom_DonGian" onkeypress="return keydownfocus(event,'TL_BinhQuan',0);" runat="server" CssClass="txt-center Nhom_DonGian TextBox std med validate[custom[integer]]" />

<style>
    table.ta02 tr td {
        padding: 0 2px !important
    }

        table.ta02 tr td input.std.med {
            border: 0 !important
        }
</style>
