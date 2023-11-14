using FluentValidation;

namespace CarCatalog.Application.Features.Features.Commands.UpdateFeature;

public class UpdateFeatureCommandValidator : AbstractValidator<UpdateFeatureCommand>
{
    public UpdateFeatureCommandValidator()
    {
        RuleFor(t => t.Id)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле Id не должно быть пустым!");
        
        RuleFor(f => f.Name)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле Name не должно быть пустым!")
            .Length(3, 50)
            .WithMessage("Длина Name не должна быть меньше 3 символов и больше 50 символов!");
    }
}