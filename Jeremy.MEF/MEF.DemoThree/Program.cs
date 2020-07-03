using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEF.DemoThree
{
    public class Program
    {
        //按照契约名导入类，不指定类型的清空下，默认类型为Object，使用时需要强制转换
        [ImportMany("MusicBook")]
        public IEnumerable<object> Services { get; set; }

        //导入属性，这里不区分public还是private
        [ImportMany]
        public List<string> InputString { get; set; }

        //导入无参数方法
        [Import]
        public Func<string> methodWithoutPara { get; set; }

        //导入有参数方法
        [Import]
        public Func<int, string> methodWithPara { get; set; }

        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Compose();
            Console.WriteLine("----------------------打印导入的类--------------------------------");
            //打印导入的类
            if (pro.Services != null)
            {
                foreach (var s in pro.Services)
                {
                    var ss = (IBookService)s;
                    Console.WriteLine(ss.GetBookName());
                }
            }
            Console.WriteLine("---------------------打印导入的属性-------------------------------");
            // 打印导入的属性
            foreach (var str in pro.InputString)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-------------------打印导入的无参方法-----------------------------");
            // 调用无参数方法
            if (pro.methodWithoutPara != null)
            {
                Console.WriteLine(pro.methodWithoutPara());
            }
            Console.WriteLine("-------------------打印导入的有参方法-----------------------------");
            // 调用有参数方法
            if (pro.methodWithPara != null)
            {
                Console.WriteLine(pro.methodWithPara(3000));
            }


            Console.ReadKey();
        }

        private void Compose()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
    }
}
