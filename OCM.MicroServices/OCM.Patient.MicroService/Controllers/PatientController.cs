using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using OCM.Patient.MicroService.Model;
 

namespace OCM.Patient.MicroService.Controllers
{
    [Produces("application/json")]
    [Route("api/Patient")]
    public class PatientController : Controller
    {

        public PatientController()
        {

        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            //var client = new MongoClient("mongodb://usr_ocms:usr_ocms2018@ds018268.mlab.com:18268/ocms");
            //var database = client.GetDatabase("ocms");


            var client = new MongoClient("mongodb://SharadYadav:aHGg5KzpUuKYfp7k@cluster0-uxq1f.mongodb.net/ocms");
            var database = client.GetDatabase("ocms");

            var patient = database.GetCollection<BsonDocument>("Patient").Find(c=>c["firstName"] == "Sharad").ToList();

            return new string[] { "value1", "value2" };
        }

    }
}