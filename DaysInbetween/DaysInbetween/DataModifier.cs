using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaysInbetween
{
    class DataModifier
    {
        private string date1;
        private string date2;

        public string Date1
        {
            get { return date1; }
            set { date1 = value; }
        }

        public string Date2
        {
            get { return date2; }
            set { date2 = value; }
        }

        public int Diff()
        {
            int[] dates1 = date1.Split(' ').Select(int.Parse).ToArray();
            int[] dates2 = date2.Split(' ').Select(int.Parse).ToArray();
            int i = Math.Abs((dates1[0] - dates2[0]) * 365 + (dates1[1] - dates2[1]) * 30 + dates1[2] - dates2[2])+Math.Abs((int)(dates1[0] - dates2[0]) / 4);
            return i;
        }



    }
}
