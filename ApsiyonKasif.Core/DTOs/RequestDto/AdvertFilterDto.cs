using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.DTOs.RequestDto
{
    public record AdvertFilterDto(
        decimal? maxPrice,
        decimal? minPrice,
        int? minApartmentAge,
        int? maxApartmentAge,
        decimal? dues,
        int? roomCountId,
        int? floor,
        decimal? minNetArea,
        decimal? maxNetArea,
        bool? hasFurnished,
        int? heatingTypeId
        );
}
