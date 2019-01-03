using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWF.Models
{
    public class Search
    {
        public string ProfileName { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public int DistanceMax { get; set; }
        public string Seeking { get; set; }
    }
}