using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validation
{
    public class MaintenanceValidator : AbstractValidator<Maintenance>
    {
        private readonly IEnumerable<Maintenance> _maintenances;
        public MaintenanceValidator(IEnumerable<Maintenance> maintenances)
        {
            _maintenances = maintenances;

            RuleFor(m => m.Date);
            RuleFor(m => m.Milage)
                .GreaterThanOrEqualTo(0);
            RuleFor(m => m.Description)
                .NotEmpty();
            RuleFor(c => c.Status)
                .IsInEnum();
            RuleFor(m => m.MaintenanceType)
                .IsInEnum();
        }
    }
}
