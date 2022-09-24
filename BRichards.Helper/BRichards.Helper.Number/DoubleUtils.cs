using System.Globalization;

namespace BRichards.Helper.Number;

public static class DoubleUtils
{
    public static double GetDouble(this string? s)
    {
        var systemSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
        try
        {
            return s switch
            {
                null => 0,
                _ => !s.Contains(',')
                        ? double.Parse(s, CultureInfo.InvariantCulture)
                        : Convert.ToDouble(s.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()))
            };
        }
        catch (Exception)
        {
            try
            {
                return Convert.ToDouble(s);
            }
            catch
            {
                try
                {
                    return s is null ? 0 : Convert.ToDouble(s.Replace(",", ";").Replace(".", ",").Replace(";", "."));
                }
                catch
                {
                    throw new Exception("Wrong string-to-double format");
                }
            }
        }
    }
}
