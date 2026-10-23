<%@ Control Language="VB" AutoEventWireup="false" CodeFile="FAQDetail.ascx.vb" Inherits="DesktopModules.Modules.Home.FAQ" %>
<%@ Register Src="~/DesktopModules/Module/Home/LienHeCongTy.ascx" TagPrefix="BT" TagName="LienHeCongTy" %>

        <div class="col-md-8 contact-left">
            <div class="frlienhe frFAQ">
                <div class=" row border-evelope">
                    <div class="row">
                        <div class="col-md-12 lienh">
                            <h3><i class="fa fa-question-circle-o "></i>&nbsp; Xem chi tiết hỏi đáp</h3>
                        </div>
                    </div>
                    <div class="row">
                        <asp:Literal ID="lbMsg" runat="server" />
                        <div class="col-md-12 lhn">
                            <span class="icon-lh"><i class="fa fa-user icon"></i></span>
                            <asp:TextBox ID="FullName" CssClass="form-control form-control-lh " placeholder="Người gửi" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row">

                        <div class="col-md-12 lhn">
                            <span class="icon-lh"><i class="fa fa-comments-o" aria-hidden="true"></i></span>
                            <asp:TextBox TextMode="MultiLine" MaxLength="300" ID="Contents" runat="server" placeholder="Nội dung câu hỏi" CssClass="form-control form-control-lh" length="500" Height="80px"></asp:TextBox>
                        </div>
                        <div class="col-md-12 lhn">
                            <p><strong>Trả lời: </strong></p>
                            <asp:Label  runat="server" ID="lblAnswer" CssClass="form-control label label-success" ></asp:Label>
                        </div>
                    </div>
                    
                    <div class="row pdt10 text-center">
                        <a class="btn btn-default" href="/hoi-dap">Quay lại danh sách hỏi đáp</a>
                        </div>
                    <div class="clear"></div>
                </div>
            </div>
        </div>
        <div class="col-md-4 contact-right">
            <BT:LienHeCongTy runat="server" ID="LienHeCongTy" />
        </div>
        <div class="clear"></div>

