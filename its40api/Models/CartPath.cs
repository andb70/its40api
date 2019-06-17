namespace its40api.Models
{
    using System;
    using System.Collections.Generic;
    public class CartPath
    {
        public int Rank { get; set; }
        public string ZoneSequence { get; set; }
        public List<ZoneTime> Zones { get; set; }
        public TimeSpan AvgTime { get; set; }
        double NumCarts { get; set; }
    }
    public class ZoneTime
    {
        public int ZoneId { get; set; }
        public TimeSpan AvgTime { get; set; }
    }
}
