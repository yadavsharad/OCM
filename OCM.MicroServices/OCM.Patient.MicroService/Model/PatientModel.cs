using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCM.Patient.MicroService.Model
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


    }
}
