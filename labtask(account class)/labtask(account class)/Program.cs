
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class account

    {
        string accName;
        int balance;
        int openingbalance;
        int tenureYear;
        int limit;
        public Account()
        {

        }
        public Account(string accName, int openingblance, int balance, int tenureYear, int limit)
        {
            this.accName = accName;
            this.openingbalance = openingblance;
            this.balance = balance;
            this.tenureYear = tenureYear;
            this.limit = limit;
        }
        public string AName
        {
            set { accName = value; }
            get { return accName; }
        }
        public int openingbalance
        {
            set { openingbalance = value; }
            get { return openingbalance; }
        }
        public int Balance
        {
            set { Balance = value; }
            get { return Balance; }
        }
        public int tenureYear
        {
            set { tenureYear = value; }
            get { return tenureYear; }
        }
        public int limit
        {
            set { limit = value; }
            get { return limit; }
        }


        public void deposit(int amount)
        {
            balance = balance + amount;
        }

        public void withdeaw(int amount)
        {
            balance = balance - amount;

        }

        public void Transfer(int amount,Account receiver)//Transfer amount from one account to another account
        {

        }
    }
}