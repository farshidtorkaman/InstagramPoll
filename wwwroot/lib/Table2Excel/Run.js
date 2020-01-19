

$.getScript("../Scripts/Table2Excel/jquery.table2excel.min.js", function(){

    $("button.excel").click(function () {
        $("table").table2excel({
            // exclude CSS class
            exclude: ".noExl",
            name: "Worksheet Name",
            filename: "Hesab" //do not include extension
        });
    });
});