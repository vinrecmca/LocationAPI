using LocationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
namespace LocationAPI.Controllers
{
    public class ValuesController : ApiController
    {
        Artech_LocationEntities _locationEntities = new Artech_LocationEntities();
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        public IHttpActionResult Get()
        {
            var locList = _locationEntities.LocationInfoes;
            var jsonResult = JsonConvert.SerializeObject(locList);

            if (jsonResult != null)
            {
                return Ok(jsonResult);
            }
            return NotFound();

        }

    }
}
