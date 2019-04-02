using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClient
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        
        public double Balance
        {
            get { return balance ; }
            set { balance = value; }
        }

        public void Deposit(int id,double ammount)
        {
            this.balance += ammount;
        }

        public void Withdraw(double ammount)
        {
            this.balance -= ammount;
        }

        public override string ToString()
        {
            return "Account " + id + " Balance " + balance;
        }

    }
}
