using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linux1230.Helper.StringUtils;

public static class RandomString
{
    const string chars = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789";

    public static string GetRandomString(int length, string additionalChars = "")
    {
        Random random = new();
        return new string(Enumerable.Repeat(chars + additionalChars, length).Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
