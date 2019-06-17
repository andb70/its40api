namespace its40api.DataAccess
{
    using System.Collections.Generic;
    using Dapper;
    using System.Data.SqlClient;
    using InfluxData.Net.InfluxDb;
    using InfluxData.Net.Common.Enums;
    using InfluxData.Net.Common.Infrastructure;
    using its40api.Models;

    public class ReceiptDataAccess : IDataAccess<Receipt> 
    {
        IInfluxDbClientConfiguration a; 
        InfluxDbClient influxDbClient;
        public ReceiptDataAccess(string host)
        {
           // influxDbClient = new InfluxDbClient(a);
        }

        public List<Receipt> GetList(string whereClause, object filters = null)
        {
            /*
             SELECT cart_id, zone_id FROM qr_codes.autogen.cart_data WHERE time >= '2019-06-11T11:54:17Z' AND time <= '2019-06-11T19:10:27Z' AND cart_id = 3"
             */

            //string query = "SELECT cart_id, zone_id, time FROM qr_codes.autogen.cart_data\n";
            //using (var connection = new SqlConnection(_connectionString))
            //{
            //    var result = connection.Query<Receipt>(query + whereClause, filters);
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
    {
        public int CartId { get; set; }
        public List<ShoppingList> ShoppingList { get; set; }
        public int TotalSpending { get; set; }
        public DateTime TimeStamp { get; set; }

    }
    public class ShoppingList
    {
        public int ZoneId { get; set; }
        public int ShopAmount { get; set; }
    }
             */
            return new List<Receipt> {
                new Receipt { CartId = 1 , ShoppingList = new List<ShoppingList>{
                    new ShoppingList {ZoneId = 2, ShopAmount= 25.12M, },
                    new ShoppingList {ZoneId = 4, ShopAmount= 15.12M, },
                    new ShoppingList {ZoneId = 8, ShopAmount= 28M, },
                    new ShoppingList {ZoneId = 12, ShopAmount= 2.56M, }
                }, TotalSpending = 156.12M, TimeStamp =new System.DateTime(2019,6,17,16,23,12)},
};

        }
    }
}
