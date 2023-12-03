using System;
namespace ConverterDemo{
    public static class Converter{
        public static double ToFahrenheit(double celcius){
            return (celcius * 9 /5) + 32;
        }
        public static double ToCelcius(double fahrenheit){
            return (fahrenheit - 32 )* 5 / 9;
        }
    }
}