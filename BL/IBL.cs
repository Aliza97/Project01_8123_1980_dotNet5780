using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {
        void CheckValidityDate(); //entry date at least a day before the release date
        bool CheckBankAuthorization(BankBranch b); // if authorization to debit from the bankaccount..
        bool CheckFreeDate(); // check if the date of guestrequest are free for yehidat iruah
        void AfterCloseStatus(string Status);// can't chane anymore the status if close
        void IfChangeStatus(string Status); // if the status change , has to pay 10shkl per day


    }
}
