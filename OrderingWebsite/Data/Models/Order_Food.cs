using System;
namespace OrderingWebsite.DAL.Models
{
    public class Order_Food
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public int Count { get; set; }
    }
}
