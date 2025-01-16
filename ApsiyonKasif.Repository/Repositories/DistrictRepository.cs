using ApsiyonKasif.Core.Entities;
using ApsiyonKasif.Core.Repositories;
using ApsiyonKasif.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonKasif.Repository.Repositories
{
    public class DistrictRepository : GenericRepository<District>, IDistrictRepository
    {
        public DistrictRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<District> GetDistrictDetailsAsync(int districtId)
        {
            return (await _context.Districts.
                Where(d => d.Id == districtId)
                .Include(d => d.County)
                .Include(d => d.County)
                    .ThenInclude(d => d.City)
                .Include(d => d.County)
                    .ThenInclude(d => d.City)
                        .ThenInclude(d => d.Counties)
                .FirstOrDefaultAsync())!;
        }
    }
}
