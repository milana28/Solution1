using NUnit.Framework;
using WebApplication1.Domain;

namespace TestProject1.Domain;

[TestFixture]
public class TemperatureTest
{
    [Test]
    public void CelsiusToFahrenheitTest()
    {
        new Temperature() { Celsius = 0 }.CelsiusToFahrenheit().Equals(32);
        new Temperature() { Celsius = -17.78 }.CelsiusToFahrenheit().Equals(0);
        new Temperature() { Celsius = -40 }.CelsiusToFahrenheit().Equals(-40);
    }
    
    [Test]
    public void FahrenheitToCelsiusTest()
    {
        new Temperature() { Celsius = 32 }.FahrenheitToCelsius().Equals(0);
        new Temperature() { Celsius = 0 }.CelsiusToFahrenheit().Equals(-17.78);
        new Temperature() { Celsius = -40 }.CelsiusToFahrenheit().Equals(-40);
    }
}