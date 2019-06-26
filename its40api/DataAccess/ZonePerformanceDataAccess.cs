namespace its40api.DataAccess
{
    using System.Collections.Generic;
    using Dapper;
    using System.Data.SqlClient;
    using its40api.Models;
    using Vibrant.InfluxDB.Client;
    using System;
    public class ZonePerformanceDataAccess : IDataAccess<ZonePerformance> 
    {
        InfluxClient client;
        public ZonePerformanceDataAccess(string host)
        {
            client = new InfluxClient(new Uri(host));
        }

        public List<ZonePerformance> GetList(string whereClause, object filters = null)
        {
            /*
            var queryTemplate = "SELECT cart_id, zone_id, time FROM qr_codes.autogen.cart_data limit 2000";
            var resultSet = client.ReadAsync<QrInfo>("qr_codes", queryTemplate).Result;
            // resultSet will contain 1 result in the Results collection (or multiple if you execute multiple queries at once)
            var result = resultSet.Results[0];

            // result will contain 1 series in the Series collection (or potentially multiple if you specify a GROUP BY clause)
            var series = result.Series[0];
            var list = new List<ZonePerformance>();
            int id = -1;
            int count = 0;
            foreach (var row in series.Rows)
            {
                if (row.QrId != id)
                    list.Add(new ZonePerformance {  ZoneId = row.ZoneId, TimeStamp = row.TimeStamp });
                id = row.QrId;
                if (++count > 20)
                    break;
            }
            return list;// CartUtil.GetCarts();
            */
            return ZonePerformanceUtil.GetZonePerformances();

        }
    }
}
