namespace CarCatalog.Domain.Enums;

public class DriveTrainEnum : BaseEnum<DriveTrainEnum, Guid>
{
    public static DriveTrainEnum FWD { get; } =
        new(Guid.Parse("f028158b-f8dc-4983-959f-1795af2b0a46"), "Передний привод");

    public static DriveTrainEnum RWD { get; } =
        new(Guid.Parse("7396ee6e-398b-4291-b010-1b224bf525f8"), "Задний привод");

    public static DriveTrainEnum AWD { get; } =
        new(Guid.Parse("16e03be9-03d6-4a4e-8376-3c51594f1c13"), "Полный привод");

    protected DriveTrainEnum(Guid val, string name) : base(val, name)
    {
    }
}