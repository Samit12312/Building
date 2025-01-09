using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apartment apt1 = new Apartment("John Doe", new double[] { 25, 20, 15 });
            Apartment apt2 = new Apartment("Jane Smith", new double[] { 30, 35, 20 });
            Apartment apt3 = new Apartment("Sam Green", new double[] { 50, 40, 30 });

            Building building = new Building("123 Main Street", new Apartment[] { apt1, apt2, apt3 });

            building.PrintBuildingReport();
        }
        
    }
}
