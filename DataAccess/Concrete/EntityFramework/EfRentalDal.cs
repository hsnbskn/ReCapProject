using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,MydbContext>,IRentalDal
    {        
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (MydbContext context = new MydbContext())
            {
                var result = from re in context.Rentals
                             join ca in context.Cars
                             on re.CarId equals ca.Id
                             join cus in context.Customers
                             on re.CustomerId equals cus.Id
                             join us in context.Users
                             on cus.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = re.Id,
                                 CarName = ca.carName,
                                 CarId = ca.Id,
                                 RentDate = re.RentDate,                                 
                                 UserName = us.FirstName + " " + us.LastName 

                             };
                return result.ToList();                     

            }
        }
    }
}
