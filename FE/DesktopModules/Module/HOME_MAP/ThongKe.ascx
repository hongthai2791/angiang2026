<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="ThongKe.ascx.vb" Inherits="DesktopModules.Modules.Home.ThongKe" %>
<style>
    .item-small{
        font-size:20px
    }
  .item-small .number span{
      
        font-size:25px !important;
        color:#fba33d !important;
    }
  .statistics .item p{
      
        font-size:20px !important
  }
  .statistics .item-small p{
      
        font-size:15px !important
  }
</style>
<section class="sptb">

    <div class="container journey">
        <div class="col-md-6">
            <div class="left-tke">
                <h3><span>Con số ấn tượng</span></h3>
                <div class="statistics">

                    <div class="item">
                        <div class="number">
                            <span class="counter info-box-number" ><%=CoViecLam %></span>
                        </div>
                        <p>có việc làm</p>
                    </div>
                    <div class="item">
                        <div class="number">
                            <span class="counter info-box-number" ><%=LucLuongLD %></span>
                        </div>
                        <p>lực lượng lao động</p>
                    </div>
                    <div class="item">
                        <div class="number">
                            <span class="counter info-box-number" ><%=HoatDongKte %></span>
                        </div>
                        <p>hoạt động kinh tế</p>
                    </div>
                    <div class="item">
                        <div class="number">
                            <span class="counter info-box-number" ><%=DanSo15 %></span>
                        </div>
                        <p>dân số 15+</p>
                    </div>
                    <div class="item">
                        <div class="number">
                            <span class="counter info-box-number" ><%=HoatDongKte %></span>
                        </div>
                        <p>thất nghiệp</p>
                    </div>
                    <div class="item">
                        <div class="number">
                            <span class="counter info-box-number" ><%=DanSo15 %></span>
                        </div>
                        <p>không hoạt động kinh tế</p>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <div class="right-tke">
                  <div class="statistics">
                      
                    <div class="item" style="width:100%">
                        <div class="number">
                            <span class="counter info-box-number" >1.109</span>
                        </div>
                        <p>doanh nghiệp</p>
                    </div>
                      <br />
                    <div class="item">
                        <div class="number">
                            <span class="counter info-box-number" >4.019</span>
                        </div>
                        <p>việc làm trống</p>

                    <div class="item-small">
                        <div class="number">
                            <span class="counter info-box-number" >1.136</span>
                        </div>
                        <p>Ngành công nghiệp</p>
                    </div>

                    <div class="item-small">
                        <div class="number">
                            <span class="counter info-box-number" >1.963</span>
                        </div>
                        <p>Ngành nông nghiệp</p>
                    </div>
                        
                    <div class="item-small">
                        <div class="number">
                            <span class="counter info-box-number" >920</span>
                        </div>
                        <p>Ngành dịch vụ</p>
                    </div>
                    </div>

                    <div class="item">
                        <div class="number">
                            <span class="counter info-box-number" >340</span>
                        </div>
                        <p>Hồ sơ tìm việc</p>
                        
                    <div class="item-small">
                        <div class="number">
                            <span class="counter info-box-number" >70</span>
                        </div>
                        <p>Độ tuổi: 18-24 </p>
                    </div>
                    <div class="item-small">
                        <div class="number">
                            <span class="counter info-box-number" >80</span>
                        </div>
                        <p>Độ tuổi: 25-24</p>
                    </div>
                    <div class="item-small">
                        <div class="number">
                            <span class="counter info-box-number" >150</span>
                        </div>
                        <p>Độ tuổi: 35-54</p>
                    </div>
                    <div class="item-small">
                        <div class="number">
                            <span class="counter info-box-number" >40</span>
                        </div>
                        <p>Độ tuổi: 55+</p>
                    </div>
                    </div>
                      </div>
                <%--<img src="./images/map/img-map.jpg" />--%>
            </div>
        </div>
    </div>

</section>
<%--<script>
    $('.info-box-number').each(function () {
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
</script>--%>
