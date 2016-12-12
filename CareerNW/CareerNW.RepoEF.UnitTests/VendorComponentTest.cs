using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CareerNW.RepoEF;
using CareerNW.RepoEF.Components;

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
    }
}
