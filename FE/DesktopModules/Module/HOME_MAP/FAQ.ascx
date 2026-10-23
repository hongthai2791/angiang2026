<%@ Control Language="VB" AutoEventWireup="false" CodeFile="FAQ.ascx.vb" Inherits="DesktopModules.Modules.Home.FAQ" %>
<%@ Register TagPrefix="dnn" TagName="VbCapchar" Src="~/admin/Captcha/VbCapchar.ascx" %>
<%@ Register Src="~/DesktopModules/Module/Home/LienHeCongTy.ascx" TagPrefix="BT" TagName="LienHeCongTy" %>

<asp:UpdatePanel runat="server" ID="P">
    <ContentTemplate>
        <div class="col-md-8 contact-left">
            <div class="frlienhe frFAQ">
                <div class=" row border-evelope">
                    <div class="row">
                        <div class="col-md-12 lienh">
                            <h3><i class="fa fa-question-circle-o "></i>&nbsp; Đặt câu hỏi cho chúng tôi</h3>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="lbMsg" runat="server" />

                        <div class="col-md-12 lhn">
                            <span class="icon-lh"><i class="fa fa-user icon"></i></span>
                            <asp:TextBox ID="FullName" CssClass="form-control validate[required] form-control-lh " placeholder="Tên của bạn (*)" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-md-7 pdl0">

                        <div class="col-md-12 lhn">
                            <span class="icon-lh"><i class="fa fa-envelope icon"></i></span>
                            <asp:TextBox ID="Email" CssClass="form-control validate[required] form-control-lh" placeholder="Email liên hệ (*)" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-md-5 pdr0">

                        <div class="col-md-12 lhn">
                            <span class="icon-lh"><i class="fa fa-phone" aria-hidden="true"></i></span>
                            <asp:TextBox ID="Tel" CssClass="form-control validate[required] form-control-lh " placeholder="Số điện thoại (*)" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">

                        <div class="col-md-12 lhn">
                            <span class="icon-lh"><i class="fa fa-comments-o" aria-hidden="true"></i></span>
                            <asp:TextBox TextMode="MultiLine" MaxLength="300" ID="Contents" runat="server" placeholder="Nhập tối đa 500 ký tự" CssClass="form-control validate[required] form-control-lh" length="500" Height="80px"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-12 lhn">
                            <dnn:VbCapchar ID="ctlCaptcha" runat="server" />
                        </div>
                    </div>

                    <div class="clear"></div>
                    <div class="col-md-12 bt-contact" style="text-align: center">
                        <asp:Button ID="cmdSend" runat="server" OnClientClick="return $('#Form').validationEngine('validate')" Text="Gửi câu hỏi" class="btn btn-success"></asp:Button>
                        <asp:Button ID="cmdBack" runat="server" Text="Làm lại" class="btn"></asp:Button>
                    </div>
                </div>
                <div class="row pdt10">
                    <span class="title_text_line">Danh sách câu hỏi &nbsp;(<asp:Label ID="lbTotal" runat="server" ForeColor="#C70707" Font-Bold="true" Text="0"></asp:Label>)</span>
                    
                    <div class="col-md-12 col-xs-12 pdr0">
                        <asp:TextBox ID="txtTitle" runat="server" placeholder="Tìm kiếm theo nội dung câu hỏi......" CssClass="timKiemD" Columns="20" Width="100%" />
                        <asp:LinkButton ID="lbtFind" runat="server" CausesValidation="False" CssClass="btTkiemD" />
                    </div>
                </div>
                <div class="list-comment pdt10">
                    <div class="row noidung-vb">
                        <div class="ctable-respo">
                            <asp:DataGrid ID="grdData" Width="100%" DataKeyField="Id" runat="server" AutoGenerateColumns="False" CssClass="table-bordered respo-table">
                                <HeaderStyle CssClass="hdTitle"></HeaderStyle>
                                <ItemStyle BackColor="#f5f5f5" />
                                <AlternatingItemStyle BackColor="#ffffff" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="STT">
                                        <ItemTemplate>
                                            <asp:Literal ID="OrderNo" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="40" HorizontalAlign="Center" CssClass="fix-column" />
                                        <HeaderStyle HorizontalAlign="Center" CssClass="fix-column" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Họ tên" Visible="false">
                                        <ItemTemplate>
                                            <asp:Literal ID="Name" runat="server" />
                                            <div class="toggle-row" title="Xem thêm"></div>
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="column-primary" />
                                        <ItemStyle CssClass="column-primary" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Nội dung" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                        <ItemTemplate>
                                            <asp:Literal ID="Contents" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle CssClass="noidung respo-view" />
                                        <HeaderStyle CssClass="noidung respo-title" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Ngày gửi" HeaderStyle-CssClass="c-ciew" ItemStyle-CssClass="c-ciew">
                                        <ItemTemplate>
                                            <asp:Literal ID="SendDate" runat="server" />
                                        </ItemTemplate>
                                        <ItemStyle Width="12%" CssClass="Phone respo-view" />
                                        <HeaderStyle CssClass="Phone respo-title" />
                                    </asp:TemplateColumn>

                                </Columns>
                            </asp:DataGrid>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="litPage" runat="server" />
                    </div>

                    <asp:HiddenField ID="CurrentPage" Visible="false" runat="server" />
                </div>
                <%--<div class="list-comment">
                    <div class="comment_item width_common">
                        <div class="user_status"><a class="avata_coment" title="Nguyễn Văn A">D</a></div>
                        <div class="content-comment">
                            <span class="txt-name"><a class="nickname" href="https://my.vnexpress.net/users/feed/1080073026?_gl=1*iqfhce*_gcl_au*MzcwNDAzMjExLjE3MTIwMjUxMzM."><b>Nam Viet</b></a></span>
                            <a class="full_content" data-toggle="collapse" title="Bấm để xem câu trả lời" href="#collapseExample55">Động vật hoang dã của Việt Nam thật là phong phú cần phải đầu tư nhiều hơn nữa để bảo vệ và bảo tồn những khu rừng hoang dã</a>
                        </div>
                        <div class="collapse" id="collapseExample55">
                            <div class="sub_comment width_common">
                                <div class="sub_comment_item comment_item width_common">
                                    <div class="user_status" data-user-type="8">
                                        <a class="avata_coment" title="Việc làm hòa bình">
                                            <img class="img_avatar" src="http://file.eportal.top/image/noimage/2.jpg?dpi=50&quality=50"></a>
                                    </div>
                                    <div class="content-comment">
                                        <p class="full_content">
                                            Năm ngoái: 2023 xuất khẩu nông sản VN đạt 53 tỷ đô, Thái là 49 tỷ đô. Mong VN tiếp tục đẩy mạnh việc áp dụng khoa học-công nghệ-kỹ thuật vào nông nghiệp (cũng như các ngành khác) để gia tăng lợi thế cạnh tranh, phát triển sản phẩm thật tốt, chất lượng cao... Thì chắc chắn doanh thu &amp; lợi nhuận sẽ quay trở lại với bà con...
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>--%>
            </div>
        </div>
        </div>
        <div class="col-md-4 contact-right">
            <BT:LienHeCongTy runat="server" ID="LienHeCongTy" />
        </div>
        <div class="clear"></div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="cmdSend" />
    </Triggers>
</asp:UpdatePanel>

