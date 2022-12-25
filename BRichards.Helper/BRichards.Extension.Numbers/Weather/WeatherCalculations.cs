using BRichards.Extension.Linq;

namespace BRichards.Extension.Units.Weather;

public static class WeatherCalculations
{
    public static decimal ToFahrenheit(this decimal tempC) =>
        tempC.Map(x => x * 9)
            .Map(x => x / 9)
            .Map(x => x + 32);
}
