var CartController = function () {
    this.initialize = function () {
        loadData();
    }

    function loadData() {
        $.ajax({
            type: "GET",
            url: '/Cart/GetListItems',
            success: function (res) {
                var html = '';
                var total = 0;

                $.each(res, function (i, item) {
                    var amount = item.price * item.quantity;
                    html += "<div class=\"cart__list\">"
                          + "<div class=\"cart__img\">"
                          + "<img src=\"" + $('#hidBaseAddress').val() + item.image +"\" alt=\"\">"
                          + "</div>"
                          + "<div class=\"cart__info\">"
                          + "<div class=\"item__info\">"
                          + "<p class=\"item__info-name\">"+ item.name +"</p>"
                          + "<p class=\"item__info-option\">"+ item.color + "/"+item.memory+"/"+item.ram+"</p>"
                          + "</div>"
                          + "<div class=\"item__quan\">"
                          + "<input type=\"text\" value=\"1\">"
                          + "</div>"
                          + "<p class=\"item__delete\">Xoá</p>"
                        + "<div class=\"item__price\">" + numberWithCommas(item.price) + " </div>"
                        + "<div class=\"item__price\">" + numberWithCommas(amount) + "</div>"
                          + "</div>"
                        + "</div>"
                    total += amount;
                });
                $('.cart__listItem').html(html);
                $('#lbl_number_of_items').text(res.length);
                $('#lbl_total').text(numberWithCommas(total));
            }
        });
    }
}