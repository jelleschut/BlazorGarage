using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Domain.Validation
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilderOptions<TItem, TProperty> IsUnique<TItem, TProperty>
            (this IRuleBuilder<TItem, TProperty> ruleBuilder, IEnumerable<TItem> items) where TItem : class
        {
            return ruleBuilder.SetValidator(new UniqueValidator<TItem>(items));
        }
    }

    internal class UniqueValidator<T> : PropertyValidator where T : class
    {
        private readonly IEnumerable<T> _items;

        public UniqueValidator(IEnumerable<T> items)
          : base("{PropertyName} must be unique")
        {
            _items = items;
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var editedItem = context.InstanceToValidate as T;
            var newValue = context.PropertyValue as string;
            var property = typeof(T).GetTypeInfo().GetDeclaredProperty(context.PropertyName);
            return _items.All(item =>
              item.Equals(editedItem) || property.GetValue(item).ToString() != newValue);
        }
    }
}
