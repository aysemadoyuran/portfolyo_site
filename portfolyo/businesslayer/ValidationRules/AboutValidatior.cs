using entitylayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.ValidationRules
{
    public class AboutValidatior: AbstractValidator<About>
    {
        public AboutValidatior()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Bilgisi Boş Geçilemez");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon Numarası Boş Geçilemez");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres Bilgisi Boş Geçilemez");
        }
   
    }
}
