using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planista_2._0
{
    class BirthdayParty : Party
    {
        public BirthdayParty(int numberOfPeople ,
            bool fancyDecorations , string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
        public string CakeWriting { get; set; }
        private int ActualLengt
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }
        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 20;
            else
                return 40;
        }
        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }
       
      override  public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 20)
                    cakeCost = 40M + ActualLengt * .25M;
                else
                    cakeCost = 75M + ActualLengt * .25M;
                return totalCost + cakeCost;
            }
        }
    }

}
