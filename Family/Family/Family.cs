using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Family
{
    class Family
    {
        private List<Person> fam = new List<Person>();
        public List<Person> Fam
        {
            get { return fam; }
            set { fam = value; }
        }
    }
}
