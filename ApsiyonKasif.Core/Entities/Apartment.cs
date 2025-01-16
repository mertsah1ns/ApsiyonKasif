using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class Apartment
    {
        public int Id { get; set; }
        //public string? Name { get; set; }
        //public string? ConnectedBlock { get; set; }
        //public int Age { get; set; }
        //public decimal Dues { get; set; }
        //public int NumberOfFloor { get; set; }

        //[Column(TypeName = "decimal(8,6)")]
        //public decimal Longitude { get; set; }

        //[Column(TypeName = "decimal(8,6)")]
        //public decimal Latitude { get; set; }
        //public bool HasElevator { get; set; }
        //public bool HasGarage { get; set; }

        public int DistrictId { get; set; }

        [JsonIgnore]
        public District District { get; set; }

        public int? BuildingComplexId { get; set; }

        [JsonIgnore]
        public BuildingComplex BuildingComplex { get; set; }    

        public int HeatingTypeId { get; set; }
        
        [JsonIgnore]
        public HeatingType HeatingType { get; set; }

        [JsonIgnore]
        public ICollection<Home> Home { get; set; }

        //[JsonIgnore]
        public ICollection<ApartmentProperty> ApartmentProperties { get; set; }
    }
}
