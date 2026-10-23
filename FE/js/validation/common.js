function vali_textnumber(phno) {// Số, chữ thường và chữ hoa
    var regexPattern = new RegExp(/^[a-zA-Z0-9 àáảãạăằắẳẵặâầấẩẫậòóỏõọôồốổỗộơờớởỡợèéẻẽẹêềếểễệěùúủũụưừứửữựìíỉĩịđ.,]*$/);    // regular expression pattern
    return regexPattern.test(phno);
}
function vali_charactersspace(phno) {// Ký tự và khoảng trắng
    var regexPattern = new RegExp(/[a-zA-Z ]+$/);    
    return regexPattern.test(phno);
}
function vali_characters(phno) {// Ký tự a-z
    var regexPattern = new RegExp(/^[A-z]+$/);    
    return regexPattern.test(phno);
}
function vali_email(phno) {// Email
    var regexPattern = new RegExp(/[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/);    
    return regexPattern.test(phno);
}
function vali_visa(phno) {// Visa
    var regexPattern = new RegExp(/^4[0-9]{12}(?:[0-9]{3})?$/);
    return regexPattern.test(phno);
}
function vali_masterCard(phno) {// MasterCard
    var regexPattern = new RegExp(/^5[1-5][0-9]{14}$/);
    return regexPattern.test(phno);
}
function vali_website(phno) {// Website
    var expression = /(https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|www\.[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9]+\.[^\s]{2,}|www\.[a-zA-Z0-9]+\.[^\s]{2,})/gi;
    var regexPattern = new RegExp(expression);
    return regexPattern.test(phno);
}