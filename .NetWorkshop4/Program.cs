using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> AnimalList = new List<Animal>();

            AnimalList.Add(new Animal { ID = 1, Type = "Herbivorous", Name = "Cow" });
            AnimalList.Add(new Animal { ID = 2, Type = "Herbivorous", Name = "Rhinoceros" });
            AnimalList.Add(new Animal { ID = 3, Type = "Carnivorous", Name = "Snake" });
            AnimalList.Add(new Animal { ID = 4, Type = "Herbivorous", Name = "Goat" });
            AnimalList.Add(new Animal { ID = 5, Type = "Carnivorous", Name = "Lion" });
            AnimalList.Add(new Animal { ID = 6, Type = "Herbivorous", Name = "Deer" });
            AnimalList.Add(new Animal { ID = 7, Type = "Carnivorous", Name = "Toad" });
            AnimalList.Add(new Animal { ID = 8, Type = "Omnivorous", Name = "Bear" });
            AnimalList.Add(new Animal { ID = 9, Type = "Omnivorous", Name = "Human" });

            /* OUTPUT 1
            var result = (from animal in AnimalList select animal).ToList(); 

            for(var animal in result)
                Console.WriteLine("{0} is a {1} animal", animal.Name, animal.Type);
            */


            /* OUTPUT 2
            var result = (from animal in AnimalList orderby animal.Type select animal).ToList(); 

            for(var animal in result)
                Console.WriteLine("{0} is a {1} animal", animal.Name, animal.Type); 
            */


            /* OUTPUT 3
            var result = (from animal in AnimalList where animal.Type == "Herbivorous" orderby animal.Name select animal).ToList(); 

            for(var animal in result)
                Console.WriteLine("{0} likes to eat grass", animal.Name);
            */


            /* OUTPUT 4
            var result = (from animal in AnimalList select animal).ToList();

            Console.WriteLine("--------All Animals--------");

            foreach (var animal in result)
                Console.WriteLine("{0} are {1}", animal.Name, animal.Type);

            Console.WriteLine("\n\n");

            Console.WriteLine("--------No Omnivorous--------");

            var resultOmnivorous = (from animal in AnimalList where animal.Type == "Omnivorous" select animal).ToList();

            foreach (var animal in resultOmnivorous)
                result.Remove(animal);

            foreach (var animal in result)
                Console.WriteLine("{0} are {1}", animal.Name, animal.Type);

            */


            //OUTPUT 5
            var result = AnimalList.Where(animal => animal.Type == "Herbivorous").ToList()
                                   .Select(x => new Herbivorous { ID = x.ID, AnimalName = x.Name }).ToList();

            foreach (var animal in result)
                Console.WriteLine(animal.Food);

            Console.ReadLine();

        }
    }
}
