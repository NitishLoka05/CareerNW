using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerNW.RepoEF.Components
{
    public interface IVendorComponent
    {
        IList<Vendor> GetVendors();

        bool DeleteVendor(long vendorId);

        bool CreateVendor(Vendor vendor);

        bool UpdateVendor(Vendor vendor);
    }
}
