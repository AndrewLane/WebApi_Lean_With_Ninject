namespace WebApi_Lean_With_Ninject.Services
{
    /// <summary>
    /// Dummy component to represent a dependency to be injected
    /// </summary>
    public class ProvideSomeDependency : IProvideSomeDependency
    {
        public int GetSomeDependentValue()
        {
            return 10311981;
        }
    }
}