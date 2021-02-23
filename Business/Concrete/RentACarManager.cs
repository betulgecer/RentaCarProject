using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentACarManager : IRentACarService
    {
        IRentACarDal _rentACarDal;
        public RentACarManager(IRentACarDal rentACarDal)
        {
            _rentACarDal = rentACarDal;
        }

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

        [ValidationAspect(typeof(RentACarValidator))]
        public IResult Insert(Rental rentACar)
        {
            if ((_rentACarDal.Get(p => p.CarId == rentACar.CarId)) == null)//araba kiralanmamşısa
            {
                _rentACarDal.Add(rentACar);
                return new SuccessResult(Messages.RentaCarAdded);
            }
            else //araba daha önce kiralamışsa
            {
                foreach (var rentalList in _rentACarDal.GetAll())
                {
                    if (rentalList.CarId == rentACar.CarId)//arabanın kiralama listesini alıyoruz
                    {
                        if (rentalList.ReturnDate != null)//araba daha önce kiralanmış ama geri verilmiş olan
                        {
                            _rentACarDal.Add(rentACar);
                            return new SuccessResult(Messages.RentaCarAdded);
                        }
                    }
                }
                //kiralanmış ama geri verilmemiş                
                return new ErrorResult(Messages.CarError);
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
    }
}
