// Variable for menu
let menu = "close"

const showMainMenu =(e) => {

        console.log(e);
        if (menu === "close") {     
        document.getElementById("mainMenu").style.height = "95vh";
        document.getElementById("mainMenu").style.width = "42vh";
        document.getElementById("mainMenu").style.margin = "0px";
        document.getElementById("mainMenu").style.borderColor = "#136DC0";
        document.getElementById("mainMenu").style.borderRadius = "0";
        document.getElementById("mainMenu").style.transform = "smooth";
        document.getElementById("mainMenu").style.transition = ".5s";
        document.getElementById("mainMenu").style.padding = "30px";
        document.getElementById("mainMenu").style.boxShadow = "3px 0px 15px rgba(0, 0, 0, 0.301)";
        console.log("inside the if stament",menu);
        return (menu = "open");


    }else {      
        document.getElementById("mainMenu").style.height = "40px";
        document.getElementById("mainMenu").style.width = "40px";

        document.getElementById("mainMenu").style.marginTop = "20px";
        document.getElementById("mainMenu").style.marginBottom = "20px";
        document.getElementById("mainMenu").style.marginLeft = "10px";
        document.getElementById("mainMenu").style.marginRight = "10px";

        document.getElementById("mainMenu").style.borderColor = "white";
        document.getElementById("mainMenu").style.borderRadius = "40px";
        document.getElementById("mainMenu").style.transform = "smooth";
        document.getElementById("mainMenu").style.transition = ".5s";
        document.getElementById("mainMenu").style.padding = "10px";
        document.getElementById("mainMenu").style.boxShadow = "none";

        return (menu = "close");

    }

};


const PartialHandler = (e) =>{
    showMainMenu()
    console.log(e.target.innerText)

    if(e.target.innerText === "Profile"){
        document.getElementById("profilePartial").style.display = "grid"
        document.getElementById("dailyLogPartial").style.display = "none"
        document.getElementById("networkPartial").style.display = "none"
        document.getElementById("activityTrackerPartial").style.display = "none"
        document.getElementById("stickyNotesPartial").style.display = "none"
        document.getElementById("bookmarksPartial").style.display = "none"
        document.getElementById("todoListPartial").style.display = "none"
        document.getElementById("jobTrackerPartial").style.display = "none"

    }

    if(e.target.innerText === "Daily Log"){
        document.getElementById("profilePartial").style.display = "none"
        document.getElementById("dailyLogPartial").style.display = "grid"
        document.getElementById("networkPartial").style.display = "none"
        document.getElementById("activityTrackerPartial").style.display = "none"
        document.getElementById("stickyNotesPartial").style.display = "none"
        document.getElementById("bookmarksPartial").style.display = "none"
        document.getElementById("todoListPartial").style.display = "none"

    }

    if(e.target.innerText === "Social Network"){
        document.getElementById("profilePartial").style.display = "none"
        document.getElementById("dailyLogPartial").style.display = "none"
        document.getElementById("networkPartial").style.display = "grid"
        document.getElementById("activityTrackerPartial").style.display = "none"
        document.getElementById("stickyNotesPartial").style.display = "none"
        document.getElementById("bookmarksPartial").style.display = "none"
        document.getElementById("todoListPartial").style.display = "none"
        document.getElementById("jobTrackerPartial").style.display = "none"
    }

    if(e.target.innerText === "Activity Tracker"){
        document.getElementById("profilePartial").style.display = "none"
        document.getElementById("dailyLogPartial").style.display = "none"
        document.getElementById("networkPartial").style.display = "none"
        document.getElementById("activityTrackerPartial").style.display = "grid"
        document.getElementById("stickyNotesPartial").style.display = "none"
        document.getElementById("bookmarksPartial").style.display = "none"
        document.getElementById("todoListPartial").style.display = "none"
        document.getElementById("jobTrackerPartial").style.display = "none"
    }

    if(e.target.innerText === "Stickynotes"){
        document.getElementById("profilePartial").style.display = "none"
        document.getElementById("dailyLogPartial").style.display = "none"
        document.getElementById("networkPartial").style.display = "none"
        document.getElementById("activityTrackerPartial").style.display = "none"
        document.getElementById("stickyNotesPartial").style.display = "grid"
        document.getElementById("bookmarksPartial").style.display = "none"
        document.getElementById("todoListPartial").style.display = "none"
        document.getElementById("jobTrackerPartial").style.display = "none"
    }

    if(e.target.innerText === "Bookmarks"){
        document.getElementById("profilePartial").style.display = "none"
        document.getElementById("dailyLogPartial").style.display = "none"
        document.getElementById("networkPartial").style.display = "none"
        document.getElementById("activityTrackerPartial").style.display = "none"
        document.getElementById("stickyNotesPartial").style.display = "none"
        document.getElementById("bookmarksPartial").style.display = "grid"
        document.getElementById("todoListPartial").style.display = "none"
        document.getElementById("jobTrackerPartial").style.display = "none"
    }

    if(e.target.innerText === "Todo-list"){
        document.getElementById("profilePartial").style.display = "none"
        document.getElementById("dailyLogPartial").style.display = "none"
        document.getElementById("networkPartial").style.display = "none"
        document.getElementById("activityTrackerPartial").style.display = "none"
        document.getElementById("stickyNotesPartial").style.display = "none"
        document.getElementById("bookmarksPartial").style.display = "none"
        document.getElementById("todoListPartial").style.display = "grid"
        document.getElementById("jobTrackerPartial").style.display = "none"
    }

    if(e.target.innerText === "Job Tracker"){
        document.getElementById("profilePartial").style.display = "none"
        document.getElementById("dailyLogPartial").style.display = "none"
        document.getElementById("networkPartial").style.display = "none"
        document.getElementById("activityTrackerPartial").style.display = "none"
        document.getElementById("stickyNotesPartial").style.display = "none"
        document.getElementById("bookmarksPartial").style.display = "none"
        document.getElementById("todoListPartial").style.display = "none"
        document.getElementById("jobTrackerPartial").style.display = "grid"
    }


}

