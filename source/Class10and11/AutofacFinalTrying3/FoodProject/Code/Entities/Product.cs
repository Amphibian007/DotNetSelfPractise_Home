using System;
using System.Collections.Generic;
using System.Text;

namespace FoodProject
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public IList<ProductImage> Images { get; set; }
        public IList<ProductCategory> Categories { get; set; }
    }
}
