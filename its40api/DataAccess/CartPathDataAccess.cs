namespace its40api.DataAccess
{
    using System.Collections.Generic;
    using Dapper;
    using System.Data.SqlClient;
    using its40api.Models;
    using System;
    using Vibrant.InfluxDB.Client;

    //using Vibrant.InfluxDB.Client;

    // https://github.com/MikaelGRA/InfluxDB.Client
    public class CartPathDataAccess : IDataAccess<CartPath>
    {
        InfluxClient client;
        //<<<<<<<<<<<<InfluxDBClient client;
        public CartPathDataAccess(string host)
        {

            client = new InfluxClient(new Uri(host));
            var queryTemplate = "SELECT cart_id, zone_id, time FROM qr_codes.autogen.cart_data limit 10";
            var resultSet = client.ReadAsync<QrInfo>("qr_codes", queryTemplate).Result;
            // resultSet will contain 1 result in the Results collection (or multiple if you execute multiple queries at once)
            var result = resultSet.Results[0];

            // result will contain 1 series in the Series collection (or potentially multiple if you specify a GROUP BY clause)
            var series = result.Series[0];
            var list = new List<CartPath>();
            //foreach (var row in series.Rows)
            //{
            //    list.Add(new CartPath {Zones })

            //}


            /*client = new InfluxDBClient(host, "qr_codses", "");
         List<string> dbNames =  client.GetInfluxDBNamesAsync().Result;
         var r = client.QueryMultiSeriesAsync("qr_codes", "select * from qr_codes.autogen.cart_data limit 10").Result;*/
        }

        public List<CartPath> GetList(string whereClause, object filters = null)
        {
            /*
                public int Rank { get; set; }
                public string ZoneSequence { get; set; }
                public List<ZoneTime> Zones { get; set; }
                public TimeSpan AvgTime { get; set; }
                public int NumCarts { get; set; }
           */

            /*
            print(f"{info.rect.top},  {info.rect.left}       Top, Left      {z.rect.top},{z.rect.left}")
           print(f"{info.rect.bottom},{info.rect.right}   - Bottom, Right    {z.rect.top + z.rect.height},{z.rect.left + z.rect.width}")
            403,8       Top, Left      0,0
            465,69    Bottom, Right    720,128 

            58,553       Top, Left      24,576
            124,626    Bottom, Right    648,640
             * */

            /*var queryTemplate = "SELECT cart_id, zone_id, time FROM qr_codes.autogen.cart_data limit 2000";
            var resultSet = client.ReadAsync<QrInfo>("qr_codes", queryTemplate).Result;
            // resultSet will contain 1 result in the Results collection (or multiple if you execute multiple queries at once)
            var result = resultSet.Results[0];

            // result will contain 1 series in the Series collection (or potentially multiple if you specify a GROUP BY clause)
            var series = result.Series[0];
            var list = new List<Cart>();
            int id = -1;
            int count = 0;
            foreach (var row in series.Rows)
            {
                if (row.QrId != id)
                    list.Add(new Cart { CartId = row.QrId, ZoneId = row.ZoneId, TimeStamp = row.TimeStamp });
                id = row.QrId;
                if (++count > 20)
                    break;
            }*/

            return CartPathUtil.GetCartPaths();

        }
    }
}
