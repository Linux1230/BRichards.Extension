namespace BRichards.Helper.DateTimeUtils;

public static class DateTimeExtension
{
    /// <summary>
    /// Convert given datetime to hungarian time zone equivalent
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns>DateTime?</returns>
    public static DateTime? GetHungarianDateTime(this DateTime? dateTime) =>
        dateTime != null
            ? TimeZoneInfo.ConvertTimeBySystemTimeZoneId((DateTime)dateTime, "Central Europe Standard Time")
            : null;

    /// <summary>
    /// Returns true when the given date is Saturday or Sunday
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static bool IsWeekend(this DateTime dateTime) =>
        dateTime.Date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;

    public static DateTime Next(this DateTime date, DayOfWeek dayOfWeek)
    {
        var offsetDays = dayOfWeek - date.DayOfWeek;
        if (offsetDays <= 0)
        {
            offsetDays += 7;
        }
        return date.AddDays(offsetDays);
    }
}