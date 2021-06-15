// Sign in handler----------------------------------
let logInEvent = "close"
const showSignIn= (e)=>{
    if(logInEvent === "close"){
        document.getElementById("signInContainer").style.marginTop = "0px"
        document.getElementById("signInContainer").style.transform = "smooth"
        document.getElementById("signInContainer").style.transition = ".5s"
        // e.target.innerText = "close";


    return (logInEvent = "open");

    }else{
        document.getElementById("signInContainer").style.marginTop = "-2300px"
        document.getElementById("signInContainer").style.transform = "smooth"
        document.getElementById("signInContainer").style.transition = ".5s"
        // e.target.innerText = "sign in";

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
        document.getElementById("BannerLinkTag").innerText ="view our services";
        document.getElementById("websiteServicesPartial").style.display = "grid";
        console.log("Website Services")
        document.querySelector("#BannerLinkTag").style.textDecoration = "underline";
        
    }

    if(e.target.innerText === "Apprentice"){
        document.getElementById("BannerTitle").innerText ="Apprentice";
        document.getElementById("BannerOverview").innerText = "Connect with mentors and learn to develop websites and web apps. ";
        document.getElementById("BannerSummery").innerText ="With a higher increases in web development. We are dedicated to connect you with mentors and give you the tools you need to start your programing journey.";
        document.getElementById("BannerLinkTag").innerText ="Become an Apprentice";
        document.getElementById("regApprentice").style.display = "grid";
        document.getElementById("regApprenticeStep1").style.display = "grid";

        document.getElementById("regApprenticeFooter").style.display = "grid";


        document.getElementById("apprenticePagePartial").style.display = "grid";
        document.getElementById("getStarted").style.display = "grid";
        document.getElementById("newMentorList").style.display = "none";
        document.getElementById("newApprenticeList").style.display = "flex";
        
        document.getElementById("getStartedJustAdded").innerText = "People that just became an apprentice.";
        document.getElementById("getStartedTitle").innerText = "Get Started";
        document.getElementById("getStartedInfo").innerText = "Are you looking to learn how to code websites and web apps and don't know where to start or have not progressed as much as you wanted? Well, we are here to help you connect with mentors that have been where you are and can guide you motivate you to become a website and web app developer.";
        document.getElementById("connectWithBTN").innerText = "Start connecting with mentors";
        document.getElementById("getToolsInfo").innerText = "When you become an apprentice not only will you start connecting with mentors, but you also will have access to your dashboard and tools to help you on your new journey.  ";
        document.getElementById("becomeUserTitle").innerText = "Become an apprentice. Get paid to learn.";
        document.getElementById("becomeUserInfo").innerText = "If you are interested in developing websites or web apps, why not get paid while learning as an apprentice? When you find a business that needs a website or web app, you can connect with a mentor and share the bacon. Once you are ready, you can become a mentor for others.";

    }
    
    if(e.target.innerText === "Mentor"){
       document.getElementById("BannerTitle").innerText ="Mentor";
       document.getElementById("BannerOverview").innerText = "Help business get online and mentor others.";
       document.getElementById("BannerSummery").innerText ="Do you have the skills to code websites or web apps? Do you want to help businesses get online and at the same time be a mentor for someone? Then get started become a mentor today.";
       document.getElementById("BannerLinkTag").innerText ="Become a Mentor";
       document.getElementById("regMentor").style.display = "grid";    
       document.getElementById("regMentorStep1").style.display = "grid";

       document.getElementById("regMentorFooter").style.display = "grid";    


       document.getElementById("apprenticePagePartial").style.display = "grid";
       document.getElementById("getStarted").style.display = "grid";
       document.getElementById("newMentorList").style.display = "flex";
       document.getElementById("newApprenticeList").style.display = "none";


       document.getElementById("getStartedJustAdded").innerText = "People that just became mentors.";
       document.getElementById("getStartedTitle").innerText = "Help others";
       document.getElementById("getStartedInfo").innerText = "There are many people that need help starting their developer journey. Help others discover the wonderful world of programming. Become a mentor become a leader for someone in need.";
       document.getElementById("connectWithBTN").innerText = "Start helping others";
       document.getElementById("getToolsInfo").innerText = "When you become a mentor you can connect with an apprentice that needs help programming a website or web app. You also get access to your dashboard with tools to help you stay organized.";
       document.getElementById("becomeUserTitle").innerText = "Become a mentor. Help others learn.";
       document.getElementById("becomeUserInfo").innerText = "Do you have the skills to code websites or web apps? Do you want to help businesses get online and at the same time be a mentor for someone? Then get started become a mentor today.";


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
        document.getElementById("regApprentice").style.display = "none";
        document.getElementById("regMentor").style.display = "none";     
        document.getElementById("apprenticePagePartial").style.display = "none";
        
        document.getElementById("getStarted").style.display = "none";
        document.getElementById("regApprenticeFooter").style.display = "none";
        document.getElementById("regMentorFooter").style.display = "none";
        document.getElementById("websiteServicesPartial").style.display = "none";


        


        
    return (HeaderBannerStatus = "close");

    }


}
console.log(HeaderBannerStatus)



// const HeaderEventHandler = (e) =>{
//     if(e.target.innerText === "Become an Apprentice"){
//         document.getElementById("regApprentice").style.display = "grid";
//     }
//     if(e.target.innerText === "Become a Mentor"){
//         document.getElementById("regMentor").style.display = "grid";       

//     }
// } 


// Mentor Registration------------------------------------------------
const StateSelectedHandlerMentor = (e) => {
    let stateSelected = document.getElementById("MentorStateSelectionList").value;
    document.getElementById("MentorState").value = stateSelected;


    let stateSelectedFooter = document.getElementById("MentorStateSelectionListFooter").value;
    document.getElementById("MentorStateFooter").value = stateSelectedFooter;
    console.log(stateSelectedFooter)

    // document.getElementById("ApprenticeState").value = stateSelected;
}

let mentorStep = "step1"

const RegMentorHandler = (e) =>{

    mentorStep = mentorStep + e.target.innerText;
    console.log(mentorStep)
    
    if(mentorStep === "step1next"){
        document.getElementById('regMentorStep1').style.display = "none";
        document.getElementById('regMentorStep2').style.display = "grid";
        document.getElementById('regMentorStep3').style.display = "none";

        mentorStep = "step2";    
        return (mentorStep)
    
    }

    if(mentorStep === "step2back"){
        document.getElementById('regMentorStep1').style.display = "grid";   
        document.getElementById('regMentorStep2').style.display = "none";
        document.getElementById('regMentorStep3').style.display = "none";

        mentorStep = "step1";
        return (mentorStep)
    
    }

    if(mentorStep === "step2next"){
        document.getElementById('regMentorStep1').style.display = "none";
        document.getElementById('regMentorStep2').style.display = "none";
        document.getElementById('regMentorStep3').style.display = "grid";

        mentorStep = "step3"; 
        return (mentorStep)
    
    }

    
    if(mentorStep === "step3back"){
        document.getElementById('regMentorStep1').style.display = "none";   
        document.getElementById('regMentorStep2').style.display = "grid";
        document.getElementById('regMentorStep3').style.display = "none";

        mentorStep = "step2";
        return (mentorStep)
    
    }

}


let mentorStepFooter = "step1"

const RegMentorHandlerFooter = (e) =>{

    mentorStepFooter = mentorStepFooter + e.target.innerText;
    console.log(mentorStepFooter)
    
    if(mentorStepFooter === "step1next"){
        document.getElementById('regMentorStep1Footer').style.display = "none";
        document.getElementById('regMentorStep2Footer').style.display = "grid";
        document.getElementById('regMentorStep3Footer').style.display = "none";

        mentorStepFooter = "step2";    
        return (mentorStepFooter)
    
    }

    if(mentorStepFooter === "step2back"){
        document.getElementById('regMentorStep1Footer').style.display = "grid";   
        document.getElementById('regMentorStep2Footer').style.display = "none";
        document.getElementById('regMentorStep3Footer').style.display = "none";

        mentorStepFooter = "step1";
        return (mentorStepFooter)
    
    }

    if(mentorStepFooter === "step2next"){
        document.getElementById('regMentorStep1Footer').style.display = "none";
        document.getElementById('regMentorStep2Footer').style.display = "none";
        document.getElementById('regMentorStep3Footer').style.display = "grid";

        mentorStepFooter = "step3"; 
        return (mentorStepFooter)
    
    }

    
    if(mentorStepFooter === "step3back"){
        document.getElementById('regMentorStep1Footer').style.display = "none";   
        document.getElementById('regMentorStep2Footer').style.display = "grid";
        document.getElementById('regMentorStep3Footer').style.display = "none";

        mentorStepFooter = "step2";
        return (mentorStepFooter)
    
    }

}



// Apprentice Registration---------------------------------------------------------
const StateSelectedHandlerApprentice = (e) => {
    let stateSelected = document.getElementById("ApprenticeStateSelectionList").value;
    document.getElementById("ApprenticeState").value = stateSelected;

    let stateSelectedFooter = document.getElementById("ApprenticeStateSelectionListFooter").value;
    document.getElementById("ApprenticeStateFooter").value = stateSelectedFooter;
}



let ApprenticeStep = "step1"

const RegApprenticeHandler = (e) =>{

    ApprenticeStep = ApprenticeStep + e.target.innerText;
    console.log(ApprenticeStep)
    
    if(ApprenticeStep === "step1next"){
        document.getElementById('regApprenticeStep1').style.display = "none";
        document.getElementById('regApprenticeStep2').style.display = "grid";
        document.getElementById('regApprenticeStep3').style.display = "none";

        ApprenticeStep = "step2";    
        return (ApprenticeStep)
    
    }

    if(ApprenticeStep === "step2back"){
        document.getElementById('regApprenticeStep1').style.display = "grid";   
        document.getElementById('regApprenticeStep2').style.display = "none";
        document.getElementById('regApprenticeStep3').style.display = "none";

        ApprenticeStep = "step1";
        return (ApprenticeStep)
    
    }

    if(ApprenticeStep === "step2next"){
        document.getElementById('regApprenticeStep1').style.display = "none";
        document.getElementById('regApprenticeStep2').style.display = "none";
        document.getElementById('regApprenticeStep3').style.display = "grid";

        ApprenticeStep = "step3"; 
        return (ApprenticeStep)
    
    }

    
    if(ApprenticeStep === "step3back"){
        document.getElementById('regApprenticeStep1').style.display = "none";   
        document.getElementById('regApprenticeStep2').style.display = "grid";
        document.getElementById('regApprenticeStep3').style.display = "none";

        ApprenticeStep = "step2";
        return (ApprenticeStep)
    
    }

}


let ApprenticeStepFooter = "step1"

const RegApprenticeHandlerFooter = (e) =>{

    ApprenticeStepFooter = ApprenticeStepFooter + e.target.innerText;
    console.log(ApprenticeStepFooter)
    
    if(ApprenticeStepFooter === "step1next"){
        document.getElementById('regApprenticeStep1Footer').style.display = "none";
        document.getElementById('regApprenticeStep2Footer').style.display = "grid";
        document.getElementById('regApprenticeStep3').style.display = "none";

        ApprenticeStepFooter = "step2";    
        return (ApprenticeStepFooter)
    
    }

    if(ApprenticeStepFooter === "step2back"){
        document.getElementById('regApprenticeStep1Footer').style.display = "grid";   
        document.getElementById('regApprenticeStep2Footer').style.display = "none";
        document.getElementById('regApprenticeStep3Footer').style.display = "none";

        ApprenticeStepFooter = "step1";
        return (ApprenticeStepFooter)
    
    }

    if(ApprenticeStepFooter === "step2next"){
        document.getElementById('regApprenticeStep1Footer').style.display = "none";
        document.getElementById('regApprenticeStep2Footer').style.display = "none";
        document.getElementById('regApprenticeStep3Footer').style.display = "grid";

        ApprenticeStepFooter = "step3"; 
        return (ApprenticeStepFooter)
    
    }

    
    if(ApprenticeStepFooter === "step3back"){
        document.getElementById('regApprenticeStep1Footer').style.display = "none";   
        document.getElementById('regApprenticeStep2Footer').style.display = "grid";
        document.getElementById('regApprenticeStep3Footer').style.display = "none";

        ApprenticeStepFooter = "step2";
        return (ApprenticeStepFooter)
    
    }

}



const ServicesOptions =(e)=>{
    if(e.target.innerText === "Mobile Website"){
    document.querySelector("#mobileWebsiteServices").style.height = "auto";
    document.querySelector("#responsiveWebsiteServices").style.height = "50px";
    document.querySelector("#webAppServices").style.height = "50px";



    };

        if(e.target.innerText === "Essential Website"){
            document.querySelector("#mobileWebsiteServices").style.height = "50px";
            document.querySelector("#responsiveWebsiteServices").style.height = "auto";
            document.querySelector("#webAppServices").style.height = "50px";
        

    };

    if(e.target.innerText === "Web App"){
        document.querySelector("#mobileWebsiteServices").style.height = "50px";
        document.querySelector("#responsiveWebsiteServices").style.height = "50px";
        document.querySelector("#webAppServices").style.height = "auto";
    
        };



}



const PremiumServicesHandler = (e)=>{

    
    if(e.target.innerText === "More Options"){
        document.querySelector("#premiumServicesBNT").innerText = "Close";
        document.querySelector("#premiumServices").style.height = "400px";
        return

    }

    
    if(e.target.innerText === "Close"){
        document.querySelector("#premiumServicesBNT").innerText = "More Options";
        document.querySelector("#premiumServices").style.height = "80px";

        return
    
    
        };

  
}



const RegTitleHandler = (e) => {
        document.querySelector("#BannerLinkTag").innerText = e.target.innerText;
        document.querySelector("#BannerLinkTag").style.textDecoration = "none";    
}