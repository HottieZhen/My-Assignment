﻿using System;
namespace OrderingWebsite.BLL
{
    public class FoodMenuDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
}
