using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    internal class Building
    {
        string buildingaddress;
        Apartment[] apartments;
        public Building(string buildingaddress, Apartment[] apartments)
        {
            this.buildingaddress = buildingaddress;
            this.apartments = apartments;
        }
        public double CalculateTotalBuildingFee()
        {
            double totalFee = 0;
            for (int i = 0; i < apartments.Length; i++)
            {
                totalFee += apartments[i].CalculateBuildingFee();
            }
            return totalFee;
        }
        public void PrintBuildingReport()
        {
            Console.WriteLine($"Building Address: {buildingaddress}");
            Console.WriteLine("Apartment Fees:");
            for (int i = 0; i < apartments.Length; i++)
            {
                apartments[i].PrintBuildingFee();
            }
            Console.WriteLine($"Total Building Fee: {CalculateTotalBuildingFee():F2} ₪");
        }
        public override string ToString() 
        {
            return $"building address : {buildingaddress} \napartments {apartments}";
        }
    }
}
