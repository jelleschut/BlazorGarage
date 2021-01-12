using Domain.Enums;
using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Domain.Validation
{
    public class CarValidator : AbstractValidator<Car>
    {
        private readonly IEnumerable<Car> _cars;

        public CarValidator(IEnumerable<Car> cars)
        {
            _cars = cars;

            RuleFor(c => c.LicenseNumber)
                .NotEmpty()
                .Length(6,8)
                .IsUnique(_cars);

            RuleFor(c => c.Brand)
                .NotEmpty()
                .NotNull();

            RuleFor(c => c.Model)
                .NotEmpty()
                .NotNull();

            RuleFor(c => c.Owner)
                .NotEmpty()
                .NotNull();

            RuleFor(c => c.Driver).Equal(c => c.Owner)
                .When(c => c.Owner.OwnerType == OwnerEnum.DRIVER)
                .WithMessage("Driver must be equal to owner");

            RuleFor(c => c.Driver)
                .NotEmpty()
                .NotNull();

            RuleFor(c => c.Maintenances);
        }
    }
}
