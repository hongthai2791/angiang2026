<%@ Control Language="VB" AutoEventWireup="false" CodeFile="SearchAdv.ascx.vb" Inherits="DesktopModules.Modules.Home.SearchAdv" %>

<div class="search-job row">
    <div class="search-job-content">
        <div class="row">
            <div class="box-search">
                <div class="col-md-4 col-xs-8">
                    <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control input-search ui-autocomplete-input" value="" placeholder="Tiêu đề tuyển dụng, tên doanh nghiệp ..." autocomplete="off"></asp:TextBox>

                </div>
                <div class="col-md-3 col-xs-12 hidden-xs ">
                    <asp:DropDownList CssClass="selectpicker" ID="QuanHuyen" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-3 col-xs-12 hidden-xs ">
                    <asp:DropDownList CssClass="selectpicker" ID="NganhNghe" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-2 col-xs-4">
                    <asp:LinkButton ID="cmdSearch" runat="server" CssClass="btn btn-topcv btn-search-job"  ><i class="fa fa-search"></i>&nbsp; Tìm kiếm</asp:LinkButton>

                    </div>
                <div class="clear"></div>
                
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

