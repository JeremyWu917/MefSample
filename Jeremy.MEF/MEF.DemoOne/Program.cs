using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEF.DemoOne
{
    public class Program
    {
        [Import]//这里使用[Import]导入刚刚导出的MusicBook
        public IBookService Service { get; set; }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Compose();
            if (program.Service != null)
            {
                Console.WriteLine(program.Service.GetBookName());
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 实例化CompositionContainer来实现组合
        /// </summary>
        private void Compose()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
    }
}
