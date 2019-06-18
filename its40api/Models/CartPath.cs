namespace its40api.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CartPath
    {
        public int Rank { get; set; }
        public string ZoneSequence { get; set; }
        public List<ZoneTime> Zones { get; set; }
        public TimeSpan AvgTime { get; set; }
        public int NumCarts { get; set; }
    }
    public class ZoneTime
    {
        public int ZoneId { get; set; }
        public TimeSpan AvgTime { get; set; }
    }
    public static class CartPathUtil
    {
        static Random rand = new Random();
        public static List<CartPath> GetCartPaths()
        {
            var l = new List<CartPath>();
            for (int i = 1; i < 10; i++)
            {
                l.Add(GetCartPath(i));
            }
            return l;
        }
        public static CartPath GetCartPath(int rank)
        {
            var zones = GetZones();
            TimeSpan avgTime = new TimeSpan(zones[0].AvgTime.Ticks);
            StringBuilder seq = new StringBuilder(zones[0].ZoneId.ToString()); 
            for (int i = 1; i < zones.Count; i++)
            {
                seq.Append(" - ");
                seq.Append(zones[i].ZoneId.ToString());
                avgTime.Add(zones[1].AvgTime);
            }
            var cp = new CartPath
            {
                Rank= rank,
                Zones = zones,
                ZoneSequence = seq.ToString(),
                NumCarts = rand.Next(1, 100),
                AvgTime=avgTime
            };
            return cp;
        }

        public static List<ZoneTime> GetZones()
        {
            var list = new List<ZoneTime>();
            for (int i = 0; i < rand.Next(3,15); i++)
            {
                decimal s = rand.Next(10, 300);
                int m =(int)Math.Floor(s / 60M);
                s = s - m * 60;
                list.Add(new ZoneTime { ZoneId = rand.Next(1, 15), AvgTime = new TimeSpan(0,m,(int)s) });
            }
            return list;
        }
    }

}
