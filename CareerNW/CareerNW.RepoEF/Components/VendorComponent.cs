﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CareerNW.RepoEF.Components
{
    public class VendorComponent : IVendorComponent
    {
        public IList<Vendor> GetVendors()
        {
            try
            {
                using (var dbcontext = new CareerNWDbContext())
                {
                    var vendors = dbcontext.Vendors
                        .Include(v => v.Addresses)
                        .Include(v => v.EMails)
                        .Include(v => v.Phones)
                        .Include(v => v.Phones.Select(p => p.PhoneType))
                        .AsParallel()
                        .OrderBy(v => v.ID)
                        .ToList();

                    return vendors;
                }
            }
            catch (Exception ex)
            {
                return new List<Vendor>();
            }
            finally
            {

            }
        }

        public bool DeleteVendor(long vendorId)
        {
            try
            {
                using (var dbcontext = new CareerNWDbContext())
                {
                    var vendor = dbcontext.Vendors
                        .Include(v => v.Addresses)
                        .Include(v => v.EMails)
                        .Include(v => v.Phones)
                        .Include(v => v.Phones.Select(p => p.PhoneType))
                        .AsParallel()
                        .FirstOrDefault(v => v.ID == vendorId);
                    
                    dbcontext.Vendors.Remove(vendor);
                    dbcontext.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {

            }
        }
    }
}
