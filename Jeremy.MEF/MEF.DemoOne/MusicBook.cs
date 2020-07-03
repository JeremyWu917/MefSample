using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.DemoOne
{
    [Export(typeof(IBookService))]//将类声明导出为IBookService接口类型
    public class MusicBook : IBookService
    {
        public string BookName { get; set; }

        public string GetBookName()
        {
            return "Hi, Music Book!";
        }
    }
}
