
// show the text and button options
function showNewLog(e) {
    document.getElementById("newLogBTN").style.height = "80vh";
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



const ShowDeleteLog = (e)=>{
    console.log("js File",e.target.id);

    let itemContainer = e.target.id + "Title";
    let itemToDelete = e.target.id + "Box";

    document.getElementById(itemContainer).style.display = "none";
    document.getElementById(itemToDelete).style.display = "grid";






}



const HideDeleteLog = (e)=>{
    console.log(e.target.id);

    let itemContainer = e.target.id + "Title"
    let itemToDelete = e.target.id + "Box"

    document.getElementById(itemContainer).style.display = "grid";
    document.getElementById(itemToDelete).style.display = "none";
    


}



function showDeleteSection(e){
    let deleteSectionItem = "deleteSection" + e.target.id;
    console.log(deleteSectionItem);
    document.getElementById(deleteSectionItem).style.display = "block";


}

function hideDeleteSection(e){
    let deleteSectionItem = "deleteSection" + e.target.id;
    console.log(deleteSectionItem);
    
    document.getElementById(deleteSectionItem).style.display = "none";

}