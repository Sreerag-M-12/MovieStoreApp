using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem.Models
{
    internal class BankAccount
    {
        static int MINIMUM_BALANCE = 500;

        private int _accountNumber;
        private string _accountName;
        private int _balance;


        public int AccountNumber
        {
            set { _accountNumber = value; }
            get { return _accountNumber; }
        }
        public string Name
        {
            set { _accountName = value; }
            get { return _accountName; }
        }

        public int Balance
        {
            set
            {
                if (value < MINIMUM_BALANCE)
                    _balance = MINIMUM_BALANCE;
                else
                    _balance = value;
            }
            get { return _balance; }
        }

        public BankAccount(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = MINIMUM_BALANCE;
        }

        public BankAccount(int accountNumber, string name, int balance)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
        }


        public override string ToString()
        {
            Console.WriteLine($"=========Account No {AccountNumber}===========");
            Console.WriteLine($"Bank Account no: {AccountNumber}");
            Console.WriteLine($"User Name no: {Name}");
            Console.WriteLine($"Bank Balance : {Balance}");
            Console.WriteLine("==================================");
            return " ";
        }


        public bool WithDrawMoney(int money)
        {
            if (Balance - money < MINIMUM_BALANCE)
                return false;

            Balance -= money;
            return true;
        }

        public bool DepositMoney(int money)
        {
            Balance = Balance + money;
            return true;
        }

        public static BankAccount AccountWithMaxBalance(BankAccount[] account)
        {
            double maxBalance = 0;
            int temp = 0;
            for (int i = 0; i < account.Length; i++)
            {
                if (account[i].Balance > maxBalance)
                    maxBalance = account[i].Balance;
                temp = i;
            }

            return account[temp];

        }

        
    }
}
