using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class MinimumDiscountHelper : IDiscountHelper
    {
        /*
         make the MinimumDiscountHelper demonstrate the following behaviors:
        • If the total is greater than $100, the discount will be 10 percent.
        • If the total is between $10 and $100 inclusive, the discount will 
        • be $5. No discount will be applied on totals less than $10.
        • An ArgumentOutOfRangeException will be thrown for negative totals.
         */
        public decimal ApplyDiscount(decimal totalParam)
        {
            if (totalParam < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (totalParam > 100)
            {
                return totalParam * 0.9M;
            }
            else if (totalParam >= 10 && totalParam <= 100)
            {
                return totalParam - 5;
            }
            else return totalParam;
        }
    }
}