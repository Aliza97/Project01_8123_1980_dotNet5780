using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        #region Properties
        public long HostKey { get ; set ; }
        public string PrivateName { get ; set ; }
        public string FamilyName { get ; set ; }
        public long PhoneNumber { get ; set; }
        public string MailAddress { get; set; }
        public BankBranch BankBranchDetails { get ; set; }
        public int BankAccountNumber { get; set; }
        public bool CollectionClearance { get ; set; }
        #endregion
        public override string ToString()

        { return this.ToStringProperty(); }
    }
}
