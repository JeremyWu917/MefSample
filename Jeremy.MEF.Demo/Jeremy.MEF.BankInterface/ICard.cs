using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.BankInterface
{
    // 规定子类继承即导出
    //[InheritedExport]
    public interface ICard
    {
        /// <summary>
        /// 账户金额
        /// </summary>
        double Money { get; set; }
        /// <summary>
        /// 获取账户信息
        /// </summary>
        /// <returns></returns>
        string GetCountInfo();
        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="money"></param>
        void SaveMoney(double money);
        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="money"></param>
        void CheckOutMoney(double money);
    }

    public interface IMetaData
    {
        string CardType { get; }
    }

}
