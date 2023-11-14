using FluentValidation;

namespace CarCatalog.Application.Features.CarModels.Commands.UpdateCarModel;

public class UpdateCarModelCommandValidator : AbstractValidator<UpdateCarModelCommand>
{
    public UpdateCarModelCommandValidator()
    {
        RuleFor(cm => cm.Id)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле Id не должно быть пустым!");
        
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