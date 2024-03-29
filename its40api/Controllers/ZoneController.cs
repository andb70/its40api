﻿namespace its40api.Controllers
{
    using System.Collections.Generic;
    using its40api.DataAccess;
    using its40api.Models;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;

    [Route("api/[controller]")]
    [ApiController]
    public class ZoneController : ControllerBase
    {
        IDataAccess<Zone> _dataAccess;
        public ZoneController(IDataAccess<Zone> dataAccess)
        {
            _dataAccess = dataAccess;
        }
        // GET api/Cart/id
        [HttpGet]
        public ActionResult<IEnumerable<Zone>> Get()
        {
            
            //try
            //{
                /*
                 SELECT cart_id, zone_id FROM qr_codes.autogen.cart_data WHERE time >= '2019-06-11T11:54:17Z' AND time <= '2019-06-11T19:10:27Z' AND cart_id = 3"
                 */
                var list = _dataAccess.GetList("");
                return Ok(list);
            //}
            //catch (Exception e)
            //{
            //    return StatusCode(500);
            //}
        }
        // GET api/values/5
        [HttpGet("s")]
        public ActionResult<string> Json()
        {
            var list = _dataAccess.GetList("");
            var o = new { list };
            var u = JsonConvert.SerializeObject(o);
            return Ok(u);
        }
        [HttpGet("o")]
        public ActionResult<object> Boo()
        {
            var list = _dataAccess.GetList("");
            var o = new { list };
            return Ok(o);
        }
        [HttpOptions]
        public IActionResult Options()
        {
            return Ok();
        }
    }
}