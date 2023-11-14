namespace CarCatalog.Domain.Enums;

public class BodyStyleEnum : BaseEnum<BodyStyleEnum, Guid>
{
    public static BodyStyleEnum Sedan { get; } =
        new (Guid.Parse("2b03ae77-d8e2-4e5c-9a6b-66f27e076488"), "Седан");
    public static BodyStyleEnum Hatchback { get; } =
        new (Guid.Parse("f4571a87-1587-4a22-9d9e-0e44f9e85557"), "Хэтчбек");
    public static BodyStyleEnum Coupe { get; } =
        new (Guid.Parse("46729b9d-1ea7-42d9-934e-f5619d988467"), "Купе");
    
    
    protected BodyStyleEnum(Guid val, string name) : base(val, name)
    {
    }
}