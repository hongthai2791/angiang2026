<%@ Control Language="VB" AutoEventWireup="false" CodeFile="QRCheckList.ascx.vb" Inherits="DesktopModules.View.QRCheckList" %>
<style>
    .skin-blue-light .content-wrapper, .skin-blue-light .main-footer {
        overflow: auto
    }

    .valid-row {
        background-color: lightgreen !important; /* Màu xanh nhạt */
        font-weight: bold;
    }

    .btnUpload {
        height: 40px !important;
        width: 100% !important;
        padding: 4px 6px !important;
    }

        .btnUpload:hover {
            background-color: #9ef3c44f;
            border-color: #39865e;
        }

    .qr-container {
        height: auto;
        overflow-y: auto;
        overflow-x: auto;
        box-sizing: border-box;
        padding: 5px 10px;
        border: 2px solid pink;
    }

    .excel-info {
        margin-top: 10px;
        overflow-y: auto;
        overflow-x: hidden;
        box-sizing: border-box;
        padding: 5px 10px;
        border: 2px solid #337ab7;
    }

    .result-info {
        height: auto;
        padding: 10px;
        border: 2px solid gray;
    }

    .result-success {
        padding: 10px;
        border: 2px solid green;
    }

    .result-danger {
        padding: 10px;
        border: 2px solid red;
    }

    input[type=file] {
        padding: 8px 20px !important;
        border: 2px dashed red;
    }

    .table-container {
        max-height: 400px; /* Chiều cao tối đa của bảng */
        overflow-y: auto; /* Cho phép cuộn dọc */
        border: 1px solid #ccc;
        position: relative;
    }

        .table-container table {
            width: 100%;
            border-collapse: collapse;
        }

        .table-container thead {
            position: sticky;
            top: -1px;
            background-color: white; /* Giữ tiêu đề nổi bật */
            z-index: 2;
            box-shadow: 0 2px 2px rgba(0, 0, 0, 0.1); /* Đổ bóng nhẹ */
        }

        .table-container th, .table-container td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

    .filter-row {
        position: sticky;
        top: -2px; /* Đẩy xuống dưới hàng tiêu đề */
        background-color: #f8f8f8;
        z-index: 1;
    }

        .filter-row input {
            width: 100%;
            padding: 5px;
            border: 1px solid #ccc;
        }

    .table-container tbody tr.selected {
        background-color: pink !important;
        color: #000;
        font-weight: bold;
    }

    .table > tbody > tr > td, .table > tbody > tr > th, .table > tfoot > tr > td, .table > tfoot > tr > th, .table > thead > tr > td, .table > thead > tr > th {
        line-height: 0;
        font-size: 11px;
    }

    textarea {
        background: linear-gradient(white, white) padding-box, conic-gradient( from var(--border-angle), oklch(100% 100% 0deg), oklch(100% 100% 45deg), oklch(100% 100% 90deg), oklch(100% 100% 135deg), oklch(100% 100% 180deg), oklch(100% 100% 225deg), oklch(100% 100% 270deg), oklch(100% 100% 315deg), oklch(100% 100% 360deg) ) border-box;
    }

        textarea:focus {
            animation: border-angle-rotate 2s infinite linear;
        }

    @keyframes border-angle-rotate {
        from {
            --border-angle: 0deg;
        }

        to {
            --border-angle: 360deg;
        }
    }
</style>
<script src="../../../../js/tools/jsQR.min.js?v=1.1"></script>

<%@ Register Src="~/DesktopModules/Module/DIC/Main/Breadcum.ascx" TagPrefix="uc1" TagName="Breadcum" %>


<div class="box box-info ">
    <div class="box-header with-border acv-header ">
        <div class="col-md-6 col-xs-6">
            <h3 class="box-title">HẬU KIỂM HÀNG HÓA</h3>

        </div>
        <div class="col-md-6 col-xs-6 text-right">
            <uc1:Breadcum runat="server" ID="Breadcum" />

        </div>
    </div>
    <div class="box-body acv-body">
        <div class="main-body">
            <div class="row">
                <div class="col-md-6">
                    <div class="row">

                        <asp:FileUpload ID="_FileUpload" AllowMultiple="true" CssClass=" btnUpload" Style="padding-top: 15px" runat="server" Width="80%" />
                        <div class="pdt5"></div>
                        Hàng bắt đầu đọc:
                        <input typ="text" style="width: 50px" id="txtRow" value="3" />
                        Cột Mã đơn:
                        <input typ="text" style="width: 50px" id="txtOrderId" value="A" />
                        Cột loại hoàn:
                        <input typ="text" style="width: 50px" id="txtTYPE_ID" value="B" />
                        Cột Mã vận đơn:
                        <input typ="text" style="width: 50px" id="txtTracking" value="AI" />
                        Cột ngày đi:
                        <input typ="text" style="width: 50px" id="txtTimeRe" value="AB" />
                        Cột ngày hoàn:
                        <input typ="text" style="width: 50px" id="txtDATE_ID" value="AD" />
                        <a id="btnTaiLen" style="width: 100%" class="btn  btn-warning shadow mgt10" tooltip="Tải các tệp đã chọn lên">
                            <i class="fa fa-cloud-upload"></i>Tải tệp lên
                        </a>

                    </div>
                    <div class="row">
                        <div class="excel-info ">
                            <div class="row">
                                <div class="label label-info "><i class="fa fa-info"></i>&nbsp;&nbsp;Thông tin đọc từ tệp Excel</div>
                                <strong>Tổng số bản ghi:</strong> <span id="totalRecords">0</span>
                                <div class="row table-container" style="overflow: auto; height: 255px">
                                    <table id="excelTable" class="table" style="line-height: 0px">
                                        <thead>
                                            <tr>
                                                <th style="width: 30px">ID </th>
                                                <th style="width: 100px">Mã đơn </th>
                                                <th style="width: 100px">Mã vận đơn </th>
                                                <th style="width: 70px">Loại hoàn </th>
                                                <th>Ngày đi </th>
                                                <th>Ngày hoàn </th>
                                            </tr>
                                            <tr class="filter-row">
                                                <th>
                                                    <input type="text" id="filter-id"></th>
                                                <th>
                                                    <input type="text" id="filter-tracking"></th>
                                                <th>
                                                    <input type="text" id=""></th>
                                                <th>
                                                    <input type="text" id=""></th>
                                                <th>
                                                    <input type="date" id="from-date" style="width: 50px">-
                    <input type="date" id="to-date" style="width: 50px"></th>
                                                <th>
                                                    <input type="date" id="tfrom-date" style="width: 50px">-
                    <input type="date" id="tto-date" style="width: 50px"></th>
                                            </tr>
                                        </thead>
                                        <tbody id="excelDataBody">
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <p><a onclick="exportFile()" data-toggle="tooltip" title="Xuất lại file excel, tự động đánh dấu trong file các mã không tồn tại là màu đỏ">Xuất lại tệp sau khi đối chiếu</a></p>
                        <p><a onclick="exportFileSuccess()" data-toggle="tooltip" title="Xuất riêng các mã đã tồn tại">Xuất riêng tệp lọc các mã không tồn tại</a></p>
                        <p><a onclick="exportFileFail()" data-toggle="tooltip" title="Xuất riêng các mã không tồn tại">Xuất riêng tệp lọc các mã tồn tại</a></p>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="qr-container">
                        <div class="col-md-12">
                            <div class="label label-danger"><i class="fa fa-qrcode"></i>&nbsp;&nbsp;Dữ liệu quét mã vạch</div>
                        </div>
                        <div class="col-md-12">
                            <video id="qr-video" style="width: 100%; display: none;"></video>
                        </div>
                        <div class="result-list">
                            <asp:TextBox runat="server" Width="100%" CssClass="txtResult" onblur="startScanner()" ID="txtQRText" onfocus="startScanner()"></asp:TextBox>
                            <p>Lịch sử quét (<span id="totalCount">0</span>)</p>
                            <table class="table">
                                <thead>
                                    <tr>
                                        <th>Mã vận đơn</th>
                                    </tr>
                                </thead>
                                <tbody id="qr-list">
                                </tbody>
                            </table>
                            <asp:TextBox runat="server" CssClass="txtHistory hidden"  ID="txtQRHistory" TextMode="MultiLine" Height="40px"></asp:TextBox>
                        </div>
                        <div class="clear"></div>
                    </div>

                    <div class="clear"></div>
                    <%--  <div class="col-md-12">
                        <a id="btnCompare" style="width: 100%" data-toggle="tooltip" class="btn  btn-danger shadow mgt10" tooltip="So khớp giữa dữ liệu file excel và dữ liệu quét từ máy QR">
                            <i class="fa fa-cloud-upload"></i>&nbsp;&nbsp;Đối sánh dữ liệu
                        </a>
                    </div>--%>
                    <div class="col-md-12 mgt10 pd0">

                        <div class="row result-info ">
                            <div class="col-md-12 ">
                                <div class="label label-success "><i class="fa fa-paper-plane"></i>&nbsp;&nbsp;Kết quả đối chiếu</div>
                            </div>
                            <div class="clear"></div>
                            <div class="row pd0">

                                <div class="col-md-6 " style="overflow: auto; height: 100%; max-height: 200px">
                                    <div class="result-success ">
                                        <p><strong>TỒN TẠI:</strong> <span id="validCount">0</span></p>
                                        <table class="table ">
                                            <thead>
                                                <tr>
                                                    <th>Mã vận đơn</th>
                                                </tr>
                                            </thead>
                                            <tbody id="validCodesBody"></tbody>
                                        </table>
                                    </div>
                                </div>
                                <div class="col-md-6 " style="overflow: auto; height: 100%; max-height: 200px">
                                    <div class="result-danger ">
                                        <p><strong>KHÔNG TỒN TẠI:</strong> <span id="invalidCount">0</span></p>
                                        <table class="table ">
                                            <thead>
                                                <tr>
                                                    <th>Mã vận đơn</th>
                                                </tr>
                                            </thead>
                                            <tbody id="invalidCodesBody"></tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
            <div class="panel panel-warning small  pd10">
                <i>
                    <p>Hướng dẫn sử dụng:</p>
                    <p>Bước 1: Chọn tệp excel và bấm nút Tải tệp lên</p>
                    <p>Bước 2: Bấm nút Quét mã vạch và dùng máy quét mã các đơn hàng vào phần mềm</p>
                    <%--<p>Bước 3: Bấm nút Đối sánh để xem tình trạng thừa thiếu đơn hàng</p>--%>
                </i>
            </div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>

        <div class="col-md-6 hidden-md">
            <a class="btn btn-danger" style="width: 100%" onclick="openQRScanner()"><i class="fa fa-qrcode"></i>&nbsp; Quét mã (Camera - QR code)</a>
        </div>
        <div class="col-md-6 hidden-xs">
            <a class="btn btn-primary" style="width: 100%" id="btnQuetQR" onclick="startScanner()"><i class="fa fa-play"></i>&nbsp;Quét mã bằng máy</a>
        </div>
    </div>
</div>
<asp:HiddenField ID="HidPortalID" runat="server" Value="7" />
<asp:HiddenField ID="HidUID" runat="server" Value="7" />
<asp:HiddenField ID="PathSave" runat="server" Value="7" />
<script>
    document.addEventListener("DOMContentLoaded", function () {
        const fromDateInput = document.getElementById("from-date");
        const toDateInput = document.getElementById("to-date");
        const tableBody = document.getElementById("excelDataBody");

        function filterByDate() {
            let fromDate = fromDateInput.value ? new Date(fromDateInput.value).getTime() : null;
            let toDate = toDateInput.value ? new Date(toDateInput.value).getTime() : null;

            Array.from(tableBody.getElementsByTagName("tr")).forEach(row => {
                let dateCell = row.cells[2].textContent.trim(); // Cột Ngày Hoàn Đơn
                let rowDate = new Date(dateCell).getTime(); // Chuyển thành timestamp

                let showRow = true;
                if (fromDate && rowDate < fromDate) showRow = false;
                if (toDate && rowDate > toDate) showRow = false;

                row.style.display = showRow ? "" : "none"; // Hiển thị hoặc ẩn dòng
            });
        }

        fromDateInput.addEventListener("input", filterByDate);
        toDateInput.addEventListener("input", filterByDate);
    });


    document.addEventListener("DOMContentLoaded", function () {
        const tableBody = document.querySelector("#excelDataBody");

        tableBody.addEventListener("click", function (event) {
            let clickedRow = event.target.closest("tr"); // Tìm hàng được click

            if (clickedRow) {
                Array.from(tableBody.getElementsByTagName("tr")).forEach(row => row.classList.remove("selected"));
                clickedRow.classList.add("selected");
            }
        });
    });

    document.addEventListener("DOMContentLoaded", function () {
        const filterId = document.getElementById("filter-id");
        const filterTracking = document.getElementById("filter-tracking");
        const tableBody = document.getElementById("excelDataBody");

        function filterTable() {
            let idFilter = filterId.value.toLowerCase();
            let trackingFilter = filterTracking.value.toLowerCase();

            Array.from(tableBody.getElementsByTagName("tr")).forEach(row => {
                let idCell = row.cells[0].textContent.toLowerCase();
                let trackingCell = row.cells[1].textContent.toLowerCase();
                row.style.display = (idCell.includes(idFilter) && trackingCell.includes(trackingFilter)) ? "" : "none";
            });
        }

        filterId.addEventListener("input", filterTable);
        filterTracking.addEventListener("input", filterTable);
    });


    function saveQRCode(qrCode) {
        $.ajax({
            url: "/api/tools/ScanHandler.ashx",
            type: "POST",
            data: { action: "save", qrCode: qrCode },
            success: function (response) {
                loadQRCodeList(); // Tải lại danh sách sau khi lưu
            }
        });
    }
    function loadQRCodeList() {
        $.ajax({
            url: "/api/tools/ScanHandler.ashx",
            type: "GET",
            data: { action: "read" },
            success: function (response) {
                let qrList = response;
                let html = "";

                qrList.forEach(qr => {
                    html += `<tr><td>${qr}</td></tr>`;
                });

                $("#qr-list").html(html);
            }
        });
    }

    // Gọi hàm load danh sách khi trang tải
    $(document).ready(function () {
        loadQRCodeList();
    });

    function openQRScanner() {
        let video = document.getElementById("qr-video");
        video.style.display = "block";
        video.scrollIntoView();
        navigator.mediaDevices.getUserMedia({ video: { facingMode: "environment" } })
            .then(function (stream) {
                video.srcObject = stream;
                video.play();

                let canvas = document.createElement("canvas");
                let context = canvas.getContext("2d");

                function scan() {
                    if (video.readyState === video.HAVE_ENOUGH_DATA) {
                        canvas.width = video.videoWidth;
                        canvas.height = video.videoHeight;
                        context.drawImage(video, 0, 0, canvas.width, canvas.height);

                        let imageData = context.getImageData(0, 0, canvas.width, canvas.height);
                        let qrCode = jsQR(imageData.data, imageData.width, imageData.height);

                        if (qrCode) {
                            let scannedCode = qrCode.data;
                            document.getElementById("<%= txtQRText.ClientID %>").value = scannedCode;

                            video.srcObject.getTracks().forEach(track => track.stop()); // Tắt camera
                            video.style.display = "none";

                            // Gửi mã QR lên server để kiểm tra
                            checkQRCode(scannedCode);
                        } else {
                            requestAnimationFrame(scan);
                        }
                    } else {
                        requestAnimationFrame(scan);
                    }
                }
                requestAnimationFrame(scan);
            })
            .catch(function (error) {
                alert("Không thể mở camera: " + error);
            });

    }
    function exportFile() {
        waiting();
        $.ajax({
            url: "/api/tools/ExportAll.ashx",
            type: "GET",
            xhrFields: {
                responseType: 'blob'
            },
            success: function (response) {
                let blob = new Blob([response], { type: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" });
                let link = document.createElement("a");
                link.href = window.URL.createObjectURL(blob);
                link.download = "DanhSach_Xuat.xlsx";
                link.click();
            },
            error: function () {
                alert("Lỗi khi xuất file!"); removewaiting();
            }
        });
        removewaiting();
    }
    function checkQRCode(t) {
        let qrCode = t;
        if (qrCode === "") return;
        debugger;
        saveQRCode(t);
        loadQRCodeList();
        let exists = false;
        let rows = document.querySelectorAll("#excelTable tbody tr");

        rows.forEach(row => {
            let trackingID = row.cells[2].innerText.trim(); // Lấy giá trị cột thứ 3
            if (trackingID === qrCode) {
                exists = true;
                $(row).addClass("valid-row"); // Thêm class để tô màu xanh
                $(row).focus();
            }
        });

        if (exists) {
            $("#validCodesBody").prepend(`<tr><td>${qrCode}</td></tr>`);
            $("#validCount").text(parseInt($("#validCount").text()) + 1);
        } else {
            $("#invalidCodesBody").prepend(`<tr><td>${qrCode}</td></tr>`);
            $("#invalidCount").text(parseInt($("#invalidCount").text()) + 1);
        }
        $("#totalCount").text(parseInt($("#totalCount").text()) + 1);
        t.value = "";
    }

    function startScanner() {

        var t = "#btnQuetQR";
        if ($(t).hasClass("btn-primary") == true) {
            var input = document.getElementById("<%= txtQRText.ClientID %>");
            var hisinput = document.getElementById("<%= txtQRHistory.ClientID %>");
            var inputVal = "";
            input.addEventListener("keypress", function (event) {
                if (event.key === "Enter") {
                    event.preventDefault();
                    if (input.value != "") {
                        inputVal = input.value.trim(); hisinput.prepend("|" + input.value);
                        checkQRCode(inputVal);
                    }
                    input.value = ""
                }
            });
            input.focus();
            $(t).removeClass("btn-primary");
            $(t).addClass("btn-warning");
            $(t).html("<i class='fa fa-stop'></i>&nbsp; Dừng quét");
        }
        else {
            stopScanner();
        }
    }
    function stopScanner() {
        var t = "#btnQuetQR";
        $(t).removeClass("btn-warning");
        $(t).addClass("btn-primary");
        $(t).html("<i class='fa fa-play'></i>&nbsp; Quét mã vạch");
        $("#btnCompare").focus();
    }
    function loadExcelData() {
        $.ajax({
            url: "/api/tools/GetExcelData.ashx",
            type: "GET",
            success: function (response) {
                $("#excelDataBody").html(response.html);
                $("#totalRecords").text(response.totalRecords);
            },
            error: function () {
                alert("Lỗi khi tải dữ liệu!");
            }
        });
    }
    $(document).ready(function () {
        loadExcelData();
        loadQRCodeList();
        $("#btnTaiLen").click(function () {

            var files = $("#<%= _FileUpload.ClientID %>")[0].files;
            if (!files) {
                alert("Vui lòng chọn file Excel!");
                return;
            }

            var formData = new FormData();
            for (var i = 0; i < files.length; i++) {
                formData.append("files[]", files[i]);
            }
            formData.append("portal", $("#<%= HidPortalID.ClientID %>").val());
            formData.append("rid", $("#txtRow").val());
            formData.append("tid", $("#txtTracking").val());
            formData.append("oid", $("#txtOrderId").val());
            formData.append("typeid", $("#txtTYPE_ID").val());
            formData.append("timeid", $("#txtTimeRe").val());
            formData.append("did", $("#txtDATE_ID").val());
            formData.append("uid", $("#<%= HidUID.ClientID %>").val());
            formData.append("pathsave", $("#<%= PathSave.ClientID %>").val());
            waiting();

            $.ajax({
                url: "/api/tools/UploadHandler.ashx",
                type: "POST",
                data: formData,
                contentType: false,
                processData: false,
                success: function (response) {
                    removewaiting();
                    alert(response);
                },
                error: function () {
                    removewaiting();
                    alert("Lỗi khi tải lên file!");

                }
            });
            loadExcelData();
        });
    });

</script>
