<%@ Control Language="vb" CodeFile="MergeData.ascx.vb" Inherits="Modules.Method.View" AutoEventWireup="false" Explicit="True" %>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-9 pdl0">
                    <h3 class="box-title">Sáp nhập dữ liệu hộ theo Xã/phường</h3>
                </div>

                <div class="col-md-3">
                    <asp:Literal ID="txtYear" runat="server"></asp:Literal>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body qlte">
                <div class="main-body">
                    <div class="panel panel-warning" style="color: #e8e8e8!important; font-size: 16px; font-weight: 500; background: #584040; padding: 10px!important;">
                        <i class="fa fa-exclamation-triangle" aria-hidden="true"></i>&nbsp; 
                        Lưu ý: Chọn đúng Xã/phường lấy và nhận dữ liệu để tránh sai sót dữ liệu. Dữ liệu sẽ không thể hoàn tác!
                        <br />
                        <p>- Nếu sáp nhập trong cùng Quận/huyện:</p>
                        <p class="pdl10">+ Trong danh mục hành chính, Xã/phường cũ bị xóa bỏ, cập nhật lại toàn bộ mã Xã/phường của các Thôn/tổ tại Xã/phường cũ thành mã Xã/phường mới</p>
                        <p class="pdl10">+ Trong dữ liệu hộ, cập nhật lại toàn bộ mã Xã/phường mới, giữ nguyên mã Thôn/tổ</p>
                        <p>- Nếu sáp nhập khác Quận/huyện:</p>
                        <p class="pdl10">+ Không cần chọn Xã/phường để nhận dữ liệu</p>
                        <p class="pdl10">+ Trong danh mục hành chính, cập nhật lại mã Quận/huyện của Xã/phường được chọn theo mã Quận/huyện mới</p>
                        <p class="pdl10">+ Trong dữ liệu hộ, cập nhật lại toàn bộ mã Quận/huyện, giữ nguyên mã Xã/phường, mã Thôn/tổ</p>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <fieldset>
                                <legend>Chọn Xã/phường lấy dữ liệu</legend>
                                <div class="col-md-4 lb txt-center">Tỉnh/ thành phố</div>
                                <div class="col-md-8">
                                    <asp:DropDownList ID="TinhTP" Enabled="false" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                                </div>
                                <div class="col-md-4  lb txt-center">Quận/ huyện</div>
                                <div class="col-md-8">
                                    <asp:DropDownList ID="QuanHuyen" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                                </div>
                                <div class="clr"></div>
                                <div class="col-md-4 lb txt-center">Xã/ phường</div>
                                <div class="col-md-8">
                                    <asp:DropDownList ID="XaPhuong" runat="server" AutoPostBack="true" CssClass="selectpicker validate[required]" />
                                </div>

                            </fieldset>
                        </div>
                        <div class="col-md-6">
                            <fieldset>
                                <legend>Chọn Xã/phường nhận dữ liệu</legend>

                                <div class="col-md-4 lb txt-center">Tỉnh/ thành phố</div>
                                <div class="col-md-8">
                                    <asp:DropDownList ID="TinhTP2" Enabled="false" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                                </div>

                                <div class="col-md-4 lb txt-center">Quận/ huyện</div>
                                <div class="col-md-8">
                                    <asp:DropDownList ID="QuanHuyen2" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                                </div>
                                <div class="clr"></div>
                                <asp:Panel runat="server" ID="pnXaPhuong">
                                    <div class="col-md-4 lb txt-center">Xã/ phường</div>
                                    <div class="col-md-8">
                                        <asp:DropDownList ID="XaPhuong2" runat="server" AutoPostBack="true" CssClass="selectpicker validate[required]" />
                                    </div>
                                </asp:Panel>
                                <div class="col-md-12 lb txt-center">
                                    <asp:CheckBox runat="server" ID="chkThonTo" Text="Giữ nguyên tên Thôn/tổ" Checked="true" ToolTip="Nếu không tích chọn, tên Thôn/tổ được ghép thêm tên Phường/Xã cũ" />
                                </div>
                            </fieldset>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>

        <div class="fix-btt-toolbar">
            <div>
                <asp:LinkButton ID="cmdSave" OnClientClick="return runProcess()" runat="server" Text="Tiến hành sáp nhập" CssClass="cmsbut cmsbtnew cmsbtmerger " />
            </div>
        </div>
        <asp:HiddenField ID="YearPro" runat="server" Visible="false" />
        <asp:HiddenField ID="currPage" runat="server" Visible="false" />
        <asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="QuanHuyen" />
        <asp:AsyncPostBackTrigger ControlID="QuanHuyen2" />
        <asp:AsyncPostBackTrigger ControlID="cmdSave" />
    </Triggers>
</asp:UpdatePanel>
<script>
    function runProcess() {
        waiting();
        if (confirm('Bạn có chắc chắn thực hiện sáp nhập Xã/phường đã chọn?') == false) {
            removewaiting();
            return false
        }
    };
</script>
