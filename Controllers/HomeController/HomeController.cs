using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using viewModels2.Models;
namespace dojoSurvey
{
    public class HomeController : Controller // Home is the name of the directory where all of these actions/views should reference
    {
        [HttpGet] //This renders the Form Submission Page
        [Route("")]
        public IActionResult Index()
        {
            string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            return View("Index", message);
        }
        

        [HttpGet] //This renders a list of users on the User's Page
        [Route("users")]
        public IActionResult Users()
        {
             
            List<string> usernames = new List<string>();
                usernames.Add("Moose Phillips");
                usernames.Add("Kilian Krebsbach");
                usernames.Add("Barbara");
                usernames.Add("Moose Phillips");
                usernames.Add("Moose Phillips");
                usernames.Add("Moose Phillips");
            return View("Users", usernames);
        }

        [HttpGet] //This renders a list of users on the User's Page
        [Route("numbers")]
        public IActionResult Numbers()
        {
            int[] numbs = new int[]
            {
                1,2,3,10,43,5,6,7,8,9,1,0
            };

            return View("Numbers", numbs);
        }

        [HttpGet] //This renders a list of users on the User's Page
        [Route("user")]
        public IActionResult Userpage()
        {
            User someUser = new User()
            {
                FirstName = "Mary Ann",
                LastName = "Kearney"
            };


            return View("Userpage", someUser);
        }
    }
}