<%@ Control Language="vb" CodeFile="HomeChatDemo.ascx.vb" Inherits="Modules.HomeChatDemo.View" AutoEventWireup="false" Explicit="True" %>
<style>
    body{margin: 0 !important;}
    .personabar{display:none !important;}
    .cwbb__header-icon-close{display:none;}
</style>
<div id="chatWebBox" style="height: 100vh;">
    <div class="chat-web-box">
        <div class="cwbb__header custom-background-color2">
            <div class="cwbb__header-icon-status cwbb__header-icon-status-active" id="status-support"></div>
            <div class="cwbb__header-name-bot custom-text-color3 i_title" style="color: #fff;">eChat - Hỗ trợ trực tuyến</div>
            <div class="cwbb__header-icon-close">
                <svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                    <g opacity="0.45">
                        <path d="M13.3054 11.9984L19.2773 6.03125C19.6382 5.67031 19.6382 5.08672 19.2773 4.72813C18.9164 4.36719 18.3328 4.36719 17.9742 4.72813L12 10.693L6.02573 4.72578C5.66479 4.36484 5.0812 4.36484 4.72261 4.72578C4.36167 5.08672 4.36167 5.67031 4.72261 6.02891L10.6945 11.9961L4.72261 17.9656C4.36167 18.3266 4.36167 18.9102 4.72261 19.2688C4.90308 19.4492 5.13979 19.5383 5.37417 19.5383C5.61089 19.5383 5.84526 19.4492 6.02573 19.2688L12 13.3016L17.9742 19.2711C18.1546 19.4516 18.389 19.5406 18.6257 19.5406C18.8625 19.5406 19.0968 19.4516 19.2773 19.2711C19.6382 18.9102 19.6382 18.3266 19.2773 17.968L13.3054 11.9984Z" fill="#000"></path>
                    </g></svg>
            </div>
        </div>
        <div class="cwbb__chat-content" id="h_chatcontent" style="height: calc(100vh - 126px);">
            <div class="history-chat">
                <div class="message-content message_support">
                    <div class="message-content__detail">
                        <div class="avatar">
                            <img class="message_support-avatar" id="df_icon" src="/Portals/_default/Skins/ChatBot/images/logo.png" alt="Chatbot">
                        </div>
                        <div class="text-box message">
                            <div class="text-box_area">
                                <div class="text-box__text text_chatbot" id="df_xinchao">Xin chào! Mình có thể giúp gì cho bạn hôm nay?☺️</div>
                            </div>
                        </div>
                    </div>
                    <div class="message-content__time" id="df_time">06/11/2023 13:44</div>
                </div>
            </div>
        </div>
        <div class="cwbb__chat-fixed">
            <div class="cwbb__chat-suggest" style="visibility: hidden; height: 0px;">
                <div class="cwbb__chat-suggest_title">
                    Gợi ý <span class="cwbb__chat-suggest_icon">
                        <svg width="14" height="8" viewBox="0 0 14 8" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path d="M13.8402 0.619934C13.6269 0.406133 13.2806 0.405805 13.0668 0.619141L7.38669 6.28747C7.17344 6.5007 6.82653 6.50067 6.61289 6.28706L0.933188 0.619141C0.719387 0.405778 0.37316 0.406133 0.15977 0.619934C-0.0535661 0.833735 -0.0532106 1.17999 0.160563 1.39332L5.83989 7.06086C6.15984 7.38076 6.57997 7.54066 7.00016 7.54066C7.42011 7.54066 7.84014 7.38081 8.15968 7.06125L13.8394 1.39332C14.0532 1.17999 14.0536 0.833735 13.8402 0.619934Z" fill="black"></path></svg>
                    </span>
                </div>
                <div class="cwbb__chat-suggest_list cwbb__chat-suggest_list_open"></div>
            </div>

            <form class="msger-inputarea">
                <div class="cwbb__chat-input" style="border-top: 1px solid rgb(232, 232, 232);">
                    <div class="chat-input-text">
                        <input type="text" class="chat-input-text_input msger-input" placeholder="Vui lòng nhập nội dung/ Please type your message here">
                    </div>
                    <div class="chat-input-submit">
                        <button type="submit" class="msger-send-btn">
                            <svg width="34" height="34" viewBox="0 0 34 34" fill="none" xmlns="http://www.w3.org/2000/svg">
                                <path d="M24.1893 0.797559C23.4249 0.0663564 22.3128 -0.185972 21.2829 0.140325L1.90617 6.36622C1.90065 6.368 1.89513 6.36982 1.88965 6.3717C0.741482 6.76268 -0.000195461 7.769 3.86397e-08 8.93543C0.000195539 10.0978 0.737182 11.1009 1.87861 11.4944L9.92011 14.4395L13.086 22.2081C13.4991 23.2972 14.5458 23.9997 15.7574 23.9997H15.7596C16.9774 23.9989 18.0278 23.2887 18.4357 22.1905C18.4381 22.184 18.4404 22.1777 18.4426 22.1712L24.8819 3.56679C25.2162 2.58715 24.9509 1.52604 24.1893 0.797559ZM16.5911 21.5693C16.395 22.084 15.9046 22.1245 15.7583 22.1246C15.6106 22.1246 15.1162 22.0838 14.9216 21.5623C14.9185 21.5538 14.9151 21.5453 14.9117 21.5369L11.5836 13.3703C11.4833 13.1242 11.2793 12.93 11.0218 12.8358L2.56608 9.73901C2.5588 9.73634 2.55147 9.73376 2.54414 9.73123C1.99767 9.54542 1.9551 9.07489 1.9551 8.93511C1.9551 8.79593 1.99708 8.32878 2.53686 8.14114L21.5152 2.04322L13.337 9.88264C12.9551 10.2487 12.9549 10.8423 13.3366 11.2085C13.5275 11.3917 13.7778 11.4833 14.028 11.4833C14.2781 11.4833 14.5282 11.3919 14.719 11.2089L22.8866 3.37972L16.5911 21.5693Z" fill="#A0A0A0"></path></svg></button>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>
<asp:UpdatePanel ID="pageView" runat="server">
    <ContentTemplate>
        <asp:TextBox ID="IdBot" runat="server" CssClass="ItemIDBot none" />
    </ContentTemplate>
</asp:UpdatePanel>
<script src="/Portals/_default/Skins/ChatBot/js/maindemo.js"></script>