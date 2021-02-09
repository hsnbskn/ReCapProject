using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        //Database simülasyonu
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=3, ModelYear=2017, DailyPrice=1000, Description="Audi A3"},
                new Car{Id=2, BrandId=1, ColorId=2, ModelYear=2005, DailyPrice=500, Description="Fiat Linea"},
                new Car{Id=3, BrandId=2, ColorId=3, ModelYear=2010, DailyPrice=700, Description="Toyota Corolla"},
                new Car{Id=4, BrandId=3, ColorId=5, ModelYear=2019, DailyPrice=1500, Description="Mercedes W124"}
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Id + " ID Nolu Araç Eklendi.");
        }

        public void Delete(int id)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == id);
            _cars.Remove(carToDelete);
            Console.WriteLine(id + " ID Nolu Araç Silindi.");
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            Console.WriteLine(car.Id + " ID Nolu Araç Güncellendi.");
        }
    }
}
