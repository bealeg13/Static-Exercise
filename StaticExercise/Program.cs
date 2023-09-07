namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Converted to {TempConverter.FahrenheitToCelsius(90)} degrees Celsius");
            Console.WriteLine($"Converted to {TempConverter.CelesiusToFahrenheit(40)} degrees Fahrenheit"); 
        }
    }
}
