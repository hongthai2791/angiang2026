<%@ Control Language="VB" EnableViewState="false" AutoEventWireup="false" CodeFile="HomeVanBan.ascx.vb" Inherits="DesktopModules.Modules.Home.HomeBanner" %>
<style>
    .home-notify {
        background-color: #f4f5fa;
        padding-top: 20px
    }

        .home-notify .contents, .home-notify .contents p {
            font-size: 14px;
            line-height: 20px
        }

       .home-vanban {
            height: 40px;
            background: #e8ddd6;
            color: #fff;
            text-transform: uppercase;
            padding-top: 8px;
            line-height: normal !important;
            font-family: Roboto-Bold;
            text-align:center;
        }
       .home-vanban a{
           font-size: 22px;
    color: #313030;
       }

        .home-notify .header-news {
            height: 40px;
            background: #00a3ee;
            color: #fff;
            text-transform: uppercase;
            padding-top: 10px;
            line-height: normal !important;
            margin-bottom: 20px;
        }

        
    
     

        .home-notify .contents {
            padding: 5px;
            height: 250px;
            overflow: auto
        }

        .home-notify .title a {
            font-size: 15px;
            font-family: Roboto-Bold;
        }

        .home-notify .bgw {
            padding: 5px;
            height: 350px;
            overflow: auto;
        }

        .home-notify .box-news {
            padding: 5px;
            align-items: center;
            flex-direction: row;
            margin-bottom: 4px;
            border: solid 1px #aaa3;
            display: flex;
        }

            .home-notify .box-news:nth-child(even) {
                background-image: linear-gradient(to top,#e6e9f06b 0%,#eef1f56e 100%);
            }

            .home-notify .box-news .imgbox {
                margin-right: .5rem;
            }

        .home-notify h5, .home-notify h5 a {
            font-family: Roboto-Medium;
            font-size: 24px;
            text-align: center;
            padding-bottom: 20px;
            text-align: center !important;
            padding-bottom: 30px;
            color: #0b508c;
        }
</style>
<div class="home-notify">
    <div class="container" style="position: relative">
           <div class="home-vanban">
            <a  href="/van-ban">Văn bản</a>
            </div>
        <div class="col-md-12 pdbt10 pd0 bgw scroll">
            <asp:Literal ID="litNew" runat="server"></asp:Literal>
        </div>
        <%--<div class="col-md-6 pdbt10 pdl0 bgw">
            <div class="noti-boxright">
                <ul class="nav nav-pills">
                    
                    <li><a data-toggle="tab" href="#thongbaovieclam">Thông báo và kết quả phiên giao dịch việc làm</a></li>
                </ul>

                <div class="tab-content scroll">
                    <div id="tintucsukien" class="tab-pane fade in active">
                       
                    </div>
                    <div id="thongbaovieclam" class="tab-pane fade">
                        <div class="row">
                            <asp:Literal ID="litTBVL" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
        </div>--%>

    </div>
</div>
