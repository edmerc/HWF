using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWF.Models
{
    public class MemberProfile
    {
        public int ID { get; set; }
        public string ProfileName { get; set; }
        public string ProfileHeading { get; set; }
        public string Avatar { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
        public string Her { get; set; }
        public string Him { get; set; }
        public string Seeking { get; set; }
    }

    public class MemberFullProfile
    {
        public int ID { get; set; }
        public string ProfileName { get; set; }
        public string ProfileHeading { get; set; }
        public string Avatar { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
        public string Her { get; set; }
        public string Him { get; set; }
        public string Seeking { get; set; }
        public int AccountStatus { get; set; }
        public bool IsActive { get; set; }
        public bool SasFriends{ get; set; }
    }
}