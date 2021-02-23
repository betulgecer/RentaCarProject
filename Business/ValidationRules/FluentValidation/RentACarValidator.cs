using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentACarValidator : AbstractValidator<Rental>
    {

        public RentACarValidator()
        {
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.RentalId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
        }
    }
}
