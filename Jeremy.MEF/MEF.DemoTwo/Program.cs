using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEF.DemoTwo
{
    class Program
    {
        // 按照契约名导入，相同的契约名回被同时导入

        [ImportMany("MusicBook")]
        //[ImportMany("MusicBook")]还有下面的声明变成了IEnumerable<>
        //因为要导入多个实例，所以要用到集合，下面采用foreach遍历输出
        public IEnumerable<IBookService> Services { get; set; }
        //public IEnumerable<object> Services { get; set; }

        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Compose();
            if (pro.Services != null)
            {
                // foreach遍历
                foreach (var item in pro.Services)
                {
                    Console.WriteLine(item.GetBookName());
                }

                //var ss = (IBookService)s;
                //Console.WriteLine(ss.GetBookName());
            }
            Console.Read();
        }

        private void Compose()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
    }
}
