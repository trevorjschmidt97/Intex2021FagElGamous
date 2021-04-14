using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class C14datum
    {
        public int C14id { get; set; }
        public int? BurialSiteId { get; set; }
        public int? BurialNumber { get; set; }
        public int? Rack { get; set; }
        public int? Area { get; set; }
        public int? Tubenum { get; set; }
        public string Description { get; set; }
        public int? SizeMl { get; set; }
        public int? Foci { get; set; }
        public int? C14sample2017 { get; set; }
        public string LocationNotes { get; set; }
        public string Questions { get; set; }
        public int? QuestionsConventional114cAgeBp { get; set; }
        public int? _14cCalendarDate { get; set; }
        public int? Calibrated95CalendarDateMax { get; set; }
        public int? Calibrated95CalendarDateMin { get; set; }
        public int? Calibrated95CalendarDateSpan { get; set; }
        public string Calibrated95CalendarDateAvg { get; set; }
        public string Category { get; set; }
        public string Notes { get; set; }
    }
}
