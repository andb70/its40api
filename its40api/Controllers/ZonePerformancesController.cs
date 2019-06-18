namespace its40api.Controllers
{
    using System.Collections.Generic;
    using its40api.DataAccess;
    using its40api.Models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ZonePerformanceController : ControllerBase
    {
        IDataAccess<Cart> _dataAccess;
        public ZonePerformanceController(IDataAccess<Cart> dataAccess)
        {
            _dataAccess = dataAccess;
        }
        // GET api/Cart/id
        [HttpGet("{cartId}")]
        public ActionResult<IEnumerable<ZonePerformance>> Get(int cartId)
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
    }
}