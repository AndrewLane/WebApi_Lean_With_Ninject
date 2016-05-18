using System;
using System.Web.Http;
using WebApi_Lean_With_Ninject.Services;

namespace WebApi_Lean_With_Ninject.Controllers
{
    public class DummyController : ApiController
    {
        IProvideSomeDependency _dependency;

        public DummyController(IProvideSomeDependency dependency)
        {
            if (dependency == null) throw new ArgumentNullException(nameof(dependency));
            _dependency = dependency;
        }

        [HttpGet]
        public string Hello()
        {
            return $"World {_dependency.GetSomeDependentValue()}";
        }
    }
}
