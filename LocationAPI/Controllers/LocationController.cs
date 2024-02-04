using LocationAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LocationAPI.Controllers
{
    public class LocationController : Controller
    {
        Artech_LocationEntities _locationEntities = new Artech_LocationEntities();
        // GET: Location
        public ActionResult Index()
        {
            return View(_locationEntities);
        }
        [HttpPost]
        public ActionResult Insert(LocationInfo location)
        {
            LocationInfo info = new LocationInfo();
            info.LocationName = location.LocationName;
            _locationEntities.LocationInfoes.Add(location);
            if (!string.IsNullOrWhiteSpace(info.LocationName))
                _locationEntities.SaveChanges();
            //int id = location.ID;

            return View(location);
        }

        
    }
}