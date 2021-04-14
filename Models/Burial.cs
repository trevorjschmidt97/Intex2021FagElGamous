using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class Burial
    {
        public int BurialKeyId { get; set; }
        public int? Gamous { get; set; }
        public int? BurialSiteId { get; set; }
        public int? BurialNumber { get; set; }
        public double? BurialWestToHead { get; set; }
        public double? BurialWestToFeet { get; set; }
        public double? BurialSouthToHead { get; set; }
        public double? BurialSouthToFeet { get; set; }
        public double? BurialDepth { get; set; }
        public double? Length { get; set; }
        public string Goods { get; set; }
        public int? YearOnSkull { get; set; }
        public string MonthOnSkull { get; set; }
        public int? DateOnSkull { get; set; }
        public string InitialsOfDataEntryExpert { get; set; }
        public string InitialsOfDataEntryChecker { get; set; }
        public string ByuSample { get; set; }
        public int? BodyAnalysis { get; set; }
        public string SkullAtMagazine { get; set; }
        public string PostcraniaAtMagazine { get; set; }
        public string SexSkull { get; set; }
        public string AgeSkull { get; set; }
        public string RackandShelf { get; set; }
        public string SkullTrauma { get; set; }
        public string PostcraniaTrauma { get; set; }
        public string CribraOrbitala { get; set; }
        public string PoroticHyperostosis { get; set; }
        public string PoroticHyperostosisLocations { get; set; }
        public string MetopicSuture { get; set; }
        public string Tmjoa { get; set; }
        public string LinearHypoplasiaEnamel { get; set; }
        public int? YearExcav { get; set; }
        public string MonthExcavated { get; set; }
        public int? DateExcavated { get; set; }
        public string BurialPreservation { get; set; }
        public string BurialWrapping { get; set; }
        public string BurialAdultChild { get; set; }
        public string GenderCode { get; set; }
        public string AgeCodeSingle { get; set; }
        public string BurialDirection { get; set; }
        public string Burialageatdeath { get; set; }
        public string Burialagemethod { get; set; }
        public string HairColorCode { get; set; }
        public string Burialsampletaken { get; set; }
        public double? LengthM { get; set; }
        public string Cluster { get; set; }
        public string FaceBundle { get; set; }
        public string ImagesYn { get; set; }
        public string OsteologyNotes { get; set; }
    }
}
