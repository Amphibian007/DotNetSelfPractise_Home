using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractise
{
    public class DiscountCalculator<TProduct> where TProduct:Product
    {
        public int CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}
