let HeaderBannerStatus ="close"

const HeaderBannerHandler =(e)=>{

    if(e.target.innerText === "Website Services"){
        console.log("Website Services")
    }

    if(e.target.innerText === "Apprentice"){
        console.log("Apprentice")
    }
    
    if(e.target.innerText === "Mentor"){
        console.log("Mentor")

    }

    if(HeaderBannerStatus === "close"){
    document.getElementById("backHomeBTN").style.top = "0";
    document.getElementById("backHomeBTN").style.transform = "smooth";
    document.getElementById("backHomeBTN").style.transition = "1s";
    
    document.getElementById("HeaderBanner").style.top = "0";
    document.getElementById("HeaderBanner").style.transform = "smooth";
    document.getElementById("HeaderBanner").style.transition = "1s";

    document.getElementById("blurImage").style.filter = 'blur(7px)';
    document.getElementById("blurImage").style.transform = "smooth";
    document.getElementById("blurImage").style.transition = ".5s";

    return (HeaderBannerStatus = "open");

    }
    else{
        document.getElementById("backHomeBTN").style.top = "-700px";
        document.getElementById("backHomeBTN").style.transform = "smooth";
        document.getElementById("backHomeBTN").style.transition = "1s";

        document.getElementById("HeaderBanner").style.top = "-700px";
        document.getElementById("HeaderBanner").style.transform = "smooth";
        document.getElementById("HeaderBanner").style.transition = "1s";
    
        document.getElementById("blurImage").style.filter = 'blur(0px)';
        document.getElementById("blurImage").style.transform = "smooth";
        document.getElementById("blurImage").style.transition = ".5s";
    return (HeaderBannerStatus = "close");

    }


}
console.log(HeaderBannerStatus)
