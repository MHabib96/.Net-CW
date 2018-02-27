using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Employee : IComparable
    {
        //Declaring Employee variables
        public String name;
        public String family;
        public int idNumber = 0;

        //Employee Constructor
        public Employee(String name, String family, int idNumber)
        {
            this.name = name;
            this.family = family;
            this.idNumber = idNumber;
        }

        //Compares instance with specified object
        //Returns int specifying if instance procedes, follows, or in same position.
        int IComparable.CompareTo(object obj)
        {
            int returnValue;
            Employee temp = (Employee)obj;
            if (this.idNumber > temp.idNumber)
                returnValue = 1;
            else
                if (this.idNumber < temp.idNumber)
                returnValue = -1;
            else
                returnValue = -0;
            return returnValue;
        }

    }
}
