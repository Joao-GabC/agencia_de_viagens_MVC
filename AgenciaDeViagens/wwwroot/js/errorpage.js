const countdown = document.getElementById("countdown");
var countdownNum = 10;

document.addEventListener("DOMContentLoaded", () => {
    setTimeout(() => {
        window.location.replace("/Home/Index");
    }, 10000);
    for (i = 10; i < 10; i++) {
        setTimeout(() => {
            countdown.innerHTML = countdownNum;
        }, 1000);
    }
})