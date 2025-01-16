using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class Advert
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

        public int AdvertTypeId { get; set; }

        //[JsonIgnore]
        public AdvertType AdvertType { get; set; }

        public int HomeId { get; set; }

        //[JsonIgnore]
        public Home Home { get; set; }

        [JsonIgnore]
        public int ApartmentId { get; set; }

        //[JsonIgnore]
        public Apartment Apartment { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
