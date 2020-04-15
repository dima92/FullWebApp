using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string ClassCar { get; set; }
        public DateTime DateManufacture { get; set; }
        public string NumberRegistration { get; set; }
        public virtual ICollection<Order> Order { get; set; }

        public override string ToString()
        {
            return $"{Mark} {Model}";
        }
    }
}