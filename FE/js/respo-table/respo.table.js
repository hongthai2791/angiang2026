$(document).ready(function () {
    var name = "", text = "";
    $(".respo-title").each(function (e) {
        name = $(this).attr("class");
        $("." + name.replace("respo-title", "").trim()).attr("text-column", $(this).text());
    });
});
function toggleclick(t) {
    if ($(t).hasClass("toggle-active")) {
        $(t).removeClass("toggle-active"); $(t).parents(".column-primary").parents("tr").find(".respo-view").removeClass("author");
    } else {
        $(t).addClass("toggle-active"); $(t).parents(".column-primary").parents("tr").find(".respo-view").addClass("author");
    }
};