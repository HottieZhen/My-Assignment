using System;
using System.Collections.Generic;

namespace OrderingWebsite.BLL.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public List<Tuple<string, int>> FoodDic { get; set; }
    }
}
