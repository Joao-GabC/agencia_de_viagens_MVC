var countdownNum = 10;

document.addEventListener("DOMContentLoaded", () => {
    const countdown = document.getElementById("countdown");

    const interval = setInterval(() => {
        countdown.innerHTML = countdownNum;
        countdownNum--;

        if (countdownNum < 0) {
            clearInterval(interval);
            window.location.replace("/Home/Index");
        }
    }, 1000);
});