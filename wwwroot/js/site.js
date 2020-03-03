$(document).ready(function () {
    Date.prototype.daysInMonth = function () {
        return 33 - new Date(this.getFullYear(), this.getMonth(), 33).getDate();
    };
    days = new Date().daysInMonth();
    var d = new Date(),

        n = (d.getMonth() + 1),

        y = d.getFullYear();
    if (n < 10) { n = '0' + n } else { n = n }
    $('.first-form-title span').empty();
    $('.first-form-title span').append(days + '.' + n + '.' + y)
});
setTimeout(function () {
    $(".ks").fadeOut(200);;
}, 800);
setTimeout(function () {
    $(".vd").fadeIn(200);;
}, 1000);
setTimeout(function () {
    $(".vd").fadeOut(200);;
}, 2800);
setTimeout(function () {
    $(".lc").fadeIn(200);;
}, 3000);
setTimeout(function () {
    $(".lc").fadeOut(200);;
}, 4800);
setTimeout(function () {
    $(".ks").fadeIn(200);;
}, 5000);
setInterval(function () {
    setTimeout(function () {
        $(".ks").fadeOut(200);;
    }, 1800);
    setTimeout(function () {
        $(".vd").fadeIn(200);;
    }, 2000);
    setTimeout(function () {
        $(".vd").fadeOut(200);;
    }, 3800);
    setTimeout(function () {
        $(".lc").fadeIn(200);;
    }, 4000);
    setTimeout(function () {
        $(".lc").fadeOut(200);;
    }, 5800);
    setTimeout(function () {
        $(".ks").fadeIn(200);;
    }, 6000);
}, 6000);


/**
 * @function      Include
 * @description   Includes an external scripts to the page
 * @param         {string} scriptUrl
 */
function include(scriptUrl) {
    document.write('<script src="' + scriptUrl + '"></script>');
}

/**
 * @function      isIE
 * @description   checks if browser is an IE
 * @returns       {number} IE Version
 */
function isIE() {
    var myNav = navigator.userAgent.toLowerCase();
    return (myNav.indexOf('msie') != -1) ? parseInt(myNav.split('msie')[1]) : false;
};

/**
 * @module       Copyright
 * @description  Evaluates the copyright year
 */
;
(function ($) {
    $(document).ready(function () {
        $("#copyright-year").text((new Date).getFullYear());
    });
})(jQuery);

/**
 * @module       IE Fall&Polyfill
 * @description  Adds some loosing functionality to old IE browsers
 */
;
(function ($) {
    if (isIE() && isIE() < 11) {
        $('html').addClass('lt-ie11');
        $(document).ready(function () {
            PointerEventsPolyfill.initialize({});
        });
    }

    if (isIE() && isIE() < 10) {
        $('html').addClass('lt-ie10');
    }
})(jQuery);


/**
 * @module       WOW Animation
 * @description  Enables scroll animation on the page
 */
;
(function ($) {
    var o = $('html');
    if (o.hasClass('desktop') && o.hasClass("wow-animation") && $(".wow").length) {
        $(document).ready(function () {
            new WOW().init();
        });
    }
})(jQuery);


/**
 * @module       ToTop
 * @description  Enables ToTop Plugin
 */
;
(function ($) {
    var o = $('html');
    if (o.hasClass('desktop')) {

        $(document).ready(function () {
            $().UItoTop({
                easingType: 'easeOutQuart',
                containerClass: 'ui-to-top'
            });
        });
    }
})(jQuery);

/**
 * @module       RD Mailform
 * @description  Enables RD Mailform Plugin
 */
;
(function ($) {
    var o = $('.rd-mailform');
    if (o.length > 0) {
        $(document).ready(function () {
            var o = $('.rd-mailform');

            if (o.length) {
                o.rdMailForm({
                    validator: {
                        'constraints': {
                            '@LettersOnly': {
                                message: 'Please use letters only!'
                            },
                            '@NumbersOnly': {
                                message: 'Please use numbers only!'
                            },
                            '@NotEmpty': {
                                message: 'Field should not be empty!'
                            },
                            '@Email': {
                                message: 'Enter valid e-mail address!'
                            },
                            '@Phone': {
                                message: 'Enter valid phone number!'
                            },
                            '@Date': {
                                message: 'Use MM/DD/YYYY format!'
                            },
                            '@SelectRequired': {
                                message: 'Please choose an option!'
                            }
                        }
                    }
                }, {
                    'MF000': 'Sent',
                    'MF001': 'Recipients are not set!',
                    'MF002': 'Form will not work locally!',
                    'MF003': 'Please, define email field in your form!',
                    'MF004': 'Please, define type of your form!',
                    'MF254': 'Something went wrong with PHPMailer!',
                    'MF255': 'There was an error submitting the form!'
                });
            }
        });
    }
})(jQuery);

/**
 * @module       RD Navbar
 * @description  Enables RD Navbar Plugin
 */
;
(function ($) {
    var o = $('.rd-navbar');
    if (o.length > 0) {
        $(document).ready(function () {
            o.RDNavbar({
                stuckWidth: 768,
                stuckMorph: true,
                stuckLayout: "rd-navbar-static",
                responsive: {
                    0: {
                        layout: 'rd-navbar-fixed',
                        focusOnHover: false
                    },
                    768: {
                        layout: 'rd-navbar-fullwidth'
                    },
                    1200: {
                        layout: o.attr("data-rd-navbar-lg").split(" ")[0],
                    }
                },
                onepage: {
                    enable: false,
                    offset: 0,
                    speed: 400
                }
            });
        });
    }
})(jQuery);


/**
 * @module       Magnific Popup
 * @description  Enables Magnific Popup Plugin
 */
;
(function ($) {

    var o = $('[data-lightbox]').not('[data-lightbox="gallery"] [data-lightbox]').not('.owl-carousel'),
        g = $('[data-lightbox^="gallery"]').not('.owl-carousel');

    if (o.length > 0 || g.length > 0) {

        $(document).ready(function () {
            if (o.length) {
                o.each(function () {
                    var $this = $(this);
                    $this.magnificPopup({
                        type: $this.attr("data-lightbox")
                    });
                })
            }

            if (g.length) {
                g.each(function () {
                    var $gallery = $(this);
                    $gallery
                        .find('[data-lightbox]').each(function () {
                            var $item = $(this);
                            $item.addClass("mfp-" + $item.attr("data-lightbox"));
                        })
                        .end()
                        .magnificPopup({
                            delegate: '[data-lightbox]',
                            type: "image",
                            gallery: {
                                enabled: true
                            }
                        });
                })
            }
        });
    }

})(jQuery);

$(document).ready(function () {

    $('.popup-with-zoom-anim').magnificPopup({
        type: 'inline',

        fixedContentPos: false,
        fixedBgPos: true,

        overflowY: 'auto',

        closeBtnInside: true,
        preloader: false,

        midClick: true,
        removalDelay: 300,
        mainClass: 'my-mfp-zoom-in'
    });

    $("input[name='phone']").mask("+38(999) 999-99-99");



    $("#contactForm input, #first-form input").jqBootstrapValidation({
        preventSubmit: true,
        submitError: function ($form, event, errors) {
            // additional error messages or events
        },
        submitSuccess: function ($form, event) {
            event.preventDefault(); // prevent default submit behaviour
            // get values from FORM

            var name = $("input#name", $form).val();
            var email = $("input#email", $form).val();
            var phone = $("input#phone", $form).val();
            var time = $("input#time", $form).val();
            var message = $("input#message", $form).val();

            var model = $("input#model", $form).val();
            var date = $("input#date", $form).val();
            var power = $("input#power", $form).val();
            var status = $("input#status", $form).val();



            form = new FormData();

            if (typeof name !== "undefined") {
                form.append("name", name);
            }

            if (typeof email !== "undefined") {
                form.append("email", email);
            }

            if (typeof phone !== "undefined") {
                form.append("phone", phone);
            }

            if (typeof time !== "undefined") {
                form.append("time", time);
            }

            if (typeof message !== "undefined") {
                form.append("message", message);
            }

            if (typeof model !== "undefined" || typeof date !== "undefined" || typeof power !== "undefined" || typeof status !== "undefined") {
                var message2 = 'Марка и модель трактора: ' + model + '<br> Дата изготовления трактора:' + date + '<br> Мощность: ' + power + '<br> Состояние: ' + status + '<br>';
                form.append("message2", message2);
            }

            if (typeof $("input#file", $form).get(0) !== 'undefined') {
                form.append("file", $("input#file", $form).get(0).files[0]);
            }


            var firstName = name; // For Success/Failure Message
            // Check for white space in name for Success/Fail message
            if (firstName !== undefined && firstName.indexOf(' ') >= 0) {
                firstName = name.split(' ').slice(0, -1).join(' ');
            }
            $.ajax({
                url: "/contact_me.php",
                type: "POST",
                processData: false,
                contentType: false,
                data: form,
                cache: false,
                success: function () {
                    if (email != "") {
                        $($form).html("<div class='resp-succ'>" + window.message_thanks + "</div>");
                    } else {
                        $($form).html("<div class='resp-succ'>" + window.message_thanks + "</div>");
                    }

                },
                error: function () {
                    $($form).html("<div class='resp-succ'>Форма не работает. <br> Позвоните пожалуйста.</div>");
                },

            });
        },
        filter: function () {
            return $(this).is(":visible");
        },
    });

    /**
     * This javascript file checks for the brower/browser tab action.
     * It is based on the file menstioned by Daniel Melo.
     * Reference: http://stackoverflow.com/questions/1921941/close-kill-the-session-when-the-browser-or-tab-is-closed
     */


    var checkCloseX = 0;
    $(document).mousemove(function (e) {
        if (e.pageY <= 5 || event.clientY <= 5) {
            if (checkCloseX == 0) {
                $("#rdcp").click()
            }
            checkCloseX = 1;
        }
    });

    $('.dot').hover(function () {
        if (window.innerWidth > 768) {
            $(this).toggleClass('z-index-10');
            $('.why-item-box-' + event.target.attributes[1].value + ' img').attr('src', $('.why-item-box-' + event.target.attributes[1].value + ' img').attr('data-src'));
            $('.why-item-box-' + event.target.attributes[1].value).toggleClass('hide');
        }
    })

    $('.dot').click(function () {
        if (window.innerWidth <= 768) {
            $('.why-item-box-' + event.target.attributes[1].value + ' img').attr('src', $('.why-item-box-' + event.target.attributes[1].value + ' img').attr('data-src'));
            $('.why-item-box-' + event.target.attributes[1].value).toggleClass('hide');

        }
    })

    $('.item-box-btn-close').click(function () {
        if (window.innerWidth <= 768) {
            $(this).parents('.why-item-box').addClass('hide');
        }
    })

});

$('.bt-first-form-redesign').on('click', function () {
    ga('send', 'event', 'button', 'send_offer'); fbq('track', 'Lead');
});

$('.green-line_button').on('click', function () {
    ga('send', 'event', 'button', 'call_me'); fbq('track', 'Lead');
});

$('.bt-popup').on('click', function () {
    ga('send', 'event', 'click', 'button'); fbq('track', 'Lead');
});

;
(function($) {
    $.Lazy('google-map', function(element, response) {
        console.log(document.getElementById('google-map'));
        map = new google.maps.Map(document.getElementById('google-map'), {
            center: { lat: 48.409050, lng: 34.998631 },
            zoom: 17
        });

        var marker = new google.maps.Marker({
            position: { lat: 48.409050, lng: 34.998631 },
            map: map,
        });

        response(true);
    });
})(jQuery);

;
$(function() {
    $('.lazy').Lazy();
    $('#google-map').Lazy();
    $("iframe[data-src]").Lazy();
});

        /* Кнопки КУПИТЬ и ЦЕНА В КРЕДИТ */

        function getQueryVariable(variable) {
            var query = window.location.search.substring(1);
            var vars = query.split('&');
            for (var i = 0; i < vars.length; i++) {
                var pair = vars[i].split('=');
                if (pair[0] == variable) {
                    return pair[1];
                }
            }
            return false;
        }

        function createCookie(name, value, days) {
            var expires = '';
            if (days) {
                var date = new Date();
                date.setTime(date.getTime() + days * 24 * 60 * 60 * 1000);
                var expires = '; expires=' + date.toUTCString();
            }
            document.cookie = name + '=' + value + expires + '; path=/';
        }

        function eraseCookie(name) {
            createCookie(name, '', -1);
        }

        var c_name = '__utmz';
        var days = 60
        if (getQueryVariable('utm_source') != '') {
            let utm_source = getQueryVariable('utm_source') || '';
            createCookie('__utm_source', utm_source, days);

            let utm_medium = getQueryVariable('utm_medium') || '';
            createCookie('__utm_medium', utm_medium, days);

            let utm_term = getQueryVariable('utm_term') || '';
            createCookie('__utm_term', utm_term, days);

            let utm_campaign = getQueryVariable('utm_campaign') || '';
            createCookie('__utm_campaign', utm_campaign, days);

            let utm_content = getQueryVariable('utm_content') || '';
            createCookie('__utm_content', utm_content, days);
        }

        let yclid = getQueryVariable('yclid') || '';
        createCookie('__yclid', yclid, days);

        let gclid = getQueryVariable('gclid') || '';
        createCookie('__gclid', gclid, days);

        createCookie("__utm_url", window.location.href.split("?")[0], days);

        if (document.referrer.indexOf(location.protocol + '//' + location.host) === 0) {
            createCookie('__utm_referrer', document.referrer, days);
        }

        function getCookieObject() {
            let t = {};
            document.cookie.split(';').filter(r => {
                r = r.trim().split('=');
                t[r[0]] = r[1];
            });
            return t;
        }
        $(document).ready(function() {
            let cookie = getCookieObject();
            $('#form-order').submit(function() {
                let form = $(this);
                let data = {
                    "contact": {
                        "name": form.find('[name="name"]').val(),
                        "phone": {
                            "action": "add",
                            "value": form.find('[name="phone"]').val()
                        },
                        "email": {
                            "action": "add",
                            "value": form.find('[name="email"]').val()
                        },
                        "responsible": {
                            "type": "linear",
                            "value": "Отдел продаж"
                        }
                    },
                    "lead": {
                        "name": "Заявка с сайта tdtz.in.ua",
                        "responsible": {
                            "type": "entity",
                            "entity": "contact",
                            "action": "update"
                        },
                        "fields": {
                            "Форма": form.find('[name="abcid"]').val(),
                            "utm_source": cookie.__utm_source,
                            "utm_medium": cookie.__utm_medium,
                            "utm_campaign": cookie.__utm_campaign,
                            "utm_content": cookie.__utm_content,
                            "utm_term": cookie.__utm_term,
                            "Gclid": cookie.__gclid,
                            "Yclid": cookie.__yclid,
                            "GAclientID": cookie._ga,
                            "Страница обращения": cookie.__utm_url,
                            "Коментар": ""
                        },
                        "status_id": "10735228"
                    },
                };
                $.post(
                    'https://blackbox.bpmcenter.pro/api/33278e359d2ccdf04f7cfc90c589b61c/hook',
                    data,
                    (res) => {
                        console.log(res);
                    }
                );
            });
        })

var slideIndex = 0;
function showSlides(n) {
    if(slideIndex === n) { 
        return
    }

    slideIndex = n;

    var i;
    var slides = $("#tractors").find("#carousel-example-generic .item");
    var dots = document.getElementsByClassName("carousel-indicator-dot");

    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex].style.display = "block";
    dots[slideIndex].className += " active";
}