using FluentValidation;

namespace CarCatalog.Application.Features.Cars.Commands.CreateCar;

public class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
{
    public CreateCarCommandValidator()
    {
        RuleFor(c => c.BrandId)
            .NotEmpty()
            .WithMessage("Поле BrandId не должно быть пустым!");

        RuleFor(c => c.CarModelId)
            .NotEmpty()
            .WithMessage("Поле CarModelId не должно быть пустым!");

        RuleFor(c => c.BodyStyleId)
            .NotEmpty()
            .WithMessage("Поле BodyStyleId не должно быть пустым!");

        RuleFor(c => c.Year)
            .NotNull()
            .WithMessage("Поле Year не должно быть пустым!");

        RuleFor(c => c.Set)
            .NotNull()
            .WithMessage("Поле Set не должно быть пустым!")
            .Length(2, 30)
            .WithMessage("Длина комплектации не должна превышать 50 символов!");

        RuleFor(c => c.EngineCapacity)
            .NotNull()
            .WithMessage("Поле EngineCapacity не должно быть пустым!");

        RuleFor(c => c.HorsePower)
            .NotNull()
            .WithMessage("Поле HorsePower не должно быть пустым!");

        RuleFor(c => c.FuelTypeId)
            .NotEmpty()
            .WithMessage("Поле FuelTypeId не должно быть пустым!");

        RuleFor(c => c.TransmissionId)
            .NotEmpty()
            .WithMessage("Поле TransmissionId не должно быть пустым!");

        RuleFor(c => c.DriveTrainId)
            .NotEmpty()
            .WithMessage("Поле DriveTrainId не должно быть пустым!");

        RuleFor(c => c.CarColorId)
            .NotEmpty()
            .WithMessage("Поле CarColorId не должно быть пустым!");

        RuleFor(c => c.Description)
            .Length(0, 1000)
            .WithMessage("Длина описания превышает 1000 символов!");

        RuleFor(c => c.Price)
            .NotNull()
            .WithMessage("Поле Price не должно быть пустым!");
    }
}