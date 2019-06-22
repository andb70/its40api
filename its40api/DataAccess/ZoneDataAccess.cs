namespace its40api.DataAccess
{
    using System.Collections.Generic;
    using Dapper;
    using System.Data.SqlClient;
    using InfluxData.Net.InfluxDb;
    using InfluxData.Net.Common.Enums;
    using InfluxData.Net.Common.Infrastructure;
    using its40api.Models;

    public class ZoneDataAccess : IDataAccess<Zone> 
    {
        //IInfluxDbClientConfiguration a; 
        //InfluxDbClient influxDbClient;
        public ZoneDataAccess(string host)
        {
            //influxDbClient = new InfluxDbClient(a);
        }

        public List<Zone> GetList(string whereClause, object filters = null)
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

            return new List<Zone>() {
                    new Zone{Name="BANCO FORMAGGI", ZoneId = 1}
                    , new Zone{Name="e", ZoneId = 2}
                    , new Zone{Name="Servizio Formaggi 1", ZoneId = 3}
                    , new Zone{Name="Alimentari", ZoneId = 4}
                    , new Zone{Name="e", ZoneId = 5}
                    , new Zone{Name="Servizio Carni 1", ZoneId = 6}
                    , new Zone{Name="Prodotti da frigo", ZoneId = 7}
                    , new Zone{Name="Detersivi", ZoneId = 8}
                    , new Zone{Name="Bibite", ZoneId = 9}
                    , new Zone{Name="scaffale 2", ZoneId = 10}
                    , new Zone{Name="e", ZoneId = 11}
                    , new Zone{Name="Servizio Formaggi 2", ZoneId = 12}
                    , new Zone{Name="BANCO CARNI", ZoneId = 13}
                    , new Zone{Name="Scaffale1", ZoneId = 14}
                    , new Zone{Name="Prodotti da forno", ZoneId = 15}
                    , new Zone{Name="Promo", ZoneId = 16}
                    , new Zone{Name="Servizio carni 2", ZoneId = 17}
                    , new Zone{Name="Verdure", ZoneId = 18}
                    , new Zone{Name="e", ZoneId = 19}
                    , new Zone{Name="Cassa 1", ZoneId = 20}
                    , new Zone{Name="e", ZoneId = 21}
                    , new Zone{Name="Cassa 2", ZoneId = 22}
                    , new Zone{Name="e", ZoneId = 23}
                    , new Zone{Name="Ingresso 1", ZoneId = 24}
                    , new Zone{Name="e", ZoneId = 25}
                    , new Zone{Name="Ingresso 2", ZoneId = 26}
                    , new Zone{Name="e", ZoneId = 27}
            };

        }
    }
}
