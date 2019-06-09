const uri = "api/dish";
let getDishToOrder = null;
function getAllCount(data) {
    const el = $("#counter");
    let name = "dish-do";
    if (data) {
        if (data > 1) {
            name = "to-dish";
        }
        el.text(data + " " + name);
    } else {
        el.text("No " + name);
    }
}

$(document).ready(function () {
    getToOrderDish();

    document.getElementById("orderedDish").style.display = "none";
});

function getToOrderDish() {
    $.ajax({
        type: "GET",
        url: uri,
        cache: false,
        success: function (data) {
            const tBody = $("#getDishToOrder");

            $(tBody).empty();

            getAllCount(data.length);

            $.each(data, function (key, item) {
                const tr = $("<tr></tr>")
                    .append(
                        $("<td></td>").append(
                            $("<input/>", {
                                type: "checkbox",
                                disabled: true,
                                checked: item.isComplete
                            })
                        )
                    )
                    .append($("<td></td>").text(item.name))
                    .append($("<td></td>").text(item.desc))
                    .append(
                        $("<td></td>").append(
                            $("<button>Sugestion</button>").on("click", function () {
                                editDish(item.id);
                            })
                        )
                    )
                    .append(
                        $("<td></td>").append(
                            $("<button>Take</button>").on("click", function () {
                                orderDishItem(item.id);
                            })
                        )
                    );

                tr.appendTo(tBody);
            });

            getDishToOrder = data;
        }
    });
}

function orderDishItem(id) {
    $.ajax({
        url: uri + "/" + id,
        type: "DELETE",
        success: function (result) {
            getToOrderDish();
        }
    });
}

$(".my-form").on("submit", function () {
    const item = {
        name: $("#edit-name").val(),
        isComplete: $("#edit-isComplete").is(":checked"),
        id: $("#edit-id").val()
    };

    $.ajax({
        url: uri + "/" + $("#edit-id").val(),
        type: "PUT",
        accepts: "application/json",
        contentType: "application/json",
        data: JSON.stringify(item),
        success: function (result) {
            getToOrderDish();
        }
    });

    closeInput();
    return false;
});

function closeInput() {
    $("#spoiler").css({ display: "none" });
}