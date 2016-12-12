using CareerNW.RepoEF;
using CareerNW.RepoEF.Components;
using CareerNW.ServiceWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CareerNW.ServiceWebAPI.Controllers
{
    [RoutePrefix("api/Vendor")]
    public class VendorController : ApiController
    {
        private IVendorComponent _vendorComponent;

        public VendorController(IVendorComponent vendorComponent)
        {
            _vendorComponent = vendorComponent;
        }

        [HttpGet]
        // GET: api/Vendor
        public IList<Models.DTOs.Vendor> Get()
        {
            var vm = new VendorModel(_vendorComponent);
            return vm.GetVendors();
        }

        // GET: api/Vendor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Vendor
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Vendor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Vendor/5
        public void Delete(int id)
        {
        }
    }
}
