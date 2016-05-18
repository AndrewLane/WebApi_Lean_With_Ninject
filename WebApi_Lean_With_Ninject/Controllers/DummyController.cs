using System.Web.Http;

namespace WebApi_Lean_With_Ninject.Controllers
{
    public class DummyController : ApiController
    {
        [HttpGet]
        public string Hello()
        {
            return "World";
        }
    }
}
