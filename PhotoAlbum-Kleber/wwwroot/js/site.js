// Write your JavaScript code.
$(document).ready(function () {
    $("#txtSearch").keyup(function () {
        var searchText = $("#txtSearch").val();
        $("#photoTable tbody tr").each(function () {
            var tr = $(this);
            if (!tr.text().toLowerCase().includes(searchText.toLowerCase())) {
                tr.addClass("hide");
            } else {
                tr.removeClass("hide");
            };
        });
    });
});