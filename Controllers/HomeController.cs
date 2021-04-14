﻿using System;
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
        private intex2021Context context { get; set; }
        private int saltLength = 15;
        private int iterationLength = 200000;
        private int pageSize { get; set; } = 10;

        private static List<Burial> GlobalBurials { get; set; }

        public HomeController(ILogger<HomeController> logger, intex2021Context ctx)
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
            GlobalBurials = context.Burials.ToList();
            
            return View();
        }


        [HttpGet]
        public IActionResult ViewBurials(int pageNum = 1)
        {

           ViewBurialsViewModel viewModel = new ViewBurialsViewModel();

            // Create a list of burials,
            // but not the normal ones, just with the info we want to see
            List<ViewBurialsBurialModel> vbbmList = new List<ViewBurialsBurialModel>();

            List<Burial> Burials = GlobalBurials
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .OrderBy(o => o.BurialSiteId)
                    .ToList();

            // for each burial in our db
            foreach (Burial b in Burials)
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

                if (!(b.BurialWestToHead is null))
                {
                    Burialwesttohead = b.BurialWestToHead.ToString();
                }

                if (!(b.BurialWestToFeet is null))
                {
                    Burialwesttofeet = b.BurialWestToFeet.ToString();
                }

                if (!(b.BurialSouthToHead is null))
                {
                    Burialsouthtohead = b.BurialSouthToHead.ToString();
                }

                if (!(b.BurialSouthToFeet is null))
                {
                    Burialsouthtofeet = b.BurialSouthToFeet.ToString();
                }

                if (!(b.BurialDepth is null))
                {
                    Burialdepth = b.BurialDepth.ToString();
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
               
                string NS = "";
                string EW = "";
                int NSTop = 0;
                int NSBottom = 0;
                int EWTop = 0;
                int EWBottom = 0;
                string Quadrant = "";

             
                BurialSite bs = context.BurialSites.Where(o => o.BurialSiteId == b.BurialSiteId).ToList().First();
                NS = bs.Ns;
                EW = bs.Ew;
                NSTop = bs.Nstop ?? default(int);
                NSBottom = bs.Nsbottom ?? default(int);
                EWTop = bs.Ewtop ?? default(int);
                EWBottom = bs.Ewbottom ?? default(int);
                Quadrant = bs.Quadrant;
                //var sql = "SELECT* FROM dbo.BurialSite WHERE BurialSiteId = {0}";

                ////context.BurialSites.FromSqlInterpolated($"SELECT * FROM dbo.BurialSite")
                //string NS = context
                //    .BurialSites
                //    .FromSqlRaw(sql, b.BurialSiteId).ToList().First().Ns.ToString();

                //int NSTop = (int)context
                //    .BurialSites
                //    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", b.BurialSiteId).ToList().First().Nstop;

                //int NSBottom = NSTop + 10;

                //string EW = context
                //    .BurialSites
                //    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", b.BurialSiteId).ToList().First().Ew.ToString();

                //int EWTop = (int)context
                //    .BurialSites
                //    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", b.BurialSiteId).ToList().First().Ewtop;

                //int EWBottom = EWTop + 10;

                //string Quadrant = context
                //    .BurialSites
                //    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", b.BurialSiteId).ToList().First().Quadrant.ToString();


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
                TotalNumItems = (GlobalBurials.Count())
            };

            viewModel.PageNumberingInfo = pageNumber;

            viewModel.Filter = new ViewBurialsFilteringInfo();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ViewBurials(ViewBurialsViewModel vbvm, int pageNum = 1)
        {
            Console.WriteLine("Starting!!!!!!!!!!!!!!!!!!!");
            ViewBurialsViewModel viewModel = new ViewBurialsViewModel();

            // Create a list of burials,
            // but not the normal ones, just with the info we want to see
            List<ViewBurialsBurialModel> vbbmList = new List<ViewBurialsBurialModel>();

            // filter the global burials
            List<Burial> newBurials = new List<Burial>();

            List<Burial> Burials = context.Burials.ToList();
            foreach (Burial bur in Burials)
            {
                Console.WriteLine("At burial: ");
                Console.WriteLine(bur.BurialNumber);                // get burial site info

                string NS = "";
                string EW = "";
                int NSTop = 0;
                int NSBottom = 0;
                int EWTop = 0;
                int EWBottom = 0;
                string Quadrant = "";

                BurialSite bs = context.BurialSites.Where(o => o.BurialSiteId == bur.BurialSiteId).ToList().First();
                NS = bs.Ns;
                EW = bs.Ew;
                NSTop = bs.Nstop ?? default(int);
                NSBottom = bs.Nsbottom ?? default(int);
                EWTop = bs.Ewtop ?? default(int);
                EWBottom = bs.Ewbottom ?? default(int);
                Quadrant = bs.Quadrant;

                //NS
                if (vbvm.Filter.NS == "N" && NS != "N")
                {
                    // continue means it skips this burial
                    continue;
                }
                if (vbvm.Filter.NS == "S" && NS != "S")
                {
                    continue;
                }

                //NSTop
                if (vbvm.Filter.NSTop != -42 && vbvm.Filter.NSTop != NSTop)
                {
                    continue;
                }

                //EW
                if (vbvm.Filter.EW == "E" && EW != "E")
                {
                    // continue means it skips this burial
                    continue;
                }
                if (vbvm.Filter.EW == "W" && EW != "W")
                {
                    continue;
                }

                //ewtop
                if (vbvm.Filter.EWTop != -42 && vbvm.Filter.EWTop != EWTop)
                {
                    continue;
                }

                //quadrant
                if (vbvm.Filter.Quadrant != "All" && vbvm.Filter.Quadrant != Quadrant)
                {
                    continue;
                }

                //west to head
                if (bur.BurialWestToHead != null)
                {
                    // we are allowed to cast to double
                    double wth = Convert.ToDouble(bur.BurialWestToHead);

                    if (wth < vbvm.Filter.BurialwesttoheadMin || wth > vbvm.Filter.BurialwesttoheadMax)
                    {
                        continue;
                    }

                }
                

                //west to feet
                if (bur.BurialWestToFeet != null)
                {
                    // we are allowed to cast to double
                    double wtf = Convert.ToDouble(bur.BurialWestToFeet);

                    if (wtf < vbvm.Filter.BurialwesttofeetMin || wtf > vbvm.Filter.BurialwesttofeetMax)
                    {
                        continue;
                    }

                }
               
                //south to head
                if (bur.BurialSouthToHead != null)
                {
                    // we are allowed to cast to double
                    double sth = Convert.ToDouble(bur.BurialSouthToHead);

                    if (sth < vbvm.Filter.BurialsouthtoheadMin || sth > vbvm.Filter.BurialsouthtoheadMax)
                    {
                        continue;
                    }

                }
               

                //south to feet
                if (bur.BurialSouthToFeet != null)
                {
                    // we are allowed to cast to double
                    double stf = Convert.ToDouble(bur.BurialSouthToFeet);

                    if (stf < vbvm.Filter.BurialsouthtofeetMin || stf > vbvm.Filter.BurialsouthtofeetMax)
                    {
                        continue;
                    }

                }
              

                //depth
                if (bur.BurialDepth != null)
                {
                    // we are allowed to cast to double
                    double d = Convert.ToDouble(bur.BurialDepth);

                    if (d < vbvm.Filter.BurialdepthMin || d > vbvm.Filter.BurialdepthMax)
                    {
                        continue;
                    }

                }
               

                // goods
                if (vbvm.Filter.Goods == "All")
                {
                    // include everything
                } else if (vbvm.Filter.Goods != bur.Goods)
                {
                    continue;
                }

                // gender codes
                if (vbvm.Filter.GenderCode == "All")
                {
                    // include everything
                }
                else if (vbvm.Filter.GenderCode != bur.GenderCode)
                {
                    continue;
                }

                // byu sampled
                if (vbvm.Filter.Byusample == "All")
                {
                    // include everything
                }
                else if (vbvm.Filter.Byusample != bur.ByuSample)
                {
                    continue;
                }


                // skullmagazine
                if (vbvm.Filter.SkullatMagazine == "All")
                {
                    // include everything
                }
                else if (vbvm.Filter.SkullatMagazine != bur.SkullAtMagazine)
                {
                    continue;
                }

                // skull age
                if (vbvm.Filter.AgeSkull2018 == "All")
                {
                    // include everything
                }
                else if (vbvm.Filter.AgeSkull2018 != bur.AgeSkull)
                {
                    continue;
                }

                // skull sex
                if (vbvm.Filter.SexSkull2018 == "All")
                {
                    // include everything
                }
                else if (vbvm.Filter.SexSkull2018 != bur.SexSkull)
                {
                    continue;
                }


                newBurials.Add(bur);
            }
            Console.WriteLine("Outingside of the filtering!!!!!!!!!!!!!!!!!!");

            GlobalBurials = newBurials;

            List<Burial> Burialss = GlobalBurials
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .OrderBy(o => o.BurialSiteId)
                    .ToList();

            // for each burial in our db
            foreach (Burial b in Burialss)
            {

                Console.WriteLine("inside the newxt lop");
                // get burial site info

                string NS = "";
                string EW = "";
                int NSTop = 0;
                int NSBottom = 0;
                int EWTop = 0;
                int EWBottom = 0;
                string Quadrant = "";

                BurialSite bs = context.BurialSites.Where(o => o.BurialSiteId == b.BurialSiteId).ToList().First();
                NS = bs.Ns;
                EW = bs.Ew;
                NSTop = bs.Nstop ?? default(int);
                NSBottom = bs.Nsbottom ?? default(int);
                EWTop = bs.Ewtop ?? default(int);
                EWBottom = bs.Ewbottom ?? default(int);
                Quadrant = bs.Quadrant;

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

                if (!(b.BurialWestToHead is null))
                {
                    Burialwesttohead = b.BurialWestToHead.ToString();
                }

                if (!(b.BurialWestToFeet is null))
                {
                    Burialwesttofeet = b.BurialWestToFeet.ToString();
                }

                if (!(b.BurialSouthToHead is null))
                {
                    Burialsouthtohead = b.BurialSouthToHead.ToString();
                }

                if (!(b.BurialSouthToFeet is null))
                {
                    Burialsouthtofeet = b.BurialSouthToFeet.ToString();
                }

                if (!(b.BurialDepth is null))
                {
                    Burialdepth = b.BurialDepth.ToString();
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

            Console.WriteLine("outside the last loop!!!!!!!!!!!!!!");
            viewModel.Burials = vbbmList;

            //kinda like a constructor
            PageNumberingInfo pageNumber = new PageNumberingInfo
            {
                NumItemsPerPage = pageSize,
                CurrentPage = pageNum,
                TotalNumItems = (GlobalBurials.Count())
            };

            viewModel.PageNumberingInfo = pageNumber;

            viewModel.Filter = vbvm.Filter;

            return View(viewModel);
        }

        


        public IActionResult ViewMummy(ViewBurialsBurialModel v)
        {
            // This is the burial we are looking at
            //Burial b = context.Burials.FromSqlRaw("SELECT * FROM Burial WHERE BurialSiteId = {0} AND BurialNumber = {1}", v.BurialSiteId, v.BurialNumber).ToList().First();
            Burial b = context.Burials.Where(o => o.BurialSiteId == v.BurialSiteId).Where(p => p.BurialNumber == v.BurialNumber).ToList().First();
            //BurialSite bs = context.BurialSites.FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", v.BurialSiteId).ToList().First();
            BurialSite bs = context.BurialSites.Where(o => o.BurialSiteId == v.BurialSiteId).ToList().First();
            //List<CranialMain> cranialMains = context.CranialMains.FromSqlRaw("SELECT * FROM CranialMain WHERE BurialSiteId = {0} AND BurialNumber = {1}", v.BurialSiteId, v.BurialNumber).ToList();
            //List<C14datum> c14Data = context.C14data.FromSqlRaw("SELECT * FROM C14Data WHERE BurialSiteId = {0} AND \"Burial#\" = {1}", v.BurialSiteId, v.BurialNumber).ToList();
            //List<FieldBook> fieldBooks = context.FieldBooks.FromSqlRaw("SELECT * FROM FieldBooks WHERE BurialSiteID = {0} AND BurialNumber = {1}", v.BurialSiteId, v.BurialNumber).ToList();

            ViewBurialViewModel vbvm = new ViewBurialViewModel();
            vbvm.Burial = b;
            vbvm.BurialSite = bs;
            //vbvm.C14Data = c14Data;
            //vbvm.CranialMains = cranialMains;
            //vbvm.FieldBooks = fieldBooks;
            // add image urls

            return View(vbvm);
        }

        // ------------------------------ Restricted Section--------------------

        public IActionResult EditMummy(Burial b)
        {
            Console.WriteLine("were in the edit mummy now bois");

            return View("Index");
        }

        [HttpGet]
        public IActionResult AddFieldBook()
        {
            if (GlobalStatic.role == "No Role")
            {
                return View("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult AddFieldBook(AddFieldBookViewModel afbvm)
        {
            if (GlobalStatic.role == "No Role")
            {
                return View("Index");
            }

            //string burialSiteId = context
            //    .BurialSites
            //    .FromSqlRaw("SELECT * FROM BurialSite WHERE Ns = {0} AND NSTop = {1} AND Ew = {2} AND EWTop = {3} AND Quadrant = {4}", afbvm.NS, afbvm.Nstop, afbvm.EW, afbvm.Ewtop, afbvm.Quadrant)
            //    .ToList()
            //    .First()
            //    .BurialSiteId.ToString();

            //Burial b = context.Burials.Where(o => o.BurialSiteId == v.BurialSiteId).Where(p => p.BurialNumber == v.BurialNumber).ToList().First();
            string burialSiteId = context.BurialSites.Where(o => o.Ns == afbvm.NS).Where(o => o.Ew == afbvm.EW).Where(o => o.Nstop == afbvm.Nstop).Where(o => o.Ewtop == afbvm.Ewtop).Where(o => o.Quadrant == afbvm.Quadrant).ToList().First().BurialSiteId.ToString();

            //field book id
            int maxId = (int)context.FieldBooks.Max(o => o.FieldBooksId);
            int fieldBooksId = maxId + 1;

            FieldBook fieldBook = new FieldBook
            {
                FieldBooksId = fieldBooksId,
                BurialSiteId = Int32.Parse(burialSiteId),
                BurialNumber = afbvm.BurialNumber,
                FieldBook1 = afbvm.FieldBook1,
                FieldBookPageNumber = afbvm.FieldBookPageNumber
            };

            context.FieldBooks.Add(fieldBook);
            context.SaveChanges();

            return View("Index");
        }

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
            if (GlobalStatic.role == "No Role")
            {
                return View("Index");
            }



            Burial burial = new Burial
            {
                BurialSiteId = 8,
                BurialWestToHead = Int32.Parse(mummy.Burialwesttohead),
                BurialWestToFeet = Int32.Parse(mummy.Burialwesttofeet),
                BurialSouthToHead = Int32.Parse(mummy.Burialsouthtohead),
                BurialSouthToFeet = Int32.Parse(mummy.Burialsouthtofeet),
                BurialDepth = Int32.Parse(mummy.Burialdepth),
                Length = Int32.Parse(mummy.Length),
                Goods = mummy.Goods,
                YearOnSkull = Int32.Parse(mummy.Yearonskull),
                MonthOnSkull = mummy.Monthonskull,
                DateOnSkull = Int32.Parse(mummy.DateonSkull),
                InitialsOfDataEntryChecker = mummy.InitialsofDataEntryChecker,
                InitialsOfDataEntryExpert = mummy.InitialsofDataEntryExpert,
                ByuSample = mummy.Byusample,
                SkullAtMagazine = mummy.SkullatMagazine,
                PostcraniaAtMagazine = mummy.PostcraniaatMagazine,
                SexSkull = mummy.SexSkull2018,
                AgeSkull = mummy.AgeSkull2018,
                RackandShelf = mummy.RackandShelf,
                SkullTrauma = mummy.SkullTrauma,
                PostcraniaTrauma = mummy.PostcraniaTrauma,
                CribraOrbitala = mummy.CribraOrbitala,
                PoroticHyperostosis = mummy.PoroticHyperostosis,
                PoroticHyperostosisLocations = mummy.PoroticHyperostosis,
                MetopicSuture = mummy.MetopicSuture,
                Tmjoa = mummy.TemporalMandibularJointOsteoarthritisTmjoa,
                LinearHypoplasiaEnamel = mummy.LinearHypoplasiaEnamel,
                YearExcav = Int32.Parse(mummy.Yearexcav),
                MonthExcavated = mummy.MonthExcavated,
                DateExcavated = Int32.Parse(mummy.DateExcavated),
                BurialPreservation = mummy.Burialpreservation,
                BurialWrapping = mummy.Burialwrapping,
                BurialAdultChild = mummy.Burialadultchild,
                AgeCodeSingle = mummy.AgeCodeSingle,
                BurialDirection = mummy.BurialDirection,
                Burialageatdeath = mummy.Burialageatdeath,
                Burialagemethod = mummy.Burialagemethod,
                HairColorCode = mummy.HairColorCode,
                Burialsampletaken = mummy.Burialsampletaken,
                LengthM = Int32.Parse(mummy.LengthM),
                Cluster = mummy.Cluster,
                FaceBundle = mummy.FaceBundle,
                OsteologyNotes = mummy.OsteologyNotes
            };

            context.Burials.Add(burial);
            context.SaveChanges();

            return View("Index");
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
            if (Users.Count() < 1) {
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
