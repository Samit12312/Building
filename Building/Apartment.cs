using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    internal class Apartment
    {
        string name;
        double[] Rooms;
        public Apartment(string name, double[] rooms)
        {
            this.name = name;
            this.Rooms = rooms;
        }
        public double CalculateBuildingFee()
        {
            double totalArea = caculateapartmentarea();
            string category = apartmentcatagory();
            double fee = 0;
            if (category == "small")
            {
                fee = totalArea * 0.8;
            }
            else if (category == "medium")
            {
                if (totalArea <= 70)
                {
                    fee = totalArea * 0.8;
                }
                else
                {
                    fee = 70 * 0.8 + (totalArea - 70) * 1.0;
                }
            }
            else if (category == "large")
            {
                if (totalArea <= 70)
                {
                    fee = totalArea * 0.8;
                }
                else if (totalArea <= 110)
                {
                    fee = 70 * 0.8 + (totalArea - 70) * 1.0;
                }
                else
                {
                    fee = 70 * 0.8 + 40 * 1.0 + (totalArea - 110) * 1.2;
                }
            }
            return fee;
        }
        public void PrintBuildingFee()
        {
            double fee = CalculateBuildingFee();
            Console.WriteLine($"Owner: {name}, Apartment Area: {CalculateBuildingFee()}, Fee: {fee:F2} ₪");
        }
        public string apartmentcatagory() 
        {
            double totalarea = caculateapartmentarea();
            if (totalarea <= 70) return "small";
            else if (totalarea <= 110) return "medium";
            else return "large";

        }
        public double caculateapartmentarea()
        {
            double totalarea = 0;
            for (int i = 0; i < Rooms.Length; i++)
            {
                totalarea += Rooms[i];
            }
            return totalarea;
        }
        public double GetRoomScale(int roomIndex)
        {
            if (roomIndex >= 0 && roomIndex < Rooms.Length)
            {
                return Rooms[roomIndex];
            }
            return -1;
        }
        public override string ToString()
        {
            string rooms = "";
            for (int i = 0; i < Rooms.Length; i++)
            {
                rooms += Rooms[i];
                if (i < Rooms.Length - 1)
                {
                    rooms += Rooms;
                }
            }
            return $"Owner: {this.name}/nRooms: {rooms}";
        }
    }
}
