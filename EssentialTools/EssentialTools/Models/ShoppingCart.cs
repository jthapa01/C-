using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        //ShoppingCart class is tightly coupled with the 
        //LinqValueCalculator class

        //*************************************
        //private LinqValueCalculator calc;

        //The interface allows me to break the tight coupling 
        //between the ShoppingCart and LinqValueCalculator class
        //public ShoppingCart(LinqValueCalculator calcParam)
        //**************************************
        private IValueCalculator calc;
        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}