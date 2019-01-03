using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HWF.Models;

namespace HWF.ViewModels
{
    public class OnlineMembersViewModel
    {
        public Search Search { get; set;}
        public List<MemberProfile> Members { get; set;}
    }
}