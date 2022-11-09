namespace BRichards.Helper.StringExtension;

public static class CaseInsensitive
{
    public static bool ContainsCaseInsensitive(this string text,
                                               string value) => 
        text.Contains(value, StringComparison.CurrentCultureIgnoreCase);

    public static bool MatchCaseInsensitive(this string text,
                                            string value) => 
        text.Equals(value, StringComparison.CurrentCultureIgnoreCase);
}
