using Jeremy.MEF.AnimalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.Dog
{
    [ExportAnimal(AnimalName = "Dog")]
    public class Dog : IAnimal
    {
        public bool CanSleep { get; set; }

        public string ShowAnimalAttribute()
        {
            return "[Dog] Wolf Wolf ~~~~";
        }
    }
}
