<%@ Control Language="vb" AutoEventWireup="false" CodeFile="Details.ascx.vb" Inherits="DesktopModules.Modules.FeedBack.answer_comment" %>

<asp:UpdatePanel ID="pnlResult" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border ">
                <div class="col-md-12">
                    <h3 class="box-title">THÔNG TIN CHI TIẾT Ý KIẾN PHẢN HỒI</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <asp:Label Visible="false" CssClass="c_head" runat="server" ID="_Id" />
                    <div class="clear"></div>
                    <div class="col-md-12">
                        <div class="allPage">
                            <div class="col-md-6">
                                <div style="padding-top: 10px; padding-left: 15px;">
                                    <strong>Nội dung ý kiến độc giả</strong>
                                    <asp:Literal ID="litHis" runat="server" />
                                    <div style="padding-top: 10px"></div>
                                    <asp:TextBox runat="server" ID="txtComment" Visible="false" TextMode="MultiLine" Height="100" Width="100%"></asp:TextBox>
                                    <asp:TextBox runat="server" ID="txtLoiBinh" TextMode="MultiLine" Height="100" Width="100%"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="col-md-12 b">Tiêu đề bài viết</div>
                                <div class="col-md-12">
                                    <asp:Literal runat="server" ID="txtTitle"></asp:Literal>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 col-xs-4 b">Người gửi</div>
                                <div class="col-md-10 col-xs-8 lbR-a">
                                    <asp:Literal runat="server" ID="ltrNguoiGui"></asp:Literal>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 col-xs-4 b">Ngày gửi </div>
                                <div class="col-md-10 col-xs-8 lbR-a">
                                    <asp:Literal runat="server" ID="ltrNgayGui"></asp:Literal>
                                </div>
                                <div class="clear"></div>
                                <div class="col-md-2 col-xs-4 b">IP Track </div>
                                <div class="col-md-10 col-xs-8 lbR-a">
                                    <asp:Literal runat="server" ID="ltrIp"></asp:Literal>
                                </div>
                                <div class="clear"></div>

                            </div>
                            <div class="border" style="padding-top: 10px;"></div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="col-md-12">
                                        <asp:Literal runat="server" ID="ltrAnswer"></asp:Literal>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <asp:TextBox runat="server" CssClass="txtAnswer" TextMode="MultiLine" Rows="10" ID="txtanswer" Width="100%"></asp:TextBox>
                                    <asp:Button runat="server" ID="cmdNote" CssClass="btnguiykien" Text="Gửi ý kiến" />
                                </div>
                            </div>
                            <div class="clear"></div>
                        </div>
                        <div class="clear"></div>
                    </div>
                    <div class="clear">
                        <span style="display: none">
                            <asp:HiddenField runat="server" ID="hdDelete" />
                            <asp:Button runat="server" ID="btnDelete" Text=" " />
                        </span>
                        <asp:HiddenField runat="server" ID="hdcategory" />
                        <asp:HiddenField runat="server" ID="hdTourl" />
                        <asp:HiddenField runat="server" ID="hditemid" />
                        <asp:HiddenField runat="server" ID="hdMailTo" />
                        <asp:HiddenField runat="server" ID="strLink" Visible="false" />
                    </div>
                </div>
            </div>
        </div>

        <div class="fix-btt-toolbar">
            <div>
                <asp:Button CssClass="cmdbtt cmdSave1" runat="server" ID="cmdUpdate" Text="Lưu sửa ý kiến" />
                <asp:Button ID="cmdActive" runat="server" Text="Gửi duyệt" Visible="false" CssClass="cmdbtt cmdRun" />
                <asp:Button ID="cmdPublic" Visible="false" runat="server" Text="Xuất bản, gửi mail" CssClass="cmdbtt cmdRun" OnClientClick="return checkinput();" />
                <asp:Button ID="cmdPrivate" Visible="false" runat="server" Text="Không xuất bản, gửi mail" CssClass="cmdbtt cmdStop" OnClientClick="return checkinput();" />
                <asp:Button ID="cmdSave" Visible="false" runat="server" Text="Xuất bản, không gửi mail" CssClass="cmdbtt cmdSave" OnClientClick="return checkinput();" />
                <asp:Button ID="cmdBack" runat="server" Text="Thoát" CssClass="cmdbtt cmdExit" />
            </div>
        </div>
        <script>
            function addDelete(id, value) { var NotExists = $('#' + id).val(value); return NotExists; };
            function del(id) {
                if (confirm("Bạn có chắc muốn xóa ý kiến trả lời này đi không?") == true) {
                    if (addDelete('<%= hdDelete.ClientID%>', id)) {
                        jQuery("#" + '<%= btnDelete.ClientID%>').click();
                    }
                }
            };
        </script>
    </ContentTemplate>
</asp:UpdatePanel>

