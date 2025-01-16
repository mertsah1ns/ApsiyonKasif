using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class HomeImage
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public int HomeId { get; set; }
        
        [JsonIgnore]
        public Home Home { get; set; }
    }
}
