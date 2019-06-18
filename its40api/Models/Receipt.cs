namespace its40api.Models
{
    using System;
    using System.Collections.Generic;
    public class Receipt
    {
        public int CartId { get; set; }
        public List<ShoppingList> ShoppingList { get; set; }
        public decimal TotalSpending { get; set; }
        public DateTime TimeStamp { get; set; }

    }
    public class ShoppingList
    {
        public int ZoneId { get; set; }
        public decimal ShopAmount { get; set; }
    }
    public static class ReceiptUtil
    {
        static Random rand = new Random();
        public static List<Receipt> GetReceips()
        {
            var l = new List<Receipt>();
            for (int i = 0; i < 100; i++)
            {
                if (rand.Next(0,2)>0)
                {
                    l.Add(GetReceipt(i));
                }
            }
            return l;
        }
        public static Receipt GetReceipt(int cartId)
        {
            var shoppingList = GetShoppingList();
            decimal totalSpending = 0;
            foreach (var s in shoppingList)
            {
                totalSpending+=s.ShopAmount;
            }
            var r = new Receipt
            {
                CartId= cartId,
                ShoppingList= shoppingList,
                TotalSpending = totalSpending,
                TimeStamp = DateTime.Now
            };
            return r;
        }

        public static List<ShoppingList> GetShoppingList()
        {
            var list = new List<ShoppingList>();
            for (int i = 0; i < rand.Next(3, 15); i++)
            {
                list.Add(new ShoppingList { ZoneId = rand.Next(1, 15), ShopAmount = (decimal)rand.Next(50,5000) /100 });
            }
            return list;
        }
    }

}
