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
        private int pageSize { get; set; } = 10;

        private static ViewBurialViewModel? MummyToDelete { get; set; }

        //set to true when we want to edit a mummy
        private static bool FromEdit { get; set; } = false;

        private static List<Burial> GlobalBurials { get; set; }

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
            GlobalBurials = context.Burials.ToList();
            
            return View();
        }

        //OrderByDescending(o => o.FieldBooksId).ToList();


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
                TotalNumItems = (GlobalBurials.Count())
            };

            viewModel.PageNumberingInfo = pageNumber;

            viewModel.Filter = new ViewBurialsFilteringInfo();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ViewBurials(ViewBurialsViewModel vbvm, int pageNum = 1)
        {
            ViewBurialsViewModel viewModel = new ViewBurialsViewModel();

            // Create a list of burials,
            // but not the normal ones, just with the info we want to see
            List<ViewBurialsBurialModel> vbbmList = new List<ViewBurialsBurialModel>();

            // filter the global burials
            List<Burial> newBurials = new List<Burial>();

            foreach (Burial bur in context.Burials.ToList())
            {
                // get burial site info
                string NS = context
                    .BurialSites
                    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", bur.BurialSiteId).ToList().First().NS.ToString();

                int NSTop = (int)context
                    .BurialSites
                    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", bur.BurialSiteId).ToList().First().Nstop;

                int NSBottom = NSTop + 10;

                string EW = context
                    .BurialSites
                    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", bur.BurialSiteId).ToList().First().EW.ToString();

                int EWTop = (int)context
                    .BurialSites
                    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", bur.BurialSiteId).ToList().First().Ewtop;

                int EWBottom = EWTop + 10;

                string Quadrant = context
                    .BurialSites
                    .FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", bur.BurialSiteId).ToList().First().Quadrant.ToString();


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
                if (bur.Burialwesttohead != null)
                {
                    // we are allowed to cast to double
                    double wth = Convert.ToDouble(bur.Burialwesttohead);

                    if (wth < vbvm.Filter.BurialwesttoheadMin || wth > vbvm.Filter.BurialwesttoheadMax)
                    {
                        continue;
                    }

                }
                //else
                //{
                //    continue;
                //}

                //west to feet
                if (bur.Burialwesttofeet != null)
                {
                    // we are allowed to cast to double
                    double wtf = Convert.ToDouble(bur.Burialwesttofeet);

                    if (wtf < vbvm.Filter.BurialwesttofeetMin || wtf > vbvm.Filter.BurialwesttofeetMax)
                    {
                        continue;
                    }

                }
                //else
                //{
                //    continue;
                //}

                //south to head
                if (bur.Burialsouthtohead != null)
                {
                    // we are allowed to cast to double
                    double sth = Convert.ToDouble(bur.Burialsouthtohead);

                    if (sth < vbvm.Filter.BurialsouthtoheadMin || sth > vbvm.Filter.BurialsouthtoheadMax)
                    {
                        continue;
                    }

                }
                //else
                //{
                //    continue;
                //}

                //south to feet
                if (bur.Burialsouthtofeet != null)
                {
                    // we are allowed to cast to double
                    double stf = Convert.ToDouble(bur.Burialsouthtofeet);

                    if (stf < vbvm.Filter.BurialsouthtofeetMin || stf > vbvm.Filter.BurialsouthtofeetMax)
                    {
                        continue;
                    }

                }
                //else
                //{
                //    continue;
                //}

                //depth
                if (bur.Burialdepth != null)
                {
                    // we are allowed to cast to double
                    double d = Convert.ToDouble(bur.Burialdepth);

                    if (d < vbvm.Filter.BurialdepthMin || d > vbvm.Filter.BurialdepthMax)
                    {
                        continue;
                    }

                }
                //else
                //{
                //    continue;
                //}

                //year on skull
                if (bur.Yearonskull != null)
                {
                    // we are allowed to cast to double
                    int d = int.Parse(bur.Yearonskull);

                    if (d < vbvm.Filter.YearonskullMin || d > vbvm.Filter.YearonskullMax)
                    {
                        continue;
                    }

                }

                // goods
                if (vbvm.Filter.Goods == "All")
                {
                    // include everything
                }
                else if (vbvm.Filter.Goods != bur.Goods)
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
                else if (vbvm.Filter.Byusample != bur.Byusample)
                {
                    continue;
                }

                // body analysis
                if (vbvm.Filter.BodyAnalysis == "All")
                {
                    // include everything
                }
                else if (vbvm.Filter.BodyAnalysis != bur.BodyAnalysis)
                {
                    continue;
                }

                // skullmagazine
                if (vbvm.Filter.SkullatMagazine == "All")
                {
                    // include everything
                }
                else if (vbvm.Filter.SkullatMagazine != bur.SkullatMagazine)
                {
                    continue;
                }

                // skull age
                if (vbvm.Filter.AgeSkull2018 == "All")
                {
                    // include everything
                }
                else if (vbvm.Filter.AgeSkull2018 != bur.AgeSkull2018)
                {
                    continue;
                }

                // skull sex
                if (vbvm.Filter.SexSkull2018 == "All")
                {
                    // include everything
                }
                else if (vbvm.Filter.SexSkull2018 != bur.SexSkull2018)
                {
                    continue;
                }


                newBurials.Add(bur);
            }

            GlobalBurials = newBurials;

            List<Burial> Burials = GlobalBurials
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .OrderBy(o => o.BurialSiteId)
                    .ToList();

            // for each burial in our db
            foreach (Burial b in Burials)
            {
                // get burial site info
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

            viewModel.Filter = vbvm.Filter;

            return View(viewModel);
        }

        public IActionResult ViewMummy(ViewBurialsBurialModel v)
        {
            // This is the burial we are looking at
            Burial b = context.Burials.FromSqlRaw("SELECT * FROM Burial WHERE BurialSiteId = {0} AND BurialNumber = {1}", v.BurialSiteId, v.BurialNumber).ToList().First();

            BurialSite bs = context.BurialSites.FromSqlRaw("SELECT * FROM BurialSite WHERE BurialSiteId = {0}", v.BurialSiteId).ToList().First();

            List<CranialMain> cranialMains = context.CranialMains.FromSqlRaw("SELECT * FROM CranialMain WHERE BurialSiteId = {0} AND BurialNumber = {1}", v.BurialSiteId, v.BurialNumber).ToList();
            List<C14datum> c14Data = context.C14data.FromSqlRaw("SELECT * FROM C14Data WHERE BurialSiteId = {0} AND \"Burial#\" = {1}", v.BurialSiteId, v.BurialNumber).ToList();
            List<FieldBook> fieldBooks = context.FieldBooks.FromSqlRaw("SELECT * FROM FieldBooks WHERE BurialSiteID = {0} AND BurialNumber = {1}", v.BurialSiteId, v.BurialNumber).ToList();

            ViewBurialViewModel vbvm = new ViewBurialViewModel();
            vbvm.Burial = b;
            vbvm.BurialSite = bs;
            vbvm.C14Data = c14Data;
            vbvm.CranialMains = cranialMains;
            vbvm.FieldBooks = fieldBooks;
            // add image urls

            return View(vbvm);
        }

        // ------------------------------ Restricted Section--------------------

        //edit quote allows for users to edit the quote and copies the quote they want to edit
        public IActionResult EditMummy(ViewBurialViewModel mummy)
        {
            //Console.WriteLine(mummy.BurialSite);
            
            ////Console.WriteLine(mummy.BurialSite.NS);



            //FromEdit = true;
            //MummyToDelete = mummy;
            //Console.WriteLine(MummyToDelete);

            //AddMummyViewModel newMummy = new AddMummyViewModel();

            //Console.WriteLine(mummy.BurialSite.NS);
            //newMummy.NS = mummy.BurialSite.NS;
            //newMummy.Nstop = mummy.BurialSite.Nstop;
            //newMummy.EW = mummy.BurialSite.EW;
            //newMummy.Ewtop = mummy.BurialSite.Ewtop;
            //newMummy.Quadrant = mummy.BurialSite.Quadrant;
            //newMummy.BurialNumber = mummy.Burial.BurialNumber;
            //newMummy.Burialwesttofeet = mummy.Burial.Burialwesttofeet;
            //newMummy.Burialwesttohead = mummy.Burial.Burialwesttohead;
            //newMummy.Burialsouthtofeet = mummy.Burial.Burialsouthtofeet;
            //newMummy.Burialsouthtohead = mummy.Burial.Burialsouthtohead;
            //newMummy.Burialdepth = mummy.Burial.Burialdepth;
            //newMummy.Length = mummy.Burial.Length;
            //newMummy.Goods = mummy.Burial.Goods;
            //newMummy.Yearonskull = mummy.Burial.Yearonskull;
            //newMummy.Monthonskull = mummy.Burial.Monthonskull;
            //newMummy.DateonSkull = mummy.Burial.DateonSkull;
            //newMummy.InitialsofDataEntryChecker = mummy.Burial.InitialsofDataEntryChecker;
            //newMummy.InitialsofDataEntryExpert = mummy.Burial.InitialsofDataEntryExpert;
            //newMummy.Byusample = mummy.Burial.Byusample;
            //newMummy.BodyAnalysis = mummy.Burial.BodyAnalysis;
            //newMummy.SkullatMagazine = mummy.Burial.SkullatMagazine;
            //newMummy.PostcraniaatMagazine = mummy.Burial.PostcraniaatMagazine;
            //newMummy.SexSkull2018 = mummy.Burial.SexSkull2018;
            //newMummy.AgeSkull2018 = mummy.Burial.AgeSkull2018;
            //newMummy.RackandShelf = mummy.Burial.RackandShelf;
            //newMummy.Tobeconfirmed = mummy.Burial.Tobeconfirmed;
            //newMummy.SkullTrauma = mummy.Burial.SkullTrauma;
            //newMummy.PostcraniaTrauma = mummy.Burial.PostcraniaTrauma;
            //newMummy.CribraOrbitala = mummy.Burial.CribraOrbitala;
            //newMummy.PoroticHyperostosis = mummy.Burial.PoroticHyperostosis;
            //newMummy.PoroticHyperostosisLocations = mummy.Burial.PoroticHyperostosisLocations;
            //newMummy.MetopicSuture = mummy.Burial.MetopicSuture;
            //newMummy.ButtonOsteoma = mummy.Burial.ButtonOsteoma;
            //newMummy.Osteologyunknowncomment = mummy.Burial.Osteologyunknowncomment;
            //newMummy.TemporalMandibularJointOsteoarthritisTmjoa = mummy.Burial.TemporalMandibularJointOsteoarthritisTmjoa;
            //newMummy.LinearHypoplasiaEnamel = mummy.Burial.LinearHypoplasiaEnamel;
            //newMummy.Yearexcav = mummy.Burial.Yearexcav;
            //newMummy.MonthExcavated = mummy.Burial.MonthExcavated;
            //newMummy.DateExcavated = mummy.Burial.DateExcavated;
            //newMummy.Burialpreservation = mummy.Burial.Burialpreservation;
            //newMummy.Burialwrapping = mummy.Burial.Burialwrapping;
            //newMummy.Burialadultchild = mummy.Burial.Burialadultchild;
            //newMummy.Burialgendermethod = mummy.Burial.Burialgendermethod;
            //newMummy.AgeCodeSingle = mummy.Burial.AgeCodeSingle;
            //newMummy.BurialDirection = mummy.Burial.BurialDirection;
            //newMummy.Burialagemethod = mummy.Burial.Burialagemethod;
            //newMummy.Burialageatdeath = mummy.Burial.Burialageatdeath;
            //newMummy.HairColorCode = mummy.Burial.HairColorCode;
            //newMummy.Burialsampletaken = mummy.Burial.Burialsampletaken;
            //newMummy.LengthM = mummy.Burial.LengthM;
            //newMummy.Cluster = mummy.Burial.Cluster;
            //newMummy.FaceBundle = mummy.Burial.FaceBundle;
            //newMummy.OsteologyNotes = mummy.Burial.OsteologyNotes;

            return View("Index");
            //return View("AddBurial", newMummy);
        }

        [HttpGet]        public IActionResult AddBiologicalSite()        {            if (GlobalStatic.role == "No Role")            {                return View("Index");            }            return View();        }        [HttpPost]        public IActionResult AddBiologicalSite(AddBiologicalViewModel biologicalsample)        {
            //context.Add.Add(mummy);

            //context.SaveChanges();
            return View();        }


        public IActionResult C14data()        {            if (GlobalStatic.role == "No Role")            {                return View("Index");            }            return View();        }        [HttpPost]        public IActionResult C14data(C14datum cdatum)        {
            //context.Add.Add(mummy);

            //context.SaveChanges();
            return View();        }



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

            string burialSiteId = context
                .BurialSites
                .FromSqlRaw("SELECT * FROM BurialSite WHERE [N/S] = {0} AND NSTop = {1} AND [E/W] = {2} AND EWTop = {3} AND Quadrant = {4}", afbvm.NS, afbvm.Nstop, afbvm.EW, afbvm.Ewtop, afbvm.Quadrant)
                .ToList()
                .First()
                .BurialSiteId.ToString();

            //field book id
            int maxId = (int)context.FieldBooks.Max(o => o.FieldBooksId);
            int fieldBooksId = maxId + 1;

            FieldBook fieldBook = new FieldBook
            {
                FieldBooksId = fieldBooksId,
                BurialSiteId = Convert.ToInt64(burialSiteId),
                BurialNumber = afbvm.BurialNumber,
                FieldBook1 = afbvm.FieldBook1,
                FieldBookPageNumber = afbvm.FieldBookPageNumber
            };

            context.FieldBooks.Add(fieldBook);
            context.SaveChanges();

            return View();
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

            Console.WriteLine(mummy.NS);
            Console.WriteLine(mummy.Nstop);
            Console.WriteLine(mummy.EW);
            Console.WriteLine(mummy.Ewtop);
            Console.WriteLine(mummy.Quadrant);

            string burialSiteId = context
               .BurialSites
               .FromSqlRaw("SELECT * FROM BurialSite WHERE [N/S] = {0} AND [NSTop] = {1} AND [E/W] = {2} AND EWTop = {3} AND Quadrant = {4}", mummy.NS, mummy.Nstop, mummy.EW, mummy.Ewtop, mummy.Quadrant)
               .ToList()
               .First()
               .BurialSiteId.ToString();


            int maxId = (int)context.Burials.Max(o => o.BurialKeyID);
            int BurialKeyID = maxId + 1;

            Burial burial = new Burial
            {
                BurialKeyID = BurialKeyID,
                BurialSiteId = Convert.ToInt64(burialSiteId),
                BurialNumber = mummy.BurialNumber,
                Burialwesttohead = mummy.Burialwesttohead,
                Burialwesttofeet = mummy.Burialwesttofeet,
                Burialsouthtohead = mummy.Burialsouthtohead,
                Burialsouthtofeet = mummy.Burialsouthtofeet,
                Burialdepth = mummy.Burialdepth,
                Length = mummy.Length,
                Goods = mummy.Goods,
                Yearonskull = mummy.Yearonskull,
                Monthonskull = mummy.Monthonskull,
                DateonSkull = mummy.DateonSkull,
                InitialsofDataEntryChecker = mummy.InitialsofDataEntryChecker,
                InitialsofDataEntryExpert = mummy.InitialsofDataEntryExpert,
                Byusample = mummy.Byusample,
                BodyAnalysis = mummy.BodyAnalysis,
                SkullatMagazine = mummy.SkullatMagazine,
                PostcraniaatMagazine = mummy.PostcraniaatMagazine,
                SexSkull2018 = mummy.SexSkull2018,
                AgeSkull2018 = mummy.AgeSkull2018,
                RackandShelf = mummy.RackandShelf,
                Tobeconfirmed = mummy.Tobeconfirmed,
                SkullTrauma = mummy.SkullTrauma,
                PostcraniaTrauma = mummy.PostcraniaTrauma,
                CribraOrbitala = mummy.CribraOrbitala,
                PoroticHyperostosis = mummy.PoroticHyperostosis,
                PoroticHyperostosisLocations = mummy.PoroticHyperostosis,
                MetopicSuture = mummy.MetopicSuture,
                ButtonOsteoma = mummy.ButtonOsteoma,
                TemporalMandibularJointOsteoarthritisTmjoa = mummy.TemporalMandibularJointOsteoarthritisTmjoa,
                LinearHypoplasiaEnamel = mummy.LinearHypoplasiaEnamel,
                Yearexcav = mummy.Yearexcav,
                MonthExcavated = mummy.MonthExcavated,
                DateExcavated = mummy.DateExcavated,
                Burialpreservation = mummy.Burialpreservation,
                Burialwrapping = mummy.Burialwrapping,
                Burialadultchild = mummy.Burialadultchild,
                Burialgendermethod = mummy.Burialgendermethod,
                AgeCodeSingle = mummy.AgeCodeSingle,
                BurialDirection = mummy.BurialDirection,
                Burialageatdeath = mummy.Burialageatdeath,
                Burialagemethod = mummy.Burialagemethod,
                HairColorCode = mummy.HairColorCode,
                Burialsampletaken = mummy.Burialsampletaken,
                LengthM = mummy.LengthM,
                Cluster = mummy.Cluster,
                FaceBundle = mummy.FaceBundle,
                OsteologyNotes = mummy.OsteologyNotes
            };

            context.Burials.Add(burial);
            context.SaveChanges();

            return View("ViewBurials");
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

            Console.WriteLine(u.Email);

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
