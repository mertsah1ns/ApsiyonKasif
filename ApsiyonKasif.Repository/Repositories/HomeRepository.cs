using ApsiyonKasif.Core.Entities;
using ApsiyonKasif.Core.Repositories;
using ApsiyonKasif.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonKasif.Repository.Repositories
{
    public class HomeRepository : GenericRepository<Home>, IHomeRepository
    {
        public HomeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
