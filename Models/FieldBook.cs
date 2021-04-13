using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class FieldBook
    {
        [Key]
        public long? FieldBooksId { get; set; }

        public long? BurialSiteId { get; set; }
        public long? BurialNumber { get; set; }
        public string FieldBook1 { get; set; }
        public long? FieldBookPageNumber { get; set; }
    }
}
