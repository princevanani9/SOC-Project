using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class PatientContext: DbContext
    {
        public PatientContext() : base("name=Patient")
        {

        }
        public DbSet<Patient> Patients { get; set; }
    }
}
