(function () {

    angular.module("MyApp").directive("grid", function ($compile) {
        var ddo = {
            compile: function (element, attr) {
                var columns = [];

                element.find("column").each(function () {
                    var columnEl = $(this);

                    var title = columnEl.find("title").text();
                    var content = columnEl.find("content").html();

                    var column = {
                        title: title,
                        contentFn: $compile(content),
                    };
                    columns.push(column);
                });

                element.empty();

                return function link(scope, element, attrs) {

                    var table = $("<table><thead><tr></tr></thead><tbody></tbody></table>");
                    table.appendTo(element);

                    var tr = table.find("tr");
                    columns.forEach(function (column) {
                        var td = $("<td />");
                        td.text(column.title);
                        td.appendTo(tr);
                    });

                    var tbody = table.find("tbody");
                    var data = scope[attrs.model];
                    data.forEach(function (row) {
                        var tr = $("<tr/>");
                        tbody.append(tr);

                        columns.forEach(function (column) {
                            var td = $("<td />");
                            td.appendTo(tr);

                            var itemScope = scope.$new();
                            itemScope[attrs.modelItem] = row;
                            column.contentFn(itemScope, function (clone) {
                                td.append(clone);
                            });
                        });
                    });
                }
            },
        };

        return ddo;
    });

})();
