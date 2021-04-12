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
using Microsoft.EntityFrameworkCore;
using Intex2021FagElGamous.ViewModels;
using Intex2021FagElGamous.Models.ViewModels;

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

        public IActionResult ViewBurials(int pageNum = 1)
        {
            //sets the number of mummy records per page
            int pageSize = 10;


            ViewBurialsViewModel viewModel = new ViewBurialsViewModel();


            // Create a list of burials,
            // but not the normal ones, just with the info we want to see
            List<ViewBurialsBurialModel> vbbmList = new List<ViewBurialsBurialModel>();

            // for each burial in our db
            foreach (Burial b in context.Burials
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .ToList())
            {
                // create a burials model
                ViewBurialsBurialModel vbbm = new ViewBurialsBurialModel();

                // grab it's burial number
                int BurialNumber = (int)b.BurialNumber;
                int BurialSiteId = (int)b.BurialSiteId;
                string OsteologyNotes = null;

                string Burialwesttohead = null;
                string Burialwesttofeet = null;
                string Burialsouthtohead = null;
                string Burialsouthtofeet = null;
                string Burialdepth = null;
                string Length = null;
                string Goods = null;
                string GenderCode = null;


                if (!(b.OsteologyNotes is null))
                {
                    OsteologyNotes = b.OsteologyNotes.ToString();
                }

                if (!(b.Burialwesttohead is null))
                {
                    Burialwesttohead = b.Burialwesttohead.ToString();
                }

                if (!(b.Burialwesttofeet is null))
                {
                    Burialwesttofeet = b.Burialwesttofeet.ToString();
                }

                if (!(b.Burialsouthtohead is null))
                {
                    Burialsouthtohead = b.Burialsouthtohead.ToString();
                }

                if (!(b.Burialsouthtofeet is null))
                {
                    Burialsouthtofeet = b.Burialsouthtofeet.ToString();
                }

                if (!(b.Burialdepth is null))
                {
                    Burialdepth = b.Burialdepth.ToString();
                }

                if (!(b.Length is null))
                {
                    Length = b.Length.ToString();
                }

                if (!(b.Goods is null))
                {
                    Goods = b.Goods.ToString();
                }

                if (!(b.GenderCode is null))
                {
                    GenderCode = b.GenderCode.ToString();
                }

                string NS = context
                    .BurialSites
                    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", b.BurialSiteId).ToList().First().NS.ToString();

                int NSTop = (int)context
                    .BurialSites
                    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", b.BurialSiteId).ToList().First().Nstop;

                int NSBottom = NSTop + 10;

                string EW = context
                    .BurialSites
                    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", b.BurialSiteId).ToList().First().EW.ToString();

                int EWTop = (int)context
                    .BurialSites
                    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", b.BurialSiteId).ToList().First().Ewtop;

                int EWBottom = EWTop + 10;

                string Quadrant = context
                    .BurialSites
                    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", b.BurialSiteId).ToList().First().Quadrant.ToString();


                // add all the info to the vbbm
                vbbm.BurialNumber = BurialNumber;
                vbbm.NS = NS;
                vbbm.NSTop = NSTop;
                vbbm.NSBottom = NSBottom;
                vbbm.EW = EW;
                vbbm.EWTop = EWTop;
                vbbm.EWBottom = EWBottom;
                vbbm.Quadrant = Quadrant;
                vbbm.OsteologyNotes = OsteologyNotes;
                vbbm.Burialwesttohead = Burialwesttohead;
                vbbm.Burialwesttofeet = Burialwesttofeet;
                vbbm.Burialsouthtohead = Burialsouthtohead;
                vbbm.Burialsouthtofeet = Burialsouthtofeet;
                vbbm.Burialdepth = Burialdepth;
                vbbm.Length = Length;
                vbbm.Goods = Goods;
                vbbm.GenderCode = GenderCode;
                vbbm.BurialSiteId = BurialSiteId;

                vbbmList.Add(vbbm);
            }
            viewModel.Burials = vbbmList;

            //kinda like a constructor
            PageNumberingInfo pageNumber = new PageNumberingInfo
            {
                NumItemsPerPage = pageSize,
                CurrentPage = pageNum,
                TotalNumItems = (context.Burials.Count())
            };

            viewModel.PageNumberingInfo = pageNumber;

            return View(viewModel);
        }


        public IActionResult ViewMummy(ViewBurialsBurialModel v)
        {
            Burial b = context.Burials.FromSqlRaw("SELECT * FROM Burial WHERE BurialSiteId = {0} AND BurialNumber = {1}", v.BurialSiteId, v.BurialNumber).ToList().First();

            return View(b);
        }
       
        // ------------------------------ Restricted Section--------------------
        [HttpGet]
        public IActionResult AddBurial()
        {
            if (GlobalStatic.role == "No Role")
            {
                return View("Index");
            }
      
            return View();
        }


        [HttpPost]
        public IActionResult AddBurial(AddMummyViewModel mummy)
        {
            //context.Add.Add(mummy);

            //context.SaveChanges();
            return View();
        }

        public IActionResult Admin()
        {
            if (GlobalStatic.role != "Admin")
            {
                return View("Index");
            }

            List<AdminViewModel> avms = new List<AdminViewModel>();

            List<User> Users = context.Users.ToList();

            foreach (User user in Users)
            {
                // create a new adminview model
                AdminViewModel avm = new AdminViewModel();
                avm.Email = user.Email;
                avm.FirstName = user.FirstName;
                avm.LastName = user.LastName;
                avm.Role = user.Role;
                avm.UserID = user.UserId;

                avms.Add(avm);
            }

            avms = avms.OrderBy(o => o.Email).ToList();

            return View(avms);
        }

        public IActionResult RemoveUser(AdminViewModel avmm)
        {
            string UserID = avmm.UserID;
            Console.WriteLine("inside delete user");
            Console.WriteLine("Userid", UserID);
            List<User> UsersToDelete = context.Users.ToList();
            foreach (User user in UsersToDelete)
            {
                Console.WriteLine(user.UserId);
                if (user.UserId == UserID)
                {
                    Console.WriteLine("Inside of the actual deletion");
                    context.Users.Remove(user);
                    context.SaveChanges();
                    break;
                }
            }

            Console.WriteLine("outside");
            List<AdminViewModel> avms = new List<AdminViewModel>();

            List<User> Users = context.Users.ToList();

            foreach (User user in Users)
            {
                // create a new adminview model
                AdminViewModel avm = new AdminViewModel();
                avm.Email = user.Email;
                avm.FirstName = user.FirstName;
                avm.LastName = user.LastName;
                avm.Role = user.Role;
                avm.UserID = user.UserId;

                avms.Add(avm);
            }

            avms = avms.OrderBy(o => o.Email).ToList();

            return View("Admin", avms);
        }

        public IActionResult ChangeRoleNone(AdminViewModel avmm)
        {
            string UserID = avmm.UserID;
            List<User> UsersToDelete = context.Users.ToList();
            foreach (User user in UsersToDelete)
            {
                Console.WriteLine(user.UserId);
                if (user.UserId == UserID)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();

                    user.Role = "No Role";
                    context.Users.Add(user);
                    context.SaveChanges();
                    break;
                }
            }

            Console.WriteLine("outside");
            List<AdminViewModel> avms = new List<AdminViewModel>();

            List<User> Users = context.Users.ToList();

            foreach (User user in Users)
            {
                // create a new adminview model
                AdminViewModel avm = new AdminViewModel();
                avm.Email = user.Email;
                avm.FirstName = user.FirstName;
                avm.LastName = user.LastName;
                avm.Role = user.Role;
                avm.UserID = user.UserId;

                avms.Add(avm);
            }

            avms = avms.OrderBy(o => o.Email).ToList();

            return View("Admin", avms);
        }

        public IActionResult ChangeRoleResearcher(AdminViewModel avmm)
        {
            string UserID = avmm.UserID;
            List<User> UsersToDelete = context.Users.ToList();
            foreach (User user in UsersToDelete)
            {
                Console.WriteLine(user.UserId);
                if (user.UserId == UserID)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();

                    user.Role = "Researcher";
                    context.Users.Add(user);
                    context.SaveChanges();
                    break;
                }
            }

            Console.WriteLine("outside");
            List<AdminViewModel> avms = new List<AdminViewModel>();

            List<User> Users = context.Users.ToList();

            foreach (User user in Users)
            {
                // create a new adminview model
                AdminViewModel avm = new AdminViewModel();
                avm.Email = user.Email;
                avm.FirstName = user.FirstName;
                avm.LastName = user.LastName;
                avm.Role = user.Role;
                avm.UserID = user.UserId;

                avms.Add(avm);
            }

            avms = avms.OrderBy(o => o.Email).ToList();

            return View("Admin", avms);
        }

        public IActionResult ChangeRoleAdmin(AdminViewModel avmm)
        {
            string UserID = avmm.UserID;
            List<User> UsersToDelete = context.Users.ToList();
            foreach (User user in UsersToDelete)
            {
                Console.WriteLine(user.UserId);
                if (user.UserId == UserID)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();

                    user.Role = "Admin";
                    context.Users.Add(user);
                    context.SaveChanges();
                    break;
                }
            }

            Console.WriteLine("outside");
            List<AdminViewModel> avms = new List<AdminViewModel>();

            List<User> Users = context.Users.ToList();

            foreach (User user in Users)
            {
                // create a new adminview model
                AdminViewModel avm = new AdminViewModel();
                avm.Email = user.Email;
                avm.FirstName = user.FirstName;
                avm.LastName = user.LastName;
                avm.Role = user.Role;
                avm.UserID = user.UserId;

                avms.Add(avm);
            }

            avms = avms.OrderBy(o => o.Email).ToList();

            return View("Admin", avms);
        }


        // ------------------------------- Profile stuff -----------------------
        public IActionResult Profile()
        {
            ProfileViewModel p = new ProfileViewModel
            {
                FirstName = GlobalStatic.FirstName,
                LastName = GlobalStatic.LastName,
                Role = GlobalStatic.role,
                Email = GlobalStatic.Email
            };
            return View(p);
        }

        [HttpGet]
        public IActionResult ResetEmail()
        {
            if (GlobalStatic.userID == null)
            {
                return View("Index");
            }
            ResetEmailViewModel revm = new ResetEmailViewModel
            {
                Email = GlobalStatic.Email
            };
                
            return View(revm);
        }

        [HttpPost]
        public IActionResult ResetEmail(ResetEmailViewModel r)
        {
            if (GlobalStatic.userID == null)
            {
                return View("Index");
            }

            List<User> Users = context.Users.ToList();

            foreach (User user in Users)
            {
                if (user.UserId == GlobalStatic.userID)
                {
                    // this is the right user to update
                    context.Users.Remove(user);
                    context.SaveChanges();

                    user.Email = r.Email;
                    context.Users.Add(user);
                    context.SaveChanges();

                    GlobalStatic.Email = r.Email;

                    return View("Profile", new ProfileViewModel
                    {
                        FirstName = GlobalStatic.FirstName,
                        LastName = GlobalStatic.LastName,
                        Role = GlobalStatic.role,
                        Email = GlobalStatic.Email
                    });
                }
            }

            return View("Index");
        }

        [HttpGet]
        public IActionResult ResetUserInfo()
        {
            if (GlobalStatic.userID == null)
            {
                return View("Index");
            }

            ResetUserInfoViewModel r = new ResetUserInfoViewModel
            {
                FirstName = GlobalStatic.FirstName,
                LastName = GlobalStatic.LastName
            };

            return View(r);
        }

        [HttpPost]
        public IActionResult ResetUserInfo(ResetUserInfoViewModel r)
        {
            if (GlobalStatic.userID == null)
            {
                return View("Index");
            }

            List<User> Users = context.Users.ToList();

            foreach (User user in Users)
            {
                if (user.UserId == GlobalStatic.userID)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();

                    user.FirstName = r.FirstName;
                    user.LastName = r.LastName;
                    context.Users.Add(user);
                    context.SaveChanges();

                    GlobalStatic.FirstName = r.FirstName;
                    GlobalStatic.LastName = r.LastName;

                    return View("Profile", new ProfileViewModel
                    {
                        FirstName = GlobalStatic.FirstName,
                        LastName = GlobalStatic.LastName,
                        Role = GlobalStatic.role,
                        Email = GlobalStatic.Email
                    });
                }
            }
            return View("Profile", new ProfileViewModel
            {
                FirstName = GlobalStatic.FirstName,
                LastName = GlobalStatic.LastName,
                Role = GlobalStatic.role,
                Email = GlobalStatic.Email
            });
        }

        [HttpGet]
        public IActionResult ResetPassword()
        {
            if (GlobalStatic.userID == null)
            {
                return View("Profile");
            }

            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel r)
        {
            if (GlobalStatic.userID == null)
            {
                return View("Index");
            }

            if (r.NewPassword != r.NewPasswordConfirmed)
            {
                ModelState.AddModelError(string.Empty, "Passwords are not the same");
                // passwords do not match
                return View();
            }

            if (r.NewPassword.Length <= 11)
            {
                ModelState.AddModelError(string.Empty, "Password must be 12 characters or more");
                // passwords not long enough
                return View();
            }

            List<User> Users = context.Users.ToList();

            foreach (User user in Users)
            {
                if (user.UserId == GlobalStatic.userID)
                {
                    // this is the right user to update
                    context.Users.Remove(user);
                    context.SaveChanges();

                    string updatePass = r.PreviousPassword + user.PassSalt;
                    for (int i = 0; i < user.PassIterations; ++i)
                    {
                        updatePass = hash(updatePass);
                    }

                    if (updatePass != user.PassHash)
                    {
                        ModelState.AddModelError(string.Empty, "Incorrect Current Password");
                        return View();
                    }

                    string newSalt = RandomString(saltLength);
                    string newPass = r.NewPassword + newSalt;
                    for (int i = 0; i < user.PassIterations; ++i)
                    {
                        newPass = hash(newPass);
                    }
                    user.PassHash = newPass;
                    user.PassSalt = newSalt;

                    context.Users.Add(user);
                    context.SaveChanges();

                    return View("Profile", new ProfileViewModel
                    {
                        FirstName = GlobalStatic.FirstName,
                        LastName = GlobalStatic.LastName,
                        Role = GlobalStatic.role,
                        Email = GlobalStatic.Email
                    });
                }
            }

            ModelState.AddModelError(string.Empty, "Something went wrong");
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

            if (rvm.Password.Length <= 11)
            {
                ModelState.AddModelError(string.Empty, "Password must be 12 characters or more");
                // passwords not long enough
                return View();
            }

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
            if (Users.Count() < 1)
            {
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
                    }
                    else
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
