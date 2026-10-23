<%@ Control Language="vb" CodeFile="ND23_PLII.ascx.vb" Inherits="Modules.ND23_PLII.Edit" AutoEventWireup="false" Explicit="True" %>
<style>
    .disabledbutton {
        pointer-events: none;
        opacity: 0.4;
    }

    .cmsbtdelHo {
        background-image: url(/portals/_default/skins/vbn/images/del.png?w);
    }
</style>
<link rel="stylesheet" href="/portals/_default/skins/vbn/css/pks.css?v=1.0.1" />

<asp:UpdatePanel runat="server" ID="pnThongTinHo">
    <ContentTemplate>
        <div class="left-col">
            <div class="left-title "><i class="fa fa-list-ol" aria-hidden="true"></i>&nbsp;MỤC LỤC</div>
            <ol id="list-example">
                <li>
                    <a href="#thongtinchung">Thông tin chung</a>
                </li>
                <li>
                    <a href="#trinhdokynang">Đăng ký dịch vụ</a>
                </li>
                <li>
                    <a href="#thoigiandangky">Thời gian đăng ký</a>
                </li>

            </ol>
        </div>
        <div class="content-pks">
            <div class="box box-info box-infoHo" data-spy="scroll" data-target="#list-example" data-offset="0">
                <div class="box-body col-md-12 pb10">
                    <div class="col-md-12 text-center h4" id="thongtinphieu">
                        <b class="title-pks">PHIẾU ĐĂNG KÝ
                        </b>
                        <br />
                        <i>(Dành cho tập thể người lao động)</i>
                    </div>
                    <div class="clear"></div>

                    <div class="main-body1 ">

                        <div class="col-md-12 col-xs-12">
                            <div class="row box-info pd0 boxg1" id="thongtinchung" style="min-height: 255px">
                                <div class="title-ho bgt1">1.THÔNG TIN CHÍNH</div>
                                <div class="col-md-6 pdr0 none ">
                                    <div class="col-md-12 pdl0 pdb0 pdt0">Số thứ tự</div>
                                    <div class="col-md-12 pdl0 pdb0 pdt0">
                                        <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox" />
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 b pdt5">1.Tập thể người lao động đến từ <span class="red">*</span></div>
                                <div class="col-md-10 pdl0">
                                    <asp:TextBox ID="TenTapThe" runat="server" CssClass="TextBox validate[required]" />

                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">2.Số lượng &nbsp;<span class="red">*</span></div>
                                <div class="col-md-10 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="SoLuong" runat="server" Text="2" CssClass="TextBox CCCD validate[required]" type="number"/>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">3.Họ tên người đại diện &nbsp;<span class="red">*</span></div>
                                <div class="col-md-10 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="NguoiDaiDien" runat="server" CssClass="TextBox CCCD validate[required]" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">4.Địa chỉ liên hệ &nbsp;<span class="red">*</span></div>
                                <div class="col-md-10 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="DiaChiLH" runat="server" CssClass="TextBox CCCD validate[required]" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">5.Số điện thoại &nbsp;<span class="red">*</span></div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="SDT_LL" runat="server" CssClass="TextBox CCCD validate[required]" />
                                </div>
                                <div class="col-md-2 pdr0 pdt5 b">6.Email </div>
                                <div class="col-md-4 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="EMAIL_LL" runat="server" CssClass="TextBox CCCD" />
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 pdr0 pdt5 b">7.Liên hệ khác </div>
                                <div class="col-md-10 pdl0 pdb0 pdt0">
                                    <asp:TextBox ID="KHAC_LL" runat="server" CssClass="TextBox CCCD" />
                                </div>
                                <div class="clear"></div>
                            </div>
                        </div>
                        <div class="row box-info pd0" id="trinhdokynang">
                            <div class="title-ho bgt1">ĐĂNG KÝ DỊCH VỤ</div>
                            <div class="col-md-12 pdl0">
                                <div class="col-md-6">
                                    <asp:CheckBox runat="server" Text="Tư vấn chính sách, pháp luật lao động" CssClass="tbCheckList" ID="DKDV_CSPL" />

                                </div>
                                <div class="col-md-6">
                                    <asp:CheckBox runat="server" Text="Tư vấn việc làm" CssClass="tbCheckList" ID="DKDV_TVVL" />

                                </div>
                                <div class="clear"></div>

                                <div class="col-md-6">
                                    <asp:CheckBox runat="server" Text="Tư vấn về đào tạo, kỹ năng nghề" CssClass="tbCheckList" ID="DKDV_TVDTN" />

                                </div>

                                <div class="clear"></div>
                                <div class="col-md-3">
                                    <asp:CheckBox runat="server" Text="Khác" CssClass="tbCheckList" ID="DKDV_KHAC" />

                                </div>
                                <div class="col-md-9">
                                    <asp:TextBox runat="server" placeholder="Nếu chọn Khác cần ghi rõ cụ thể" ID="DKDV_KHAC_TEXT" CssClass="TextBox"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row box-info pd0 mgb10" id="thoigiandangky">
                            <div class="col-md-2 title-ho bgt1">THỜI GIAN ĐĂNG KÝ</div>
                            <div class="col-md-10 pdl0">
                                <asp:TextBox runat="server" ID="ThoiGianDangKy" CssClass="TextBox datepicker validate[required]"></asp:TextBox>
                            </div>

                        </div>
                        <asp:Literal ID="litUpdate" runat="server" />
                        <div class="col-md-12 txt-center mgb10 mgt10">
                            <asp:Button ID="cmdUpdate" runat="server" Text="Hoàn thành phiếu" CssClass="btn btn-success" OnClientClick="return retunwaiting();" />
                        </div>
                    </div>
                    <div class="clrUp"></div>
                </div>
            </div>

            <div class="none">
                <asp:HiddenField ID="IdKhau" Visible="false" runat="server" />
                <asp:HiddenField ID="YearPro" Visible="false" runat="server" />
                <asp:HiddenField ID="IsLock" Visible="false" runat="server" />
            </div>
        </div>
        </div>

    
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdUpdate" />
    </Triggers>
</asp:UpdatePanel>
<asp:Literal runat="server" ID="ltMessage"></asp:Literal>