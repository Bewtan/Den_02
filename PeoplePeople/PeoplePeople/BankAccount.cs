﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeoplePeople
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

    }
}
