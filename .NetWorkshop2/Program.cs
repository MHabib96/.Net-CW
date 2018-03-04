﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, Circle> circles = new Dictionary<String, Circle>();

            circles.Add("c1", new Circle("C1", 1.0));
            circles.Add("c2", new Circle("C2", 2.0));
            circles.Add("c3", new Circle("C3", 3.0));

            Circle c = circles["c2"];

            Console.WriteLine("Circle {0} has radius {1}", c.GetName(), c.GetRadius());

            circles["c2"] = new Circle("New C2", 200.0);

            c = circles["c2"];

            Console.WriteLine("Circle {0} has radius {1}",
                c.GetName(), c.GetRadius());


            Console.ReadLine();
        }

    }
}

