using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class RoomCount
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        [JsonIgnore]
        public ICollection<Home> Homes { get; set; }
    }
}
