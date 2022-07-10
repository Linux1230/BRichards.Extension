namespace Linux1230.Helper.StringUtils;

public static class CaseInsensitive
{
    public static bool ContainsCaseInsensitive(this string text, string value)
    {
        return text.Contains(value, StringComparison.CurrentCultureIgnoreCase);
    }

    public static bool MatchCaseInsensitive(this string text, string value)
    {
        return text.Equals(value, StringComparison.CurrentCultureIgnoreCase);
    }
}
