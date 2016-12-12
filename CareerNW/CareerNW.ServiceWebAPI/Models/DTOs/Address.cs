using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CareerNW.ServiceWebAPI.Models.DTOs
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public string StreetAddress { get; set; }

        [DataMember]
        public string StreetAddress2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string Zipcode { get; set; }
    }
}
