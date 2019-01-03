using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HWF.Models;
using HWF.ViewModels;

namespace HWF.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MembersOnline()
        {
            var search = new Search()
            {
                ProfileName = "Profile 1",
                AgeMin = 18,
                AgeMax = 50,
                DistanceMax = 50,
                Seeking = "F"
            };
            var members = new List<MemberProfile>
            {
                new MemberProfile
                {
                    ID =2,
                    ProfileName ="Profile 2",
                    ProfileHeading ="Header for profile 2",
                    Her ="Straight",
                    City ="Tampa",
                    State ="FL",
                    Avatar ="Female-Avatar-3",
                    Country ="U.S.",
                    Seeking ="M"
                },
                new MemberProfile
                {
                    ID =3,
                    ProfileName ="Profile 3",
                    ProfileHeading ="Header for profile 3",
                    Her ="Straight",
                    City ="Tampa",
                    State ="FL",
                    Avatar ="Female-Avatar-2",
                    Country ="U.S.",
                    Seeking ="M"
                }
            };
            var veiwModel = new OnlineMembersViewModel
            {
                Search = search,    
                Members = members
            };
            return View(veiwModel);
        }
    }
}