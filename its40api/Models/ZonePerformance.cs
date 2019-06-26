namespace its40api.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ZonePerformance
    {
        public int ZoneId { get; set; }
        public int PreviousZoneId { get; set; }
        public int NumCarts { get; set; }
        public decimal AvgSpending { get; set; }
        public decimal TotalSpending { get; set; }
        public decimal Conversion { get; set; }
        public TimeSpan AvgStayTime { get; set; }
        public DateTime TimeStamp { get; set; }
    }
    public static class ZonePerformanceUtil
    {
        static Random rand = new Random();
        public static List<ZonePerformance> GetZonePerformances()
        {
            var l = new List<ZonePerformance>();
            for (int i = 1; i < 14; i++)
            {
                l.Add(GetZonePerformance(i));
            }
            return l;
        }
        public static ZonePerformance GetZonePerformance(int zoneId)
        {
            int numCarts = rand.Next(20, 60);
            decimal totalSpending= (decimal)rand.Next(1000, 6000) / 100;
            decimal s = rand.Next(10, 300);
            int m = (int)Math.Floor(s / 60M);
            s = s - m * 60;
            var r = new ZonePerformance
            {
                PreviousZoneId = rand.Next(1, 14),
                NumCarts = numCarts,
                AvgSpending= totalSpending /numCarts,
                TotalSpending = totalSpending ,
                Conversion = (decimal)rand.Next(3000, 8000) / 100,
                AvgStayTime = new TimeSpan(0, m, (int)s),
                TimeStamp = DateTime.Now
            };
            return r;
        }

    }
}
