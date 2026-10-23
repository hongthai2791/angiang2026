<%@ Control Language="vb" AutoEventWireup="true" CodeFile="JobUserChoose.ascx.vb" Inherits="Modules.EPORTAL.View" %>

        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-6">
                    <h3 class="box-title">NGUỒN NHÂN LỰC || HỒ SƠ ỨNG VIÊN</h3>
                </div>
                <div class="clear"></div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <div class="col-md-2 lb">Chọn tỉnh thành</div>
                        <div class="col-md-4">
                            <asp:DropDownList ID="TinhTP" CssClass="selectpicker" runat="server" />
                        </div>
                         <div class="clr"></div> <div class="col-md-2 lb">Tên Server</div>
                        <div class="col-md-4">
                            <asp:TextBox ID="ServerName" runat="server" CssClass="TextBox validate[required]" text="103.101.163.14"/>
                            <%--<asp:DropDownList ID="ServerName" runat="server" CssClass="selectpicker " />--%>
                        </div>
                         <div class="clr"></div>
                        <div class="col-md-2 lb ">Tài khoản</div>
                        <div class="col-md-4">
                            <asp:TextBox ID="TaiKhoan" runat="server" CssClass="TextBox validate[required]" />
                        </div>
                         <div class="clr"></div>
                        <div class="col-md-2 lb ">Mật khẩu</div>
                        <div class="col-md-4">
                            <asp:TextBox ID="MatKhau" TextMode="Password"  runat="server" CssClass="TextBox validate[required]" />
                        </div> 
                        <div class="clr"></div>
                        <div class="col-md-2 lb ">DataBases</div>
                        <div class="col-md-4">
                            <asp:TextBox ID="DataBases" runat="server" CssClass="TextBox validate[required]" />
                        </div>
                    </div>
                    <div class="clr"></div>
                </div>
            </div>
        </div>
        <asp:Literal ID="lbMsg" runat="server" />

        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmdbtt cmdExit" />
                <asp:Button ID="cmdUpdate" runat="server" Text="Lấy dữ liệu" CssClass="cmdbtt cmdSave" />
            </div>
        </div>



