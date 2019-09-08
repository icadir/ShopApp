﻿
using System.Collections.Generic;

namespace ShopApp.Entities.Entities
{
   public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

    }
}
