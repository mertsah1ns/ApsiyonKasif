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
    public class Owner
    {
        public int Id { get; set; }
        public int HomeId { get; set; }

        [JsonIgnore]
        public Home Home { get; set; }
        public string AppUserId { get; set; }

        [JsonIgnore]
        public AppUser AppUser { get; set; }

        [NotMapped]
        public AppUserDto AppUserDto { get; set; }
    }
}
