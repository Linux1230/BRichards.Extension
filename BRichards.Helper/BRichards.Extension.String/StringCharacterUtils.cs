namespace BRichards.Extension.String;

public static class StringCharacterUtils
{
    public static string ToFirstLetterCapital(this string str) =>
        char.ToUpper(str[0]) + str.Remove(0, 1);
}
