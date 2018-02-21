using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle Objects
            Circle c1 = CreateCircle();
            Circle c2 = CreateCircle();

            Console.WriteLine("Circle Name: "+c1.GetName()); // '\n' skips to next line for formatting.
            Console.WriteLine("Circle Radius: "+c1.GetRadius());
            Console.WriteLine("Circle Area: "+c1.Area());

            Console.WriteLine("Circle Name: " + c2.GetName());
            Console.WriteLine("Circle Radius: " + c2.GetRadius());
            Console.WriteLine("Circle Area: " + c2.Area());

            //Finish if statement, Slide 41.
            if(c1.IsGreaterThan(c2))
            {
                Console.Write(("Circle " + c1.GetName() + " is greater than "));
                Console.WriteLine("Circle " + c2.GetName());
            }
            else if(c2.IsGreaterThan(c1))
            {
                Console.Write("Circle "+c2.GetName()+" is greater than ");
                Console.WriteLine("Circle "+c1.GetName());
            }
            else
            {
                Console.Write("Circle "+c1.GetName()+" and Circle "+c2.GetName());
                Console.WriteLine(" are the same size.");
            }

            Console.ReadLine(); //Little hack to keep the window open
        }

        static Circle CreateCircle()
        {
            String name, temp;
            double radius;
            Console.Write("Please enter name for new Circle: ");
            name = Console.ReadLine();
            Console.Write("Please enter Radius: ");
            temp = Console.ReadLine();
            radius = double.Parse(temp);
            return new Circle(name, radius);
        }

    }
}