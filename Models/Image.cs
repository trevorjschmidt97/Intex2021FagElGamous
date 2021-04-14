using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public int? BurialSiteId { get; set; }
        public int? BurialNumber { get; set; }
        public string Url { get; set; }
    }
}
