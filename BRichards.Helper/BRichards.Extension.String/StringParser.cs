namespace BRichards.Extension.String;

public static class StringParser
{
    public static IEnumerable<IEnumerable<string>> Parser(this string input,
                                                          string lineSlit,
                                                          string fieldSplit) =>
        input.Split(new[] { lineSlit }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Split(new[] { fieldSplit }, StringSplitOptions.RemoveEmptyEntries));

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
