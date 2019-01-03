using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HWF.Models;

namespace HWF.Controllers
{
    public class MailboxController : Controller
    {
        // GET: Mailbox
        public ActionResult Index()
        {
            var mailbox = new Mailbox()
            {
                ID = 1,
                NumberOfMessages = 1,
                NumberOfNewMessages = 1
            };

            return View(mailbox);
        }
         public ActionResult MailboxMessage()
        {
            var message = new MailMessage()
            {
                to = 1,
                from = 2,
                subject = "Hello.  This is a hard-coded test.",
                body = "This is a test of the mailbox system."
            };
            return View(message);
        }
    }
}