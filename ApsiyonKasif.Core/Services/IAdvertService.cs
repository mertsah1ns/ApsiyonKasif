using ApsiyonKasif.Core.DTOs.RequestDto;
using ApsiyonKasif.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Services
{
    public interface IAdvertService : IGenericService<Advert>
    {
        Task<List<Advert>> AdvertFilter(AdvertFilterDto filter);
        Task<Advert> AdvertDetail(int advertId);
    }
}
