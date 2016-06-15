$(function () {


    $("#button").button();

    $("#radioset").buttonset();
    $("#tabs").tabs();

    $("#dialog").dialog({
        autoOpen: false,
        width: 400,
        buttons: [
            {
                text: "Ok",
                click: function () {
                    $(this).dialog("close");
                }
            },
            {
                text: "Cancel",
                click: function () {
                    $(this).dialog("close");
                }
            }
        ]
    });

    $("#dialog-link").click(function (event) {
        $("#dialog").dialog("open");
        event.preventDefault();
    });

    $("#datepicker").datepicker({
        inline: true
    });

    $("#slider").slider({
        range: true,
        values: [17, 67]
    });

    $("#progressbar").progressbar({
        value: 20
    });

    $("#dialog-link, #icons li").hover(
        function () {
            $(this).addClass("ui-state-hover");
        },
        function () {
            $(this).removeClass("ui-state-hover");
        }
    );
});