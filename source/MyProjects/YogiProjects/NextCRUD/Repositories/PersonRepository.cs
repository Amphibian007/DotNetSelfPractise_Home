using NextCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextCRUD.Repositories
{
    public static class PersonRepository
    {
        public static List<Person> allPersons = new List<Person>();
        public static IEnumerable<Person> showAllPersons
        {
            get { return allPersons; }
        }
        public static void Create(Person p1)
        {
            allPersons.Add(p1);
        }
        public static void Delete(Person p1)
        {
            allPersons.Remove(p1);
        }
    }
}
