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
}
