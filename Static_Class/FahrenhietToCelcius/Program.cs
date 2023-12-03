using System;
namespace ConverterDemo{
    public class Program{
        static void Main(){
            double celcius, fahrenheit;

            Console.Write("Enter temperature in Fahreheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
        
            celcius= Converter.ToCelcius(fahrenheit);
            System.Console.WriteLine("value of {0} celcius to fahrenheit is {1}", celcius, fahrenheit);
          
            fahrenheit= Converter.ToFahrenheit(celcius);
            System.Console.WriteLine("value of {0} fahrenheit to celcius is {1}", fahrenheit,celcius);
            Console.ReadLine();
            
        }
    }
}