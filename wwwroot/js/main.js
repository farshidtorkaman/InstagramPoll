
function scrolling() {
    if ($('.page-1').hasClass('active')) {

        $('.top-navbar').css('backgroundColor', 'transparent');
        $('.bottom-navbar').css('backgroundColor', 'transparent');
        // $('.top-navbar h5').css('color', 'yellow');
        $('.top-navbar h5').css('transition', 'all 1s');
    }

    if ($('.page-2').hasClass('active')) {
        $('.top-navbar').css('backgroundColor', 'rgba(0,0,0,0.5)');
        $('.bottom-navbar').css('backgroundColor', 'rgba(0,0,0,0.5)');
        $('.top-navbar h5').css('color', 'yellow');
        $('.top-navbar h5').css('transition', 'all 1s');

    }

    // if ($('.page-3').hasClass('active')) {
    //     $('.top-navbar h5').css('color', 'red')
    //     $('.top-navbar h5').css('transition', 'all 1s')
    // }
}

//=======================PAGE 1================
//======================bg video====================
var vid = document.getElementById("bgvid");
var pauseButton = document.querySelector("#polina button");

if (window.matchMedia('(prefers-reduced-motion)').matches) {
    vid.removeAttribute("autoplay");
    vid.pause();
    pauseButton.innerHTML = "Paused";
}

function vidFade() {
    vid.classList.add("stopfade");
}

vid.addEventListener('ended', function()
{
// only functional if "loop" is removed
    vid.pause();
// to capture IE10
    vidFade();
});


pauseButton.addEventListener("click", function() {
    vid.classList.toggle("stopfade");
    if (vid.paused) {
        vid.play();
        pauseButton.innerHTML = "Pause";
    } else {
        vid.pause();
        pauseButton.innerHTML = "Paused";
    }
});

//========================PAGE 2=======================



