using entitylayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.ValidationRules
{
    public class FeatureValidatior : AbstractValidator<Feature>
    {
        //ctor
        public FeatureValidatior()
        {
            RuleFor(x => x.Header).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad-Soyad Boş Geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev Bilgisi Boş Geçilemez");
        }
    }
}
