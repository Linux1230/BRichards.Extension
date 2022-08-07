namespace BRichards.Helper.StringUtils;

public static class StringParser
{
    public static IEnumerable<IEnumerable<string>> Parser(this string input,
                                                          string lineSlit,
                                                          string fieldSplit) =>
        input.Split(new[] { lineSlit }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Split(new[] { fieldSplit }, StringSplitOptions.RemoveEmptyEntries));
}
