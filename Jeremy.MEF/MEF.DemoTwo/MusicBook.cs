using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.DemoTwo
{
    [Export("MusicBook", typeof(IBookService))]//导出，对外契约为MusicBook
    //[Export("MusicBook")]//[Export("Book")],仅仅指定了契约名，而没有指定类型，那么默认为object。这种情况就要在输出是进行强制类型转换
    public class MusicBook : IBookService
    {
        public string BookName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetBookName()
        {
            return "MusicBook";
        }
    }
}
