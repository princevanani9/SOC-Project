using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    [ServiceContract]
    public interface IPatient
    {
        [OperationContract]
        bool AddPatient(Patient patient);

        [OperationContract]
        bool UpdatePatient(Patient patient);

        [OperationContract]
        bool DeletePatient(int patientId);

        [OperationContract]
        Patient FindPatient(int patientId);

        [OperationContract]
        IEnumerable<Patient> GetPatients();
    }
}
