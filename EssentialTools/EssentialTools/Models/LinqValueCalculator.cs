﻿using System.Collections.Generic;
using System.Linq;
using EssentialTools.Models;


namespace EssentialTools.Models
{
    //implemented interface to solve the tightly
    //coupled problem
    public class LinqValueCalculator:IValueCalculator
    {
        private IDiscountHelper discounter;
        private static int counter = 0;
        //constructor injection
        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            discounter = discountParam;
            System.Diagnostics.Debug.WriteLine(
                string.Format("Instance {0} created", ++counter));
        }
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            //return products.Sum(p => p.Price);
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}