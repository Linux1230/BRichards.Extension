using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRichards.Helper.StringUtils;
public static class StringCharacterUtils
{
    public static string FirstLetterCapital(this string str) =>
        char.ToUpper(str[0]) + str.Remove(0, 1);
}
