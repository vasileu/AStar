using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class Location
    {
        public Location(int x, int y, int value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }

        public int value { get; private set; }
        public int x { get; private set; }
        public int y { get; private set; }

        public double getDistance(Location other)
        {
            int diffX = x - other.x;
            int diffY = y - other.y;
            return Math.Sqrt(diffX * diffX + diffY * diffY);
        }

        public override string ToString()
        {
            return x + ", " + y;
        }

    }
}
