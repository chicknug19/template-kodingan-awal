using Microsoft.AspNetCore.Mvc;
using JPP.Web.Controllers;

namespace JPP.Web.Areas.Event.Controllers
{
    [Area("Event")]
    public class EventListController : BaseController
    {
        protected override bool RequireLogin => true;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}