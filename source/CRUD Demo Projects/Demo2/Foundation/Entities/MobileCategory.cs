using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Entities
{
    public class MobileCategory : IEntity<int>
    {
        public int Id { get; set; }
        public int MobileId { get; set; }
        public Mobile Mobile { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
