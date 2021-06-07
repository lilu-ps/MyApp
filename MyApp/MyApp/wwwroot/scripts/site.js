$(document).ready(function () {
    var input = document.getElementById("StatementFilter");

    input.addEventListener("keyup", function (event) {
        if (event.keyCode === 13) {

            console.log("another worker");
            var statementFilter = {
                statementName: input.value
            };


            $.ajax({
                type: 'GET',
                url: '/StatementModels/UpdateStatementGrid',
                data: statementFilter,
                success: function (a) {
                    $('#grid-view-body').html(a);
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(errorThrown)
                }
            });
        }
    });

 });