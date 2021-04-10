using Core.Utilities;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetDetailByBrand(int brandId);
        IDataResult<List<CarDetailDto>> GetDetailsByColorAndByBrand(int colorId, int brandId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetDetailByColor(int colorId);
        IDataResult<List<CarDetailDto>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult AddTransactionalTest(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetailsById(int id);

        IDataResult<Car> GetById(int id);

    }
}
