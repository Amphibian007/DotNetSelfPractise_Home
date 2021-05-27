using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalculator
{
    public class InputConverter
    {
        public double InputToNumeric(string input)
        {
            double output = double.Parse(input);
            return output;
        }
    }
}
