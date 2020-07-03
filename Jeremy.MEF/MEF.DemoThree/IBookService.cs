using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.DemoThree
{
    /// <summary>
    /// 书 接口
    /// </summary>
    public interface IBookService
    {
        /// <summary>
        /// 书名
        /// </summary>
        string BookName { get; set; }

        /// <summary>
        /// 获取数据的名字
        /// </summary>
        /// <returns></returns>
        string GetBookName();
    }
}
