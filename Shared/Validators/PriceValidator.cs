using FluentValidation;

namespace FieldGroups.Shared.Validators;

public class PriceValidator : BaseValidator<decimal>
{
    public PriceValidator()
    {
        RuleFor(x => x)
        .Cascade(CascadeMode.Stop)
        .NotEmpty()
        .WithMessage("This is required.")
        .GreaterThan(0)
        .WithMessage("Price cannot be below zero.");
    }
}