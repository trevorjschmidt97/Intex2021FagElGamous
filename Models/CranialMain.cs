using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class CranialMain
    {
        public long? BurialSiteId { get; set; }
        public long? BurialNumber { get; set; }
        public long? SampleNumber { get; set; }
        public double? MaximumCranialLength { get; set; }
        public double? MaximumCranialBreadth { get; set; }
        public double? BasionBregmaHeight { get; set; }
        public double? BasionNasion { get; set; }
        public double? BasionProsthionLength { get; set; }
        public double? BizygomaticDiameter { get; set; }
        public double? NasionProsthion { get; set; }
        public double? MaximumNasalBreadth { get; set; }
        public double? InterorbitalBreadth { get; set; }
        public double? BurialDepth { get; set; }
        public string BurialArtifactDescription { get; set; }
        public string BuriedwithArtifacts { get; set; }
        public string GilesGender { get; set; }
        public string BodyGender { get; set; }
    }
}
