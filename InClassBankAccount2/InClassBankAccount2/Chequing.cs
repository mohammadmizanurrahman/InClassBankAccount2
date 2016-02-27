using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassBankAccount2
{
    public class Chequing : Account
    {
        public Chequing(string accNumber, string accName, decimal initialAmount)

        {
            base.accountNumber = accNumber;
            base.accountName = accName;
            base.Deposit(initialAmount);
            base.accountType = Acc_Type.Chequing;


        }


        public override bool Withdrawal(decimal amount)
        {
            if (amount > 0)
            {
                if ((balance - amount) >= -500)
                {
                    balance -= amount;
                    return true;
                }

            }
            return false;
        }




    }

}
