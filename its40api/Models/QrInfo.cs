using System;
namespace its40api.Models
{
    using Vibrant.InfluxDB.Client;

    public class QrInfo
    {
        [InfluxField("cart_id")]
        public int QrId { get; set; }

        [InfluxField("zone_id")]
        public int ZoneId { get; set; }

        [InfluxTimestamp]
        //[InfluxField("time")]
        public DateTime TimeStamp { get; set; }
    }
}
