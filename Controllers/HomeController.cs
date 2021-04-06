using System;
using Microsoft.AspNetCore.Mvc;
using ProgressLog.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace ProgressLog.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }


        // Navigation no process
        [HttpGet("signin")]
        public IActionResult gotoSignin()
        {
            return RedirectToAction("index");
        }

        [HttpGet("registration")]
        public IActionResult gotoRegistration()
        {
            return RedirectToAction("login");
        }

        // -----------------------------------------------------------end

        // Rendering Pages in Views--------------------------------------------
        [HttpGet("")]
        public IActionResult index()
        {
            return View("index");
        }


        [HttpGet("login")]
        public IActionResult login()
        {
            return View("login");
        }


        [HttpGet("regApprentice")]
        public IActionResult regApprentice()
        {
            return View("_regApprentice");
        }

        [HttpGet("regMentor")]
        public IActionResult regMentor()
        {
            return View("_regMentor");
        }


        [HttpGet("dashboard")]
        public IActionResult dashboard()
        {
            // block pages is not in session
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("index");
            }

            // check to see if section id is in session
            if (HttpContext.Session.GetInt32("SectionId") == null)
            {
                HttpContext.Session.SetInt32("SectionId", 0);
            }


            // get user in session
            int UserIdInSession = (int)HttpContext.Session.GetInt32("UserId");
            // get section in session
            int SectionInSession = (int)HttpContext.Session.GetInt32("SectionId");
            ViewBag.passSectionId = SectionInSession;


            // Filter db by User in Session 
            User UserIndb = _context.Users
                .FirstOrDefault(u => u.UserId == UserIdInSession);
            ViewBag.ToDisplay = UserIndb;


            // filter db set section by user
            ViewBag.allSections = _context.Sections
                .Where(us => us.UserId == UserIdInSession)
                .ToList();

            // filter db by section id 
            ViewBag.allUserLogs = _context.LogRecords
                .Where(ul => ul.SectionId == SectionInSession)
                .ToList();

            MainWrapper wMod = new MainWrapper();

            return View("dashboard", wMod);
        }

        // -----------------------------------------------------------end

        // Processing Section Opporations--------------------------------------------------

        [HttpPost("NewSectionHandler")]
        public IActionResult NewSectionHandler(Section FromForm)
        {

            // block pages is not in session
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("login");
            }
            System.Console.WriteLine("you have reach the sections backend.");

            // get and set userId
            int GetUserbyId = (int)HttpContext.Session.GetInt32("UserId");
            FromForm.UserId = GetUserbyId;

            System.Console.WriteLine(FromForm.Title);
            System.Console.WriteLine(FromForm.SectionId);
            HttpContext.Session.SetInt32("SectionId", FromForm.SectionId);


            _context.Add(FromForm);
            _context.SaveChanges();


            // System.Console.WriteLine("section button was click");
            return Json(new { StatusCode = "Success", FromForm });
        }

        [HttpGet("DisplaySection")]
        public JsonResult DisplaySection()
        {
            int UserIdInSession = (int)HttpContext.Session.GetInt32("UserId");

            MainWrapper wMode = new MainWrapper();

            List<Section> sectionItems = _context.Sections
            .Where(us => us.UserId == UserIdInSession)
            .ToList();


            //     ViewBag.TodoListItems = _context.TodoLists
            //    .Where(us => us.UserId == UserIdInSession)
            //    .ToList();

            return Json(new { data = sectionItems });

        }


        [HttpGet("DeleteSectionHandler")]
        public IActionResult DeleteSectionHandler(Section DataId)
        {


            // block pages is not in session
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("login");
            }
            System.Console.WriteLine("You have successfully reach the backend of delete section");
            System.Console.WriteLine($"id: {DataId.SectionId}");


            Section GetSection = _context.Sections.FirstOrDefault(lr => lr.SectionId == DataId.SectionId);


            _context.Sections.Remove(GetSection);
            _context.SaveChanges();

            return Json(new { StatusCode = "Success", GetSection });
        }



        [HttpGet("FilterSectionHandler")]
        public IActionResult FilterSectionHandler(Section DataId)
        {

            // block pages is not in session
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("login");
            }

            System.Console.WriteLine("You have successfully reach the backend of filtering section");
            System.Console.WriteLine($"dataid: {DataId.SectionId}");

            HttpContext.Session.SetInt32("SectionId", DataId.SectionId);
            List<LogRecord> GetUserLogs = _context.LogRecords
                .Where(ul => ul.SectionId == DataId.SectionId)
                .ToList();

            System.Console.WriteLine($"users logs: {GetUserLogs}");

            // return RedirectToAction("dashboard");

            return Json(new { StatusCode = "Success", GetUserLogs });
        }



        [HttpGet("FilterBySession")]
        public IActionResult FilterBySession(Section DataId)
        {

            System.Console.WriteLine("you have reached the filter by session backend");

            int SelectedSectionId = (int)HttpContext.Session.GetInt32("SectionId");
            List<LogRecord> FilterBySession = _context.LogRecords
                .Where(ul => ul.SectionId == SelectedSectionId)
                .ToList();

            System.Console.WriteLine($"users logs: {FilterBySession}");

            // return RedirectToAction("dashboard");

            return Json(new { StatusCode = "Success", FilterBySession });
        }



        // Processing Log Opporations--------------------------------------------------

        // [HttpPost("CreateLog")]
        // public IActionResult CreateLog(LogRecord FromForm)
        // {

        //     int GetUserbyId = (int)HttpContext.Session.GetInt32("UserId");
        //     FromForm.UserId = GetUserbyId;

        //     int SelectedSectionId = (int)HttpContext.Session.GetInt32("SectionId");
        //     FromForm.SectionId = SelectedSectionId;


        //     _context.Add(FromForm);
        //     _context.SaveChanges();


        //     System.Console.WriteLine("Save button was click");
        //     return RedirectToAction("dashboard");
        // }

        [HttpPost("CreateNewLog")]
        public IActionResult CreateNewLog(LogRecord FromForm)
        {

            // block pages is not in session
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("login");
            }
            System.Console.WriteLine("You have reached the backend of new log.");
            System.Console.WriteLine($"Data from user: {FromForm.TextLog}");


            int GetUserbyId = (int)HttpContext.Session.GetInt32("UserId");
            FromForm.UserId = GetUserbyId;

            int SelectedSectionId = (int)HttpContext.Session.GetInt32("SectionId");
            FromForm.SectionId = SelectedSectionId;


            _context.Add(FromForm);
            _context.SaveChanges();


            return Json(new { StatusCode = "Success", FromForm });

        }


        [HttpPost("EditLogHandler")]
        public IActionResult EditLogHandler(LogRecord DataId)
        {

            // block pages is not in session
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("login");
            }

            System.Console.WriteLine("You have reached the backend of editing log.");
            System.Console.WriteLine($"*** id to edit here {DataId.LogRecordId}");
            System.Console.WriteLine($"*** New Text {DataId.TextLog}");


            // get user in session
            int UserIdInSession = (int)HttpContext.Session.GetInt32("UserId");
            // get section in session
            int SectionInSession = (int)HttpContext.Session.GetInt32("SectionId");


            LogRecord GetLog = _context.LogRecords.SingleOrDefault(l => l.LogRecordId == DataId.LogRecordId);


            GetLog.LogRecordId = DataId.LogRecordId;
            GetLog.TextLog = DataId.TextLog;

            _context.SaveChanges();


            return Json(new { StatusCode = "Success", DataId });

        }


        // [HttpGet("edit/{LogRecordId}")]
        // public IActionResult editLog(int LogRecordId)
        // {

        //     // block pages is not in session
        //     if (HttpContext.Session.GetInt32("UserId") == null)
        //     {
        //         return RedirectToAction("login");
        //     }

        //     // check to see if section id is in session
        //     if (HttpContext.Session.GetInt32("SectionId") == null)
        //     {
        //         HttpContext.Session.SetInt32("SectionId", 0);
        //     }


        //     // get user in session
        //     int UserIdInSession = (int)HttpContext.Session.GetInt32("UserId");
        //     // get section in session
        //     int SectionInSession = (int)HttpContext.Session.GetInt32("SectionId");
        //     ViewBag.passSectionId = SectionInSession;



        //     // filter db set section by user
        //     ViewBag.allSections = _context.Sections
        //         .Where(us => us.UserId == UserIdInSession)
        //         .ToList();

        //     // filter db by section id 
        //     ViewBag.allUserLogs = _context.LogRecords
        //         .Where(ul => ul.SectionId == SectionInSession)
        //         .ToList();

        //     LogRecord GetLog = _context.LogRecords.SingleOrDefault(l => l.LogRecordId == LogRecordId);


        //     MainWrapper wMod = new MainWrapper();
        //     wMod.LogRecord = GetLog;

        //     System.Console.WriteLine("edit button was click");
        //     return View("edit", wMod);
        // }




        // [HttpGet("sectionLink/{SectionId}")]
        // public IActionResult sectionLink(int SectionId)
        // {


        //     HttpContext.Session.SetInt32("SectionId", SectionId);
        //     System.Console.WriteLine(SectionId);


        //     System.Console.WriteLine("Section was click");

        //     return RedirectToAction("dashboard");
        // }



        // [HttpGet("deleteLog/{LogRecordId}")]
        // public IActionResult deleteLog(int LogRecordId)
        // {
        //     LogRecord GetLog = _context.LogRecords.FirstOrDefault(lr => lr.LogRecordId == LogRecordId);

        //     _context.LogRecords.Remove(GetLog);
        //     _context.SaveChanges();

        //     System.Console.WriteLine("Delete Button was click");
        //     return RedirectToAction("dashboard");
        // }



        [HttpGet("DeleteLogEntryHandler")]
        public IActionResult DeleteLogEntryHandler(LogRecord DataId)
        {

            // block pages is not in session
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("login");
            }
            System.Console.WriteLine("you have reach the backend of delete Log entry");
            System.Console.WriteLine($"this is the id: {DataId.LogRecordId}");


            LogRecord GetLog = _context.LogRecords.FirstOrDefault(lr => lr.LogRecordId == DataId.LogRecordId);

            _context.LogRecords.Remove(GetLog);
            _context.SaveChanges();

            // return RedirectToAction("dashboard");
            return Json(new { Status = "Delete Log Success", GetLog });
        }




        // [HttpPost("update/{LogRecordId}")]
        // public IActionResult updateLog(LogRecord FromForm, int LogRecordId)
        // {

        //     LogRecord GetLog = _context.LogRecords.SingleOrDefault(l => l.LogRecordId == LogRecordId);


        //     GetLog.LogRecordId = LogRecordId;
        //     GetLog.TextLog = FromForm.TextLog;

        //     _context.SaveChanges();

        //     System.Console.WriteLine("Saved changes button was click");
        //     return RedirectToAction("dashboard");
        // }






        // User registration Login-------------------------------------------------
        // [HttpPost("Redgister")]
        // public IActionResult Redgister(User FromForm)
        // {
        //     // Check if email is already in db
        //     if (_context.Users.Any(u => u.Email == FromForm.Email))
        //     {
        //         ModelState.AddModelError("Email", "Email already in use!");
        //     }

        //     // Validations
        //     if (ModelState.IsValid)
        //     {
        //         // #hash password
        //         PasswordHasher<User> Hasher = new PasswordHasher<User>();
        //         FromForm.Password = Hasher.HashPassword(FromForm, FromForm.Password);

        //         // Add to db
        //         _context.Add(FromForm);
        //         _context.SaveChanges();

        //         // Session
        //         HttpContext.Session.SetInt32("UserId", _context.Users.FirstOrDefault(i => i.UserId == FromForm.UserId).UserId);
        //         // Redirect
        //         System.Console.WriteLine("You may contine!");
        //         return RedirectToAction("dashboard");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Fix your erros!");
        //         return View("index");

        //     }

        // }


        [HttpPost("RegisterApprentice")]
        public IActionResult RegisterApprentice(User FromForm)
        {
            // Check if email is already in db
            if (_context.Users.Any(u => u.Email == FromForm.Email))
            {
                ModelState.AddModelError("Email", "Email already in use!");
            }

            // Validations
            if (ModelState.IsValid)
            {
                // #hash password
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                FromForm.Password = Hasher.HashPassword(FromForm, FromForm.Password);

                FromForm.AccountType = "Apprentice";
                FromForm.UserTitle = "New Developer";
                FromForm.ProfileImg = "profilePlaceholder.png";
                FromForm.MeetUpLink = "http://www.progresslypage.com/";
                FromForm.ProfileBackground = "136DC0";


                // Add to db
                _context.Add(FromForm);
                _context.SaveChanges();

                // Session
                HttpContext.Session.SetInt32("UserId", _context.Users.FirstOrDefault(i => i.UserId == FromForm.UserId).UserId);
                // Redirect
                System.Console.WriteLine("You may contine!");
                return RedirectToAction("dashboard");
            }
            else
            {
                System.Console.WriteLine("Fix your erros!");
                return View("index");

            }


        }

        [HttpPost("RegisterMentor")]
        public IActionResult RegisterMentor(User FromForm)
        {
            // Check if email is already in db
            if (_context.Users.Any(u => u.Email == FromForm.Email))
            {
                ModelState.AddModelError("Email", "Email already in use!");
            }

            // Validations
            if (ModelState.IsValid)
            {
                // #hash password
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                FromForm.Password = Hasher.HashPassword(FromForm, FromForm.Password);

                FromForm.AccountType = "Mentor";
                FromForm.ProfileImg = "profilePlaceholder.png";
                FromForm.ProfileBackground = "136DC0";


                // Add to db
                _context.Add(FromForm);
                _context.SaveChanges();

                // Session
                HttpContext.Session.SetInt32("UserId", _context.Users.FirstOrDefault(i => i.UserId == FromForm.UserId).UserId);
                // Redirect
                System.Console.WriteLine("You may contine!");
                return RedirectToAction("dashboard");
            }
            else
            {
                System.Console.WriteLine("Fix your erros!");
                return View("index");

            }


        }



        [HttpPost("Login")]
        public IActionResult Login(LoginUser userSubmission)
        {
            // Validations
            if (ModelState.IsValid)
            {
                // Check db email with from email
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.Email);

                // No user in db
                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("login");
                }
                // Check hashing are the same
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);

                if (result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                }
                // Set Session Instance
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("dashboard");

            }

            return View("login");

        }


        [HttpGet("logout")]
        public IActionResult logout()
        {
            // Clear Session
            HttpContext.Session.Clear();
            return RedirectToAction("login");
        }


        // ------------------------------------------end of registration and login








    }
}