using System.Numerics;

namespace BRichards.Extension.Numerics;
/// <summary>
/// 
/// </summary>
public static class BigIntegerExtension
{
    /// <summary>
    /// Returns a TimeSpan from a BigInteger value based on a scale factor
    /// </summary>
    /// <param name="bigInteger"></param>
    /// <param name="timeSpanScale"></param>
    /// <returns></returns>
    public static TimeSpan ToTimeSpan(this BigInteger bigInteger, long timeSpanScale = TimeSpan.TicksPerSecond)
    {
        var timeSpan = TimeSpan.FromTicks(TimeSpan.MaxValue.Ticks);
        BigInteger.DivRem(bigInteger, new BigInteger(timeSpanScale), out var remainder);
        timeSpan = TimeSpan.FromTicks((long)(remainder * timeSpanScale / BigInteger.Pow(10, 18)) + timeSpan.Ticks);
        return timeSpan;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static BigInteger ToBigInteger(this string? value) =>
        value is null
            ? BigInteger.Zero
            : BigInteger.TryParse(value ?? string.Empty, out var bigInteger)
                ? bigInteger
                : BigInteger.Zero;
}
