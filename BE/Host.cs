using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        long _HostKey;
        string _PrivateName;
        string _FamilyName;
        long _PhoneNumber;
        string _MailAddress;
        BankBranch _BankBranchDetails;
        int _BankAccountNumber;
        bool _CollectionClearance;
        
        #region Properties
        public long HostKey { get => _HostKey; set => value = _HostKey; }
        public string PrivateName { get => _PrivateName; set => value = _PrivateName; }
        public string FamilyName { get => _FamilyName; set => value = _FamilyName; }
        public long PhoneNumber { get => _PhoneNumber; set => value = _PhoneNumber; }
        public string MailAddress { get => _MailAddress; set => value = _MailAddress; }
        public BankBranch BankBranchDetails { get => _BankBranchDetails; set => value = _BankBranchDetails; }
        public int BankAccountNumber { get => _BankAccountNumber; set => value = _BankAccountNumber; }
        public bool CollectionClearance { get => _CollectionClearance; set => value = _CollectionClearance; }
        #endregion
        public override string ToString()

        { return this.ToStringProperty(); }
    }
}
