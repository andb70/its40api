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
                new Zone{Name="Ingresso", ZoneId = 1 },
                new Zone{Name="Giochi", ZoneId = 2 },
                new Zone{Name="Casalinghi", ZoneId = 3 },
                new Zone{Name="Piccoli amici", ZoneId = 4 },
                new Zone{Name="Birre", ZoneId = 5 },
                new Zone{Name="Vini", ZoneId = 6 },
                new Zone{Name="Zona promo 2", ZoneId = 7 },
                new Zone{Name="Zona promo 1", ZoneId = 8 },
                new Zone{Name="Canco carni", ZoneId = 9 },
                new Zone{Name="Banco formaggi", ZoneId = 10 },
                new Zone{Name="Corsia 3", ZoneId = 11 },
                new Zone{Name="Corsia 2", ZoneId = 12 },
                new Zone{Name="Corsia 1", ZoneId = 13 },
                new Zone{Name="Uscita", ZoneId = 14 }
            };

        }
    }
}
