using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountyId { get; set; }

        //[JsonIgnore]
        public County County { get; set; }

        [JsonIgnore]
        public ICollection<Apartment> Apartments { get; set; }
    }
}
