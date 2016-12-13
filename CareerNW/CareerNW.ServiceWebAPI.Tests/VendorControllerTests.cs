using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CareerNW.ServiceWebAPI.Controllers;
using System.Linq;
using CareerNW.RepoEF.Components;
using Moq;
using CareerNW.RepoEF;
using System.Collections.Generic;

namespace CareerNW.ServiceWebAPI.UnitTests
{
    [TestClass]
    public class VendorControllerTests
    {
        [TestMethod]
        public void GetVendors_test()
        {
            var vendorsMock = new List<Vendor>();
            vendorsMock.Add(new Vendor()
            {
                Addresses = new List<Address>(),
                Phones = new List<Phone>(),
                EMails = new List<EMail>()
            });
            vendorsMock.First().Addresses.Add(new Address());
            vendorsMock.First().Phones.Add(new Phone()
            {
                PhoneType = new PhoneType()
                {
                    Type = "Mobile"
                }
            });
            var componentMock = new Mock<IVendorComponent>();
            componentMock.Setup(service => service.GetVendors())
                        .Returns(vendorsMock);
            
            var controller = new VendorController(componentMock.Object);

            var vendors = controller.Get();

            Assert.IsNotNull(vendors);
            Assert.IsTrue(vendors.Count > 0);

            Assert.IsNotNull(vendors.FirstOrDefault().Addresses);
            Assert.IsTrue(vendors.FirstOrDefault().Addresses.Count > 0);

            Assert.IsNotNull(vendors.FirstOrDefault().Phones.FirstOrDefault().PhoneType);
            Assert.AreEqual(vendors.FirstOrDefault().Phones.FirstOrDefault().PhoneType, "Mobile");

        }
        [TestMethod]
        public void DeleteVendor_test()
        {
            var componentMock = new Mock<IVendorComponent>();
            componentMock.Setup(service => service.DeleteVendor(It.IsAny<long>()))
                        .Returns(true); ;

            var controller = new VendorController(componentMock.Object);

            controller.Delete(1);
            
        }
    }
}
