using ApsiyonKasif.Core.Entities;

namespace ApsiyonKasif.Core.Repositories
{
    public interface IDistrictRepository : IGenericRepository<District>
    {
        Task<District> GetDistrictDetailsAsync(int districtId);
    }
}
