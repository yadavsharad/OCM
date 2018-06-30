using MongoDB.Driver;
using OCM.Patient.MicroService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCM.Patient.MicroService.Data
{
    public class PatientRepository : IPatientRepository<PatientModel>
    {
        public bool Add(PatientModel model)
        {

            //var client = new MongoClient("mongodb://kay:aHGg5KzpUuKYfp7k@cluster0-uxq1f.mongodb.net/admin?ssl=true&replicaSet=cluster0-uxq1f.mongodb.net&authSource=admin");
            //var database = client.GetDatabase("admin");
            return true;
        }
    }
}
