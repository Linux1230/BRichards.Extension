using System.Globalization;

namespace Linux1230.Helper.Number;

public static class DoubleUtils
{
    public static void Test()
    {
        string asd = "10";
        double asdd = asd.GetDouble();
    }

    public static double GetDouble(this string? s)
    {
        char systemSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
        try
        {
            if (s is null)
                return 0;

            if (!s.Contains(','))
                return double.Parse(s, CultureInfo.InvariantCulture);
            
            return Convert.ToDouble(s.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()));
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
                    if (s is null)
                        return 0;

                    return Convert.ToDouble(s.Replace(",", ";").Replace(".", ",").Replace(";", "."));
                }
                catch
                {
                    throw new Exception("Wrong string-to-double format");
                }
            }
        }
    }
}