namespace its40api.DataAccess
{
    using System.Collections.Generic;
    using Dapper;
    using System.Data.SqlClient;
    using InfluxData.Net.InfluxDb;
    using InfluxData.Net.Common.Enums;
    using InfluxData.Net.Common.Infrastructure;
    using its40api.Models;

    public class CartDataAccess : IDataAccess<Cart> 
    {
        //IInfluxDbClientConfiguration a; 
        //InfluxDbClient influxDbClient;
        public CartDataAccess(string host)
        {
            //influxDbClient = new InfluxDbClient(a);
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


            //var serialNumber = "F2EA2B0CDFF";
            ////var queryTemplate = "SELECT cart_id, zone_id, time FROM qr_codes.autogen.cart_data WHERE \"serialNumber\" = @SerialNumber";
            //var queryTemplate = "SELECT cart_id, zone_id, time FROM qr_codes.autogen.cart_data";

            //var response = influxDbClient.Client.QueryAsync(
            //    queryTemplate: queryTemplate,
            //    parameters: new
            //    {
            //        @cart_id = serialNumber
            //    },
            //    dbName: "qr_codes"
            //).Result;
            /*
    public class Cart
    {
        public int CartId { get; set; }
        public int ZoneId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
             */
            return new List<Cart> {
                new Cart { CartId = 1 , ZoneId =3, TimeStamp =new System.DateTime(2019,6,10,11,23,12)},
                new Cart { CartId = 1 , ZoneId =4, TimeStamp =new System.DateTime(2019,6,12,16,55,44)},
                new Cart { CartId = 1 , ZoneId =5, TimeStamp =new System.DateTime(2019,6,17,8,23,12)},
                new Cart { CartId = 1 , ZoneId =5, TimeStamp =new System.DateTime(2019,6,17,9,23,12)},
                new Cart { CartId = 5 , ZoneId =14, TimeStamp =new System.DateTime(2019,6,17,10,23,12)},
                new Cart { CartId = 5 , ZoneId =5, TimeStamp =new System.DateTime(2019,6,17,11,23,12)},
                new Cart { CartId = 5 , ZoneId =11, TimeStamp =new System.DateTime(2019,6,17,14,23,12)},
                new Cart { CartId = 6 , ZoneId =9, TimeStamp =new System.DateTime(2019,6,17,15,23,12)},
                new Cart { CartId = 6 , ZoneId =7, TimeStamp =new System.DateTime(2019,6,17,16,23,12)},
                new Cart { CartId = 7 , ZoneId =3, TimeStamp =new System.DateTime(2019,6,17,16,23,12)} };

        }
    }
}
