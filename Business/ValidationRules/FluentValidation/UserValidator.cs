using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(2).WithMessage("İsim '2' karakterden uzun olmalıdır.");
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(2).WithMessage("Soyisim '2' karakterden uzun olmalıdır");
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).EmailAddress().WithMessage("Mail adresiniz e-mail biçiminde olmalıdır.");
            //RuleFor(u => u.Password).NotEmpty();
            //RuleFor(u => u.Password).MinimumLength(8).WithMessage("Şifreniz en az '8' karakterden oluşmalıdır. ");
        }
    }
}
