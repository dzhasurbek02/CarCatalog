namespace CarCatalog.Domain.Enums;

public class BrandEnum : BaseEnum<BrandEnum, Guid>
{
    public static BrandEnum Mercedes { get; } =
        new (Guid.Parse("5f1f8780-5b3c-441b-b042-1e89643b0d0b"), "Mercedes");

    public static BrandEnum BMW { get; } =
        new(Guid.Parse("50945d15-834d-4192-b36c-8647418374a4"), "BMW");

    public static BrandEnum Toyota { get; } =
        new(Guid.Parse("d097d1f3-27f2-4d02-8f5e-63ec0443bb8e"), "Toyota");

    protected BrandEnum(Guid val, string name) : base(val, name)
    {
    }
}