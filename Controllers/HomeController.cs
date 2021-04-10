using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Intex2021FagElGamous.Models;
using System.Text;
using System.Security.Cryptography;

namespace Intex2021FagElGamous.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FagElGamousBYUDBContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, FagElGamousBYUDBContext ctx)
        {
            context = ctx;
            _logger = logger;
        }

        string hash(string input)
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = SHA256.Create().ComputeHash(inputBytes);

            return BitConverter.ToString(hashBytes).Replace("-", "");
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewBurials()
        {
            return View();
        }

        public IActionResult AddBurial()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }


        // ---------------------- Login ish --------------------
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel rvm)
        {


            return View("Index");
        }

        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signin(SigninViewModel u)
        {

            List<User> Users = context.Users.ToList();

            if (Users.Count() >= 1)
            {
                foreach (User user in Users)
                {
                    if (user.Email == u.Email)
                    {
                        string hashString = hash(u.Password);

                        // check for password
                        for (int i = 0; i < user.PassIterations - 1; i++)
                        {
                            hashString = hash(hashString);
                        }

                        // If the password is right
                        if (user.PassHash == hashString)
                        {
                            GlobalStatic.userID = user.UserId;
                            GlobalStatic.role = user.Role;
                            GlobalStatic.Email = user.Email;
                            GlobalStatic.FirstName = user.FirstName;
                            GlobalStatic.LastName = user.LastName;
                            return View("Index");
                        } else
                        {
                            GlobalStatic.userID = null;
                            GlobalStatic.role = null;
                            GlobalStatic.Email = null;
                            GlobalStatic.FirstName = null;
                            GlobalStatic.LastName = null;

                            SigninViewModel s = new SigninViewModel
                            {
                                Email = null,
                                Password = null,
                                Message = "Incorrect Password"
                            };

                            return View(s);
                        }
                    }
                }
                // exit the for loop ie. no email
                SigninViewModel sivm = new SigninViewModel
                {
                    Email = null,
                    Password = null,
                    Message = "Email Does Not Exist"
                };

                return View(sivm);

            } else // there's no users in the db
            {
                SigninViewModel sivm = new SigninViewModel
                {
                    Email = null,
                    Password = null,
                    Message = "Email Does Not Exist"
                };

                return View(sivm);
            } 
        }

        public IActionResult Logout()
        {
            GlobalStatic.userID = null;
            GlobalStatic.role = null;
            GlobalStatic.Email = null;
            GlobalStatic.FirstName = null;
            GlobalStatic.LastName = null;
            return View("Index");
        }
        // ---------------------- End Login ish ----------------

    }
}
