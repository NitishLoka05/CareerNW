using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CareerNW.ServiceWebAPI.Models.DTOs
{
    [DataContract]
    public class Phone
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public string Number { get; set; }

        [DataMember]
        public string Extension { get; set; }

        [DataMember]
        public string PhoneType { get; set; }
    }
}
