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
        string model = "";
        int price = 0;

        public string Name // метод для поля name, чтобы получать и записывать(устанавливать) значения
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Model // метод для поля marka, чтобы получать и записывать(устанавливать) значения
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Price // метод для поля price, чтобы получать и записывать(устанавливать) значения
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
