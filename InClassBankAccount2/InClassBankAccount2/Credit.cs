using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassBankAccount2
{
    public class Credit : Account
    {
        public Credit(string accNumber, string accName, decimal initialAmount)

        {
            base.accountNumber = accNumber;
            base.accountName = accName;
            base.Deposit(initialAmount);
            base.accountType = Acc_Type.Credit;


        }

    }
}
