using System;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Araba tanımla
            Car car1 = new Car {Id=6, BrandId=1, ColorId=7, DailyPrice= 800, Description="Yeni eklenen araç", ModelYear=2010 };                   
            
            CarManager carManager = new CarManager(new EfCarDal());
            //Yeni araba ekle
            carManager.Add(car1);

            Console.WriteLine("----------------------------\n");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " - " + car.Description);
            }


            

        }
    }
}

