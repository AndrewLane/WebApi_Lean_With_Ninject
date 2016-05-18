using Ninject;
using System.Web.Http.Dependencies;

namespace WebApi_Lean_With_Ninject.Infrastructure
{
    public class NinjectDependencyResolver : NinjectScope, IDependencyResolver
    {
        private readonly IKernel _kernel;
        public NinjectDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            _kernel = kernel;
        }
        public IDependencyScope BeginScope()
        {
            return new NinjectScope(_kernel.BeginBlock());
        }
    }
}