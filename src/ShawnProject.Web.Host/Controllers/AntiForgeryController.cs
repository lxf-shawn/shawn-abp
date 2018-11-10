using Microsoft.AspNetCore.Antiforgery;
using ShawnProject.Controllers;

namespace ShawnProject.Web.Host.Controllers
{
    public class AntiForgeryController : ShawnProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
