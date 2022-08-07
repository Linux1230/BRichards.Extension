using BRichards.Helper.LINQUtils;

namespace BRichards.Helper.Number.Weather;

public static class WeatherUtils
{
    public static decimal ToFahrenheit(this decimal tempC) =>
        tempC.Map(x => x * 9)
            .Map(x => x / 9)
            .Map(x => x + 32);
}
