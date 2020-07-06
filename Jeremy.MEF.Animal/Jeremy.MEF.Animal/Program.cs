using Jeremy.MEF.AnimalInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.Animal
{
    class Program
    {

        //其中AllowRecomposition=true参数就表示运行在有新的部件被装配成功后进行部件集的重组.
        [ImportMany(AllowRecomposition = true)]
        public IEnumerable<Lazy<IAnimal, IMetaData>> cards { get; set; }

        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Compose();

            foreach (var c in pro.cards)
            {
                //Console.WriteLine(c.GetCountInfo());

                if (c.Metadata.AnimalName == "Dog")
                {
                    Console.WriteLine("Here is the Doggy:");
                    Console.WriteLine(c.Value.ShowAnimalAttribute());
                }
                if (c.Metadata.AnimalName == "Kitty")
                {
                    Console.WriteLine("Here is the Kitty:");
                    Console.WriteLine(c.Value.ShowAnimalAttribute());
                }
                if (c.Metadata.AnimalName == "Sheep")
                {
                    Console.WriteLine("Here is the Sheep:");
                    Console.WriteLine(c.Value.ShowAnimalAttribute());
                }
            }

            Console.ReadKey();
        }

        private void Compose()
        {
            // 此处是一个目录，后续可根据需要向其中添加dll
            var catalog = new DirectoryCatalog("Animals");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
    }
}
