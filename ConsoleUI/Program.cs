using System;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAddTest();            
            //DetailsTest();
            //UserAddTest();
            //CustomerAddTest();
            //RentalAddTest();
            //RentalUpdateTest();

        }

        private static void RentalUpdateTest()
        {
            Rental rental1 = new Rental { CarId = 3, CustomerId = 2, ReturnDate = DateTime.Now };
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Update(rental1);
        }

        private static void RentalAddTest()
        {
            Rental rental3 = new Rental { CarId = 3, CustomerId = 1, RentDate = DateTime.Now};
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
                        
            Console.WriteLine(rentalManager.Add(rental3).Message);
        }

        private static void CustomerAddTest()
        {
            Customer customer2 = new Customer { UserId = 2, CompanyName = "X-Bilişim" };

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(customer2);

            
        }

        private static void UserAddTest()
        {
            User user2 = new User { FirstName = "Alparslan", LastName = "Beyazıt", Password = "deneme132", Email = "alparslan@gmail.com" };

            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Add(user2);
        }

        private static void DetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " | " + car.BrandName + " | " + car.ColorName + " | " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

       

        private static void CarAddTest()
        {
            //Araba tanımla
            Car car1 = new Car { Id = 6, BrandId = 1, ColorId = 7, DailyPrice = 800, Description = "Yeni eklenen araç", ModelYear = 2010 };

            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            //Yeni araba ekle
            carManager.Add(car1);

            
        }
    }
}

