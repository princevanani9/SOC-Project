using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    [DataContract]
    public class Patient
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int patientId { get; set; }
        [DataMember]
        public string first_name { get; set; }
        [DataMember]
        public string last_name { get; set; }
        [DataMember]
        public string gender { get; set; }
        [DataMember]
        public int age { get; set; }
        [DataMember]
        public string sickness { get; set; }
        [DataMember]
        public string prescription { get; set; }
        [DataMember]
        public string allergies { get; set; }
        [DataMember]
        public string special_req { get; set; }
        [DataMember]
        public DateTime  admit_date { get; set; }
        [DataMember]
        public DateTime discharge_date { get; set; }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public string mobile_no { get; set; }
        [DataMember]
        public string email { get; set; }

    }
}
