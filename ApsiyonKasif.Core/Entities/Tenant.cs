using ApsiyonKasif.Core.DTOs.ResponseDto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class Tenant
    {
        [JsonIgnore]
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }

        [JsonIgnore]
        public int HomeId { get; set; }

        [JsonIgnore]
        public bool IsOccupied { get; set; }

        [JsonIgnore]
        public Home Home { get; set; }

        [JsonIgnore]
        public string AppUserId { get; set; }

        [JsonIgnore]
        public AppUser AppUser { get; set; }
    }
}
