<%@ Control Language="VB" AutoEventWireup="false" CodeFile="SearchAdv.ascx.vb" Inherits="DesktopModules.Modules.Home.SearchAdv" %>

<div class="search-job row">
    <div class="search-job-content">
        <div class="row">
            
                <div class="col-md-12 text-center pb10 hidden-xs " style="color:#fff">
                        <div class="col-md-4">    Số tin tuyển dụng: <span="counter-num" style="color:yellow;font-weight:bold"> <%=SoTinTuyenDung %></span></div>
                        <div class="col-md-4">    Số nhà tuyển dụng: <span="counter-num" style="color:yellow;font-weight:bold"> <%=SoNhaTuyenDung %></span></div>
                        <div class="col-md-4">    Số hồ sơ tìm việc: <span="counter-num" style="color:yellow;font-weight:bold"> <%=SoHoSo %></span></div>
               
                </div>
            <div class="box-search">
                <div class="col-md-4 col-xs-8">
                    <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control input-search ui-autocomplete-input" value="" placeholder="Vị trí, mức lương ..." autocomplete="off"></asp:TextBox>

                </div>
                <div class="col-md-3 col-xs-12 hidden-xs ">
                    <asp:DropDownList CssClass="selectpicker" ID="TinhTP" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-3 col-xs-12 hidden-xs ">
                    <asp:DropDownList CssClass="selectpicker" ID="NganhNghe" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-2 col-xs-4">
                    <asp:LinkButton ID="cmdSearch" runat="server" CssClass="btn btn-topcv btn-search-job"  ><i class="fa fa-search"></i>&nbsp; Tìm kiếm</asp:LinkButton>

                    </div>
                <div class="clear"></div>
                
            <div class="categories-feature hidden-xs mt20">
                <div class="item-category">
                    <a href="viec-lam/nganh-nghe/ban-hang-9">
                        <h6 class="text">Bán hàng</h6>
                    </a>
                </div>

                <div class="item-category">
                    <a href="viec-lam/nganh-nghe/ban-le-ban-si-40">

                        <h6 class="text">Kinh doanh</h6>
                    </a>
                </div>

                <div class="item-category">
                    <a href="viec-lam/nganh-nghe/tu-van-52">

                        <h6 class="text">Nhà hàng / Khách sạn</h6>
                    </a>
                </div>

                <div class="item-category">
                    <a href="viec-lam/nganh-nghe/it-phan-mem-38">

                        <h6 class="text">Công nghệ thông tin</h6>
                    </a>
                </div>

                <div class="item-category">
                    <a href="viec-lam/nganh-nghe/bat-dong-san-4">

                        <h6 class="text">Tài chính / Đầu tư</h6>
                    </a>
                </div>

                <div class="item-category">
                    <a href="viec-lam/nganh-nghe/dich-vu-khach-hang-39">

                        <h6 class="text">Bảo hiểm</h6>
                    </a>
                </div>
            </div>
            </div>

        </div>
    </div>
</div>
<script>
    $('.counter-num').each(function () {
        $(this).prop('Counter', 0).animate({
            Counter: $(this).text()
        }, {
            duration: 2000,
            easing: 'swing',
            step: function (now) {
                $(this).text(Math.ceil(now));
            }
        });
    });
</script>

