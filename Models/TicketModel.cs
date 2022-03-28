using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dmf.Helpdesk.Models
{
    public class TicketModel
    {
        public string TicketNo
        {
            get;
            set;
        }

        public DateTime DateCreated
        {
            get;
            set;
        }

        public DateTime DateModified
        {
            get;
            set;
        }

        public string RequesterUsername
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }
    }
}
