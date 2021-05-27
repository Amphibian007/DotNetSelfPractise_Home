using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressionPractise
{
    public class Book
    {
        public string Title { get; set; }
        private int _price;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
