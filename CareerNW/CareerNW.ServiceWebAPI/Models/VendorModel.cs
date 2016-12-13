using CareerNW.RepoEF.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CareerNW.ServiceWebAPI.Models
{
    public class VendorModel
    {

        private IVendorComponent _vendorComponent;

        public VendorModel(IVendorComponent vendorComponent)
        {
            _vendorComponent = vendorComponent;
        }

        public IList<DTOs.Vendor> GetVendors()
        {
            var vendors = _vendorComponent.GetVendors();

            var vendorsDto = new List<DTOs.Vendor>();

            if (vendors == null) return vendorsDto;

            foreach (var vendor in vendors)
            {
                var vendorDto = new DTOs.Vendor()
                {
                    ID = vendor.ID,
                    Name = vendor.Name,
                    IsPrime = vendor.IsPrime
                };

                vendorDto.Addresses = new List<DTOs.Address>();
                if (vendor.Addresses.Any())
                {
                    foreach (var address in vendor.Addresses)
                    {
                        var addressDto = new DTOs.Address()
                        {
                            ID = address.ID,
                            StreetAddress = address.StreetAddress,
                            StreetAddress2 = address.StreetAddress2,
                            City = address.City,
                            State = address.State,
                            Country = address.Country,
                            Zipcode = address.Zipcode
                        };

                        vendorDto.Addresses.Add(addressDto);
                    }
                }

                vendorDto.EMails = new List<DTOs.EMail>();
                if (vendor.EMails.Any())
                {
                    foreach (var vendorEMail in vendor.EMails)
                    {
                        var emailDto = new DTOs.EMail()
                        {
                            ID = vendorEMail.ID,
                            Address = vendorEMail.Address,
                        };

                        vendorDto.EMails.Add(emailDto);
                    }
                }

                vendorDto.Phones = new List<DTOs.Phone>();
                if (vendor.Phones.Any())
                {
                    foreach (var vendorPhone in vendor.Phones)
                    {
                        var phoneDto = new DTOs.Phone()
                        {
                            ID = vendorPhone.ID,
                            CountryCode = vendorPhone.CountryCode,
                            Number = vendorPhone.Number,
                            Extension = vendorPhone.Extension,
                            PhoneType = vendorPhone.PhoneType.Type
                        };

                        vendorDto.Phones.Add(phoneDto);
                    }
                }

                vendorsDto.Add(vendorDto);
            }

            return vendorsDto;
        }

        internal void DeleteVendor(long id)
        {
            _vendorComponent.DeleteVendor(id);
        }
    }
}