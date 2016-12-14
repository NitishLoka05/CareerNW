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
                var vendorDto = mapToDto(vendor);
                vendorsDto.Add(vendorDto);
            }

            return vendorsDto;
        }

        private VendorDto mapToDto(Vendor vendor)
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

            return vendorDto;
        }

        internal VendorDto GetVendors(long id)
        {
            var vendor = _vendorComponent.GetVendor(id);

            var vendorDto = mapToDto(vendor);

            return vendorDto;
        }

        internal void CreateVendor(VendorDto vendorDto)
        {
            var vendor = mapToEntity(vendorDto);
            _vendorComponent.CreateVendor(vendor);
        }

        internal void UpdateVendor(VendorDto vendorDto)
        {
            var vendor = mapToEntity(vendorDto);
            _vendorComponent.UpdateVendor(vendor);
        }

        private Vendor mapToEntity(VendorDto _vendorDto)
        {
            var vendor = new Vendor();
            vendor.ID = _vendorDto.ID;
            vendor.Name = _vendorDto.Name;
            vendor.IsPrime = _vendorDto.IsPrime;

            vendor.Addresses = (_vendorDto.Addresses != null && _vendorDto.Addresses.Count > 0) ? new List<Address>() : null;
            foreach (var _addressDto in _vendorDto.Addresses)
            {
                vendor.Addresses.Add(new Address()
                {
                    ID = _addressDto.ID,
                    StreetAddress = _addressDto.StreetAddress,
                    StreetAddress2 = _addressDto.StreetAddress2,
                    City = _addressDto.City,
                    State = _addressDto.State,
                    Country = _addressDto.Country,
                    Zipcode = _addressDto.Zipcode
                });
            }

            vendor.EMails = (_vendorDto.EMails != null && _vendorDto.EMails.Count > 0) ? new List<EMail>() : null;
            foreach (var _emailDto in _vendorDto.EMails)
            {
                vendor.EMails.Add(new EMail()
                {
                    ID = _emailDto.ID,
                    Address = _emailDto.Address
                });
            }

            vendor.Phones = (_vendorDto.Phones != null && _vendorDto.Phones.Count > 0) ? new List<Phone>() : null;
            foreach (var _phoneDto in _vendorDto.Phones)
            {
                vendor.Phones.Add(new Phone()
                {
                    ID = _phoneDto.ID,
                    Number = _phoneDto.Number,
                    CountryCode = _phoneDto.CountryCode,
                    Extension = _phoneDto.Extension,
                    PhoneType = new PhoneType()
                    {
                        Type = _phoneDto.PhoneType,
                        Phones = vendor.Phones
                    }
                });
            }
            return vendor;
        }

        internal void DeleteVendor(long id)
        {
            _vendorComponent.DeleteVendor(id);
        }
    }
}