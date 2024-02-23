//Try to Do nav-Bar-Link Activate for lin
document.addEventListener("DOMContentLoaded", function () {
    var links = document.querySelectorAll(".nav-item.nav-link");

    links.forEach(function (link) {
        link.addEventListener("click", function () {
            link.classList.add("active");
            links.forEach(function (otherLink) {
                if (otherLink !== link) {
                    otherLink.classList.remove("active");
                }
            });
        });
    });
    });




