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
    public class HomeService : GenericService<Home>, IHomeService
    {
        public HomeService(IGenericRepository<Home> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
