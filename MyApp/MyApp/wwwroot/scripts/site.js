﻿$(document).ready(function () {
    var input = document.getElementById("StatementFilter");

    input.addEventListener("keyup", function (event) {
        if (event.keyCode === 13) {
            var statementFilter = {
                statementName: input.value
            };

            $.ajax({
                type: 'GET',
                url: '/StatementModels/UpdateStatementGrid',
                data: statementFilter
            });
        }
    });

 });