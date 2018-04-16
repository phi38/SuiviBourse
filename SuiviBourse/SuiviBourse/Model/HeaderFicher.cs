using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviBourse.Model
{
    public class HeaderFiche
    {
        public string Code { get; set; }
        public string Place { get; set; }
        public string Codif { get; set; }
        public string ValorisationHeaderFiche { get; set; }
        public string VariationHeaderFiche { get; set; }
        public string JourHeaderFiche { get; set; }
        public string HeureSecondesHeaderFiche { get; set; }
        public string TweetHeaderFiche { get; set; }
    }

    public class RootObject
    {
        public HeaderFiche HeaderFiche { get; set; }
    }
}
