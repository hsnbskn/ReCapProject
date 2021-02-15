using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager (IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var results = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            foreach (var result in results)
            {
                if (result.ReturnDate == null)
                {
                    return new ErrorResult(Messages.RentalNotAvailable);
                }
            }
                      

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.SuccessRentCar);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {

            var updatedRental = _rentalDal.Get(r => r.CarId == rental.CarId);
            if (updatedRental.ReturnDate != null)
            {
                return new ErrorResult(Messages.ReturnDateNotNull);
            }

            updatedRental.ReturnDate = DateTime.Now;

            _rentalDal.Update(updatedRental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
