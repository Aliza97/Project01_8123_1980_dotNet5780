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

        public long HostKey;
        public string PrivateName;
        public string FamilyName;
        public long PhoneNumber;
        public string MailAddress;
        public BankBranch BankBranchDetails;
        public int BankAccountNumber;
        public bool CollectionClearance;


        #endregion
        public override string ToString()

        { return this.ToStringProperty(); }
    }
}
