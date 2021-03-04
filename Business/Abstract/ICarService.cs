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
        IDataResult<Car> GetAllByBrandId(int brandId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<Car> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetails(Expression<Func<Car, bool>>filter = null);
        IResult AddTransactionalTest(Car car);

    }
}
