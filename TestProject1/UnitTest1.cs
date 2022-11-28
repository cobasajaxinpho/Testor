using WebApplication2;
using Xunit;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        WeatherForecast test = new WeatherForecast();
        test.TemperatureC = 100;
        Assert.Equal("hot", test.IsOverHeat());

    }
}