using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [DataContract]
    public class Order
    {
        public string Id { get; set; }
        public string Company { get; set; }
        public string Employee { get; set; }
        public DateTime OrderedAt { get; set; }
        public DateTime RequireAt { get; set; }
        public DateTime? ShippedAt { get; set; }
        public Address ShipTo { get; set; }
        public string ShipVia { get; set; }
        public decimal Freight { get; set; }
        public List<OrderLine> Lines { get; set; }
    }

    [DataContract]
    public class OrderLine
    {
        public string Product { get; set; }
        public string ProductName { get; set; }
        public decimal PricePerUnit { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
    }

}
