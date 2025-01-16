using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Hours { get; set; }
        public bool IsScheduled { get; set; }

        public int AdvertId { get; set; }

        [JsonIgnore]
        public Advert Advert { get; set; }
    }
}
