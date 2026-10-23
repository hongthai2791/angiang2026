<%@ Control Language="vb" CodeFile="Provide_BackupView.ascx.vb" Inherits="Modules.Education.View" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Chuyển kỳ dữ liệu mới </h3>
        </div>
        <asp:DropDownList ID="drPageSize" Visible="false" CssClass="selectpicker" AutoPostBack="true" runat="server" />
        <div class="clear"></div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-12 ">
                <div class="panel panel-warning" style="color: #e8e8e8!important; font-size: 16px; font-weight: 500; background: #584040; padding: 10px!important;">
                    <i class="fa fa-exclamation-triangle" aria-hidden="true"></i>&nbsp; 
                        Lưu ý: Khi thực hiện Chuyển kỳ, dữ liệu sẽ được tạo cho kỳ mới, cần chắc chắn rằng dữ liệu của kỳ hiện tại đã được nhập xong hoàn thiện!
                </div>
            </div>
            <div class="col-md-4">
                <div class="col-md-12">
                    <div class="backup-title">Chọn dữ liệu</div>
                </div>
                <div class="col-md-12">
                    <asp:DropDownList ID="TinhTP" runat="server" AutoPostBack="true" CssClass="selectpicker"></asp:DropDownList>
                </div>
            </div>
            <div class="col-md-4">
                <div class="col-md-12">
                    <div class="backup-title">Năm hiện tại</div>
                </div>
                <div class="col-md-12">
                    <div class="backup-year">
                        <asp:Literal ID="ltrYearID" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="col-md-12">
                    <div class="backup-title">Năm dữ liệu mới</div>
                </div>
                <div class="col-md-12">
                    <div class="backup-year">
                        <asp:Literal ID="ltrYearIDNew" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
            <div class="col-md-12 txt-center">
                <asp:Literal ID="cmdSaoLuu" runat="server" />
            </div>

            <div class="row none">
                <table border="1" cellspacing="0" width="100%">
                    <tr style="text-align: center; color: #fff; vertical-align: middle">
                        <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 5%">STT</td>
                        <td class="hdTitle" style="background-color: #566869; font-size: 12px;">Đơn vị</td>
                        <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 12%">Ngày thực hiện</td>
                        <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 12%">Người thực hiện</td>
                        <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 25%">Thông tin sao lưu</td>
                        <td class="hdTitle" style="background-color: #566869; font-size: 12px; width: 15%">
                            <img src="/portals/_default/skins/vbn/images/sendData.png?w" alt="Edit" title="Sao lưu số liệu" /></td>
                    </tr>
                    <asp:Literal ID="litData" Visible="false" runat="server" />
                </table>
            </div>
            <div class="row">
                <asp:Literal ID="litPage" runat="server" />
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>
<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
<asp:HiddenField ID="YearPro" runat="server" Visible="false" />
<script>
    function smartNotice(remsec) {
        if (remsec == -1) {
            window.location.reload();
            return;
        }
        delay = remsec * 1000;
        $("#noticeSend").html("Hệ thống sẽ tự động tải lại dữ liệu sau: " + remsec + " giây");
        setTimeout(function () { smartNotice(remsec - 1); }, delay);
    };

    function senddata(pid, matinh, mahuyen, maxa, mathon, isyear, username, notif) {
        if (confirm('Bạn có chắc chắn muốn sao lưu dữ liệu của ' + notif + '?')) {
            waiting();
            $.ajax({
                type: 'GET', url: '/api/work/nldnn.asmx/SendData?pid=' + pid + '&matinh=' + matinh + '&mahuyen=' + mahuyen + '&maxa=' + maxa + '&mathon=' + mathon + '&yr=' + isyear + '&username=' + username,
                success: function (data) {
                    removewaiting();
                    var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                        notify('success', json.data, 'Thông báo', false)

                    };
                    smartNotice(3);
                },
                error: function (data) {
                    removewaiting();
                    var json = $.parseJSON($(data).find("string").text()); if (json.data) {
                        notify('info', json.data, 'Thông báo', false)
                    };
                }
            });

        };
    };
</script>
