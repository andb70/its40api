namespace its40api.DataAccess
{
    using System.Collections.Generic;
    using Dapper;
    using System.Data.SqlClient;
    using its40api.Models;

    public class ReceiptDataAccess : IDataAccess<Receipt> 
    {
        //IInfluxDbClientConfiguration a; 
        //InfluxDbClient influxDbClient;
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

            return ReceiptUtil.GetReceips();

        }
    }
}
