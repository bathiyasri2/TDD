using System.Security.Principal;
using System.Web;

namespace TDD.Tests.Controllers
{
    internal class MockHttpContext : HttpContextBase
    {
        private readonly IPrincipal _user = new GenericPrincipal(new GenericIdentity("someuser"), null);

        public override IPrincipal User
        {
            get
            {
                return _user;
            }

            set
            {
                base.User = value;
            }
        }

    }
}