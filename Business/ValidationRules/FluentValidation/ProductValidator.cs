using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //kurallar yukarıda verilen sınıf için olmalı
            RuleFor(p=>p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0); //0 dana büyük
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //içecek kategorisi 10 dan fazla olması 
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("ürünler A harfi ile başlamalı"); //a ile başlamalı

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
            //arg==productname
        }
    }
}
