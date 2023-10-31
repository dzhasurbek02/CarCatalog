using FluentValidation;

namespace CarCatalog.Application.Features.Features.Commands.CreateFeature;

public class CreateFeatureCommandValidator : AbstractValidator<CreateFeatureCommand>
{
    public CreateFeatureCommandValidator()
    {
        RuleFor(f => f.Name)
            .NotEmpty()
            .WithMessage("Поле Name не должно быть пустым!")
            .Length(3, 50)
            .WithMessage("Длина Name не должна быть меньше 3 символов и больше 50 символов!");
    }
}