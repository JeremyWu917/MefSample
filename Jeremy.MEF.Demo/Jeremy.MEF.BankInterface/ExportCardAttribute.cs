using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.BankInterface
{
    /// <summary>
    /// 声明一个继承自ExportAttribute的类，AllowMultiple = false,代表一个类不允许多次使用此属性
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ExportCardAttribute : ExportAttribute
    {
        public ExportCardAttribute() : base(typeof(ICard))
        {

        }

        /// <summary>
        /// 卡片类型
        /// </summary>
        public string CardType { get; set; }
    }
}
