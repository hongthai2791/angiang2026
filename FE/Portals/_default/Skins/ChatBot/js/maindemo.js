var vrtimeout = 2000;
var ST_TITLE = ''; var ST_VANBAN = ''; var ST_ICON = ''; var ST_TUXAU = []; var ST_NENKHUNGCHAT = ''; var lstKeyWord = [];
var ST_NENDONSAC = ''; var ST_NENCHUYENMAU = '';
const ID_BOT = get(".ItemIDBot").value;
const ID_HOITHOAI = get(".ItemIDBot").value;
const msgerForm = get(".msger-inputarea");
const msgerInput = get(".msger-input");
const msgerChat = get(".history-chat");

const prompts = [
    ["hi", "hey", "hello", "good morning", "good afternoon", "xin chào", "chào bạn"],
    ["how are you", "how is life", "how are things", "bạn khỏe không", "khỏe không"],
    ["what are you doing", "what is going on", "what is up"],
    ["how old are you"],
    ["who are you", "are you human", "are you bot", "are you human or bot", "bạn là ai", "bạn là người hay robot","bạn là robot"],
    ["who created you", "who made you"],
    [
        "your name please",
        "your name",
        "may i know your name",
        "what is your name",
        "what call yourself"
    ],
    ["i love you", "love you", "love", "my love"],
    ["happy", "good", "fun", "wonderful", "fantastic", "cool"],
    ["bad", "bored", "tired"],
    ["help me", "tell me story", "tell me joke"],
    ["ah", "yes", "ok", "okay", "nice"],
    ["bye", "good bye", "goodbye", "see you later", "tạm biệt"],
    ["bro"],
    ["what", "why", "how", "where", "when"],
    ["no", "not sure", "maybe", "no thanks"],
    [""],
    ["haha", "ha", "lol", "hehe", "funny", "joke"],
    ["việc làm", "tìm việc", "tìm việc làm", "tôi muốn tìm việc làm", "chị muốn tìm việc làm", "anh muốn tìm việc làm", "chú muốn tìm việc làm", "cháu muốn tìm việc làm", "ông muốn tìm việc làm", "bác muốn tìm việc làm"]
]
const replies = [
    ["Xin chào!", "Hi!", "Hey!", "Chào bạn!", "Howdy"],
    [
        "Tôi khỏe... còn bạn thì sao?",
        "Khá tốt, bạn thế nào?",
        "Tuyệt vời, bạn thế nào?"
    ],
    [
        "Không có gì nhiều",
        "Đang chuẩn bị đi ngủ",
        "Bạn có thể đoán được không?",
        "Thực ra tôi không biết"
    ],
    ["Tôi là vô tận"],
    ["Tôi chỉ là một con thuyền", "Tôi chỉ là người lắng nghe để thấu hiểu mọi người","Tôi chỉ là người mang niềm vui đến mọi người"],
    ["Một vị thần đích thực, người anh em của tôi", "Tôi rất khi khi được sinh ra"],
    ["Tôi vô danh", "Hãy gọi là cái tên dễ thương"],
    ["Tôi cũng yêu Bạn", "Tôi cũng vậy"],
    ["Bạn đã bao giờ cảm thấy tồi tệ chưa?", "Rất vui được nghe điều đó"],
    ["Tại sao?", "Tại sao? Bạn không nên!", "Hãy thử xem TV", "Bạn thử đi du lịch", "Hãy thử xem phim"],
    ["Còn chuyện gì thế?", "Đã có một thời..."],
    ["Kể cho tôi nghe một câu chuyện", "Cho tôi biết về bản thân của bạn"],
    ["Bye", "Goodbye", "Hẹn gặp lại", "Tạm biệt"],
    ["Anh Bạn!"],
    ["Câu hỏi tuyệt vời"],
    ["Không sao đâu", "Tôi hiểu", "Bạn muốn nói về điều gì?"],
    ["Hãy nói điều gì đó đi :("],
    ["Haha!", "Good one!"],
    ["Hãy cho tôi biết bạn cần tìm việc gì?", "Tôi luôn sẵn lòng, hãy cho tôi biết bạn cần tìm việc gì?", "Bạn muốn làm ngành nghề nào?", "Bạn đã từng làm ngành nghề gì?"]
];
const alternative = [
    "Hiện tại tôi chưa có câu trả lời cho nội dung này, bạn thử lại nhé!",
    "Nội dung này tôi chưa có câu trả lời, tôi đang lắng nghe để hoàn thiện hơn. Bạn hãy thử lại nhé!",
    "Bạn hãy thử lại nội dung khác nhé!"
]
const robot = ["Tôi đang quá tải, bạn vui lòng thử lại sau...", "Tôi đang gặp một chút vấn đề...", "Hẹn bạn dịp khác..."];

$("form").on("submit", function (event) {
    event.preventDefault();
    const msgText = msgerInput.value;
    if (!msgText) return;
    msgerInput.value = "";
    if (!text_validate(msgText)) {
        addChatClientDF('******');
        addChatSupportDF('Tôi chỉ hiểu được số, chữ thường và chữ hoa :(');
    }
    else {
        var checkTuXau = ST_TUXAU.some(item => item.toLowerCase().replaceAll(" ", "") == msgText.toLowerCase().replaceAll(" ", ""))
        if (checkTuXau) {
            addChatClientDF('******');
            addChatSupportDF('Bạn hãy là một người văn minh!');
            return;
        }
        else {
            addChatClient(msgText);
            addChatLoading();
            output(msgText);
        }
    }
});

function output(input) {
    let product;
    //let text = input.toLowerCase().replace(/[^\w\s]/gi, "").replace(/[\d]/gi, "").trim();
    let text = input.toLowerCase().trim();
    text = text
        .replace(/ a /g, " ")
        .replace(/i feel /g, "")
        .replace(/whats/g, "what is")
        .replace(/please /g, "")
        .replace(/ please/g, "")
        .replace(/r u/g, "are you");
    //if (compare(prompts, replies, text)) {
    //    product = compare(prompts, replies, text);
    //} else if (text.match(/thank/gi)) {
    //    product = "You're welcome!"
    //} else if (text.match(/(robot|bot|robo)/gi)) {
    //    product = robot[Math.floor(Math.random() * robot.length)];
    //} else {
    //    product = alternative[Math.floor(Math.random() * alternative.length)];
    //}
    if (compare(prompts, replies, text)) {
        product = compare(prompts, replies, text);
    }
    const delay = input.split(" ").length * 100;
    setTimeout(() => {
        if (product != "" && product != undefined) {
            addChatSupport(product);
            removeLoading();
            if (ID_HOITHOAI == "0") {
                $('.txtClient').val(text);
                $('.txtChatBot').val(product);
                $('.iConChatBot').val(ST_ICON);
                $('.btn-savemessage').click();
            }
        }
        else
        {
            checkTuKhoa(text);
            if (ID_HOITHOAI == "0") {
                $('.txtClient').val(text);
                $('.txtChatBot').val(product);
                $('.iConChatBot').val(ST_ICON);
                $('.btn-savemessage').click();
            }
        }

    }, delay);
}
function compare(promptsArray, repliesArray, string) {
    let reply;
    let replyFound = false;
    for (let x = 0; x < promptsArray.length; x++) {
        for (let y = 0; y < promptsArray[x].length; y++) {
            if (promptsArray[x][y] === string) {
                let replies = repliesArray[x];
                reply = replies[Math.floor(Math.random() * replies.length)];
                replyFound = true;
                break;
            }
        }
        if (replyFound) {
            break;
        }
    }
    return reply;
}

function addChatClientDF(text) {
    const msgHTML = `
  <div class="message-content message_client">
    <div class="message-content__detail">
      <div class="text-box message">
        <div class="text-box_area">
          <div class="text-box__text custom-background-color1" style="background: ${ST_NENCHUYENMAU};">${text}</div>
        </div>
      </div>
      </div>
      <div class="message-content__time">${formatDate(new Date())}</div>
    </div>
  `;
    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
}
function addChatSupportDF(text) {
    const msgHTML = `
  <div class="message-content message_support">
    <div class="message-content__detail">
      <div class="avatar"><img class="message_support-avatar" src="${ST_ICON}" alt="ChatBot"></div>
      <div class="text-box message">
        <div class="text-box_area">
          <div class="text-box__text custom-background-color1" style="background: ${ST_NENDONSAC};">${text}</div>
        </div>
      </div>
      </div>
      <div class="message-content__time">${formatDate(new Date())}</div>
    </div>
  `;
    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
}
function addChatClient(text) {
    const msgHTML = `
  <div class="message-content message_client">
    <div class="message-content__detail">
      <div class="text-box message">
        <div class="text-box_area">
          <div class="text-box__text custom-background-color1" style="background: ${ST_NENCHUYENMAU};">${text}</div>
        </div>
      </div>
      </div>
      <div class="message-content__time">${formatDate(new Date())}</div>
    </div>
  `;
    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
    //addTinHoiThoai(msgHTML, text, 1)
}
function addChatSupport(text) {
    const msgHTML = `
  <div class="message-content message_support">
    <div class="message-content__detail">
      <div class="avatar"><img class="message_support-avatar" src="${ST_ICON}" alt="ChatBot"></div>
      <div class="text-box message">
        <div class="text-box_area">
          <div class="text-box__text custom-background-color1" style="background: ${ST_NENDONSAC};">${text}</div>
        </div>
      </div>
      </div>
      <div class="message-content__time">${formatDate(new Date())}</div>
    </div>
  `;
    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
    //addTinHoiThoai(msgHTML, text, 2)
}
function get(selector, root = document) {
    return root.querySelector(selector);
}
function formatDate(date) {
    const year = date.getFullYear();
    const moth = "0" + (date.getMonth() + 1);
    const day = "0" + date.getDate();
    const h = "0" + date.getHours();
    const m = "0" + date.getMinutes();
    return `${day.slice(-2)}/${moth.slice(-2)}/${year} ${h.slice(-2)}:${m.slice(-2)}`;
}
function random(min, max) {
    return Math.floor(Math.random() * (max - min) + min);
}

function LoadSetting() {
    $('#df_time').text(formatDate(new Date()));
}

$('.carousel').carousel({
    interval: 2000
})


function addChatSearch(keyword) {
    $.ajax({
        type: 'POST',
        url: '/API/chatbot/common.asmx/tinnhan_searchkeyword',
        data: { idBot: ID_BOT, keyWord: keyword },
        success: function (res) {
            setTimeout(function () {
                if (res.status == 1) {
                    let product;
                    product = alternative[Math.floor(Math.random() * alternative.length)];
                    addChatSupport(product);
                    removeLoading();
                    return;
                }
                if (res.status == 2) {
                    var i;
                    for (i = 0; i < res.data.length; ++i) {
                        if (res.data[i].phanLoai == 1) { // văn bản
                            addChatSupport(res.data[i].noiDung);
                        }
                        if (res.data[i].phanLoai == 2) { // button
                            addChatSupportButton(res.data[i].noiDung, res.data[i].noiDungButton);
                        }
                        if (res.data[i].phanLoai == 3) { // Slide
                            addChatSupportSlide(res.data[i].noiDung, res.data[i].noiDungSlide);
                        }
                        if (res.data[i].phanLoai == 4) { // Tập tin
                            addChatSupportTapTin(res.data[i].noiDung, res.data[i].tenTinNhan, res.data[i].tapTin);
                        }
                        if (res.data[i].phanLoai == 5) { // Phản hồi nhanh
                            var _kieuHienThi = res.data[i].kieuHienThi == 1 ? 'spanbold' : '';
                            addChatSupportPhanHoiNhanh(res.data[i].noiDung, res.data[i].viTri, res.data[i].thoiGianString, _kieuHienThi);
                        }
                        if (res.data[i].phanLoai == 6) { // Kịch bản
                            addChatSupportKichBan(res.data[i].noiDung, res.data[i].tenTinNhan, res.data[i].idKichBanLienKet);
                        }
                        if (res.data[i].phanLoai == 7) { // Từ khóa
                            addChatSupport(res.data[i].noiDung);
                        }
                    }
                    removeLoading();
                    return;
                }
                else {
                    let product;
                    product = robot[Math.floor(Math.random() * robot.length)];
                    addChatSupport(product);
                    removeLoading();
                    return;
                }
            }, vrtimeout);
        }
    });
}

function shownhomkichban(id) {
    addChatLoading();
    $.ajax({
        type: 'POST',
        url: '/API/chatbot/common.asmx/tinnhan_bynhomkichban',
        data: { idBot: ID_BOT, idKichBan: id },
        success: function (res) {
            setTimeout(function () {
                if (res.status == 1) {
                    let product;
                    product = alternative[Math.floor(Math.random() * alternative.length)];
                    addChatSupport(product);
                    removeLoading();
                    return;
                }
                if (res.status == 2) {
                    var i;
                    for (i = 0; i < res.data.length; ++i) {
                        if (res.data[i].phanLoai == 1) { // văn bản
                            addChatSupport(res.data[i].noiDung);
                        }
                        if (res.data[i].phanLoai == 2) { // button
                            addChatSupportButton(res.data[i].noiDung, res.data[i].noiDungButton);
                        }
                        if (res.data[i].phanLoai == 3) { // Slide
                            addChatSupportSlide(res.data[i].noiDung, res.data[i].noiDungSlide);
                        }
                        if (res.data[i].phanLoai == 4) { // Tập tin
                            addChatSupportTapTin(res.data[i].noiDung, res.data[i].tenTinNhan, res.data[i].tapTin);
                        }
                        if (res.data[i].phanLoai == 5) { // Phản hồi nhanh
                            var _kieuHienThi = res.data[i].kieuHienThi == 1 ? 'spanbold' : '';
                            addChatSupportPhanHoiNhanh(res.data[i].noiDung, res.data[i].viTri, res.data[i].thoiGianString, _kieuHienThi);
                        }
                        if (res.data[i].phanLoai == 6) { // Kịch bản
                            addChatSupportKichBan(res.data[i].noiDung, res.data[i].tenTinNhan, res.data[i].idKichBanLienKet);
                        }
                        if (res.data[i].phanLoai == 7) { // Từ khóa
                            addChatSupport(res.data[i].noiDung);
                        }
                    }
                    removeLoading();
                    return;
                }
                else {
                    let product;
                    product = robot[Math.floor(Math.random() * robot.length)];
                    addChatSupport(product);
                    removeLoading();
                    return;
                }
            }, vrtimeout);
        }
    });
}

function showkichban(id) {
    addChatLoading();
    $.ajax({
        type: 'POST',
        url: '/API/chatbot/common.asmx/tinnhan_bykichban',
        data: { idBot: ID_BOT, idKichBan: id },
        success: function (res) {
            setTimeout(function () {
                if (res.status == 1) {
                    let product;
                    product = alternative[Math.floor(Math.random() * alternative.length)];
                    addChatSupport(product);
                    removeLoading();
                    return;
                }
                if (res.status == 2) {
                    var i;
                    for (i = 0; i < res.data.length; ++i) {
                        if (res.data[i].phanLoai == 1) { // văn bản
                            addChatSupport(res.data[i].noiDung);
                        }
                        if (res.data[i].phanLoai == 2) { // button
                            addChatSupportButton(res.data[i].noiDung, res.data[i].noiDungButton);
                        }
                        if (res.data[i].phanLoai == 3) { // Slide
                            addChatSupportSlide(res.data[i].noiDung, res.data[i].noiDungSlide);
                        }
                        if (res.data[i].phanLoai == 5) { // Phản hồi nhanh
                            var _kieuHienThi = res.data[i].kieuHienThi == 1 ? 'spanbold' : '';
                            addChatSupportPhanHoiNhanh(res.data[i].noiDung, res.data[i].viTri, res.data[i].thoiGianString, _kieuHienThi);
                        }
                        if (res.data[i].phanLoai == 6) { // Kịch bản
                            addChatSupportKichBan(res.data[i].noiDung, res.data[i].tenTinNhan, res.data[i].idKichBanLienKet);
                        }
                        if (res.data[i].phanLoai == 7) { // Từ khóa
                            addChatSupport(res.data[i].noiDung);
                        }
                    }
                    removeLoading();
                    return;
                }
                else {
                    let product;
                    product = robot[Math.floor(Math.random() * robot.length)];
                    addChatSupport(product);
                    removeLoading();
                    return;
                }
            }, vrtimeout);
        }
    });
}
function showHoiThoai(id) {
    if (id > 0) {
        addChatLoading();
        $.ajax({
            type: 'POST',
            url: '/API/chatbot/common.asmx/tinhoithoai_list',
            data: { idHoiTHoai: id },
            success: function (res) {
                setTimeout(function () {
                    if (res.status == 1) {
                        removeLoading();
                        return;
                    }
                    if (res.status == 2) {
                        var i;
                        for (i = 0; i < res.data.length; ++i) {
                            msgerChat.insertAdjacentHTML("beforeend", res.data[i].noiDungHTML);
                            msgerChat.scrollTop += 500;
                        }
                        removeLoading();
                        return;
                    }
                    else {
                        removeLoading();
                        return;
                    }
                }, vrtimeout);
            }
        });
    }
}

function addChatSupportSlide(text, textSlide) {
    const msgHTML = `
  <div class="message-content message_support">
                    <div class="message-content__detail">
                        <div class="avatar">
                            <img class="message_support-avatar" src="${ST_ICON}" alt="Chatbot">
                        </div>
                        <div class="text-box message">
                            <div class="text-box_area">
                                <div class="text-box__text" style="background: ${ST_NENDONSAC};">${text}</div>
                            </div>
                        </div>
                    </div>
                    <div class="message-content-slide">
                        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                            <div class="carousel-inner">
                                ${textSlide}
                            </div>
                            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                <span class="sr-only">Previous</span>
                            </a>
                            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                <span class="sr-only">Next</span>
                            </a>
                        </div>
                    </div>
                    <div class="message-content__time">${formatDate(new Date())}</div>
                </div>
  `;
    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
   // addTinHoiThoai(msgHTML, '', 2)
}
function addChatSupportButton(text, textButton) {
    const msgHTML = `
  <div class="message-content message_support">
                    <div class="message-content__detail">
                        <div class="avatar">
                            <img class="message_support-avatar" src="${ST_ICON}" alt="Chatbot">
                        </div>
                        <div class="menu-form message" style="background: ${ST_NENDONSAC};">
                            <div class="menu-form_box">
                                <div class="menu-form_title">${text}</div>
                                ${textButton}
                            </div>
                        </div>
                    </div>
                    <div class="message-content__time">${formatDate(new Date())}</div>
                </div>
  `;
    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
    //addTinHoiThoai(msgHTML, '', 2)
}
function addChatSupportKichBan(text, textButton, idKichBan) {
    const msgHTML = `
  <div class="message-content message_support">
                    <div class="message-content__detail">
                        <div class="avatar">
                            <img class="message_support-avatar" src="${ST_ICON}" alt="Chatbot">
                        </div>
                        <div class="menu-form message" style="background: ${ST_NENDONSAC};">
                            <div class="menu-form_box">
                                <div class="menu-form_title">${text}</div>
                                 <div class="menu-form_item">
                                    <div class="menu-form_item-text"><a class="custom-text-color3" href="javascript:void(0);" onclick="showkichban(${idKichBan})">${textButton}</a></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="message-content__time">${formatDate(new Date())}</div>
                </div>
  `;
    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
    //addTinHoiThoai(msgHTML, '', 2)
}
function addChatSupportTapTin(text, textTapTin, linkTapTin) {
    const msgHTML = `
  <div class="message-content message_support">
                    <div class="message-content__detail">
                        <div class="avatar">
                            <img class="message_support-avatar" src="${ST_ICON}" alt="Chatbot">
                        </div>
                        <div class="menu-form message" style="background: ${ST_NENDONSAC};">
                            <div class="menu-form_box">
                                <div class="menu-form_title">${text}</div>
                                 <div class="menu-form_item">
                                    <div class="menu-form_item-text">
                                        <a class="custom-text-color3" href="${linkTapTin}" target="_blank" style="font-size:14px;">
                                            <img alt="Icon" src="/Portals/_default/Skins/ChatBot/images/icon_file.png" style="flex: 1 1 100%; box-sizing: border-box; max-width: 12%;" class="ng-star-inserted">
                                            ${textTapTin}
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="message-content__time">${formatDate(new Date())}</div>
                </div>
  `;
    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
    //addTinHoiThoai(msgHTML, '', 2)
}
function addChatSupportPhanHoiNhanh(text, linkUrl, thoiGian, kieuHienThi) {
    const msgHTML = `
  <div class="message-content message_support">
                    <div class="message-content__detail">
                        <div class="avatar">
                            <img class="message_support-avatar" src="${ST_ICON}" alt="Chatbot">
                        </div>
                        <div class="menu-form message" style="background: ${ST_NENDONSAC};">
                             <div class="menu-form_box">
                                <div class="menu-form_title ${kieuHienThi}">${text}</div>
                                <div class="menu-form_item">
                                    <div class="menu-form_item-text"><span>${thoiGian}</span></div>
                                </div>
                                <div class="menu-form_item">
                                    <div class="menu-form_item-text"><a class="custom-text-color3" href="${linkUrl}" target="_blank">Chia sẻ vị trí</a></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="message-content__time">${formatDate(new Date())}</div>
                </div>
  `;
    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
    //addTinHoiThoai(msgHTML, '', 2)
}

function addChatLoading() {
    const msgHTML = `
  <div class="chat-loading">
                    <div class="spinner-grow text-primary" role="status">
                        <span class="sr-only">Loading...</span>
                    </div>
                    <div class="spinner-grow text-secondary" role="status">
                        <span class="sr-only">Loading...</span>
                    </div>
                    <div class="spinner-grow text-success" role="status">
                        <span class="sr-only">Loading...</span>
                    </div>
                    <div class="spinner-grow text-danger" role="status">
                        <span class="sr-only">Loading...</span>
                    </div>
                    <div class="spinner-grow text-warning" role="status">
                        <span class="sr-only">Loading...</span>
                    </div>
                    <div class="spinner-grow text-info" role="status">
                        <span class="sr-only">Loading...</span>
                    </div>
                    <div class="spinner-grow text-light" role="status">
                        <span class="sr-only">Loading...</span>
                    </div>
                    <div class="spinner-grow text-dark" role="status">
                        <span class="sr-only">Loading...</span>
                    </div>
                </div>
  `;
    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
}
function removeLoading() {
    $('.history-chat .chat-loading').empty();
    document.getElementById('h_chatcontent').scrollTop = document.getElementById('h_chatcontent').scrollHeight
}
function loadSettingChat(iTitle, iVanBan, iCon, iTuXau, iNenKhungChat, iNenDonSac, iNenChuyenMau) {
    ST_TITLE = iTitle;
    ST_VANBAN = iVanBan;
    ST_ICON = iCon;
    ST_TUXAU = iTuXau.split(",");
    ST_NENKHUNGCHAT = iNenKhungChat;
    ST_NENDONSAC = iNenDonSac;
    ST_NENCHUYENMAU = iNenChuyenMau;
    $('.i_title').html(ST_TITLE);
    $('#df_xinchao').html(ST_VANBAN);
    $('#df_icon').attr('src', ST_ICON);
    $('.chat-web-box').css("background", ST_NENKHUNGCHAT);
    $('.cwbb__chat-content').css("background", ST_NENKHUNGCHAT);
    loadKeyWord(ID_BOT);
}
function text_validate(phno) {
    var regexPattern = new RegExp(/^[a-zA-Z0-9 àáảãạăằắẳẵặâầấẩẫậòóỏõọôồốổỗộơờớởỡợèéẻẽẹêềếểễệěùúủũụưừứửữựìíỉĩịđ.,]*$/);    // regular expression pattern
    return regexPattern.test(phno);
}

function loadKeyWord(id) {
    if (id > 0) {
        $.ajax({
            type: 'POST',
            url: '/API/chatbot/common.asmx/tukhoa_list',
            data: { idBot: id },
            success: function (res) {
                setTimeout(function () {
                    if (res.status == 2) {
                        lstKeyWord = res.data;
                        return;
                    }
                    else
                        return;
                }, vrtimeout);
            }
        });
    }
}

function checkTuKhoa(itext) {
    var i;
    var _textkey = itext;
    itext = itext.replace('.', '').toLowerCase();
    for (i = 0; i < lstKeyWord.length; ++i) {
        var key = "";
        key = lstKeyWord[i].tenTuKhoa.replace('.', '').toLowerCase();
        //console.log(itext.includes(key))
        if (itext.includes(key)) {
            shownhomtukhoa(lstKeyWord[i].idNhomTuKhoa);
            return;
        }
    }
    addChatSearch(_textkey);
}

function shownhomtukhoa(id) {
    $.ajax({
        type: 'POST',
        url: '/API/chatbot/common.asmx/tinnhan_bynhomtukhoa',
        data: { idBot: ID_BOT, idNhomTuKhoa: id },
        success: function (res) {
            setTimeout(function () {
                if (res.status == 1) {
                    let product;
                    product = alternative[Math.floor(Math.random() * alternative.length)];
                    addChatSupport(product);
                    removeLoading();
                    return;
                }
                if (res.status == 2) {
                    var i;
                    for (i = 0; i < res.data.length; ++i) {
                        if (res.data[i].phanLoai == 1) { // văn bản
                            addChatSupport(res.data[i].noiDung);
                        }
                        if (res.data[i].phanLoai == 2) { // button
                            addChatSupportButton(res.data[i].noiDung, res.data[i].noiDungButton);
                        }
                        if (res.data[i].phanLoai == 3) { // Slide
                            addChatSupportSlide(res.data[i].noiDung, res.data[i].noiDungSlide);
                        }
                        if (res.data[i].phanLoai == 4) { // Tập tin
                            addChatSupportTapTin(res.data[i].noiDung, res.data[i].tenTinNhan, res.data[i].tapTin);
                        }
                        if (res.data[i].phanLoai == 5) { // Phản hồi nhanh
                            var _kieuHienThi = res.data[i].kieuHienThi == 1 ? 'spanbold' : '';
                            addChatSupportPhanHoiNhanh(res.data[i].noiDung, res.data[i].viTri, res.data[i].thoiGianString, _kieuHienThi);
                        }
                        if (res.data[i].phanLoai == 6) { // Kịch bản
                            addChatSupportKichBan(res.data[i].noiDung, res.data[i].tenTinNhan, res.data[i].idKichBanLienKet);
                        }
                        if (res.data[i].phanLoai == 7) { // Từ khóa
                            addChatSupport(res.data[i].noiDung);
                        }
                    }
                    removeLoading();
                    return;
                }
                else {
                    let product;
                    product = robot[Math.floor(Math.random() * robot.length)];
                    addChatSupport(product);
                    removeLoading();
                    return;
                }
            }, vrtimeout);
        }
    });
}

//$('.chat-input-text_input').keypress(function (e) {
//    var regex = new RegExp(/^[a-zA-Z0-9 àáảãạăằắẳẵặâầấẩẫậòóỏõọôồốổỗộơờớởỡợèéẻẽẹêềếểễệěùúủũụưừứửữựìíỉĩị.,]*$/);
//    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
//    if (regex.test(str)) {
//        return true;
//    }
//    else {
//        e.preventDefault();
//        return false;
//    }
//});