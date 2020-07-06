using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.AnimalInterface
{
    /// <summary>
    /// 动物接口
    /// </summary>
    public interface IAnimal
    {
        /// <summary>
        /// 动物会睡觉
        /// </summary>
        bool CanSleep { get; set; }

        /// <summary>
        /// 展示以下其本身的特性
        /// </summary>
        /// <returns></returns>
        string ShowAnimalAttribute();
    }

    public interface IMetaData
    {
        /// <summary>
        /// 动物的名字
        /// </summary>
        string AnimalName { get; }
    }
}
