using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AddUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator() 
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ad alanaı boş geçilmez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı alanaı boş geçilmez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı alanaı boş geçilmez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanaı boş geçilmez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanaı boş geçilmez");
            RuleFor(x => x.ConfrimPassword).NotEmpty().WithMessage("Şifre tekrar alanaı boş geçilmez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriş yapın");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.ConfrimPassword).Equal(y=>y.Password).WithMessage("Parolanız Eşleşmiyor");
            RuleFor(x => x.Name).EmailAddress().WithMessage("Lütfen geçerli Email adresinizi giriniz");

        }
    }
}
