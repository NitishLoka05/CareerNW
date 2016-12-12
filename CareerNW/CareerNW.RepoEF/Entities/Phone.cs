namespace CareerNW.RepoEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phone")]
    public partial class Phone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phone()
        {
            Vendors = new HashSet<Vendor>();
        }

        public long ID { get; set; }

        [StringLength(5)]
        public string CountryCode { get; set; }

        [StringLength(10)]
        public string Number { get; set; }

        [StringLength(5)]
        public string Extension { get; set; }

        public int? PhoneTypeID { get; set; }

        public virtual PhoneType PhoneType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
