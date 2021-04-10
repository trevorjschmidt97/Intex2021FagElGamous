using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class BiologicalSample
    {
        public long? BioSampleId { get; set; }
        public string RackBag { get; set; }
        public long? RackBagNum { get; set; }
        public long? BurialSiteId { get; set; }
        public long? Burial { get; set; }
        public string Date { get; set; }
        public string PreviouslySampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }
        public string Cluster { get; set; }
    }
}
