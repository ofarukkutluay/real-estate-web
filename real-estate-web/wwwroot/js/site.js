﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/**
 * Template Name: EstateAgency - v4.7.0
 * Template URL: https://bootstrapmade.com/real-estate-agency-bootstrap-template/
 * Author: BootstrapMade.com
 * License: https://bootstrapmade.com/license/
 */
(function () {
    "use strict";

    /**
     * Easy selector helper function
     */
    const select = (el, all = false) => {
        el = el.trim();
        if (all) {
            return [...document.querySelectorAll(el)];
        } else {
            return document.querySelector(el);
        }
    };

    /**
     * Easy event listener function
     */
    const on = (type, el, listener, all = false) => {
        let selectEl = select(el, all);
        if (selectEl) {
            if (all) {
                selectEl.forEach((e) => e.addEventListener(type, listener));
            } else {
                selectEl.addEventListener(type, listener);
            }
        }
    };

    /**
     * Easy on scroll event listener
     */
    const onscroll = (el, listener) => {
        el.addEventListener("scroll", listener);
    };

    /**
     * navbar select active 
     */
    var link = window.location.pathname;
    let navlink;
    //console.log(link);
    if (link.length == 1) {
        navlink = select("#homenavlink");
    }
    else {
        navlink = select("[href^='" + link + "']");
    }
    //console.log(navlink);
    if (navlink) {
        if (link.match("admin")) {
            navlink.classList.remove("collapsed");
        } else {
            navlink.classList.add("active");
        }

    }

    var pageItem = select(".page-item", true);
    var searchLink = window.location.search;
    if (pageItem) {
        if (searchLink.concat("page")) {
            //console.log(pageItem);
            //console.log(searchLink.split('='));
            var pageNumber = parseInt(searchLink.split('=')[1]);
            //console.log(pageNumber);
            if (!isNaN(pageNumber)) {
                pageItem[pageNumber + 1].classList.add("active");
            }

        }
    }


    /**
     * Toggle .navbar-reduce
     */
    let selectHNavbar = select(".navbar-default");
    if (selectHNavbar) {
        onscroll(document, () => {
            if (window.scrollY > 100) {
                selectHNavbar.classList.add("navbar-reduce");
                selectHNavbar.classList.remove("navbar-trans");
            } else {
                selectHNavbar.classList.remove("navbar-reduce");
                selectHNavbar.classList.add("navbar-trans");
            }
        });
    }

    /**
     * Back to top button
     */
    let backtotop = select(".back-to-top");
    if (backtotop) {
        const toggleBacktotop = () => {
            if (window.scrollY > 100) {
                backtotop.classList.add("active");
            } else {
                backtotop.classList.remove("active");
            }
        };
        window.addEventListener("load", toggleBacktotop);
        onscroll(document, toggleBacktotop);
    }

    /**
     * Preloader
     */
    let preloader = select("#preloader");
    if (preloader) {
        window.addEventListener("load", () => {
            preloader.remove();
        });
    }

    /**
     * Search window open/close
     */
    let body = select("body");
    on("click", ".navbar-toggle-box", function (e) {
        e.preventDefault();
        body.classList.add("box-collapse-open");
        body.classList.remove("box-collapse-closed");
    });

    on("click", ".close-box-collapse", function (e) {
        e.preventDefault();
        body.classList.remove("box-collapse-open");
        body.classList.add("box-collapse-closed");
    });

    /**
     * Intro Carousel
     */
    new Swiper(".intro-carousel", {
        speed: 600,
        loop: true,
        autoplay: {
            delay: 5000,
            disableOnInteraction: false,
        },
        slidesPerView: "auto",
        pagination: {
            el: ".swiper-pagination",
            type: "bullets",
            clickable: true,
        },
    });

    /**
     * Property carousel
     */
    new Swiper("#property-carousel", {
        speed: 600,
        loop: true,
        autoplay: {
            delay: 5000,
            disableOnInteraction: false,
        },
        slidesPerView: "auto",
        pagination: {
            el: ".propery-carousel-pagination",
            type: "bullets",
            clickable: true,
        },
        breakpoints: {
            320: {
                slidesPerView: 1,
                spaceBetween: 20,
            },

            1200: {
                slidesPerView: 3,
                spaceBetween: 20,
            },
        },
    });

    /**
     * News carousel
     */
    new Swiper("#news-carousel", {
        speed: 600,
        loop: true,
        autoplay: {
            delay: 5000,
            disableOnInteraction: false,
        },
        slidesPerView: "auto",
        pagination: {
            el: ".news-carousel-pagination",
            type: "bullets",
            clickable: true,
        },
        breakpoints: {
            320: {
                slidesPerView: 1,
                spaceBetween: 20,
            },

            1200: {
                slidesPerView: 3,
                spaceBetween: 20,
            },
        },
    });

    /**
     * Testimonial carousel
     */
    new Swiper("#testimonial-carousel", {
        speed: 600,
        loop: true,
        autoplay: {
            delay: 5000,
            disableOnInteraction: false,
        },
        slidesPerView: "auto",
        pagination: {
            el: ".testimonial-carousel-pagination",
            type: "bullets",
            clickable: true,
        },
    });

    ///**
    // * Property Single carousel
    // */
    //new Swiper("#property-single-carousel", {
    //  speed: 600,
    //  loop: true,
    //  autoplay: {
    //    delay: 5000,
    //    disableOnInteraction: false,
    //  },
    //  pagination: {
    //    el: ".property-single-carousel-pagination",
    //    type: "bullets",
    //    clickable: true,
    //  },
    //});

    /**
     * Sidebar toggle
     */
    if (select(".toggle-sidebar-btn")) {
        on("click", ".toggle-sidebar-btn", function (e) {
            select("body").classList.toggle("toggle-sidebar");
        });
    }
})();
