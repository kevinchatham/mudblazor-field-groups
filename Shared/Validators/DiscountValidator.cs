using FluentValidation;

namespace FieldGroups.Shared.Validators;

public class DiscountValidator : BaseValidator<decimal>
{
    public DiscountValidator()
    {
        RuleFor(x => x)
        .Cascade(CascadeMode.Stop)
        .GreaterThanOrEqualTo(0)
        .WithMessage("Discount cannot be below zero.");
    }
}