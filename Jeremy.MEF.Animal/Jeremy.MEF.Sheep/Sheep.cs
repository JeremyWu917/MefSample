using Jeremy.MEF.AnimalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.Sheep
{
    [ExportAnimal(AnimalName = "Sheep")]
    public class Sheep : IAnimal
    {
        public bool CanSleep { get; set; }

        public string ShowAnimalAttribute()
        {
            return "[Sheep] - Mie Mie ~~~";
        }
    }
}
