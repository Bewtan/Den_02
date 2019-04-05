using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banker
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
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double ammount)
        {
            this.balance += ammount;
        }

        public void Withdraw(double ammount)
        {
            this.balance -= ammount;
        }

        public override string ToString()
        {
            return "ID:" + this.id + "\nBalance:"+ this.balance;
        }
    }
}
