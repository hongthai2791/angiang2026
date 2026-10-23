<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ThongBaoEdit.ascx.vb" Inherits="Modules.EPORTAL.View" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-sm-12">
            <h3 class="box-title">Nội dung gửi thông báo</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-7">
                <div class="row">
                    <div class="col-md-3 b pdt5">Tên doanh nghiệp</div>
                    <div class="col-md-9 pdt5">
                        <asp:TextBox ID="TenDoanhNghiep" runat="server" ReadOnly="true" CssClass="std med validate[required]" />
                    </div>
                    <div class="clear pdt5"></div>
                    <div class="col-md-3 pdt5">- Tỉnh/ thành phố</div>
                    <div class="col-md-9 pdt5">
                        <asp:DropDownList ID="TinhTP" runat="server" Enabled="false" CssClass="selectpicker" />
                    </div>
                    <div class="clear pdt5"></div>
                    <div class="col-md-3 pdt5">- Quận/ Huyện</div>
                    <div class="col-md-9 pdt5">
                        <asp:DropDownList ID="QuanHuyen" Enabled="false" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="clear pdt5"></div>
                    <div class="col-md-3 pdt5">- Xã/ Phường</div>
                    <div class="col-md-9 pdt5">
                        <asp:DropDownList ID="XaPhuong" Enabled="false" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="clear pdt5"></div>
                    <div class="col-md-3 pdt5">- Thôn, ấp, số nhà</div>
                    <div class="col-md-9 pdt5">
                        <asp:TextBox ID="SoNha" runat="server" ReadOnly="true" CssClass="std med" />
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
            <div class="col-md-5">
                <div class="row">
                    <div class="col-md-4 pdt5 txt-right">Năm thông báo</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="Years_ID" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdt5 txt-right">Kỳ thông báo</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="Period_ID" runat="server" CssClass="selectpicker" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-4 pdt5 txt-right">Ngày thông báo</div>
                    <div class="col-md-8">
                        <div class="rccalpopup">
                            <asp:TextBox ID="NgayThongBao" Placeholder="dd/mm/yyyy" CssClass="datepicker std med validate[required]" runat="server" />
                        </div>
                    </div>
                    <div class="clr clUp "></div>
                    <div class="clear"></div>
                </div>
            </div>
            <div class="clear"></div>
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-12 pdt5"><strong>DANH SÁCH ĐẦU MỤC NỘP THÔNG BÁO</strong></div>
                    <div class="col-md-12">
                        <table cellspacing="0" cellpadding="3" rules="all" border="1" style="width: 100%; border-collapse: collapse;">
                            <tbody>
                                <tr>
                                    <td class="hdTitle" style="width: 4%; text-align: center">STT</td>
                                    <td class="hdTitle">Tên thông báo</td>
                                    <td class="hdTitle" style="width: 7%; text-align: center">File mẫu</td>
                                    <td class="hdTitle" style="width: 10%; text-align: center">File đính kèm</td>
                                    <td class="hdTitle" style="width: 40%;">Kết quả</td>
                                </tr>
                                <tr style="background-color: #F8F4F1;">
                                    <td style="width: 4%; text-align: center">1</td>
                                    <td>Mẫu 28 - Thông báo lần đầu về số lao động đang làm việc tại đơn vị</td>
                                    <td style="text-align: center"><a href="/data/template/mau28.xlsx" title="Tải mẫu Thông báo ban đầu về số lao động đang làm việc tại đơn vị">
                                        <img src="/image/images/Download.png" alt="Tải xuống" /></a></td>
                                    <td style="text-align: center">
                                        <div id="cup0" runat="server" class="cmsbtupload" onclick="upfile(0)" title="Đẩy mẫu Thông báo ban đầu về số lao động đang làm việc tại đơn vị">Đẩy file</div>
                                    </td>
                                    <td>
                                        <div class="div-upload0 none">
                                            <img style="position: relative;" alt="waiting" src="/image/images/ajax-loader2.gif" />
                                        </div>
                                        <asp:Literal ID="Msg00" runat="server"></asp:Literal>
                                    </td>
                                </tr>
                                <tr style="background-color: White;">
                                    <td style="width: 4%; text-align: center">2</td>
                                    <td>Mẫu 29 - I. Thông tin về số lao động đầu kỳ - cuối kỳ</td>
                                    <td style="text-align: center"><a href="/data/template/mau29i.xlsx" title="Tải mẫu Thông tin về số lao động đầu kỳ - cuối kỳ">
                                        <img src="/image/images/Download.png" alt="Tải xuống" /></a></td>
                                    <td style="text-align: center">
                                        <div id="cup1" runat="server" class="cmsbtupload" onclick="upfile(1)" title="Đẩy mẫu Thông tin về số lao động đầu kỳ - cuối kỳ">Đẩy file</div>
                                    </td>
                                    <td>
                                        <div class="div-upload1 none">
                                            <img style="position: relative;" alt="waiting" src="/image/images/ajax-loader2.gif" />
                                        </div>
                                        <asp:Literal ID="Msg01" runat="server"></asp:Literal>
                                    </td>
                                </tr>
                                <tr style="background-color: #F8F4F1;">
                                    <td style="width: 4%; text-align: center">3</td>
                                    <td>Mẫu 29 - II. Danh sách lao động giảm</td>
                                    <td style="text-align: center"><a href="/data/template/mau29ii.xlsx" title="Tải mẫu Danh sách lao động giảm">
                                        <img src="/image/images/Download.png" alt="Tải xuống" /></a></td>
                                    <td style="text-align: center">
                                        <div id="cup2" runat="server" class="cmsbtupload" onclick="upfile(2)" title="Đẩy mẫu Danh sách lao động giảm">Đẩy file</div>
                                    </td>
                                    <td>
                                        <div class="div-upload2 none">
                                            <img style="position: relative;" alt="waiting" src="/image/images/ajax-loader2.gif" />
                                        </div>
                                        <asp:Literal ID="Msg02" runat="server"></asp:Literal>
                                    </td>
                                </tr>
                                <tr style="background-color: White;">
                                    <td style="width: 4%; text-align: center">4</td>
                                    <td>Mẫu 29 - III. Danh sách lao động tăng</td>
                                    <td style="text-align: center"><a href="/data/template/mau29iii.xlsx" title="Tải mẫu Danh sách lao động tăng">
                                        <img src="/image/images/Download.png" alt="Tải xuống" /></a></td>
                                    <td style="text-align: center">
                                        <div id="cup3" runat="server" class="cmsbtupload" onclick="upfile(3)" title="Đẩy mẫu Danh sách lao động tăng">Đẩy file</div>
                                    </td>
                                    <td>
                                        <div class="div-upload3 none">
                                            <img style="position: relative;" alt="waiting" src="/image/images/ajax-loader2.gif" />
                                        </div>
                                        <asp:Literal ID="Msg03" runat="server"></asp:Literal>
                                    </td>
                                </tr>
                                <tr style="background-color: #F8F4F1;">
                                    <td style="width: 4%; text-align: center">5</td>
                                    <td>Mẫu 29 - IV. Tạm hoãn thực hiện hợp đồng lao động</td>
                                    <td style="text-align: center"><a href="/data/template/mau29iv.xlsx" title="Tải mẫu Tạm hoãn thực hiện hợp đồng lao động">
                                        <img src="/image/images/Download.png" alt="Tải xuống" /></a></td>
                                    <td style="text-align: center">
                                        <div id="cup4" runat="server" class="cmsbtupload" onclick="upfile(4)" title="Đẩy mẫu Tạm hoãn thực hiện hợp đồng lao động">Đẩy file</div>
                                    </td>
                                    <td>
                                        <div class="div-upload4 none">
                                            <img style="position: relative;" alt="waiting" src="/image/images/ajax-loader2.gif" />
                                        </div>
                                        <asp:Literal ID="Msg04" runat="server"></asp:Literal>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class="col-md-12">
                <asp:Literal ID="litUpdate" runat="server" />
            </div>
        </div>
        <asp:HiddenField ID="ItemID" runat="server" Visible="true" />
        <asp:HiddenField ID="DoanhNghiepID" runat="server" Visible="false" />
    </div>
</div>
<div class="row text-center pd10">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdUpdate" runat="server" Text="Cập nhật" CssClass="cmsbut cmsbtupdate" OnClientClick="return $('#Form').validationEngine('validate'); " />
        <asp:Button ID="cmdNext" runat="server" Text="Nộp thông báo" CssClass="cmsbut cmsbSaves cbclick" />
        <asp:Button ID="cmdDelete" runat="server" Text="Xóa thông báo" CssClass="cmsbut cmsbtdel" />
        <div class="clr "></div>
    </div>
</div>
<asp:Button runat="server" ID="cmdUpfile" CssClass="none" />
<asp:FileUpload ID="fileImages" onchange="upLoad()" accept=".xlsx,.xls" CssClass="none" AllowMultiple="false" runat="server" />
<asp:HiddenField runat="server" ID="FileFlag" />
<asp:HiddenField runat="server" ID="pathTemp" Visible="false" />

<script>
    function doneUpload(t) { $(".div-upload" + t).addClass("none"); }; function upfile(t) { $(".div-upload" + t).removeClass("none"); $("#<%=FileFlag.ClientID %>").val(t); jQuery("#<%= fileImages.ClientID%>").click(); };
    function upLoad() { var t = $("#<%=FileFlag.ClientID %>").val(); $(".div-upload" + t).removeClass("none"); jQuery("#" + '<%= cmdUpfile.ClientID%>').click(); };
</script>
