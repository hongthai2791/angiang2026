<%@ Control Language="vb" AutoEventWireup="false" Explicit="true" CodeFile="BusinessDetail.ascx.vb" Inherits="DesktopModules.Modules.Read" %>
<div class="detail-business">
    <div class="row">
        <div class="col-md-12">
            <h1 class="title_details">
                <asp:Literal ID="Title" runat="server"></asp:Literal></h1>
            <div class="col-md-3 pdl0 logo-company">
                <asp:Literal ID="Business_Img" runat="server"></asp:Literal>
            </div>
            <div class="col-md-9 pdl0 pdr0">
                <p class="title-comdetail">
                    <asp:Literal ID="Business_Vn" runat="server"></asp:Literal>
                </p>
                <div class="info-comdetail">
                    <asp:Literal ID="FollowBusiness" runat="server"></asp:Literal>
                    <asp:Literal ID="Business_Info" runat="server"></asp:Literal>
                </div>
                <div class="col-md-12 pdl10 pdt10">
                    <div id="fb-root"></div>
                    <script async defer crossorigin="anonymous" src="https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v23.0"></script>
                    <div class="fb-share-button" data-layout="" data-size=""><a target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=<%=strFb %>&amp;src=sdkpreparse" target="_top" class="fb-xfbml-parse-ignore">Chia sẻ</a></div>
                    <div class="clear"></div>
                </div>
            </div>
            <asp:Literal ID="Description" runat="server"></asp:Literal>
            <div class="clear"></div>
        </div>
    </div>
</div>
<div class="detail-business">
    <div class="title-workbus">
        <asp:Literal ID="BusWorkTitle" runat="server"></asp:Literal>
    </div>
    <div class="box_list_works pdt10">
        <asp:Literal ID="WorkList" runat="server"></asp:Literal>
    </div>
</div>

<asp:Literal ID="litSEO" runat="server"></asp:Literal>
<asp:HiddenField ID="ItemID" runat="server" />
<asp:HiddenField ID="BusinessID" runat="server" />
<asp:HiddenField ID="currPage" Value="1" runat="server" Visible="false" />
<asp:HiddenField ID="vUrl" Value="" runat="server" Visible="false" />

<script type="text/javascript">
    function popFollow(pid, id, use) {
        waiting();
        $.ajax({
            type: 'GET', url: '/api/member/data.asmx/FollowBusiness?pid=' + pid + '&id=' + id + '&use=' + use,
            success: function (data) {
                var json = $.parseJSON($(data).find("string").text());
                if (json.data) { removewaiting(); notify('info', 'Theo dõi nhà tuyển dụng thành công.'); };
            },
        });
    };
</script>
