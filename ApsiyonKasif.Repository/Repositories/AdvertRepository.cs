using ApsiyonKasif.Core.DTOs.RequestDto;
using ApsiyonKasif.Core.DTOs.ResponseDto;
using ApsiyonKasif.Core.Entities;
using ApsiyonKasif.Core.Repositories;
using ApsiyonKasif.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApsiyonKasif.Repository.Repositories
{
    public class AdvertRepository : GenericRepository<Advert>, IAdvertRepository
    {
        public AdvertRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Advert> AdvertDetail(int advertId)
        {
            var advert = (await _context.Adverts
                .Include(x => x.AdvertType)
                .Include(x => x.Appointments)
                .Include(x => x.Home)
                //.ThenInclude(h => h.RoomCount)
                .Include(x => x.Home)
                    .ThenInclude(h => h.HomeImages)
                .Include(x => x.Home)
                    .ThenInclude(h => h.Invoices)
                .Include(x => x.Home)
                    .ThenInclude(x => x.HomeProperties)
                .Include(x => x.Home)
                    .ThenInclude(h => h.Owner)
                .Include(x => x.Apartment)
                    .ThenInclude(x => x.ApartmentProperties)
                .Include(x => x.Home)
                    .ThenInclude(x => x.Owner)
                        .ThenInclude(o => o.AppUser)
                .Include(x => x.Home)
                    .ThenInclude(h => h.Owner)
                .Include(x => x.Home)
                    .ThenInclude(h => h.Tenants)
                //.Include(x => x.Home)
                //    .ThenInclude(h => h.Apartment)
                //        .ThenInclude(a => a.HeatingType)
                .Where(x => x.Id == advertId)
                .FirstOrDefaultAsync())!;


            var appUserDto = new AppUserDto
            {
                Name = advert.Home.Owner.AppUser.Name!,
                PhoneNumber = advert.Home.Owner.AppUser.PhoneNumber!
            };

            advert.Home.Owner.AppUserDto = appUserDto;

            return advert;
        }

        public async Task<List<Advert>> AdvertFilter(AdvertFilterDto filter)
        {
            //var query = _context.Adverts
            //    .Include(x => x.AdvertType)
            //    .Include(x => x.Home)
            //    .AsQueryable();

            //Expression<Func<Advert, bool>> predicate = x => true;

            //if (filter.maxPrice.HasValue)
            //    predicate = CombineExpressions(predicate, x => x.Price <= filter.maxPrice.Value);

            //if (filter.minPrice.HasValue)
            //    predicate = CombineExpressions(predicate, x => x.Price >= filter.minPrice.Value);

            ////if (filter.maxApartmentAge.HasValue)
            ////    predicate = CombineExpressions(predicate, x => x.Home.Apartment.Age <= filter.maxApartmentAge.Value);

            ////if (filter.minApartmentAge.HasValue)
            ////    predicate = CombineExpressions(predicate, x => x.Home.Apartment.Age >= filter.minApartmentAge.Value);

            ////if (filter.dues.HasValue)
            ////    predicate = CombineExpressions(predicate, x => x.Home.Apartment.Dues == filter.dues.Value);

            //if (filter.roomCountId.HasValue)
            //    predicate = CombineExpressions(predicate, x => x.Home.RoomCountId == filter.roomCountId.Value);

            //if (filter.floor.HasValue)
            ////    predicate = CombineExpressions(predicate, x => x.Home.Floor == filter.floor.Value);

            ////if (filter.minNetArea.HasValue)
            ////    predicate = CombineExpressions(predicate, x => x.Home.NetArea >= filter.minNetArea.Value);

            ////if (filter.maxNetArea.HasValue)
            ////    predicate = CombineExpressions(predicate, x => x.Home.NetArea <= filter.maxNetArea.Value);

            ////if (filter.hasFurnished.HasValue)
            ////    predicate = CombineExpressions(predicate, x => x.Home.HasFurnished == filter.hasFurnished.Value);

            ////if (filter.heatingTypeId.HasValue)
            ////    predicate = CombineExpressions(predicate, x => x.Home.Apartment.HeatingTypeId == filter.heatingTypeId.Value);

            //return await query.Where(predicate).ToListAsync();
            return null;
        }
     

        private Expression<Func<T, bool>> CombineExpressions<T>(
            Expression<Func<T, bool>> expr1,
            Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters);
            return Expression.Lambda<Func<T, bool>>(
                Expression.AndAlso(expr1.Body, invokedExpr),
                expr1.Parameters);
        }
    }
}
