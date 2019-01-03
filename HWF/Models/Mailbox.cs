using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWF.Models
{
    public class Mailbox
    {
        public int ID{ get; set; }
        public int NumberOfMessages{ get; set; }
        public int NumberOfNewMessages{ get; set; }
    }

    public class MailMessage
    {
        public int to { get; set; }
        public int from { get; set; }
        public string subject { get; set; }
        public string body{ get; set; }
    }
}