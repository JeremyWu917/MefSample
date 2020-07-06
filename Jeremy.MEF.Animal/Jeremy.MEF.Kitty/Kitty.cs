using Jeremy.MEF.AnimalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.Kitty
{
    [ExportAnimal(AnimalName = "Kitty")]
    public class Kitty : IAnimal
    {
        public bool CanSleep { get; set; }

        public string ShowAnimalAttribute()
        {
            return "[Kitty] Miao Miao ~~";
        }
    }
}
