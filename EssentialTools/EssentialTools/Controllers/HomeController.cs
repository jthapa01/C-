using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;
        private Product[] products =
        {
            new Product{Name = "kayak", Category = "Watersports", Price = 275M },
            new Product{Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product{Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };

        public HomeController(IValueCalculator calcParam, IValueCalculator calc2)
        {
            calc = calcParam;
        }



        // GET: Home
        public ActionResult Index()
        {
            //HomeController class is tightly coupled with the 
            //LinqValueCalculator and ShoppingCart class
            //***********************************************
            //LinqValueCalculator calc = new LinqValueCalculator();
            //***********************************************
            //USING NINJECT DI CONTAINER
            //*************************************************
            /*My goal with Ninject is to reach the point where I specify
            that I want to instantiate an implementation of the
            IValueCalculator interface, but the details of which 
            implementation is required are not part of the code in
            the Home controller.*/

            //***********************************************
            //IValueCalculator calc = new LinqValueCalculator();
            //*************************************************

            //Ninject Kernel instance responsible for resolving 
            //dependencies and creating new objects.
            //IKernel ninjectKernel = new StandardKernel();
            //Configure the Ninject kernel
            //ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();

            //gets instance of the specified service
            //Resolved it in NinjectDependencyResolver class
            //IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();
            ShoppingCart cart = new ShoppingCart(calc)
            {
                Products = products
            };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}