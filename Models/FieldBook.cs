﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class FieldBook
    {
        public int FieldBooksId { get; set; }
        public int? BurialSiteId { get; set; }
        public int? BurialNumber { get; set; }
        public string FieldBook1 { get; set; }
        public string FieldBookPageNumber { get; set; }
    }
}
