using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class BuildingComplex
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(8,6)")]
        public decimal Longitude { get; set; }

        [Column(TypeName = "decimal(8,6)")]
        public decimal Latitude { get; set; }

        [JsonIgnore]
        public ICollection<Apartment> Apartment { get; set; }
    }
}
