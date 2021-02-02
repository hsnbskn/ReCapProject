using System;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Business.Abstract;
using DataAccess.Abstract;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("-----Başlangıç Listesi------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " - " + car.Description);
            }


            //ARAÇ EKLE
            carManager.Add(new Car { Id = 7, BrandId = 17, ColorId = 17, DailyPrice = 77777, Description = "Ford Ranger", ModelYear = 2021 });
            Console.WriteLine("\n------Araç Ekleme Sonrası Liste--------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " - " + car.Description);
            }


            //ID NO İLE ARAÇ GÖSTER
            Console.WriteLine("\n-----ID No ile Göster-----");
            Car car1= carManager.GetById(4);
            Console.WriteLine(car1.Id + " ID Nolu Araç: " + car1.Description);


            //ARAÇ SİLME
            carManager.Delete(4);
            Console.WriteLine("\n-------Silme İşlemi Sonrası Liste------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " - " + car.Description);
            }


            //ARAÇ GÜNCELLEME
            carManager.Update(new Car { Id = 1, BrandId = 1, DailyPrice = 1700, ColorId = 5, ModelYear = 2018, Description = "Subaru Impreza" });
            Console.WriteLine("\n-----Güncelleme Sonrası Araç Listesi-------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " - " + car.Description);
            }

        }
    }
}

