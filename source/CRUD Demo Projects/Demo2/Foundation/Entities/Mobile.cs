using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Entities
{
    public class Mobile : IEntity<int>
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Battery { get; set; }
        public string Screen { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string OS { get; set; }
        public string Camera { get; set; }
        public string Selfie { get; set; }

        public IList<MobileCategory> Categories { get; set; }
    }
}
