using FluentValidation;

namespace CarCatalog.Application.Features.Cars.Commands.UpdateCar;

public class UpdateCarCommandValidator : AbstractValidator<UpdateCarCommand>
{
    public UpdateCarCommandValidator()
    {
        RuleFor(t => t.Id)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле Id не должно быть пустым!");
        
        RuleFor(c => c.BrandId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле BrandId не должно быть пустым!");

        RuleFor(c => c.CarModelId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле CarModelId не должно быть пустым!");

        RuleFor(c => c.BodyStyleId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле BodyStyleId не должно быть пустым!");

        RuleFor(c => c.Year)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .WithMessage("Поле Year не должно быть пустым!");

        RuleFor(c => c.Set)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .WithMessage("Поле Set не должно быть пустым!")
            .Length(2, 30)
            .WithMessage("Длина комплектации не должна превышать 50 символов!");

        RuleFor(c => c.EngineCapacity)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .WithMessage("Поле EngineCapacity не должно быть пустым!");

        RuleFor(c => c.HorsePower)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .WithMessage("Поле HorsePower не должно быть пустым!");

        RuleFor(c => c.FuelTypeId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле FuelTypeId не должно быть пустым!");

        RuleFor(c => c.TransmissionId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле TransmissionId не должно быть пустым!");

        RuleFor(c => c.DriveTrainId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле DriveTrainId не должно быть пустым!");

        RuleFor(c => c.CarColorId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле CarColorId не должно быть пустым!");

        RuleFor(c => c.Description)
            .Cascade(CascadeMode.Stop)
            .Length(0, 1000)
            .WithMessage("Длина описания превышает 1000 символов!");

        RuleFor(c => c.Price)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .WithMessage("Поле Price не должно быть пустым!");
    }
}