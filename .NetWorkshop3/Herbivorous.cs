using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop3
{
    class Herbivorous
    {
        public int ID { get; set; }
        
        public string AnimalName { get; set; }

        public string Food
        {
            get
            {
                return this.AnimalName + " eats grass and grains!!";
            }
        }
    }
}
