/* 
    Author: khanhcoibg
    Email: khanhnq@TN.Common.com.vn
    Created Date: 16/11/2014
    Project: WB Portal
*/
$.fn.ajax_load_content = function () {
    var _this = this;
    var _ajaxLoad = function (obj, i) {
        if (typeof ($(obj[i])) != "undefined" && obj.length > i) {
            var _element = $(obj[i]);
            var _url = _element.attr("data-url");
            var _param = _element.attr("data-param");

            if (typeof (_url) != "undefined" && typeof (_param) != "undefined") {
                $.ajax({
                    type: "POST",
                    url: _url,
                    data: _param,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        _element.replaceWith(response.d);
                    },
                    error: function (msg) {
                        console.log("Lỗi tải Content từ URL: " + _url + ". Content lỗi: " + msg.d);
                    },
                    complete: function () {
                        _ajaxLoad(obj, i + 1);
                    }
                });
            }
            else {
                console.log("Không thể xác định URL hoặc PARAMETER của đối tượng số: " + i);
            }
        }
    }

    // Sắp xếp thứ tự load
    _this.sort(function (a, b) {
        a = parseInt($(a).attr("data-load-priority"), 10);
        b = parseInt($(b).attr("data-load-priority"), 10);
        if(a > b) {
            return 1;
        } else if(a < b) {
            return -1;
        } else {
            return 0;
        }
    });

    // Tiến hành load từ object đầu tiên
    _ajaxLoad(_this, 0);
}
$(function () {
    $(".ajax-load").ajax_load_content();
})