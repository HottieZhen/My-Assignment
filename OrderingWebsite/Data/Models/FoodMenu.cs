using System;
namespace OrderingWebsite.DAL.Models
{
    public class FoodMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
