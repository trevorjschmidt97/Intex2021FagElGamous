using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class BiologicalSample
    {
        public int BioSampleId { get; set; }
        public string RackBag { get; set; }
        public int? RackBagNum { get; set; }
        public int? BurialSiteId { get; set; }
        public int? Burial { get; set; }
        public string Date { get; set; }
        public string PreviouslySampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }
        public int? Cluster { get; set; }
    }
}
