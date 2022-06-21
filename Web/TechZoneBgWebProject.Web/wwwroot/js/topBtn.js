window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    var mybutton = document.getElementById("myBtn");
    if (document.body.scrollTop > 500
        || document.documentElement.scrollTop > 500
        || document.body.scrollTop <= 800
        || document.documentElement.scrollTop <= 800) {
        mybutton.style.display = 'block';
        mybutton.style.opacity = 0;

    } if (document.body.scrollTop > 800 || document.documentElement.scrollTop > 800) {  
        mybutton.style.display = 'block';
        mybutton.style.opacity = 0.8;

    } else {
        mybutton.style.display = 'none';
        mybutton.style.opacity = 0;
    }
}

$("#myBtn").click(function () {
    $("html, body").animate({ scrollTop: 0 }, 1200);
    return false;
});