using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassBankAccount2
{
    public enum Acc_Type
    {

        Saving,
        Chequing,
        Credit
    }

    class Program
    {
        static void Main(string[] args)
        {
            //

            Saving Sv1 = new Saving("001", "Sette", 300.00m);
            Chequing Chq1 = new Chequing("001", "Mizan", 200.00m);
            Credit Cr1 = new Credit("001", "Dave", 400.00m);
            Chq1.Deposit(400);

            Sv1.Deposit(200);
            Cr1.Deposit(100);

            if (Sv1.Withdrawal(600.00m))
            {
                Console.WriteLine("Withdrawal From Saving Success");
            }
            else
            {
                Console.WriteLine("Withdrawal From Saving Fail");
            }

            if (Sv1.Withdrawal(200.00m))
            {
                Console.WriteLine("Withdrawal From Saving Success ");
            }
            else
            {
                Console.WriteLine("Withdrawal From Saving Fail");


            }




            if (Chq1.Withdrawal(900.00m))
            {
                Console.WriteLine("Withdrawal From Chequing Success");
            }
            else
            {
                Console.WriteLine("Withdrawal From Chequing Fail");
            }



            if (Chq1.Withdrawal(400.00m))
            {
                Console.WriteLine("Withdrawal From Chequing Success ");
            }
            else
            {
                Console.WriteLine("Withdrawal From Chequing Fail");


            }



            Console.WriteLine("Balance of Saving Account: " + Sv1.BalanceCheck());
            Console.WriteLine("Balance of Chequing Account: " + Chq1.BalanceCheck());
            Console.WriteLine("Balance of Credit Account: " + Cr1.BalanceCheck());
            Console.ReadLine();





        }
    }

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




    public class Saving : Account
    {
        public Saving(string accNumber, string accName, decimal initialAmount)

        {
            base.accountNumber = accNumber;
            base.accountName = accName;
            base.Deposit(initialAmount);
            base.accountType = Acc_Type.Saving;


        }

    }




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
