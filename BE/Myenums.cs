using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    
        public enum Status { NotYetAdressed = 1, MailHasBeenSent, Accepted, Refused };
        public enum Area { North = 1, South, Center, Jerusalem }
        public enum Type { Zimmer = 1, HotelRoom, Camping, Appartment }
        public enum StatusRequest { TransactionOpen = 1, TransactionClosedThroughTheSite, WasclosedBecauseExpired }
   
}
