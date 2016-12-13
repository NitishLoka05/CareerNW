using CareerNW.RepoEF;
using CareerNW.RepoEF.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using VendorDto = CareerNW.ServiceWebAPI.Models.DTOs.Vendor;
using AddressDto = CareerNW.ServiceWebAPI.Models.DTOs.Address;
using PhoneDto = CareerNW.ServiceWebAPI.Models.DTOs.Phone;
using EmailDto = CareerNW.ServiceWebAPI.Models.DTOs.EMail;

namespace CareerNW.ServiceWebAPI.Models
{
    public class VendorModel
    {

        private IVendorComponent _vendorComponent;

        public VendorModel(IVendorComponent vendorComponent)
        {
            _vendorComponent = vendorComponent;
        }

        public IList<VendorDto> GetVendors()
        {
            var vendors = _vendorComponent.GetVendors();

            var vendorsDto = new List<VendorDto>();

            if (vendors == null) return vendorsDto;

            foreach (var vendor in vendors)
            {
                var vendorDto = new VendorDto()
                {
                    ID = vendor.ID,
                    Name = vendor.Name,
                    IsPrime = vendor.IsPrime
                };

                vendorDto.Addresses = new List<AddressDto>();
                if (vendor.Addresses.Any())
                {
                    foreach (var address in vendor.Addresses)
                    {
                        var addressDto = new AddressDto()
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

                vendorDto.EMails = new List<EmailDto>();
                if (vendor.EMails.Any())
                {
                    foreach (var vendorEMail in vendor.EMails)
                    {
                        var emailDto = new EmailDto()
                        {
                            ID = vendorEMail.ID,
                            Address = vendorEMail.Address,
                        };

                        vendorDto.EMails.Add(emailDto);
                    }
                }

                vendorDto.Phones = new List<PhoneDto>();
                if (vendor.Phones.Any())
                {
                    foreach (var vendorPhone in vendor.Phones)
                    {
                        var phoneDto = new PhoneDto()
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

        internal void CreateVendor(VendorDto vendorDto)
        {
            var vendor = new Vendor();
            _vendorComponent.CreateVendor(vendor);
        }

        internal void DeleteVendor(long id)
        {
            _vendorComponent.DeleteVendor(id);
        }
    }
}