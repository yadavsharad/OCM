using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCM.Patient.MicroService.Data
{
    public interface IPatientRepository<T>
    {
        bool Add(T model);
    }
}
