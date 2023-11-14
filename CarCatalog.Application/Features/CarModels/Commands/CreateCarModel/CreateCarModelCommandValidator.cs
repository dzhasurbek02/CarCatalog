using FluentValidation;

namespace CarCatalog.Application.Features.CarModels.Commands.CreateCarModel;

public class CreateCarModelCommandValidator : AbstractValidator<CreateCarModelCommand>
{
    public CreateCarModelCommandValidator()
    {
        RuleFor(cm => cm.BrandId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле BrandId не должно быть пустым!");
        
        RuleFor(cm => cm.Name)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле Name не должно быть пустым!")
            .Length(1, 30)
            .WithMessage("Длина Name не должна быть больше 30 символов!");
    }
}