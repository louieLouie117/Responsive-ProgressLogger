
// show the text and button options
function showNewLog(e) {
    document.getElementById("newLogBTN").style.height = "100vw";
    document.getElementById("newLogBTN").style.position = "relative";
    document.getElementById("newLogBTN").style.padding = "40px";
    document.getElementById("hide-wapper").style.display = "none";
    document.getElementById("saveBTN").style.display = "block";
    document.getElementById("cancleLog").style.display ="block";
    
};


function hideNewLog(e){
    document.getElementById("newLogBTN").style.height = "auto";
    document.getElementById("saveBTN").style.display = "none";
    document.getElementById("newLogBTN").style.position = "fixed";
    document.getElementById("cancleLog").style.display ="none";
    document.getElementById("hide-wapper").style.display = "grid";
    document.getElementById("newLogBTN").style.padding = "0";
    document.getElementById("newLogBTN").style.paddingLeft = "20px";
    document.getElementById("newLogBTN").innerHTML = "";



}


function showDeleteSection(e){
    document.getElementById("deleteSection").style.display = "grid";

}

function hideDeleteSection(e){
    document.getElementById("deleteSection").style.display = "none";

}