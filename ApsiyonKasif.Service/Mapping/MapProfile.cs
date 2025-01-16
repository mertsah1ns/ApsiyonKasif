using ApsiyonKasif.Core.DTOs.RequestDto;
using ApsiyonKasif.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonKasif.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Advert, CreateAdvertDto>().ReverseMap();
        }
    }
}
