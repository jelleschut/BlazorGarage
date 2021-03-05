using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Domain.Validation
{
    public class OwnerValidator : AbstractValidator<Owner>
    {
        Regex re = new Regex(@"\d{4} ?[A-Za-z]{2}");
        public OwnerValidator()
        {
            RuleFor(o => o.Name)
                .NotEmpty()
                .MaximumLength(80);
            RuleFor(o => o.City)
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(o => o.Street)
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(o => o.HouseNumber)
                .NotEmpty();
 //               .GreaterThan(0);
            RuleFor(o => o.Zipcode)
                .Matches(re);
            RuleFor(o => o.PhoneNumber);
            RuleFor(o => o.Email)
                .EmailAddress();
            RuleFor(o => o.OwnerType)
                .IsInEnum();
        }
    }
}
