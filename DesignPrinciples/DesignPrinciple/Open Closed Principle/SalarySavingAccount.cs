using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.DesignPrinciple.Open_Closed_Principle
{
    //salary saving account--->inherting the interface
    public class SalarySavingAccount : ISavingAccount
    {
        double interest, balance = 30000;
        public override void CalculateInterest()
        {
            interest = balance * 0.5;
            Console.WriteLine("Interest Amount for Salary Saving Account : {0}\n", interest);
        }

    }
}
