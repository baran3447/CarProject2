using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework;
using Entitis.Concrete;
using Entitis.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join c2 in context.Colors
                             on c.ColorId equals c2.ColorId
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 Id = c.Id,
                                 CarName = c.CarName,
                                 ColorName = c2.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();

            }
            
        }
    }
}