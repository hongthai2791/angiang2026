<%@ Control Language="vb" CodeFile="Firebase.ascx.vb" Inherits="Modules.Firebase.View" AutoEventWireup="false" Explicit="True" %>
<link href="/portals/_default/skins/vbn/firebase/main.css?v=1.1" rel="stylesheet" />
<link href="/portals/_default/skins/vbn/firebase/manifest.json?v=1.1" rel="manifest" />

<div id="token_div" style="display: none;">
    <p id="token" style="word-break: break-all; display: none;"></p>
</div>
<div id="permission_div" style="display: none!important;">
    <p id="token" style="display: none;"></p>
</div>


<script src="/portals/_default/skins/vbn/firebase/init.js?v=1.1"></script>
 <script defer src="https://www.gstatic.com/firebasejs/7.17.1/firebase-app.js"></script>

<script defer src="https://www.gstatic.com/firebasejs/7.17.1/firebase-auth.js"></script>
<script defer src="https://www.gstatic.com/firebasejs/7.17.1/firebase-firestore.js"></script>


<script type="text/javascript">
    const messaging = firebase.messaging();
    messaging.usePublicVapidKey("AIzaSyDkqLVhl1iJRdSzYC - nC8JMg_Q7iiFZRgI");
    messaging.getToken().then((currentToken) => {
        if (currentToken) {
            sendTokenToServer(currentToken);
            updateUIForPushEnabled(currentToken);
        } else {
            // Show permission request.
            console.log('No Instance ID token available. Request permission to generate one.');
            // Show permission UI.
            updateUIForPushPermissionRequired();
            setTokenSentToServer(false);
        }
    }).catch((err) => {
        console.log('An error occurred while retrieving token. ', err);
        showToken('Error retrieving Instance ID token. ', err);
        setTokenSentToServer(false);
    });
    // Callback fired if Instance ID token is updated.
    messaging.onTokenRefresh(() => {
        messaging.getToken().then((refreshedToken) => {
            console.log('Token refreshed.');
            // Indicate that the new Instance ID token has not yet been sent to the
            // app server.
            setTokenSentToServer(false);
            // Send Instance ID token to app server.
            sendTokenToServer(refreshedToken);
            // ...
        }).catch((err) => {
            console.log('Unable to retrieve refreshed token ', err);
            showToken('Unable to retrieve refreshed token ', err);
        });
    });

<%--    const messaging = firebase.messaging();
    const tokenDivId = 'token_div';
    const permissionDivId = 'permission_div';
    messaging.onTokenRefresh(function () {
        debugger;
        messaging.getToken()
            .then(function (refreshedToken) {
                console.log('Token refreshed.');
                setTokenSentToServer(false);
                sendTokenToServer(refreshedToken);
                resetUI();
            })
            .catch(function (err) {
                console.log('Unable to retrieve refreshed token ', err);
                showToken('Unable to retrieve refreshed token ', err);
            });
    });
    messaging.onMessage(function (payload) { console.log("Message received. ", payload); appendMessage(payload); });
    var username = "<%=Me.UserInfo.Username%>";

    function resetUI() {
        clearMessages();
        showToken('loading...');
        messaging.getToken()
            .then(function (currentToken) {
                if (currentToken) {
                    sendTokenToServer(currentToken);
                    updateUIForPushEnabled(currentToken);
                    $.ajax({
                        type: "POST", url: '/api/app/fcm.asmx/fcmAddNew',
                        dataType: 'json', async: true,
                        cache: false, contentType: 'application/json; charset=utf-8', data: JSON.stringify({ token: currentToken, appID: username, appType: 'Web' }),
                        success: function (data) {
                            config.log(data);
                        }, failure: function (errMsg) {
                            alert(errMsg);
                        }
                    });
                } else {
                    console.log('No Instance ID token available. Request permission to generate one.');
                    updateUIForPushPermissionRequired();
                    setTokenSentToServer(false);
                }
            })
            .catch(function (err) {
                console.log('An error occurred while retrieving token. ', err);
                showToken('Error retrieving Instance ID token. ', err);
                setTokenSentToServer(false);
            });
    }
    function showToken(currentToken) { var tokenElement = document.querySelector('#token'); tokenElement.textContent = currentToken; };
    function sendTokenToServer(currentToken) { if (!isTokenSentToServer()) { console.log('Sending token to server...'); setTokenSentToServer(true); } else { console.log('Token already sent to server so won\'t send it again unless it changes'); } }
    function isTokenSentToServer() { return window.localStorage.getItem('sentToServer') == 1; }
    function setTokenSentToServer(sent) { window.localStorage.setItem('sentToServer', sent ? 1 : 0); }
    function showHideDiv(divId, show) { const div = document.querySelector('#' + divId); if (show) { div.style = "display: visible"; } else { div.style = "display: none"; } }
    function requestPermission() {
        console.log('Requesting permission...');
        messaging.requestPermission()
            .then(function () { console.log('Notification permission granted.'); resetUI(); })
            .catch(function (err) { console.log('Unable to get permission to notify.', err); });
    }
    function deleteToken() {
        messaging.getToken()
            .then(function (currentToken) {
                messaging.deleteToken(currentToken)
                    .then(function () { console.log('Token deleted.'); setTokenSentToServer(false); resetUI(); })
                    .catch(function (err) { console.log('Unable to delete token. ', err); });
            })
            .catch(function (err) {
                console.log('Error retrieving Instance ID token. ', err);
                showToken('Error retrieving Instance ID token. ', err);
            });
    }
    function appendMessage(payload) {
        const messagesElement = document.querySelector('#messages');
        const dataHeaderELement = document.createElement('h5');
        const dataElement = document.createElement('pre');
        dataElement.style = 'overflow-x:hidden;'
        dataHeaderELement.textContent = 'Received message:';
        dataElement.textContent = JSON.stringify(payload, null, 2);
        messagesElement.appendChild(dataHeaderELement);
        messagesElement.appendChild(dataElement);
    }
    function clearMessages() { const messagesElement = document.querySelector('#messages'); while (messagesElement.hasChildNodes()) { messagesElement.removeChild(messagesElement.lastChild); } }
    function updateUIForPushEnabled(currentToken) { showHideDiv(tokenDivId, true); showHideDiv(permissionDivId, false); showToken(currentToken); }
    function updateUIForPushPermissionRequired() { showHideDiv(tokenDivId, false); showHideDiv(permissionDivId, true); }
    requestPermission();--%>
</script>
