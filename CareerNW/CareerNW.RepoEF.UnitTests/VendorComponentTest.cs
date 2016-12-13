using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CareerNW.RepoEF;
using CareerNW.RepoEF.Components;
using System.Collections.Generic;

namespace CareerNW.RepoEF.UnitTests
{
    [TestClass]
    public class VendorComponentTest
    {
        [TestMethod]
        public void GetVendors_test()
        {
            var component = new VendorComponent();

            var vendors = component.GetVendors();

            Assert.IsNotNull(vendors);
            Assert.IsTrue(vendors.Count > 0);

            Assert.IsNotNull(vendors.FirstOrDefault().Addresses);
            Assert.IsTrue(vendors.FirstOrDefault().Addresses.Count > 0);

            Assert.IsNotNull(vendors.FirstOrDefault().Phones.FirstOrDefault().PhoneType);
            Assert.AreEqual(vendors.FirstOrDefault().Phones.FirstOrDefault().PhoneType.Type, "Mobile");

        }

        [TestMethod]
        public void DeleteVendor_test()
        {
            var component = new VendorComponent();

            var beforevendors = component.GetVendors();

            var vendorId = beforevendors[1].ID;
            var status = component.DeleteVendor(vendorId);

            var aftervendors = component.GetVendors();

            Assert.IsTrue(status);
            Assert.AreEqual(beforevendors.Count, (aftervendors.Count + 1));

        }

        [TestMethod]
        public void CreateVendor_test()
        {
            var component = new VendorComponent();

            var beforevendors = component.GetVendors();

            var newvendor = new Vendor()
            {
                Name = "Test2",
                IsPrime = true,
                Addresses = new List<Address>(),
                Phones = new List<Phone>(),
                EMails = new List<EMail>()
            };
            newvendor.Addresses.Add(new Address()
            {
                StreetAddress = "477 martinsville rd",
                City = "liberty corner",
                State = "NJ",
                Zipcode = "08873"
            });
            newvendor.Phones.Add(new Phone()
            {
                CountryCode = "1",
                Number = "1231231234",
                PhoneTypeID = 3
            });

            var status = component.CreateVendor(newvendor);
            
            var aftervendors = component.GetVendors();

            Assert.IsTrue(status);
            Assert.AreEqual(aftervendors.Count, (beforevendors.Count + 1));

        }
    }
}
