/*   
Template Name: Color Admin - Responsive Admin Dashboard Template build with Twitter Bootstrap 3.3.7 & Bootstrap 4.0.0-Alpha 6
Version: 3.0.0
Author: Sean Ngu
Website: http://www.seantheme.com/color-admin-v3.0/admin/material/
*/

var handleSelectAll = function () {
	"use strict";
    $('[data-click=email-select-all]').click(function(e) {
        e.preventDefault();
        if ($(this).closest('tr').hasClass('active')) {
            $('.table-email tr').removeClass('active');
        } else {
            $('.table-email tr').addClass('active');
        }
    });
};

var handleSelectSingle = function () {
	"use strict";
    $('[data-click=email-select-single]').click(function(e) { 
        e.preventDefault();
        var targetRow = $(this).closest('tr');
        if ($(targetRow).hasClass('active')) {
            $(targetRow).removeClass('active');
        } else {
            $(targetRow).addClass('active');
        }
    });
};

var handleEmailRemove = function () {
	"use strict";
    $('[data-click=email-remove]').click(function(e) { 
        e.preventDefault();
        var targetRow = $(this).closest('tr');
        $(targetRow).fadeOut().remove();
    });
};

var handleEmailHighlight = function () {
	"use strict";
    $('[data-click=email-highlight]').click(function(e) { 
        e.preventDefault();
        if ($(this).hasClass('text-danger')) {
            $(this).removeClass('text-danger');
        } else {
            $(this).addClass('text-danger');
        }
    });
};

var Inbox = function () {
	"use strict";
    return {
        //main function
        init: function () {
            handleSelectAll();
            handleSelectSingle();
            handleEmailRemove();
            handleEmailHighlight();
        }
    };
}();