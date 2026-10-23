<%@ Control Language="vb" CodeFile="SysConfig.ascx.vb" Inherits="Modules.Settings.View" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-12">
            <h3 class="box-title">Thiết lập cấu hình hệ thống</h3>
        </div>
    </div>
    <div class="box-body">
        <div class="main-body">
            <div class="row">
                <fieldset>
                    <legend>Thiết lập cấu hình SMTP
                    </legend>
                    <div class="clear"></div>
                    <div class="col-md-2 pdt5 txt-right">SMTP Server</div>
                    <div class="col-md-6">
                        <asp:TextBox ID="SMTP_Server" runat="server" placeholder="SMTP Server" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 pdt5 txt-right">SMTP Port</div>
                    <div class="col-md-6">
                        <asp:TextBox ID="SMTP_Port" runat="server" placeholder="SMTP Port" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 pdt5 txt-right">SMTP Email</div>
                    <div class="col-md-6">
                        <asp:TextBox ID="SMTP_Email" runat="server" placeholder="SMTP Email" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-2 pdt5 txt-right">SMTP Password</div>
                    <div class="col-md-6">
                        <asp:TextBox ID="SMTP_Password" runat="server" autocomplete="on" aria-label="Content" TextMode="Password" placeholder="SMTP Password" CssClass="TextBox" />
                    </div>
                    <div class="clear"></div>
                    <div class="col-md-12 ">
                        <asp:Button ID="cmdUpdate" runat="server" Text="Lưu lại" CssClass="btn btn-primary" OnClientClick="return retunwaiting();" />
                    </div>

                </fieldset>
            </div>
            <div class="col-md-12">
                <fieldset>
                    <legend>Mã hóa hệ thống cũ </legend>

                    <div class="row">
                        <div class="col-md-12"><strong>Mã hóa</strong></div>
                        <div class="clear"></div>
                        <div class="col-md-2 pdt5">Chuỗi kết nối</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="TextBox1" runat="server" onchange="mahoa(this);" autocomplete="on" aria-label="Content" placeholder="Nhập chuỗi kết nối" CssClass="TextBox" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 pdt5 ">Chuỗi mã hóa</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="TextBox2" runat="server" autocomplete="on" aria-label="Content" placeholder="Chuỗi được mã hóa" CssClass="TextBox2 TextBox" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12"><strong>Giải mã </strong></div>
                        <div class="clear"></div>
                        <div class="col-md-2 pdt5 ">Chuỗi mã hóa</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="TextBox3" runat="server" onchange="giaima(this);" autocomplete="on" aria-label="Content" placeholder="Nhập chuỗi kết nối" CssClass="TextBox" />
                        </div>
                        <div class="clear"></div>
                        <div class="col-md-2 pdt5 ">Chuỗi giải mã</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="TextBox4" runat="server" autocomplete="on" aria-label="Content" placeholder="Chuỗi được mã hóa" CssClass="TextBox4 TextBox" />
                        </div>
                    </div>
                </fieldset>
            </div>
            <div class="col-md-12">
                <fieldset>
                    <legend>Mã hóa hệ thống mới </legend>
                        <div class="clear"></div>
                        <div class="col-md-2 pdt5 ">Chuỗi chưa mã hóa</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="txtNewDecode" runat="server"  TextMode="MultiLine" Rows="5"  CssClass="txtNewDecode TextBox" />
                        </div>
                       <div class="clear"></div>
                        <div class="col-md-2 pdt5 ">Chuỗi đã mã hóa</div>
                        <div class="col-md-10">
                            <asp:TextBox ID="txtNewEncode" runat="server" TextMode="MultiLine" Rows="5"  CssClass="TtxtNewEncode extBox" />
                        </div>
                        <asp:Button ID="btnEncode" runat="server" Text="Mã hóa" CssClass="btn btn-primary" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="btnDecode" runat="server" Text="Giải mã" CssClass="btn btn-warning" OnClientClick="return retunwaiting();" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-default" OnClientClick="return retunwaiting();" />

                </fieldset>
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" />
    </div>
</div>
<script type="text/javascript">
    function mahoa(t) { $.ajax({ type: 'GET', url: '/api/admin/settings.asmx/mahoa?p=' + Base64.encode($(t).val()), success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".TextBox2").val(json.data); }; }, }); };
    function giaima(t) { $.ajax({ type: 'GET', url: '/api/admin/settings.asmx/giaima?p=' + Base64.encode($(t).val()), success: function (data) { var json = $.parseJSON($(data).find("string").text()); if (json.data) { $(".TextBox4").val(json.data); }; }, }); };
</script>
