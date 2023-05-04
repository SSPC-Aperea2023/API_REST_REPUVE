using API_REST_REPUVE.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace API_REST_REPUVE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public IEnumerable<string> Get()
        {

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://apirestrepuve20230504131354.azurewebsites.net/api/values?idFuente=10");
                var user = JsonConvert.DeserializeObject<List<RepuveModel>>(json);
            }
            return new string[] { "value1Alex", "value2" };
        }
    }
}
