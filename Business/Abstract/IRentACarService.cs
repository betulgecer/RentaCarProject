using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentACarService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int rentalId);
        IResult Insert(Rental rentACar);
        IResult Delete(Rental rentACar);
        IResult Update(Rental rentACar);
    }
}
