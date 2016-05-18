using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi_Lean_With_Ninject.Services;

namespace WebApi_Lean_With_Ninject.NinjectModules
{
    public class DependencyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProvideSomeDependency>().To<ProvideSomeDependency>().InSingletonScope();
        }
    }
}