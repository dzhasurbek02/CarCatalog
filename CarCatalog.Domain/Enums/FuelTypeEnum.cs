namespace CarCatalog.Domain.Enums;

public class FuelTypeEnum : BaseEnum<FuelTypeEnum, Guid>
{
    public static FuelTypeEnum Petrol { get; } =
        new(Guid.Parse("c5d93893-609d-4905-acf1-de2a197ab507"), "Бензин");

    public static FuelTypeEnum Diesel { get; } =
        new(Guid.Parse("a8627f4a-283d-4169-841d-003edeb29759"), "Дизель");

    protected FuelTypeEnum(Guid val, string name) : base(val, name)
    {
    }
}