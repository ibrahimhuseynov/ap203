using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Farm
    {
        public Animal[] animals=new Animal[0];
        public void AddAnimal(Animal animal)
        {
            Array.Resize(ref animals, animals.Length+1);
            animals[animals.Length-1] = animal;
        }
    }
}
