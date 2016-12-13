using CareerNW.RepoEF;
using CareerNW.RepoEF.Components;
using CareerNW.ServiceWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CareerNW.ServiceWebAPI.Controllers
{
    [RoutePrefix("api/Vendor")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VendorController : ApiController
    {
        private IVendorComponent _vendorComponent;
        private VendorModel _vendorModel;

        public VendorController(IVendorComponent vendorComponent)
        {
            _vendorComponent = vendorComponent;
            _vendorModel = new VendorModel(_vendorComponent);
        }

        [HttpGet]
        // GET: api/Vendor
        public IList<Models.DTOs.Vendor> Get()
        {
            return _vendorModel.GetVendors();
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
        public IHttpActionResult Delete(long id)
        {
            _vendorModel.DeleteVendor(id);
            return Ok();
        }
    }
}
