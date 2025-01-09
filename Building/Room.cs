using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    internal class Room
    {
        double width;
        double height;
        public Room(double weigth, double height) {this.width = weigth;this.height = height; }
        public Room(Room other)
        {
            this.width = other.width;
            this.height = other.height;
        }
        public double cacsurface()
        {
            return this.width * this.height;
        }
    }
}
