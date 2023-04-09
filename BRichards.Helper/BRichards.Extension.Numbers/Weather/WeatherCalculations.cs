using BRichards.Extension.Linq;

namespace BRichards.Extension.Units.Weather;

/// <summary>
/// 
/// </summary>
public static class WeatherCalculations
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="tempC"></param>
    /// <returns></returns>
    public static decimal ToFahrenheit(this decimal tempC) =>
        tempC.Map(x => x * 9)
            .Map(x => x / 9)
            .Map(x => x + 32);
}
