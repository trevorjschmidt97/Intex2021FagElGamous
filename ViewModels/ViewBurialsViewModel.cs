using System;
using System.Collections.Generic;
using Intex2021FagElGamous.Models.ViewModels;

namespace Intex2021FagElGamous.Models
{

    public class ViewBurialsViewModel
    {
        public List<ViewBurialsBurialModel> Burials { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }

        // Insert Filter model here too

    }

    public class ViewBurialsBurialModel
    {
        public string NS { get; set; }
        public int NSTop { get; set; }
        public int NSBottom { get; set; }
        public string EW { get; set; }
        public int EWTop { get; set; }
        public int EWBottom { get; set; }
        public string Quadrant { get; set; }
        public string Burialwesttohead { get; set; }
        public string Burialwesttofeet { get; set; }
        public string Burialsouthtohead { get; set; }
        public string Burialsouthtofeet { get; set; }
        public string Burialdepth { get; set; }
        public string Length { get; set; }
        public string Goods { get; set; }
        public string GenderCode { get; set; }
        public int BurialSiteId { get; set; }
        public int BurialNumber { get; set; }
        public string OsteologyNotes { get; set; }
    }

    public class ViewBurialsFilterModel
    {
        public string NS { get; set; }
        public int NSTop { get; set; }
        public int NSBottom { get; set; }
        public string EW { get; set; }
        public int EWTop { get; set; }
        public int EWBottom { get; set; }
        public string Quadrant { get; set; }

        public string Hair { get; set; }
        // continue with all the different things that they could filter on
    }
}