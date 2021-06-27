using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUWPApp.domainclasses
{
    public class Customer
    {
        string name;
        string cellphoneNumber;

        public Customer()
        {
        }

        public Customer(string name, string cellNumber)
        {
            this.name = name;
            this.cellphoneNumber = cellNumber;
        }

        public string Name { get => name; set => name = value; }
        public string CellphoneNumber { get => cellphoneNumber; set => cellphoneNumber = value; }
    }
}
