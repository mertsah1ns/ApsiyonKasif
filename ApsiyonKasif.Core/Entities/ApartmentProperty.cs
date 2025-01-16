using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class ApartmentProperty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int ApartmentId { get; set; }

        [JsonIgnore]
        public Apartment Apartment { get; set; }
    }
}
