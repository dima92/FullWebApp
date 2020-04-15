using System;
using System.Collections.Generic;
using DAL.Entities;

namespace BLL.ModelDto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirthday { get; set; }
        public string NumberLicense { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}