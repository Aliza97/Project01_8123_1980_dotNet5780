using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BankBranch
    {
        int _BankNumber;
        string _BankName;
        int _BranchNumber;
        string _BranchAdress;
        string _BranchCity;

        #region Properties
        public int BankNumber { get => _BankNumber; set => value = _BankNumber; }
        public string BankName { get => _BankName; set => value = _BankName; }
        public int BranchNumber { get => _BranchNumber; set => value = _BranchNumber; }
        public string BranchAdress { get => _BranchAdress; set => value = _BranchAdress; }
        public string BranchCity { get => _BranchCity; set => value = _BranchCity; }


        #endregion
        public override string ToString()

        { return this.ToStringProperty(); }
    }
}
