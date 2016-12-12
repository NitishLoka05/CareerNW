using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CareerNW.ServiceWebAPI.Models.DTOs
{
    [DataContract]
    public class EMail
    {
        [DataMember]
        public long ID { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}
