// See https://aka.ms/new-console-template for more information
using System;
namespace MyApplication
{
    public class Program
    {
        static void Main(string[] args){

            Car mycar = new Car();
            Car mydog =  new Car();

            mycar.horn();
            mydog.horn();

            System.Console.WriteLine(" " + mycar.modelName);
        }
    }
}