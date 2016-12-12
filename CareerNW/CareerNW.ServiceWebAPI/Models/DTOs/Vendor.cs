using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CareerNW.ServiceWebAPI.Models.DTOs
{
    [DataContract]
    public class Vendor
    {
        public Vendor()
        {
            Addresses = new List<Address>();
            EMails = new List<EMail>();
            Phones = new List<Phone>();
        }

        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool? IsPrime { get; set; }

        [DataMember]
        public virtual IList<Address> Addresses { get; set; }

        [DataMember]
        public virtual IList<EMail> EMails { get; set; }

        [DataMember]
        public virtual IList<Phone> Phones { get; set; }
    }
}