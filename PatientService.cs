using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class PatientService : IPatient
    {
        PatientContext pc = new  PatientContext();
        public bool AddPatient(Patient patient)
        {
            pc.Patients.Add(patient);
            pc.SaveChanges();
            return true;
        }

        
        public bool UpdatePatient(Patient patient)
        {
            Patient p1 = pc.Patients.Find(patient.patientId);
            p1.address = patient.address;
            p1.first_name = patient.first_name;
            p1.last_name = patient.last_name;
            p1.gender = patient.gender;
            p1.mobile_no = patient.mobile_no;
            p1.allergies = patient.allergies;
            p1.discharge_date = patient.discharge_date;
            p1.age = patient.age;
            p1.admit_date = patient.admit_date;
            p1.email = patient.email;
            p1.sickness = patient.sickness;
            p1.special_req = patient.special_req;
            p1.prescription = patient.prescription;
            pc.Patients.AddOrUpdate(p1);
            pc.SaveChanges();
            return true;

        }

        public bool DeletePatient(int patientId)
        {
            Patient p1 = pc.Patients.Find(patientId);
            pc.Patients.Remove(p1);
            pc.SaveChanges();
            return true;
        }

        public Patient FindPatient(int patientId)
        {
            Patient p1 = pc.Patients.Find(patientId);
            return p1;
        }

        public IEnumerable<Patient> GetPatients()
        {
            return pc.Patients;
        }

    }
}
