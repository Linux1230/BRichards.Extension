namespace BRichards.Extension.String;

public static class RandomString
{
    private const string Chars = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789";

    public static string GetRandomString(int length,
                                         string additionalChars = "") =>
        new(Enumerable.Repeat(Chars + additionalChars, length)
            .Select(s => s[new Random().Next(s.Length)]).ToArray());
}
