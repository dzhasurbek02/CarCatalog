using FluentValidation;

namespace CarCatalog.Application.Features.CarPhotos.Commands.CreateCarPhoto;

public class CreateCarPhotoCommandValidator : AbstractValidator<CreateCarPhotoCommand>
{
    public CreateCarPhotoCommandValidator()
    {
        RuleFor(t => t.CarId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле CarId не должно быть пустым!");
        
        RuleFor(t => t.PhotoURL)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Поле PhotoURL не должно быть пустым!")
            .Length(3, 255)
            .WithMessage("Длина PhotoURL не должна быть меньше 3 символов и больше 255 символов!");
    }
}