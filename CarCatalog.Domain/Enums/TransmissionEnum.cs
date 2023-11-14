namespace CarCatalog.Domain.Enums;

public class TransmissionEnum : BaseEnum<TransmissionEnum, Guid>
{
    public static TransmissionEnum Automatic { get; } =
        new(Guid.Parse("18f2154f-8ffe-4acc-8692-f223a24b377b"), "АКП");

    public static TransmissionEnum Manual { get; } =
        new(Guid.Parse("a6c95533-dbc4-4152-9bc3-869b94be888a"), "МКП");

    protected TransmissionEnum(Guid val, string name) : base(val, name)
    {
    }
}