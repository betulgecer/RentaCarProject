using Business.Abstract;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        //testing

        public IResult MakePayment(PaymentTest payment)
        {
            if (payment.Amount < 100)
            {
                return new ErrorResult("Bir hata oluştu");
            }
            return new SuccessResult();
        }

    }
}
