using entitylayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.ValidationRules
{
    public class PortfolioValidator: AbstractValidator<portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Alanı Boş Geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel 2 Alanı Boş Geçilemez");
            RuleFor(x => x.Name).NotEmpty().MinimumLength(5).WithMessage("Proje Adı En Az 5 Karakterden Oluşmak Zorundadır");
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100).WithMessage("Proje Adı En Fazla 100 Karakterden Oluşmak Zorundadır.");
        }
    }
}
