namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = 20;
            Console.WriteLine($"{fahrenheit}\u00b0F is {TempConverter.FahrenheitToCelsius(fahrenheit)}\u00b0C");

            var celcius = 4;
            Console.WriteLine($"{celcius}\u00b0C is {TempConverter.CelsiusToFahrenheit(celcius)}\u00b0F");
        }
    }
}
