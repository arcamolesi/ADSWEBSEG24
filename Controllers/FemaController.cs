using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ADSWEBSEG.Controllers
{
    public class FemaController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public  IActionResult ADS()
        {
            return View();
        }

        [Authorize(Roles ="Supervisor")]
        public IActionResult BCC() { 
            return View();
        }
    
    
    }
}
