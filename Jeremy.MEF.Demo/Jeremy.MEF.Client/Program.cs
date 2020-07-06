using Jeremy.MEF.BankInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.Client
{
    class Program
    {
        // 指定导入多个ICard
        //[ImportMany(typeof(ICard))]
        //public IEnumerable<ICard> cards { get; set; }

        //其中AllowRecomposition=true参数就表示运行在有新的部件被装配成功后进行部件集的重组.
        [ImportMany(AllowRecomposition = true)]
        public IEnumerable<Lazy<ICard, IMetaData>> cards { get; set; }

        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Compose();

            foreach (var c in pro.cards)
            {
                //Console.WriteLine(c.GetCountInfo());

                if (c.Metadata.CardType == "BankOfChina")
                {
                    Console.WriteLine("Here is a card of Bank Of China ");
                    Console.WriteLine(c.Value.GetCountInfo());
                }
                if (c.Metadata.CardType == "AgricultureOfChina")
                {
                    Console.WriteLine("Here is a card of Agriculture Of China ");
                    Console.WriteLine(c.Value.GetCountInfo());
                }
                if (c.Metadata.CardType == "IndustrialAndCommercialOfChina")
                {
                    Console.WriteLine("Here is a card of Industrial And Commercial Of China ");
                    Console.WriteLine(c.Value.GetCountInfo());
                }
            }

            Console.ReadKey();
        }

        private void Compose()
        {
            // 此处是一个目录，后续可根据需要向其中添加dll
            var catalog = new DirectoryCatalog("Cards");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
    }
}
