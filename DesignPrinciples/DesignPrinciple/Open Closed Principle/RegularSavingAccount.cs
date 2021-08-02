using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.DesignPrinciple.Open_Closed_Principle
{
    public class RegularSavingAccount : ISavingAccount
    {
        double interest, balance = 5000;
        //calculating interest
        public override void CalculateInterest()
        {
            if (balance < 1000)
            {
                interest -= balance * 0.2;
            }
            if (balance < 50000)
            {
                interest += balance * 0.4;
            }
            Console.WriteLine("Interest Amount for Regular Saving Account : {0}\n", interest);
        }
    }
}
