using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1
{
    class Circle
    {
        private String name;
        private double radius;
        
        //Sets the radius value on object creation
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

        public bool IsGreaterThan(Circle circleObject)
        {
            if(this.GetRadius() > circleObject.GetRadius())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
