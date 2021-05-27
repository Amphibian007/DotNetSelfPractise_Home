using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    public class DiscountCalculator<TProduct> where TProduct:Product
    {
        public double CalculateDiscount()
        {
            return 30;
        }
    }
}
