(function ($) {
    'use strict';
    $.ajax({
        url: '/Menu/GetMenu',
        data: { userId: 1 },
        type: 'GET',
        dataType: 'json',
        success: function (result) {
            console.log(result);
            var ul = $('#exampleAccordion');
            result.forEach(function (menu) {
                var li = $('<li/>', {
                    'class': 'nav-item',
                    'data-toggle': 'tooltip',
                    'data-placement': 'right',
                    'title': menu.Name,
                    html: function () {
                        $(this).append($('<a/>', {
                            'class': 'nav-link',
                            'href': menu.Url,
                            html: function () {
                                $(this).append($('<i/>', {
                                    'class': menu.Icon
                                }));
                                $(this).append($('<span/>', {
                                    'class': 'nav-link-text',
                                    html: menu.Name
                                }));
                            }
                        }));
                        if (menu.MenuChild.length > 0) {

                        }
                    }
                });
                ul.append(li);
            });

        }
    });

})(jQuery);