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
        private int saltLength = 15;
        private int iterationLength = 200000;

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

        public string RandomString(int size)
        { 
            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < size; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
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

            if (!(ModelState.IsValid))
            {
                return View();
            }

            // add check for password length

            if (rvm.Password != rvm.PasswordConfirm)
            {
                ModelState.AddModelError(string.Empty, "Passwords are not the same");
                // passwords do not match
                return View();
            }

            List<User> Users = context.Users.ToList();
            foreach (User user in Users)
            {
                if (user.Email == rvm.Email)
                {
                    ModelState.AddModelError(string.Empty, "Email already exists");
                    return View();
                }
            }

            string id = RandomString(20);
            string salt = RandomString(saltLength);
            string saltedPass = rvm.Password + salt;

            for (int i = 0; i < iterationLength; i++)
            {
                saltedPass = hash(saltedPass);
            }


            User newUser = new User();
            newUser.UserId = id;
            newUser.Email = rvm.Email;
            newUser.FirstName = rvm.FirstName;
            newUser.LastName = rvm.LastName;
            newUser.PassSalt = salt;
            newUser.PassIterations = iterationLength;
            newUser.PassHash = saltedPass;
            newUser.Role = "No Role";

            context.Users.Add(newUser);
            context.SaveChanges();

            GlobalStatic.userID = newUser.UserId;
            GlobalStatic.role = newUser.Role;
            GlobalStatic.Email = newUser.Email;
            GlobalStatic.FirstName = newUser.FirstName;
            GlobalStatic.LastName = newUser.LastName;

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
            if (!(ModelState.IsValid))
            {
                return View();
            }

            List<User> Users = context.Users.ToList();
            if (Users.Count() < 1) {
                ModelState.AddModelError(string.Empty, "Register before signing in");
                return View("Index");
            }

            foreach (User user in Users)
            {
                if (user.Email == u.Email)
                {
                    string hashString = u.Password + user.PassSalt;

                    // check for password
                    for (int i = 0; i < user.PassIterations; i++)
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
                        ModelState.AddModelError(string.Empty, "Invalid email/password");
                        GlobalStatic.userID = null;
                        GlobalStatic.role = null;
                        GlobalStatic.Email = null;
                        GlobalStatic.FirstName = null;
                        GlobalStatic.LastName = null;

                        return View();
                    }
                }
            }
            // no email matches
            ModelState.AddModelError(string.Empty, "Invalid email/password");
            GlobalStatic.userID = null;
            GlobalStatic.role = null;
            GlobalStatic.Email = null;
            GlobalStatic.FirstName = null;
            GlobalStatic.LastName = null;
            return View();
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
