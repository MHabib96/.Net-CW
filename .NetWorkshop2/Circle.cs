using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class Circle : IComparable<Circle>
    {
        private String name;
        private double radius;

        //Contructor sets name/radius on object creation
        public Circle(String name, double radius)
        {
            this.name = name;
            this.radius = radius;
        }

        //Getter Methods
        public String GetName() { return name; }
        public double GetRadius() { return radius; }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public int CompareTo(Circle other)
        {
            if (this.radius < other.radius)
                return -1;
            else if (this.radius > other.radius)
                return 1;
            else
                return 0;
        }
    }
}
