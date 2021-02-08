//Current stage
let stage = 1;

//How many buttons are left to light up in this stage
let buttonsToLight = 0;

//Time before game starts
let preperationTime = 2000;

//Id of interva;
let intervalId = 0;

//Arrays with indexes of lighted buttons
let buttonsInOrder = [];

//Boolean checking if it is player's turn
let playersTurn = false;

//First function called from start button
function PreparationPhase() {
    //Hiding start button
    document.getElementById("start-button").hidden = true;

    //Providing buttons with EventListeners
    AddListeners();
    //Starting first stage after one second
    setTimeout(NewStage, 1000);
}

//Function initializing new stage
function NewStage() {
    //Updating score display
    document.getElementById("score").innerHTML = "";
    document.getElementById("score").innerHTML = "Stage: " + stage;

    //Saving how many buttons to light up
    buttonsToLight = stage;

    //Lighting up buttons one at a time
    intervalId = setInterval(LightButtonUp, 1300);
}

//Adding EventListeners to buttons to check for player's pressing
function AddListeners() {
    for (let i = 1; i < 10; i++) {
        document.getElementById("button" + i).addEventListener("click", function () { Check(i) });
    }
}

//Clearing EventListeners from buttons
function ClearListeners() {
    for (let i = 1; i < 10; i++) {
        document.getElementById("button" + i).removeEventListener("click", Check);
    }
}

//Function called from button's EventListener initiated by player's press, index - pressed button index
function Check(index) {
    //Functional only in player's turn
    if (playersTurn == false)
        return;

    //If player pressed the right button, it's index will be removed from array
    if (index == buttonsInOrder[0]) {
        buttonsInOrder.shift();
        //Lighting up buttons to indicate clicking
        document.getElementById("button" + index).src = "../images/green.png";
        setTimeout(TurnButtonOff, 100, index);

        //If all buttons in current stage are pressed in the right order, player's turn ends and a new stage begins
        if (buttonsInOrder.length == 0) {
            playersTurn = false;
            PrepareNextStage();
        }
    }
    //End the game if the player has made a mistake
    else {
        //Showing score in alert
        alert("You managed to get to stage " + stage + ".");

        //If it's a new high score, store it in local storage
        if (localStorage.getItem('bestScoreMemory') == null) {
            localStorage.setItem('bestScoreMemory', stage);
        }
        else if (stage > localStorage.getItem('bestScoreMemory')) {
            localStorage.removeItem('bestScoreMemory');
            localStorage.setItem('bestScoreMemory', stage);
        }
        playersTurn = false;
    }
}

//Preparing next stage
function PrepareNextStage() {
    //Incrementing stage number
    stage++;
    setTimeout(NewStage, 1000);
}

//Changing button's color to show action (adding to array or being clicked by player)
function LightButtonUp() {
    //Decrementing amount of buttons to light up
    buttonsToLight--;

    //Randomizing index
    let lightedId = Math.floor(Math.random() * 9) + 1;

    //Adding randomized index to array
    buttonsInOrder.push(lightedId);

    //Changing button's color
    document.getElementById("button" + lightedId).src = "../images/green.png";

    //And reversing it after 0.3s
    setTimeout(TurnButtonOff, 300, lightedId);

    //After adequate amount of buttons has been lighted up, player's turn begins
    if (buttonsToLight <= 0) {
        clearInterval(intervalId);
        playersTurn = true;
    }
}

//Turning lighted buttons off by changing it's color
function TurnButtonOff(index) {
    document.getElementById("button" + index).src = "../images/red.png";
}