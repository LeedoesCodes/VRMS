namespace VRMS.Database.DBHelpers.EnumHelper;

public static class Tbl
{
    public static string ToEnum<T>() where T : System.Enum
    {
        var values = System.Enum.GetNames(typeof(T))
            .Select(v => $"'{v}'");

        return $"ENUM({string.Join(",", values)})";
    }
}
