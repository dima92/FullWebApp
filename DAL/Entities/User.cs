using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirthday { get; set; }
        public string NumberLicense { get; set; }
        public virtual ICollection<Order> Order { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}