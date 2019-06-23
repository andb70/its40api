namespace its40api.DataAccess
{
    using System.Collections.Generic;
    using Dapper;
    using System.Data.SqlClient;

    using its40api.Models;

    public class CartDataAccess : IDataAccess<Cart> 
    {
       // IInfluxDbClientConfiguration a; 
       // InfluxDbClient influxDbClient;
        public CartDataAccess(string host)
        {
            //influxDbClient = new InfluxDbClient(host, "", "", InfluxDbVersion.v_1_3);
        }

        public List<Cart> GetList(string whereClause, object filters = null)
        {
            /*
             SELECT cart_id, zone_id FROM qr_codes.autogen.cart_data WHERE time >= '2019-06-11T11:54:17Z' AND time <= '2019-06-11T19:10:27Z' AND cart_id = 3"
             */

            //string query = "SELECT cart_id, zone_id, time FROM qr_codes.autogen.cart_data\n";
            //using (var connection = new SqlConnection(_connectionString))
            //{
            //    var result = connection.Query<Cart>(query + whereClause, filters);
            //    return result.AsList();
            //}


            /*
    public class Cart
    {
        public int CartId { get; set; }
        public int ZoneId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
             */
            return CartUtil.GetCarts();

        }
    }
}
