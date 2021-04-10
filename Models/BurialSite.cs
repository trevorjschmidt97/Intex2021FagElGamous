using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class BurialSite
    {
        public long? BurialSiteId { get; set; }
        public string NS { get; set; }
        public long? Nstop { get; set; }
        public long? Nsbottom { get; set; }
        public string EW { get; set; }
        public long? Ewtop { get; set; }
        public long? Ewbottom { get; set; }
        public string Quadrant { get; set; }
    }
}
