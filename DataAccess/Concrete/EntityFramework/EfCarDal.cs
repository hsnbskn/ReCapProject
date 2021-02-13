using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MydbContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetails()
        {            

            using (MydbContext context = new MydbContext())
            {
                var result = from ca in context.Cars
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 BrandId = br.BrandId,
                                 BrandName = br.BrandName,
                                 ColorId = co.ColorId,
                                 ColorName = co.ColorName,
                                 Id = ca.Id,
                                 CarName = ca.carName,
                                 Description = ca.Description,
                                 ModelYear = ca.ModelYear,
                                 DailyPrice = ca.DailyPrice
                             };
                return result.ToList();

            }

        }
    }
}
