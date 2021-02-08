//Time before game starts
let preperationTime = 2000;

//Id of timeout
let timeoutId = 0;
//Id of interval
let intervalId = 0;

//Player's points
let points = 0;

//Number of targets that have already shown up
let attempts = 0;

//First function called from start button
function PreparationPhase() {
    document.getElementById("start-button").hidden = true;

    //Start training after preperation time passes
    timeoutId = setTimeout(StartTest, preperationTime);
}

//Creating target and starting the game
function StartTest() {
    //Deleting button from html file and replacing it with the target
    document.getElementById("game-screen").innerHTML = "";
    document.getElementById("game-screen").innerHTML +=
        '<img id="target" src="../images/target.png" onclick="TargetHit();" />';
    document.getElementById("target").hidden = true;

    //New target will show up every second
    intervalId = setInterval(SetNewPosition, 1000);
}

//Function checking game status and choosing new position for target
function SetNewPosition() {
    //After 20 attempts save new best score in local storage and end the game
    if (attempts >= 20) {
        document.getElementById("target").hidden = true;
        clearTimeout(intervalId);
        if (localStorage.getItem('bestScoreAim') == null) {
            localStorage.setItem('bestScoreAim', points);
        }
        else if (points > localStorage.getItem('bestScoreAim')){
            localStorage.removeItem('bestScoreAim');
            localStorage.setItem('bestScoreAim', points);
        }
        localStorage.getItem('bestScoreAim');
        return;
    }
    else
        //Incrementing number of targets
        attempts++;

    //Randomizing new coordinates
    let posX = Math.floor(Math.random() * 94) + 3;
    let posY = Math.floor(Math.random() * 92) + 3;

    //Setting new position of the target by changing it's style property
    document.getElementById("target").style.setProperty("left", posX + "%");
    document.getElementById("target").style.setProperty("top", posY + "%");

    //Showing the target at new position
    document.getElementById("target").hidden = false;
}

//Function called when the player hits a target
function TargetHit() {
    //Hiding hit target
    document.getElementById("target").hidden = true;

    //Incrementing points
    points++;

    //Displaying new score
    document.getElementById("score").innerHTML = "";
    document.getElementById("score").innerHTML = "Your score: " + points + "/20";
}