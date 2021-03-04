using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("admin, product.add")]
        [PerformanceAspect(5)]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {

            //business codes

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Car car)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }

            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [PerformanceAspect(5)]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarGetted);
        }


        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }

            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        IDataResult<Car> ICarService.GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.BrandId==brandId), Messages.CarGetted);
        }

        IDataResult<Car> ICarService.GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(b => b.ColorId == colorId),Messages.CarGetted);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            //throw new NotImplementedException();
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 10)
            {
                throw new Exception("");
            }
            Add(car);
            return null;
        }
    }
}
