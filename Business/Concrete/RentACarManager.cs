using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using Core.Utilities.Business;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class RentACarManager : IRentACarService
    {
        IRentACarDal _rentACarDal;
        ICustomerFindeksScoreService _customerFindeksScoreService;
        public RentACarManager(IRentACarDal rentACarDal, ICustomerFindeksScoreService customerFindeksScoreService)
        {
            _rentACarDal = rentACarDal;
            _customerFindeksScoreService = customerFindeksScoreService;
        }

        [PerformanceAspect(5)]
        [CacheRemoveAspect("IRentalService.Get")]
        [SecuredOperation("user,admin")]
        public IResult Delete(Rental rentACar)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _rentACarDal.Delete(rentACar);
            return new SuccessResult(Messages.RentaCarDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentACarDal.GetAll(), Messages.RentaCarGetted);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentACarDal.Get(r => r.RentalId == rentalId), Messages.RentaCarGetted);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailById(int id)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentACarDal.GetRentalDetails(r=>r.RentalId == id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentACarDal.GetRentalDetails());
        }

        [ValidationAspect(typeof(RentACarValidator))]
        [SecuredOperation("user,admin")]
        [CacheRemoveAspect("IRentalService.Get")]
        [TransactionScopeAspect]
        public IResult Insert(Rental rentACar)
        {
            IResult result = BusinessRules.Run(CheckRentDate(rentACar));
            if (result != null)
            {
                return new ErrorResult("Araç girdiğiniz tarihlerde uygun değil");
            }
            else
            {
                _rentACarDal.Add(rentACar);
                _customerFindeksScoreService.FindeksScoreAddOrUpdate(rentACar.CustomerId);
                return new SuccessResult("Araç Kiralandı");
            }
        }

        [ValidationAspect(typeof(RentACarValidator))]
        public IResult Update(Rental rentACar)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _rentACarDal.Update(rentACar);
            return new SuccessResult(Messages.RentaCarUpdated);
        }

        private IResult CheckRentDate(Rental rental)
        {
            var result = _rentACarDal.GetAll(r => r.CarId == rental.CarId &&
            (r.RentDate <= rental.RentDate && rental.RentDate <= r.ReturnDate)
            || (rental.RentDate <= r.RentDate && r.RentDate <= rental.ReturnDate));
            if (result.Count == 0)
            { return new SuccessResult(); }
            else
            { return new ErrorResult(); }
        }
    }
}
