using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class Autos
    {
        string name = ""; // создаются поля 
        string marka = "";
        int price = 0;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Marka
        {
            get { return this.marka; }
            set { this.marka = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
