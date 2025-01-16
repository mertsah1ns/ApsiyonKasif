using ApsiyonKasif.Core.Entities;

namespace ApsiyonKasif.Core.Services
{
    public interface IDistrictService : IGenericService<District>
    {
        Task<District> GetDistrictDetailsAsync(int districtId);
    }
}
