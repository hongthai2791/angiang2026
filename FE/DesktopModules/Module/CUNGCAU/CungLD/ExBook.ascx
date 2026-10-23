<%@ Control Language="vb" CodeFile="ExBook.ascx.vb" Inherits="Modules.ExBook.View" AutoEventWireup="false" Explicit="True" %>
<div class="box box-info">
    <div class="box-header with-border">
        <div class="col-md-9 pdl0">
            <h3 class="box-title">Xuất sổ cung lao động</h3>
        </div>
        <div class="col-md-3">
            <div class="alert alert-danger mgbt0">
                Kỳ nhập liệu năm
                        <asp:Literal ID="txtYear" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="clear"></div>
    </div>
    <div class="box-body qlte">
        <div class="main-body">
            <div class="row">
                <fieldset>
                    <legend>Chọn cấp hành chính để xuất dữ liệu</legend>
                    <div class="col-md-4 lb">Tỉnh/ thành phố</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="TinhTP" Enabled="false" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="col-md-4  lb">Quận/ huyện</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="QuanHuyen" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="clr"></div>
                    <div class="col-md-4 lb">Xã/ phường</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="XaPhuong" runat="server" AutoPostBack="true" CssClass="selectpicker " />
                    </div>
                    <div class="col-md-4 lb">Thôn/tổ</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="ThonTo" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>
                    <div class="col-md-4 lb">Loại sổ</div>
                    <div class="col-md-8">
                        <asp:DropDownList ID="LoaiSo" runat="server" AutoPostBack="true" CssClass="selectpicker" />
                    </div>

                </fieldset>
            </div>
            <div class="clr"></div>
        </div>
    </div>
</div>

<div class="fix-btt-toolbar">
    <div>
        <asp:Button ID="cmdSave" runat="server" OnClientClick="exportsBook()" Text="Thực hiện" CssClass="cmsbut cmsbtnew cmsbtmerger" />
    </div>
</div>
<asp:HiddenField ID="currPage" runat="server" Visible="false" />
<asp:HiddenField ID="hrefPage" runat="server" Visible="false" />
<asp:HiddenField ID="YearPro" runat="server" />

<script>
    function exportsBook() {
        if (confirm('Quá trình này sẽ mất nhiều thời gian, bạn có chắc chắn muốn thực hiện?') == true) {

            var idso = $("#<%=LoaiSo.ClientID %>").val(); window.open("/api/work/cungld.aspx?type=exBook&pid=0&idso=" + idso + "&tp=" + $("#<%=TinhTP.ClientID%>").val() + "&xa=" + $("#<%=XaPhuong.ClientID%>").val() + "&qh=" + $("#<%=QuanHuyen.ClientID%>").val() + "&thon=0&nam=" + $("#<%=YearPro.ClientID%>").val())

        }
    };
</script>
