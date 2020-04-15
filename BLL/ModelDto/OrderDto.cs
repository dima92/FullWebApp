using System;
using DAL.Entities;

namespace BLL.ModelDto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public bool Rent { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}