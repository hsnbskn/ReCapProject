using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.carName).NotEmpty();
            RuleFor(c => c.carName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();  
            RuleFor(c => c.DailyPrice).GreaterThan(0);  //0'dan farklı
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(1000).When(c => c.BrandId == 1); //BrandId==1 ise DailyPrice En az 1000 olabilir.

            //Olmayan Bir Kural Yazmak
            // Must uymalı demek.
            RuleFor(c => c.carName).Must(StartWithA).WithMessage("Araç ismi A harfi ile başlamalıdır.");


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
