using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWars
{
    class Planet
    {
        private string name;
        private int metal;
        private int mineral;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Metal
        {
            get { return metal; }
            set { metal = value; }
        }

        public int Mineral
        {
            get { return mineral; }
            set { mineral = value; }
        }
        
    }
}
