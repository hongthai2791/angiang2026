<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="MAIN.ascx.vb" Inherits="DesktopModules.Modules.Home.MAIN" %>
<div class="kiosk-main kiosk-body">
    <style>
        h1 {
            margin-top: 20px;
            color: #fff;
            font-size: 3em;
            font-weight: bold;
            margin-bottom: 20px;
        }

        .grid-container {
            display: grid;
            grid-template-columns: repeat(2, 1fr);
            gap: 20px;
        }

        .card {
            background: #2A7B9B;
            background: linear-gradient(90deg,rgba(42, 123, 155, 1) 0%, rgba(87, 199, 133, 1) 50%, rgba(237, 221, 83, 1) 100%);
            color: white;
            padding: 40px;
            border-radius: 10px;
            text-decoration: none;
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            transition: transform 0.3s, background-color 0.3s;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
        }

            .card:hover {
                transform: translateY(-5px);
                background-color: #0056b3;
            }

        .card-icon {
            font-size: 4em;
            margin-bottom: 10px;
        }

        .card-text {
            font-size: 1.5em;
            font-weight: bold;
            color: #fff
        }
        /* Tùy chỉnh cho popup */
        .modal-body {
            display: flex;
            flex-direction: column;
            gap: 15px;
        }
        /* Tùy chỉnh kích thước nút lớn hơn cho KIOSK */
        .btn-kiosk-lg {
            padding: 3rem 3rem;
            font-size: 2.2rem;
            min-width: 300px;
            margin: 10px;
        }
        /* Kiểu phiếu in */
        .phieu-in {
            font-family: 'Courier New', Courier, monospace;
            text-align: center;
            padding: 20px;
        }

            .phieu-in h4 {
                font-weight: bold;
                margin-bottom: 5px;
            }

            .phieu-in h2 {
                font-size: 4em;
                margin: 20px 0;
            }

            .phieu-in p {
                margin: 5px 0;
                font-size: 1.2em;
            }
    </style>
    <div class="pd10">
        <h1>CHÀO MỪNG QUÝ KHÁCH</h1>
        <p style="font-size: 18px; color: #fff; margin-bottom: 20px">Vui lòng chạm vào chức năng bạn muốn sử dụng</p>

        <div class="grid-container">

            <!-- Chức năng 1: Tra cứu văn bản pháp luật -->
            <a onclick="findDocument()" class="card shadow">
                <span class="card-icon">&#128220;</span>
                <span class="card-text">Tra cứu văn bản pháp luật</span>
            </a>

            <!-- Chức năng 2: Tìm kiếm tin tuyển dụng -->
            <a onclick="findWork()" class="card shadow">
                <span class="card-icon">&#128188;</span>
                <span class="card-text">Tìm kiếm tin tuyển dụng</span>
            </a>

            <!-- Chức năng 3: Kết nối thông tin người lao động -->
            <a onclick="showConnectModal()" class="card shadow">
                <span class="card-icon">&#128100;</span>
                <span class="card-text">Kết nối thông tin người lao động</span>
            </a>

            <!-- Chức năng 4: Đăng ký lấy số thứ tự -->
            <a onclick="showSoThuThu()" class="card shadow" id="btnLaySoThuTu">
                <span class="card-icon">&#128290;</span>
                <span class="card-text">Đăng ký lấy số thứ tự</span>
            </a>
        </div>

    </div>

    <div class="timer">
        <i class="fa fa-clock-o "></i>&nbsp;<span id="clock"></span>&nbsp;&nbsp; <i class="fa fa-map-marker"></i>&nbsp;Trung tâm DVVL An Giang
    </div>
    <!-- Modal mới cho chức năng kết nối thông tin người lao động -->

    <div class="modal fade" id="connectModal" role="dialog">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Kết nối/Tra cứu thông tin người lao động</h5>

                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label for="txtCCCD">Nhập số Căn cước công dân (CCCD)</label>
                        <input type="text" id="txtCCCD" class="form-control mgt10" style="font-size: 24px; padding: 20px" placeholder="Nhập số CCCD" />
                        <button type="button" onclick="findNguoiTimViec()" class="btn btn-success mgt10" style="width: 100%; padding: 15px 20px;">Tìm kiếm</button>

                    <div id="resultNguoiTimViec" class=" panel panel-info pd10" style="text-align: left;font-weight:normal;line-height: 25px;margin-bottom:0">
                        <div class="row">
                            <div class="col-xs-3  ">Họ tên:</div>
                            <div class="col-xs-9 lb ntv_hoten">--</div>
                            <div class="clear"></div>
                            <div class="col-xs-3  ">Ngày sinh:</div>
                            <div class="col-xs-9 lb ntv_ngaysinh">--</div>
                            <div class="clear"></div>
                            <div class="col-xs-3  ">Giới tính:</div>
                            <div class="col-xs-9 lb ntv_gioitinh">--</div>
                            <div class="clear"></div>
                            <div class="clear"></div>
                            <div class="col-xs-3  ">Địa chỉ:</div>
                            <div class="col-xs-9 lb ntv_diachi">--</div>
                            <div class="clear"></div>
                        </div>
                    </div>
                    </div>
                    <div class="text-center">
                        <button type="button" style="width: 100%; padding: 15px 20px;" id="btnQuetQR" class="btn btn-primary qr-button" onclick="startScanner()">
                            <i class="fa fa-qrcode"></i>
                           Quét mã QR trên phiếu hẹn
                        </button>
                         
                    </div>
                       <asp:TextBox style="border:none;color:#fff;position:absolute;width:50px;bottom:20px;z-index:-9999"  runat="server"  CssClass="txtResult" onblur="startScanner()" ID="txtQRText" onfocus="startScanner()"></asp:TextBox>
                      <div id="resultPhieuHen" class=" panel panel-info pd10" style="text-align: left;font-weight:normal;line-height: 25px;margin-bottom:0">
      <div class="row">
          <div class="col-xs-3  ">Họ tên:</div>
          <div class="col-xs-9 lb ntv_hoten">--</div>
          <div class="clear"></div>
          <div class="col-xs-3  ">Ngày sinh:</div>
          <div class="col-xs-9 lb ntv_ngaysinh">--</div>
          <div class="clear"></div>
          <div class="col-xs-3  ">Mã phiếu:</div>
          <div class="col-xs-9 lb ntv_maphieu">--</div>
          <div class="clear"></div>
          <div class="clear"></div>
          <div class="col-xs-3  ">Ngày tiếp nhận:</div>
          <div class="col-xs-9 lb ntv_ngaytiepnhan">--</div>
          <div class="clear"></div>
          <div class="col-xs-3  ">Ngày hẹn trả:</div>
          <div class="col-xs-9 lb ntv_ngayhentra">--</div>
          <div class="clear"></div>
      </div>
  </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Thoát</button>

                </div>
            </div>
        </div>
    </div>
    <!-- Modal cho phần Đăng ký lấy số thứ tự -->
    <div class="modal fade" id="laySoThuTuModal" tabindex="-1" aria-labelledby="laySoThuTuModalLabel" aria-hidden="true" data-bs-backdrop="static" data-bs-keyboard="false">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="laySoThuTuModalLabel">Đăng ký lấy số thứ tự</h5>
                </div>
                <div class="modal-body">
                    Vệ tinh
       <asp:DropDownList ID="VeTinh" runat="server" CssClass="selectpicker"></asp:DropDownList>
                    <button type="button" onclick="laySoThuThu(1)" class="btn btn-danger btn-kiosk-lg">Đăng ký hưởng BHTN</button>
                    <button type="button" onclick="laySoThuThu(2)" class="btn btn-success btn-kiosk-lg">Đăng ký học nghề</button>
                    <button type="button" onclick="laySoThuThu(3)" class="btn btn-primary btn-kiosk-lg">Đăng ký tư vấn</button>
                    <button type="button" onclick="laySoThuThu(4)" class="btn btn-warning btn-kiosk-lg">Thông báo tìm kiếm việc làm</button>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" onclick="closeSoThuThu()" data-bs-dismiss="modal">Đóng</button>
                </div>
            </div>
        </div>
    </div>
    <!-- Modal cho phiếu in -->
    <div class="modal fade" id="phieuInModal" tabindex="-1" aria-labelledby="phieuInModalLabel" aria-hidden="true" data-bs-backdrop="static" data-bs-keyboard="false">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="phieuInModalLabel">Phiếu số thứ tự</h5>
                </div>
                <div class="modal-body">
                    <div class="phieu-in">
                        <h4>TRUNG TÂM DVVL AN GIANG</h4>
                        <p id="tenVeTinh"><%=VeTinh.SelectedItem.Text %></p>
                        <hr>
                        <h2 id="soThuTu">1</h2>
                        <p id="tenDichVu"></p>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" id="btnPrint" onclick="printTicket()">In</button>
                    <button type="button" class="btn btn-secondary" onclick="closeLaySoThuThu()" data-bs-dismiss="modal">Đóng</button>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="modal fade" id="dynamicModal" tabindex="-1" role="dialog" aria-labelledby="dynamicModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="dynamicModalLabel">Trình tìm kiếm việc làm</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                <iframe id="modalIframe" src="" frameborder="0" style="width: 100%; height: 80vh;"></iframe>
            </div>
        </div>
    </div>
</div>

<script>

    function findPhieuHen(qr) {
        let qrCode = qr;
        if (qrCode === "") return;
        waiting();
        // Gọi API để tìm kiếm thông tin người lao động
        const apiUrl = '/api/home/kiosk.asmx/FindPhieuHen?qrcode=' + qrCode;
        debugger;
        try {
            $.ajax({
                type: "GET", url: apiUrl,
                success: function (data) {
                    var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                        if (json.data != "") {
                            $('#resultPhieuHen .ntv_hoten').html(json.data.hoTen); // Họ tên
                            $('#resultPhieuHen .ntv_ngaysinh').html(json.data.ngaySinh); // Ngày sinh
                            $('#resultPhieuHen .ntv_maphieu').html(json.data.maPhieu); 
                            $('#resultPhieuHen .ntv_ngaytiepnhan').html(json.data.ngayTiepNhan);
                            $('#resultPhieuHen .ntv_ngayhentra').html(json.data.ngayHenTra);
                        } else {
                            alert('Không tìm thấy thông tin phiếu hẹn.');
                            $('#resultPhieuHen .lb').html('--');
                        }
                    };
                    removewaiting();
                },
            });
        } catch (error) {
            alert('Đã xảy ra lỗi khi kết nối đến máy chủ. Vui lòng thử lại sau.');
            removewaiting();
            return false;
        }
        return false;
    }
    function findNguoiTimViec() {
        var cccd = document.getElementById('txtCCCD').value;
        if (cccd.length != 12 && cccd.length != 9) {
            alert('Số CCCD không hợp lệ. Vui lòng kiểm tra lại.');
            return false;
        }
        waiting();
        // Gọi API để tìm kiếm thông tin người lao động
        const apiUrl = '/api/home/kiosk.asmx/FindNguoiTimViec?cccd=' + cccd;
        try {
            $.ajax({
                type: "GET", url: apiUrl,
                success: function (data) {
                    var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                        if (json.data != "") {
                            $('#resultNguoiTimViec .ntv_hoten').html(json.data.hoTen); // Họ tên
                            $('#resultNguoiTimViec .ntv_ngaysinh').html(json.data.ngaySinh); // Ngày sinh
                            $('#resultNguoiTimViec .ntv_gioitinh').html(json.data.gioiTinh); // Giới tính
                            $('#resultNguoiTimViec .ntv_diachi').html(json.data.diaChi); // Địa chỉ
                        } else {
                            alert('Không tìm thấy thông tin người lao động với số CCCD đã nhập.');
                            $('#resultNguoiTimViec .lb').html('--');
                        }
                    };
                    removewaiting();
                },
            });
        } catch (error) {
            alert('Đã xảy ra lỗi khi kết nối đến máy chủ. Vui lòng thử lại sau.');
            removewaiting();
            return false;
        }
        return false;
    }
    function showConnectModal() {
        $("#connectModal").modal('show');
        return false;
    }
    function closeConnectModal() {
        $("#connectModal").modal('hide');
        return false;
    }
    function getTicketNumber(flag) {
        // Thay thế URL này bằng URL API thực tế của bạn

    }
    function laySoThuThu(flag) {
        waiting();
        $("#laySoThuTuModal").modal('hide');
        $("#phieuInModal").modal('show');

        // Lấy tên dịch vụ từ data attribute và cập nhật vào phiếu in
        var serviceName = 'Đăng ký hưởng BHTN';
        if (flag == 2) {
            serviceName = 'Đăng ký học nghề';
        }
        else if (flag == 3) {
            serviceName = 'Đăng ký tư vấn';
        }
        else if (flag == 4) {
            serviceName = 'Thông báo tìm kiếm việc làm';
        }
        document.getElementById('soThuTu').innerText = '0';
        document.getElementById('tenVeTinh').innerText = $('#<%=VeTinh.ClientID%> option:selected').text();
        document.getElementById('tenDichVu').innerText = 'Dịch vụ: ' + serviceName;
        // Lấy số thứ tự từ hàm giả lập AJAX
        var ticketNumber = getTicketNumber(flag);

        const apiUrl = '/api/home/kiosk.asmx/values?pid=<%=EPORTAL.flReg.WebConfig("TinhTP")%>&flag=' + flag + '&vetinh=' + $('#<%=VeTinh.ClientID%>').val();
        try {
            $.ajax({
                type: "GET", url: apiUrl,
                success: function (data) {
                    var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                        if (json.data != "") {
                            document.getElementById('soThuTu').innerText = json.data;
                        } else {
                            document.getElementById('soThuTu').innerText = 'NAN'
                        }
                    };
                },
            });

        } catch (error) {
            return '0';
        }



        removewaiting();
        return false;
    }
    // Hàm JavaScript để in phiếu
    function printTicket() {
        var printContents = document.querySelector('.phieu-in').innerHTML;
        var originalContents = document.body.innerHTML;

        document.body.innerHTML = printContents;
        window.print();
        document.body.innerHTML = originalContents;
        location.reload(); // Tải lại trang để khôi phục các sự kiện và trạng thái
    }
    function closeLaySoThuThu(flag) {
        waiting();
        document.getElementById('soThuTu').innerText = '0';
        $("#laySoThuTuModal").modal('hide');
        $("#phieuInModal").modal('hide');
        removewaiting();
        return false;
    }


    function showSoThuThu() {
        $("#laySoThuTuModal").modal('show');
        return false;
    }

    function closeSoThuThu() {
        $("#laySoThuTuModal").modal('hide');
        return false;
    }

    function findWork() {
        $("#dynamicModalLabel").html("Tìm kiếm việc làm");
        var url = "/tim-kiem-viec-lam";
        $("#modalIframe").attr("src", url);
        $("#dynamicModal").modal('show');
        return false;
    }

    function findDocument() {
        $("#dynamicModalLabel").html("Tìm kiếm văn bản");
        var url = "/tra-cuu-van-ban";
        $("#modalIframe").attr("src", url);
        $("#dynamicModal").modal('show');
        return false;
    }

    function startScanner() {
        var t = "#btnQuetQR";
        if ($(t).hasClass("btn-primary") == true) {
            var input = document.getElementById("<%= txtQRText.ClientID %>");
            var inputVal = "";
            input.addEventListener("keypress", function (event) {
                if (event.key === "Enter") {
                    event.preventDefault();
                    if (input.value != "") {
                        findPhieuHen(input.value);
                    }
                    input.value = ""
                }
            });
            input.focus();
            $(t).removeClass("btn-primary");
            $(t).addClass("btn-warning");
            $(t).html("<i class='fa fa-stop'></i>&nbsp; Đưa mã QR đến gần máy quét");
        }
        else {
            stopScanner();
        }
    }

    function stopScanner() {
        var t = "#btnQuetQR";
        $(t).removeClass("btn-warning");
        $(t).addClass("btn-primary");
        $(t).html("<i class='fa fa-qrcode'></i>&nbsp; Quét mã QR trên phiếu hẹn");
    }
    $('#dynamicModal').on('hidden.bs.modal', function (e) {
        $("#modalIframe").attr("src", "");
    })

    $('#connectModal').on('hidden.bs.modal', function (e) {
        $('#resultNguoiTimViec .lb').html('--');
    })

</script>
<script>
    var span = document.getElementById('clock');

    function time() {
        var d = new Date();
        var s = d.getSeconds();
        var m = d.getMinutes();
        var h = d.getHours();
        span.textContent =
            ("0" + h).substr(-2) + ":" + ("0" + m).substr(-2) + ":" + ("0" + s).substr(-2);
    }

    setInterval(time, 1000);
    var elem = document.documentElement;
    function openFullscreen() {
        if (elem.requestFullscreen) {
            elem.requestFullscreen();
        } else if (elem.webkitRequestFullscreen) { /* Safari */
            elem.webkitRequestFullscreen();
        } else if (elem.msRequestFullscreen) { /* IE11 */
            elem.msRequestFullscreen();
        }
    }

</script>
