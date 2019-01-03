using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HWF.Models;

namespace HWF.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            var member = new MemberProfile()
            {
                ID = 1,
                ProfileName = "test 1"
            };
            return View(member);
        }

        // GET: Member/Profile
        public new ActionResult Profile()
        {
            int IdNum = 0;
            string IdValue =(string)this.RouteData.Values["id"];
            bool success = Int32.TryParse(IdValue, out IdNum);
            var memberprofile = new MemberProfile()
            {
                ID = IdNum,
                ProfileName = "Profile 1",
                ProfileHeading = "Hi there.",
                Avatar = "Male-Avatar",
                City = "Tampa",
                State = "FL",
                Zip = 32145,    
                Country = "U.S.",
                Him = "straight",
                Seeking = "F"
            };
            return View(memberprofile);
        }
       
    }
}