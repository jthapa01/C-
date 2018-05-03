﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using EssentialTools.Models;
using System.Web.Mvc;
using Ninject.Web.Common;

namespace EssentialTools.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IValueCalculator>().To<LinqValueCalculator>().InRequestScope();
            //kernel.Bind<IDiscountHelper>()
            //.To<DefaultDiscountHelper>().WithPropertyValue("DiscountSize", 50M);
            kernel.Bind<IDiscountHelper>()
                           .To<DefaultDiscountHelper>().WithConstructorArgument("DiscountParam", 50M);
            kernel.Bind<IDiscountHelper>().To<FlexibleDiscountHelper>()
                .WhenInjectedInto<LinqValueCalculator>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}