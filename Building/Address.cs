using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    internal class Address
    {
        string town;
        string street;
        string number;
        public Address(string town, string street, string number)
        {
            this.town = town;
            this.street = street;
            this.number = number;
        }
        public override string ToString()
        {
            return $"town is {town}/nstreet is {street} /nnumber: {number}";
        }
    }
}
