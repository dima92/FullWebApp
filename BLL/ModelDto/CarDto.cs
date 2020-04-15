using System;
using System.Collections.Generic;
using DAL.Entities;

namespace BLL.ModelDto
{
    public class CarDto
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string ClassCar { get; set; }
        public DateTime DateManufacture { get; set; }
        public string NumberRegistration { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}