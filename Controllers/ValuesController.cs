using API_REST_REPUVE.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_REST_REPUVE.Controllers
{
    
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1Alex", "value2" };
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        //[Route("getFuente/{Idfuente}")]
        //[HttpGet]
        public string Get(int Idfuente)
        {
            List<RepuveModel> Listmodel =new List<RepuveModel>();
            RepuveModel repuveModel = new RepuveModel();
            repuveModel.Nombre = "Roberto";
            repuveModel.Apellido = "Fuentes";
            repuveModel.Curp = "ROFF810423HDFRGW20";
            repuveModel.Fecha_Nacimiento = "23 DE OCTUBRE DE 1981";
            repuveModel.Placa_Vehicular = "NFL1234";

            var res = JsonConvert.SerializeObject(repuveModel);

            return res;
        }
    }
}

