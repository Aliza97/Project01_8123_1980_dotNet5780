using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE

{
    public static class MyEnums
    {
        public enum StatusRequest { NotYetAdressed = 1, MailHasBeenSent, Accepted, Refused, Active };
        public enum Area { North = 1, South, Center, Jerusalem }
        public enum Type { Zimmer = 1, HotelRoom, Camping, Appartment }
        public enum Status { TransactionOpen = 1, MailHasBeenSent, TransactionClosedThroughTheSite, Closed, WasclosedBecauseExpired, NotRelevent }
        public enum Pool { Necessary = 1, Possible, Uninterested }
        public enum Jacuzzi { Necessary = 1, Possible, Uninterested }
        public enum Garden { Necessary = 1, Possible, Uninterested }
        public enum ChildrenAttractions { Necessary = 1, Possible, Uninterested }
        public enum CollectionClearance { Yes = 1, No }
    }
}

