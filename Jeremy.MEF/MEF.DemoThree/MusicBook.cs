using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.DemoThree
{
    [Export("MusicBook")]//将类以契约名MusicBook的形式导出，不知道类型，默认为Object
    public class MusicBook : IBookService
    {
        //导出私有属性
        [Export(typeof(string))]
        private string _privateBookName = "Private Music BookName";

        //导出公有属性
        [Export(typeof(string))]
        public string _publicBookName = "Public Music BookName";



        //导出公有方法
        [Export(typeof(Func<string>))]
        public string GetBookName()
        {
            return "MusicBook";
        }

        //导出私有方法
        [Export(typeof(Func<int, string>))]
        private string GetBookPrice(int price)
        {
            return "$" + price;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------//



        public string BookName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
