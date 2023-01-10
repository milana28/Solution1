namespace WebApplication1.Domain;

public class Temperature
{
    public double Fahrenheit { set; get; }
    public double Celsius { set; get; }

    public double CelsiusToFahrenheit()
    {
        return Celsius * 1.8 + 32;
    }
    
    public double FahrenheitToCelsius()
    {
        return (Fahrenheit - 32) / 1.8;
    }
}