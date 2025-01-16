using ApsiyonKasif.Core.DTOs.RequestDto;
using ApsiyonKasif.Core.Entities;
using ApsiyonKasif.Core.Repositories;
using ApsiyonKasif.Core.Services;
using ApsiyonKasif.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonKasif.Service.Services
{
    public class AdvertService : GenericService<Advert>, IAdvertService
    {
        private readonly IAdvertRepository _advertRepository;
        public AdvertService(IGenericRepository<Advert> repository, IUnitOfWork unitOfWork, IAdvertRepository advertRepository) : base(repository, unitOfWork)
        {
            _advertRepository = advertRepository;
        }

        public async Task<Advert> AdvertDetail(int advertId)
        {
            return await _advertRepository.AdvertDetail(advertId);
        }

        public async Task<List<Advert>> AdvertFilter(AdvertFilterDto filter)
        {
            return await _advertRepository.AdvertFilter(filter);
        }
    }
}
