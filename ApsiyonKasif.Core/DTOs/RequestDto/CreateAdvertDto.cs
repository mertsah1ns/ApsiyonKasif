using ApsiyonKasif.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.DTOs.RequestDto
{
    public record CreateAdvertDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AdvertTypeId { get; set; }
        public int HomeId { get; set; }
    }
}
