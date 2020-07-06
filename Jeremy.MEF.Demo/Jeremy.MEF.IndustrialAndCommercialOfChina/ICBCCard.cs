using Jeremy.MEF.BankInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeremy.MEF.IndustrialAndCommercialOfChina
{
    // 指定其类型为IndustrialAndCommercialOfChina
    [ExportCardAttribute(CardType = "IndustrialAndCommercialOfChina")]
    public class ICBCCard : ICard
    {
        public double Money { get; set; }

        public void CheckOutMoney(double money)
        {
            this.Money -= money;
        }

        public string GetCountInfo()
        {
            return "Industrial And Commercial Of China";
        }

        public void SaveMoney(double money)
        {
            this.Money += money;
        }
    }
}
