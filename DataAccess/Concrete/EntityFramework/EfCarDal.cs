using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in context.Cars
                             join color in context.Colors
                             on c.ColorId equals color.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailsDto
                             {
                                 ColorId = color.ColorId,
                                 ColorName = color.ColorName,
                                 BrandName = b.BrandName                                 
                             };
                return result.ToList();

            }
        }
    }
}
