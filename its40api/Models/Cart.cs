namespace its40api.Models
{
    using System;
    using System.Collections.Generic;

    public class Cart
    {
        public int CartId { get; set; }
        public int ZoneId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
    public static class CartUtil
    {
        static Random rand = new Random();

        public static List<Cart> GetCarts()
        {
            var l = new List<Cart>();
            for (int i = 0; i < 100; i++)
            {
                if (rand.Next(0, 4) > 2)
                {
                    l.Add(GetCart(i));
                }
            }
            return l;
        }
        public static Cart GetCart(int cartId)
        {
            var c = new Cart
            {
                CartId = cartId,
                ZoneId = rand.Next(1,14),
                TimeStamp = DateTime.Now
            };
            return c;
        }
    }

}
