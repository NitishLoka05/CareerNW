using CareerNW.RepoEF.Components;
using CareerNW.ServiceWebAPI.Models;
using CareerNW.ServiceWebAPI.Models.DTOs;
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
        public IList<Vendor> Get()
        {
            return _vendorModel.GetVendors();
        }

        // GET: api/Vendor/5
        public Vendor Get(long id)
        {
            return _vendorModel.GetVendors(id);
        }

        // POST: api/Vendor
        public IHttpActionResult Post([FromBody]Vendor vendor)
        {
            _vendorModel.CreateVendor(vendor);
            return Ok();
        }

        // PUT: api/Vendor/5
        public IHttpActionResult Put(long id, [FromBody]Vendor vendor)
        {
            _vendorModel.UpdateVendor(vendor);
            return Ok();
        }

        // DELETE: api/Vendor/5
        public IHttpActionResult Delete(long id)
        {
            _vendorModel.DeleteVendor(id);
            return Ok();
        }
    }
}
