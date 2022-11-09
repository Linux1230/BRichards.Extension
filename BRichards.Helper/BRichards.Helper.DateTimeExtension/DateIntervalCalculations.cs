namespace BRichards.Helper.DateTimeExtension;

public static class DateIntervalCalculations
{
    /// <summary>
    /// Returns Each Day in the given period based on parameters
    /// </summary>
    /// <param name="from">Start Date</param>
    /// <param name="thru">Thru Date</param>
    /// <returns>IEnumerable DateTime</returns>
    public static IEnumerable<DateTime> GetEachDay(DateTime from, DateTime thru)
    {
        for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
        {
            yield return day;
        }
    }

    /// <summary>
    /// Returns Each Day in the given period based on parameters
    /// </summary>
    /// <param name="from">Start Date</param>
    /// <param name="thru">Thru Date</param>
    /// <returns>IEnumerable DateOnly</returns>
    public static IEnumerable<DateOnly> GetEachDay(DateOnly from, DateOnly thru)
    {
        for (var day = from; day <= thru; day = day.AddDays(1))
        {
            yield return day;
        }
    }

    /// <summary>
    /// Returns Each Month in the given period based on parameters
    /// </summary>
    /// <param name="from">Start Date</param>
    /// <param name="thru">Thru Date</param>
    /// <returns>IEnumerable DateTime</returns>
    public static IEnumerable<DateTime> GetEachMonth(DateTime from, DateTime thru)
    {
        for (var month = from.Date; month.Date <= thru.Date; month = month.AddMonths(1))
        {
            yield return month;
        }
    }

    /// <summary>
    /// Returns Each Month in the given period based on parameters
    /// </summary>
    /// <param name="from">Start Date</param>
    /// <param name="thru">Thru Date</param>
    /// <returns>IEnumerable DateOnly</returns>
    public static IEnumerable<DateOnly> GetEachMonth(DateOnly from, DateOnly thru)
    {
        for (var month = from; month <= thru; month = month.AddMonths(1))
        {
            yield return month;
        }
    }

    /// <summary>
    /// Returns Each Month in the given period based on parameters
    /// </summary>
    /// <param name="from">Start Date</param>
    /// <param name="thru">Thru Date</param>
    /// <returns>IEnumerable DateTime</returns>
    public static IEnumerable<DateTime> GetEachYear(DateTime from, DateTime thru)
    {
        for (var year = from.Date; year.Date <= thru.Date; year = year.AddYears(1))
        {
            yield return year;
        }
    }

    /// <summary>
    /// Returns Each Month in the given period based on parameters
    /// </summary>
    /// <param name="from">Start Date</param>
    /// <param name="thru">Thru Date</param>
    /// <returns>IEnumerable DateOnly</returns>
    public static IEnumerable<DateOnly> GetEachYear(DateOnly from, DateOnly thru)
    {
        for (var year = from; year <= thru; year = year.AddYears(1))
        {
            yield return year;
        }
    }
}
