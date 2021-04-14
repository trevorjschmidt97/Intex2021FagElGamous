using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class BurialSite
    {
        public int BurialSiteId { get; set; }
        public string Ew { get; set; }
        public int? Ewbottom { get; set; }
        public int? Ewtop { get; set; }
        public string Ns { get; set; }
        public int? Nsbottom { get; set; }
        public int? Nstop { get; set; }
        public string Quadrant { get; set; }
    }
}
