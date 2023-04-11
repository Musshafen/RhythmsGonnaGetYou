using System.Collections.Generic;

namespace RhythmsGonnaGetYou
{
    public class Bands
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public int NumberOfMembers { get; set; }
        public string Website { get; set; }
        public string Genre { get; set; }
        public bool IsSigned { get; set; }
        public string ContactName { get; set; }

        public List<Albums> Albums { get; set;}
    }
}