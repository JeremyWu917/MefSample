using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.AnimalInterface
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ExportAnimalAttribute : ExportAttribute
    {
        public ExportAnimalAttribute() : base(typeof(IAnimal))
        { }

        /// <summary>
        /// 动物的姓名
        /// </summary>
        public string AnimalName { get; set; }
    }
}
