// Sign in handler----------------------------------
let logInEvent = "close"
const showSignIn= (e)=>{
    if(logInEvent === "close"){
        document.getElementById("signInContainer").style.marginTop = "0px"
        document.getElementById("signInContainer").style.transform = "smooth"
        document.getElementById("signInContainer").style.transition = ".5s"

    return (logInEvent = "open");

    }else{
        document.getElementById("signInContainer").style.marginTop = "-2300px"
        document.getElementById("signInContainer").style.transform = "smooth"
        document.getElementById("signInContainer").style.transition = ".5s"
        return (logInEvent = "close");

    }
}

// Banner handler------------------------------------

let HeaderBannerStatus ="close"
const HeaderBannerHandler =(e)=>{

    logInEvent = "open"
    showSignIn();
    logInEvent = "close"

    if(e.target.innerText === "Website Services"){
        document.getElementById("BannerTitle").innerText ="Website Services";
        document.getElementById("BannerOverview").innerText = "Design, Develope, and Maintained";   
        document.getElementById("BannerSummery").innerText ="Get a website or webapp designed, developed, and maintained by people that love helping others learn.";
        document.getElementById("BannerLinkTag").innerText ="See our services";
        console.log("Website Services")
        
    }

    if(e.target.innerText === "Apprentice"){
        document.getElementById("BannerTitle").innerText ="Apprentice";
        document.getElementById("BannerOverview").innerText = "Connect with mentors and learn to develop website and webapps. ";
        document.getElementById("BannerSummery").innerText ="With a higher increases in web development. We are dedicated to connect you with mentors and give you the tools you need to start your programing journey.";
        document.getElementById("BannerLinkTag").innerText ="Become an Apprentice";

        console.log("Apprentice")
    }
    
    if(e.target.innerText === "Mentor"){
       document.getElementById("BannerTitle").innerText ="Mentor";
       document.getElementById("BannerOverview").innerText = "Help business get online and mentor others.";
       document.getElementById("BannerSummery").innerText ="Do you have web development skills and want to helping business get online and at the same time be a mentor for someone. Than get started become a Mentor today.";
       document.getElementById("BannerLinkTag").innerText ="Become a Mentor";


        console.log("Mentor")

    }

    if(HeaderBannerStatus === "close"){
        document.getElementById("mainOptions").style.display = "none"
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
        document.getElementById("mainOptions").style.display = "grid"
        document.getElementById("backHomeBTN").style.top = "-800px";
        document.getElementById("backHomeBTN").style.transform = "smooth";
        document.getElementById("backHomeBTN").style.transition = "1s";

        document.getElementById("HeaderBanner").style.top = "-800px";
        document.getElementById("HeaderBanner").style.transform = "smooth";
        document.getElementById("HeaderBanner").style.transition = "1s";
    
        document.getElementById("blurImage").style.filter = 'blur(0px)';
        document.getElementById("blurImage").style.transform = "smooth";
        document.getElementById("blurImage").style.transition = ".5s";
    return (HeaderBannerStatus = "close");

    }


}
console.log(HeaderBannerStatus)
