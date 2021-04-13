using System;
namespace Intex2021FagElGamous.ViewModels
{
    public class AddFieldBookViewModel
    {
        //public long? FieldBooksId { get; set; }
        //public long? BurialSiteId { get; set; }
        public string NS { get; set; }
        public string EW { get; set; }
        public int NSTop { get; set; }
        public int EWTop { get; set; }
        public string Quadrant { get; set; }
        public long? BurialNumber { get; set; }
        public string FieldBook1 { get; set; }
        public long? FieldBookPageNumber { get; set; }
    }
}
