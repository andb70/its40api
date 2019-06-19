namespace its40api.Controllers
{
    using System.Collections.Generic;
    using its40api.DataAccess;
    using its40api.Models;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;

    [Route("api/[controller]")]
    [ApiController]
    public class CartPathController : ControllerBase
    {
        IDataAccess<CartPath> _dataAccess;
        public CartPathController(IDataAccess<CartPath> dataAccess)
        {
            _dataAccess = dataAccess;
        }
        // GET api/CartPath/id
        [HttpGet("{cartId}")]
        public ActionResult<IEnumerable<CartPath>> Get(int cartId)
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
        [HttpGet("s/{cartId}")]
        public ActionResult<string> Json(int cartId)
        {
            var list = _dataAccess.GetList("");
            var o = new { list};
            var u = JsonConvert.SerializeObject(o);
            return u;
        }
        [HttpGet("o/{cartId}")]
        public ActionResult<object> Boo(int cartId)
        {
            var list = _dataAccess.GetList("");
            var o = new { list };
            return o;
        }

        [HttpOptions]
        public IActionResult Options()
        {
            return Ok();
        }
    }
}