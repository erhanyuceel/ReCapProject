using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<Car> GetById(int carId);

        IDataResult<List<CarDetailDto>> GetByBrandID(int brandID);

        IDataResult<List<CarDetailDto>> GetByColorID(int colorID);

        IDataResult<List<CarDetailDto>> GetCarsWithByColorIdAndBrandId(int brandID, int colorID);

        IDataResult<CarDetailDto> GetCarDetailsById(int carId);

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult AddTransactionalTest(Car car);
    }
}
