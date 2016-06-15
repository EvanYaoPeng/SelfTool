$(document).ready(function () {
    sx_setWinHeight();
});

$(window).resize(function () {
    sx_setWinHeight();
});

function sx_setWinHeight() {
    var height = document.documentElement.clientHeight;
    var width = document.documentElement.clientWidth;

    var borderHeight = 8 * 2;
    var topHeight = 40;
    var footHeight = 30;
    var tabsHeight = 60;

    $("body").css("height", height + "px");
    $("#bodyContent").css("height", (height - borderHeight) + "px");
    $("#mainContent").css("height", (height - borderHeight - topHeight - footHeight) + "px");
    $("#mainLifeContent").css("height", (height - borderHeight - topHeight - footHeight) + "px");
    $("#mainRightContent").css("height", (height - borderHeight - topHeight - footHeight) + "px");
    //$(".base-tabs").css("height", (height - borderHeight - topHeight - footHeight - tabsHeight) + "px");

    var borderWidth = 8 * 2 + 4;
    var treeWidth = 200;
    var lineWidth = 8;
    var tabsWidth = 40;

    $("body").css("width", width + "px");
    $("#mainLifeContent").css("width", treeWidth + "px");
    $("#mainRightContent").css("width", (width - borderWidth - treeWidth - lineWidth) + "px");
    $(".base-tabs").css("width", width - borderWidth - treeWidth - lineWidth - tabsWidth + "px");
    
}

