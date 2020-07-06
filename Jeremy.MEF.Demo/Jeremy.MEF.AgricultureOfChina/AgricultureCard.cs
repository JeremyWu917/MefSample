using Jeremy.MEF.BankInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.AgricultureOfChina
{
    // 指定其类型为IndustrialAndCommercialOfChina
    [ExportCard(CardType = "AgricultureOfChina")]
    //[Export(typeof(ICard))]
    public class AgricultureCard : ICard
    {
        public double Money { get; set; }

        public void CheckOutMoney(double money)
        {
            this.Money -= money;
        }

        public string GetCountInfo()
        {
            return "Agriculture Of China";
        }

        public void SaveMoney(double money)
        {
            this.Money += money;
        }
    }
}
