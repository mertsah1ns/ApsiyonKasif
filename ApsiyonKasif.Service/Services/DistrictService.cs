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
    public class DistrictService : GenericService<District>, IDistrictService
    {
        private readonly IDistrictRepository _districtRepository;
        public DistrictService(IGenericRepository<District> repository, IUnitOfWork unitOfWork, IDistrictRepository districtRepository) : base(repository, unitOfWork)
        {
            _districtRepository = districtRepository;
        }

        public async Task<District> GetDistrictDetailsAsync(int districtId)
        {
            return await _districtRepository.GetDistrictDetailsAsync(districtId);
        }
    }
}
