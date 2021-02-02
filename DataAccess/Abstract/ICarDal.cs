using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        Car GetById(int id); //**
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);

    }
}
