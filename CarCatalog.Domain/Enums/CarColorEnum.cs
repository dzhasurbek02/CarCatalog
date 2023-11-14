namespace CarCatalog.Domain.Enums;

public class CarColorEnum : BaseEnum<CarColorEnum, Guid>
{
    public static CarColorEnum Black { get; } =
        new(Guid.Parse("58023b94-502e-487f-a31c-21922c11e65a"), "Черный");

    public static CarColorEnum White { get; } =
        new(Guid.Parse("2d8d2025-a582-4b30-9147-f31b2e87da1c"), "Белый");

    public static CarColorEnum Gray { get; } =
        new(Guid.Parse("8d82f0ce-3ad9-47b6-b0b0-2c4e3f3a2f1c"), "Серый");

    public static CarColorEnum Blue { get; } =
        new(Guid.Parse("4941444e-ab6f-4147-b262-e9b5771c3d04"), "Синий");

    public static CarColorEnum Red { get; } =
        new(Guid.Parse("048abfed-f78a-4ba0-963b-abdb33e950ac"), "Красный");

    protected CarColorEnum(Guid val, string name) : base(val, name)
    {
    }
}