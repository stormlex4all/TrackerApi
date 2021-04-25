using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TSLTestApi.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TSLTestTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class TrackerController : ControllerBase
    {
        private ITracker iTracker;
        public TrackerController(ITracker ITracker)
        {
            this.iTracker = ITracker;
        }

        // GET: api/<TrackingController>
        [HttpGet]
        public string Get()
        {
            return "value";
        }


        // GET api/<TrackingController>/5
        [HttpGet("{trackingId}")]
        public ActionResult<object> GetTrackingData(string trackingId)
        {
            try
            {
                var data = iTracker.GetTrackingData(trackingId);
                if (data != null)
                {
                    return Ok(new { success = true, result = data });
                }
                return Ok(new { success = true, message = "Nothing was found or wrong TrackerId!" });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/<TrackingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TrackingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TrackingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
