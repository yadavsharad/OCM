using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCM.Patient.MicroService.Business
{
    public interface IPatientManager<T>
    {
        bool Add(T model);
        bool Update(T model);
        bool Delete(T Model);

    }
}
