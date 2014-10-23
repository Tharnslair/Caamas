using System.Web.Mvc;

namespace TharnTask.Web.Controllers
{
    public class HomeController : TharnTaskControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}