namespace BRichards.Helper.StringUtils;

public static class AppSettingsUtils
{
    public static int ValueOrDefault(this string @this,
                                     int defaultValue) =>
        string.IsNullOrWhiteSpace(@this) || !int.TryParse(@this, out var parsedValue)
            ? defaultValue
            : parsedValue;

    public static string ValueOrDefault(this string @this,
                                        string defaultValue) =>
        string.IsNullOrWhiteSpace(@this)
            ? defaultValue
            : @this;
}