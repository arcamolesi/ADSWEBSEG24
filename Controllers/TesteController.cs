using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ADSWEBSEG.Controllers
{
 
    public class TesteController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
