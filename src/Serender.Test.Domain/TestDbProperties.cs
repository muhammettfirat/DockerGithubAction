namespace Serender.Test;

public static class TestDbProperties
{
    public static string DbTablePrefix { get; set; } = "Test";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Test";
}
