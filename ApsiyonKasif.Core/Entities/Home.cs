using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class Home
    {
        public int Id { get; set; }
        //public int DoorNumber { get; set; }
        //public int GrossArea { get; set; }
        //public int NetArea { get; set; }
        //public int Floor { get; set; }
        //public string Direction { get; set; }
        //public bool HasBalcony { get; set; }
        //public bool HasFurnished { get; set; }
        //public int BathroomCount { get; set; }

        //[Column(TypeName = "decimal(8,6)")]
        //public decimal Longitude { get; set; }

        //[Column(TypeName = "decimal(8,6)")]
        //public decimal Latitude { get; set; }

        //public int ApartmentId { get; set; }

        ////[JsonIgnore]
        //public Apartment Apartment { get; set; }

        [JsonIgnore]
        public int RoomCountId { get; set; }

        [JsonIgnore]
        public RoomCount RoomCount { get; set; }

        [JsonIgnore]
        public Advert Advert { get; set; }

        public ICollection<Invoice> Invoices { get; set; }

        //[JsonIgnore]
        public Owner Owner { get; set; }
        public ICollection<HomeProperty> HomeProperties { get; set; }
        public ICollection<Tenant> Tenants { get; set; }
        
        //[JsonIgnore]
        public ICollection<HomeImage> HomeImages { get; set; }
    }
}
