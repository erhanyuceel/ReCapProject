using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<RentalDetailDto>> GetRentDetails(Expression<Func<Rental, bool>> filter = null);

        IDataResult<List<Rental>> GetAll();

        IDataResult<Rental> GetById(int Id);

        IDataResult<List<Rental>> GetAllByCarId(int carId);

        IResult Update(Rental rental);

        IResult Delete(Rental rental);

        IResult Add(Rental rental);
    }
}
