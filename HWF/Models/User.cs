using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWF.Models
{
    public class User
    {
        public int ID { get; set; }
        public Boolean isLoggedIn { get; set; }
        public int AccessLevel { get; set; }
    }
}