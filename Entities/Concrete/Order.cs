using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
   public class Order:IEntity
    {
        public int OrdeId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}
