//Showing player's high scores on main page
function ShowScores() {
    //Variables for current high scores
    let scoreAim = 0;
    let scoreMemory = 0;

    //Getting best scores from local storage
    if (localStorage.getItem('bestScoreAim') != null)
        scoreAim = JSON.parse(localStorage.getItem('bestScoreAim'));
    if (localStorage.getItem('bestScoreMemory') != null)
        scoreMemory = JSON.parse(localStorage.getItem('bestScoreMemory'));

    //Displaying high scores on main page
    document.getElementById("score-aim").innerHTML = "";
    document.getElementById("score-aim").innerHTML = scoreAim + "/20";

    document.getElementById("score-memory").innerHTML = "";
    document.getElementById("score-memory").innerHTML = "Stage: " + scoreMemory;
}
