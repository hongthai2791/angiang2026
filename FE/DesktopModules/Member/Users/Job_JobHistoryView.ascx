<%@ Control Language="vb" AutoEventWireup="true" CodeFile="Job_JobHistoryView.ascx.vb" Inherits="Modules.EPORTAL.View" %>

<style>
    h1{ text-align: center;}
    h1 span{
        text-align: center;
        font-size:28px;
    }

    .jobhistory ul {
        --col-gap: 2rem;
        --row-gap: 2rem;
        --line-w: 0.25rem;
        display: grid;
        grid-template-columns: var(--line-w) 1fr;
        grid-auto-columns: max-content;
        column-gap: var(--col-gap);
        list-style: none;
        /*width: min(86rem, 95%);*/
        width: 96%;
        margin-inline: auto;
    }

        /* line */
        .jobhistory ul::before {
            content: "";
            grid-column: 1;
            grid-row: 1 / span 20;
            background: rgb(225, 225, 225);
            border-radius: calc(var(--line-w) / 2);
        }

        /* columns*/

        /* row gaps */
        .jobhistory ul li:not(:last-child) {
            margin-bottom: var(--row-gap);
        }

        /* card */
        .jobhistory ul li {
            grid-column: 2;
            --inlineP: 1.5rem;
            margin-inline: var(--inlineP);
            grid-row: span 2;
            display: grid;
            grid-template-rows: min-content min-content min-content;
            background:#f8f6f6;
        }

            /* date */
            .jobhistory ul li .date {
                --dateH: 3rem;
                height: var(--dateH);
                margin-inline: calc(var(--inlineP) * -1);
                text-align: center;
                background-color: var(--accent-color);
                color: white;
                font-size: 1.25rem;
                font-weight: 700;
                display: grid;
                place-content: center;
                position: relative;
                border-radius: calc(var(--dateH) / 2) 0 0 calc(var(--dateH) / 2);
            }

                /* date flap */
                .jobhistory ul li .date::before {
                    content: "";
                    width: var(--inlineP);
                    aspect-ratio: 1;
                    background: var(--accent-color);
                    background-image: linear-gradient(rgba(0, 0, 0, 0.2) 100%, transparent);
                    position: absolute;
                    top: 100%;
                    clip-path: polygon(0 0, 100% 0, 0 100%);
                    right: 0;
                }

                /* circle */
                .jobhistory ul li .date::after {
                    content: "";
                    position: absolute;
                    width: 2rem;
                    aspect-ratio: 1;
                    background: var(--bgColor);
                    border: 0.3rem solid var(--accent-color);
                    border-radius: 50%;
                    top: 50%;
                    transform: translate(50%, -50%);
                    right: calc(100% + var(--col-gap) + var(--line-w) / 2);
                }

            /* title descr */
            .jobhistory ul li .title,
            .jobhistory ul li .descr {
                background: var(--bgColor);
                position: relative;
                padding-inline: 1.5rem;
            }

            .jobhistory ul li .title {
                overflow: hidden;
                padding-block-start: 1.5rem;
                padding-block-end: 1rem;
                font-weight: 600;
                display:inline-block;

            }

            .jobhistory ul li .descr {
                padding-block-end: 1.5rem;
                font-weight: 300;
            }

                /* shadows */
                .jobhistory ul li .title::before,
                .jobhistory ul li .descr::before {
                    content: "";
                    position: absolute;
                    width: 90%;
                    height: 0.5rem;
                    background: rgba(0, 0, 0, 0.5);
                    left: 50%;
                    border-radius: 50%;
                    filter: blur(4px);
                    transform: translate(-50%, 50%);
                }

            .jobhistory ul li .title::before {
                bottom: calc(100% + 0.125rem);
            }

            .jobhistory ul li .descr::before {
                z-index: -1;
                bottom: 0.25rem;
            }

    @media (min-width: 40rem) {
        .jobhistory ul {
            grid-template-columns: 1fr var(--line-w) 1fr;
        }

            .jobhistory ul::before {
                grid-column: 2;
            }

            .jobhistory ul li:nth-child(odd) {
                grid-column: 1;
            }

            .jobhistory ul li:nth-child(even) {
                grid-column: 3;
            }

            /* start second card */
            .jobhistory ul li:nth-child(2) {
                grid-row: 2/4;
            }

            .jobhistory ul li:nth-child(odd) .date::before {
                clip-path: polygon(0 0, 100% 0, 100% 100%);
                left: 0;
            }

            .jobhistory ul li:nth-child(odd) .date::after {
                transform: translate(-50%, -50%);
                left: calc(100% + var(--col-gap) + var(--line-w) / 2);
            }

            .jobhistory ul li:nth-child(odd) .date {
                border-radius: 0 calc(var(--dateH) / 2) calc(var(--dateH) / 2) 0;
            }
    }

    .jobhistory .credits {
        margin-top: 1rem;
        text-align: right;
    }

        .jobhistory .credits a {
            color: var(--color);
        }
</style>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <div class="box box-info">
            <div class="box-header with-border">
                <div class="col-md-12">
                    <h3 class="box-title">Lịch sử cập nhật thông tin hồ sơ</h3>
                </div>
            </div>
            <div class="box-body">
                <div class="main-body">
                    <div class="row">
                        <h1><asp:Label runat="server" ID="JobTitle"></asp:Label></h1>
                        <div class="jobhistory">
                            <ul>
                                <asp:Repeater runat="server" ID="rptBienDong">
                                    <ItemTemplate>
                                        <li style="--accent-color:<%# IIf (Container .ItemIndex mod 2 = 1,"#41516C","#FBCA3E") %> ">
                                            <div class="date"> <%# DotNetNuke.EPORTAL.flReg.ReadDate(Eval("HisDate"))%></div>
                                            <div class="title">Người cập nhật: <%#Eval("UserName")%></div>
                                            <div class="descr">Lịch sử: <%#Eval("HisName")%></div>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <asp:Literal ID="lbMsg" runat="server" />
        <div class="fix-btt-toolbar">
            <div>
                <asp:Button ID="cmdBack" runat="server" Text="Quay lại" CssClass="cmsbut cmsback" OnClientClick="return $('#Form').validationEngine('detach');" />
                <%--<asp:Button ID="cmdNew" runat="server" Text="Thêm mới" CssClass="cmsbut cmsbtnew" />
                <asp:Button ID="cmdActive" runat="server" Text="Cập nhật" OnClientClick="waiting();" CssClass="cmsbut cmsbtupdate" />
                <asp:Button ID="cmdDelete" runat="server" Text="Xóa" CssClass="cmsbut cmsbtdel"  />--%>
            </div>
        </div>
        <asp:HiddenField ID="ItemID" runat="server" Visible="true" />
    </ContentTemplate>
</asp:UpdatePanel>
