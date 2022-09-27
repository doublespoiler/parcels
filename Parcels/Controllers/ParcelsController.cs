using Microsoft.AspNetCore.Mvc;

namespace Parcels.Controllers
{
    public class ParcelsController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}