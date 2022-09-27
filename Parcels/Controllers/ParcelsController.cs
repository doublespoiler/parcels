using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;


namespace Parcels.Controllers
{
    public class ParcelsController : Controller
    {
      [HttpGet("/parcels")]
      public ActionResult Index()
      {
        List<Parcel> allParcels = Parcel.GetAll();
        return View(allParcels);
      }

      [HttpGet("/parcels/new")]
      public ActionResult ParcelForm()
      {
        return View();
      }

      [HttpPost("/parcels")]
      public ActionResult Create(string name, int height, int width, int depth, int weight)
      {
        Parcel myParcel = new Parcel(name, height, width, depth, weight);
        return RedirectToAction("Index");
      }
    }
}