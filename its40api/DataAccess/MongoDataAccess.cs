namespace its40api.DataAccess
{
    using System.Collections.Generic;
    using Dapper;
    using System.Data.SqlClient;
    using its40api.Models;
    using MongoDB.Bson;
    using MongoDB.Driver;
    using System;

    public class MongoDataAccess : IDataAccess<Cart> 
    {
        MongoClient client;
        public MongoDataAccess(string connectionString)
        {
            // ...
            client = new MongoClient(connectionString);
            var database = client.GetDatabase("its40");
            //collection: receipts
            var collection = database.GetCollection<BsonDocument>("receipts");
            try
            {
                var documents = collection.Find(new BsonDocument()).ToList();
            }catch (Exception e)
            { 
                System.Console.WriteLine(e);
            }
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
            return CartUtil.GetCarts();

        }
    }
}
