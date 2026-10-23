<%@ Control Language="vb" Inherits="Modules.TNDocument.Edit" CodeFile="Doc_Edit.ascx.vb" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border ">
        <div class="col-md-12">
            <h3 class="box-title">
                <asp:Literal ID="litTitle" runat="server"></asp:Literal>
            </h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="col-md-2 lb">Chọn phân hệ</div>
            <div class="col-md-4 ">
                <asp:DropDownList ID="ddlPortal" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                <span class="required"></span>
            </div>
            <div class="col-md-2 lb txt-center">Nhóm văn bản</div>
            <div class="col-md-4">
                <asp:DropDownList ID="DocGroup_ID" runat="server" CssClass="selectpicker  validate[required]"></asp:DropDownList>
                <span class="required"></span>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 lb">Số văn bản</div>
            <div class="col-md-4">
                <asp:TextBox ID="NoCode" runat="server" CssClass="TextBox validate[required]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="col-md-2 lb txt-center">Loại văn bản</div>
            <div class="col-md-4">
                <asp:DropDownList ID="DocType_ID" runat="server" CssClass="selectpicker  validate[required]"></asp:DropDownList>
                <span class="required"></span>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 lb">Tên văn bản pháp quy</div>
            <div class="col-md-10">
                <asp:TextBox ID="Document_Name" runat="server" TextMode="MultiLine" Height="50" CssClass="TextBox validate[required]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 lb">Nội dung trích yếu</div>
            <div class="col-md-10 ">
                <asp:TextBox ID="Contents" runat="server" TextMode="MultiLine" Height="100px" CssClass="TextBox"></asp:TextBox>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 lb">Ngày ban hành</div>
            <div class="col-md-2">
                <asp:TextBox ID="PromDate" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox  validate[required]" runat="server" />
                <span class="required"></span>

            </div>
            <div class="col-md-2 lb">Ngày hiệu lực</div>
            <div class="col-md-2">
                <asp:TextBox ID="EffectDate" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox validate[required]" runat="server" />
                <span class="required"></span>

            </div>
            <div class="col-md-2 lb none">Ngày hết hiệu lực</div>
            <div class="col-md-2">
                <asp:TextBox ID="EndDate" Placeholder="dd/mm/yyyy" CssClass="datepicker TextBox none " runat="server" />
            </div>
            <div class="clear"></div>
            <div class="col-md-2 lb">Cơ quan ban hành</div>
            <div class="col-md-6">
                <asp:DropDownList ID="DocUnit_ID" runat="server" CssClass="selectpicker"></asp:DropDownList>
            </div>
            <div class="col-md-1 lb">Người ký</div>
            <div class="col-md-3">
                <asp:TextBox ID="SignerName" runat="server" CssClass="TextBox"></asp:TextBox>
            </div>
            <div class="clear"></div>
            <div class="col-md-2 lb">Lĩnh vực văn bản</div>
            <div class="col-md-6">
                <asp:DropDownList ID="DocField_ID" runat="server" CssClass="selectpicker validate[required]"></asp:DropDownList>
                <span class="required"></span>
            </div>
            <div class="col-md-1 lb">Thứ tự</div>
            <div class="col-md-1">
                <asp:TextBox ID="IsOrder" runat="server" CssClass="TextBox validate[required,custom[number]]"></asp:TextBox>
                <span class="required"></span>
            </div>
            <div class="col-md-1 lb">Sử dụng</div>
            <div class="col-md-1 pdt5">
                <asp:CheckBox ID="IsActive" Checked="true" runat="server" CssClass="CheckBox"></asp:CheckBox>
            </div>
            <div class="clear"></div>
            <div class="clear"></div>
            <div class="col-md-2 lb">Văn bản đính kèm</div>
            <div class="col-md-10">
                <div class="bt-chon-tep" onclick="changekey('0'); insertdoc(900,550); return false;">Chọn tệp</div>
                <div class="chon-file">
                    <asp:Literal ID="litFileName" runat="server"></asp:Literal>
                </div>
                <asp:HiddenField ID="FileName" runat="server" />
                <asp:HiddenField ID="FileSource" runat="server" />
                <div class="clear"></div>
            </div>
            <div class="clear" style="height: 20px"></div>

            <asp:Literal ID="litUpdate" runat="server" />
            <div class="IdKey none"></div>

        </div>
        <asp:HiddenField ID="DOC_LIST_GROUP" runat="server" />
    </div>
</div>
<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" Text="Lưu lại" CssClass="cmdbtt cmdSave" OnClientClick="savebutphe();return $('#Form').validationEngine('validate');" />
        <asp:Button ID="cmdDelete" runat="server" Visible="false" Text="Xóa" CssClass="cmdbtt cmdDel" OnClientClick="return $('#Form').validationEngine('detach');" />
        <asp:Button ID="cmdExit" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" OnClientClick="return $('#Form').validationEngine('detach');" />
    </div>
</div>
<asp:HiddenField ID="ItemId" runat="server" />
<script>
    function insertdoc(w, h) {
        var left = (screen.width / 2) - (w / 2), top = (screen.height / 2) - (h / 2), pid = $('#<%= ddlPortal.ClientID %>').val();
        if (typeof (Worker) !== "undefined") {
            if (typeof (thread) == "undefined") {
                thread = new Worker("/js/worker.js");
                thread.onmessage = function (event) {
                    var link = "/api/admin/cookie.ashx?k=" + $(".IdKey").html(), result = $.ajax({ url: link, async: false }).responseText;
                    if (result != "") {
                        thread.terminate(); thread = undefined;
                        var arr = new Array(); arr = result.split("@_@");
                        for (var i = 0; i < arr.length; i++) {
                            if (arr[i] != null && arr[i] != '') {
                                var stitle = arr[i].split("|")[0], show = arr[i].split("|")[1];
                                $("#<%=FileName.ClientID %>").val(show);
                                $("#<%=FileSource.ClientID %>").val(stitle);
                                $(".chon-file").html(show);
                            }
                        }
                        $(".IdKey").html("");
                    }
                };
            }
        }
        return window.open("<%=EPORTAL.flConnect.fileDomain %>/files/default.aspx?v=doc&c=one&i=" + pid + "&f=" + $(".IdKey").html() + "", "CMS | Hệ thống quản lý file lưu trữ", 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=30, left=' + left);
    };
    function changekey(id) { var link = "/api/admin/idcookie.ashx?i=" + id, msg = $.ajax({ url: link, async: false }).responseText; $(".IdKey").html(Base64.encode(msg)); };
</script>
