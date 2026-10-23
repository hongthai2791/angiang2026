<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Comments.ascx.vb" Inherits="DesktopModules.Home.Comments" %>
<%@ Register TagPrefix="dnn" TagName="VbCapchar" Src="~/admin/Captcha/VbCapchar.ascx" %>


<link href="/js/validation/validationEngine.jquery.css" rel="stylesheet" />
<script src="/js/validation/jquery.validationEngine-vi.js"></script>
<script src="/js/validation/jquery.validationEngine.js"></script>

<style>
    .button[disabled] {
    border-color: #dbdbdb;
    box-shadow: none;
    opacity: .5;
}
    .btn-dcm {
    background-color: #23d160;
    border-color: transparent;
    box-shadow: none;
    color: #fff;
    border-radius: 5px;
    padding: 6px;
    width: 130px;
    margin-right: 5px;
}
</style>
<div class="post-news-comment">
    <div class="detail-comment">
        <div class="post-comment">
            <div class="row form-group">
                <div class="col-md-12">
                    <div class="comments-title"><i class="fa fa-comments-o f-1d5">&nbsp;&nbsp;</i>Ý kiến bình luận</div>
                </div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2 pdt5 b">Họ và tên</div>
                <div class="col-sm-10">
                    <asp:TextBox ID="FullName" CssClass="TextBox validate[required] " runat="server"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2 pdt5 b">Email</div>
                <div class="col-sm-10">
                    <asp:TextBox ID="Email" CssClass="TextBox validate[required, custom[email]]" runat="server"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2 pdt5 b">Ý kiến đóng góp</div>
                <div class="col-sm-10">
                    <asp:TextBox ID="Contents" TextMode="MultiLine" Height="100px" CssClass="TextBox validate[required]" runat="server"></asp:TextBox>
                </div>
                <div class="clear"></div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2 pdt5 b">Xác thực</div>
                <div class="col-sm-10">
                    <dnn:VbCapchar ID="ctlCaptcha" runat="server" />
                </div>
                <div class="clear"></div>
            </div>
            <div class="row form-group">
                <div class="col-sm-2 pdt10 b">&nbsp;</div>
                <div class="col-sm-10 pdt10">
                    <button type="button" class="button btn-dcm" id="btnComment" onclick="addComment()">Gửi ý kiến</button>
                    <div class="clear"></div>
                </div>
                <asp:Literal ID="litComment" runat="server" />
            </div>
        </div>
    </div>
</div>
<asp:HiddenField ID="CurrentPage" Value="1" runat="server" />
<asp:HiddenField ID="ItemId" runat="server" />
<script type="text/javascript">
    $(document).ready(function () { $("#Form").validationEngine({ prettySelect: true }); }); function fnext(p) { var id = $("#<%=ItemId.ClientID %>").val(); var link = "/api/cms/fblist.ashx?id=" + id + "&p=" + p, msg = $.ajax({ url: link, async: false }).responseText; $(".comment-view").html(msg); };
    function updatefeedback(id, fname, mail, content, iptrack) { var pid = "<%= Me.PortalId %>"; var link = "/api/cms/fbadd.ashx?id=" + id + "&fname=" + fname + "&m=" + mail + "&c=" + content + "&rip=" + iptrack + "&pid=" + pid; var msg = $.ajax({ url: link, async: false }).responseText; };
    function ReloadSite() { setTimeout(function () { location.reload(); }, 5000) }; function callValidation() { if (grecaptcha.getResponse().length == 0) { $("#showNotValid").modal('show'); return false; } else { $(".enterComment").click(); } };
</script>
<div class="comment-modalBox">
    <div class="modal fade bs-example-modal-sm" id="mySuccess" tabindex="-1" role="dialog" aria-labelledby="mySuccess" aria-hidden="true">
        <div class="modal-dialog modal-sm" style="width: 400px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 24px">&times;</span></button>
                    <div class="modal-title h4" id="lblmySuccess">Thông báo</div>
                </div>
                <div class="modal-body">
                    Bạn đã gửi ý kiến thành công.<br />
                    Ý kiến của bạn sẽ được duyệt trước khi hiển thị!
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade bs-example-modal-sm" id="myFailed" tabindex="-1" role="dialog" aria-labelledby="myFailed" aria-hidden="true">
        <div class="modal-dialog modal-sm" style="width: 400px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 24px">&times;</span></button>
                    <div class="modal-title h4" id="lblmyFailed">Thông báo</div>
                </div>
                <div class="modal-body">
                    Đường truyền dữ liệu không ổn định.
                <br />
                    Vui lòng thử lại sau          
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade bs-example-modal-sm" id="showNotValid" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog modal-sm" style="width: 400px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true" style="font-size: 24px">&times;</span></button>
                    <div class="modal-title h4">Thông báo</div>
                </div>
                <div class="modal-body">
                    Bạn chưa chọn xác thực bảo mật.
                </div>
            </div>
        </div>
    </div>
    <asp:HiddenField runat="server" ID="_IPContrack" />
</div>
<script type="text/javascript">
    function clearContents() {
        $("#<%=FullName.ClientID%>").val('');
        $("#<%=Email.ClientID%>").val('');
        $("#<%=Contents.ClientID%>").val('');
    };
     $(document).ready(function () {
        document.getElementById("btnComment").disabled = true;
    });
    function onCommentCaptchaSuccess() { document.getElementById("btnComment").disabled = false; };
    function addComment() {
        if ($('#Form').validationEngine('validate')) {
            var pid =<%=Me.PortalId%>;
            var id = $("#<%=ItemId.ClientID%>").val();
            var hoten = $("#<%=FullName.ClientID%>").val();
            var email = $("#<%=Email.ClientID%>").val();
            var contents = Base64.encode($("#<%=Contents.ClientID%>").val());
            var contents = $("#<%=Contents.ClientID%>").val()
            var ipcontrack = $("#<%=_IPContrack.ClientID%>").val()
            var dto = {
                pid: pid,
                id: id,
                hoten: hoten,
                email: email,
                contents: contents,
                ipcontrack: ipcontrack

            }
            $.ajax({
                type: 'POST', url: '/api/home/Comment.asmx/SaveData',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: JSON.stringify(dto),
                success: function (response) {
                    clearContents();
                    notify('success', 'Bạn đã gửi ý kiến  thành công. Ý kiến của bạn sẽ được duyệt trước khi hiển thị!', 'Thông báo', false);
                    removewaiting();
                },
                failure: function (response) {
                    notify('info', 'Ý kiến bình luận của bạn chưa được gửi đi. Vui lòng thử lại', 'Thông báo', false);
                    removewaiting();
                }

            });
        };
    };
</script>

