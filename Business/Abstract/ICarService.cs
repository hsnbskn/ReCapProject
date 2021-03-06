using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetById(int id);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        IResult AddTransactionalTest(Car car);  //İşlemin geri alınması. para gitti ama karşıya ulaşmazsa bana iadesi örn.

    }
}
