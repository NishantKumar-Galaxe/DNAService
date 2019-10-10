using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [DataContract]
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    [DataContract]
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal PricePerUser { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public bool Discontinued { get; set; }
        public int ReorderLevel { get; set; }
    }

    [DataContract]
    public class Supplier
    {
        public string Id { get; set; }
        public Contact Contact { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
    }

    [DataContract]
    public class Region
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Territory> Territories { get; set; }
    }

    [DataContract]
    public class Territory
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    [DataContract]
    public class Shipper
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
