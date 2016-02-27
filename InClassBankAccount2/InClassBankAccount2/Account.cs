using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassBankAccount2
{
    public abstract class Account
    {

        protected decimal balance;
        protected Acc_Type accountType;
        protected string accountNumber;
        protected string accountName;

        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return true;
            }

            return false;
        }



        public virtual bool Withdrawal(decimal amount)
        {
            if (amount > 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    return true;
                }

            }

            return false;
        }




        public decimal BalanceCheck()
        {

            return balance;
        }

    }


}
