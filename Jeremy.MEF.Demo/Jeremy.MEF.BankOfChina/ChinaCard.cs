using Jeremy.MEF.BankInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.BankOfChina
{
    // 指定其类型为BankOfChina
    [ExportCardAttribute(CardType = "BankOfChina")]
    // 父类已规定继承即导出
    //[Export(typeof(ICard))]
    public class ChinaCard : ICard
    {
        public double Money { get; set; }

        public void CheckOutMoney(double money)
        {
            this.Money -= money;
        }

        public string GetCountInfo()
        {
            return "Bank Of China";
        }

        public void SaveMoney(double money)
        {
            this.Money += money;
        }
    }
}
