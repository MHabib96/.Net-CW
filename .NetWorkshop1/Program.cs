using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create empty ArrayList.
            ArrayList empl1 = new ArrayList();

            //Populating ArrayList with 3 Employee objects.
            empl1.Add(new Employee("David", "Livingstone", 25));
            empl1.Add(new Employee("Tim", "Ellis", 17));
            empl1.Add(new Employee("Richard", "Jones", 8));

            //Loops through ArrayList, printing out contained object names.
            Console.WriteLine("List of Employee: ");
            foreach(Employee emp in empl1)
                Console.WriteLine(emp.name);
           
            //Sorts ArrayList using .sort() method
            //Loops through ArrayList, printing out newly sorted data.
            empl1.Sort();
            Console.WriteLine("List of Employee After Sorting: ");
            foreach (Employee emp in empl1)
                Console.WriteLine(emp.name);

            Console.ReadLine(); //Keep cmd tab open when running application

        }
    }
}
