using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username Alanı Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(x => x.ComfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen En Fazla 30 Karakter Giriniz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Giriniz ");
            RuleFor(x => x.ComfirmPassword).Equal(y => y.Password).WithMessage("Şifreniz Eşleşmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Geçerli Bir Mail Adresi Giriniz");
        }
    }
}