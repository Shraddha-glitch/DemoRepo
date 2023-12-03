using System;
namespace StaticClassDemo{
    public static class College{
        public static string collegeName="HSM";
    }

    public class Program{
        static void Main(String[] args){
            //College myCollege= new College();// cannot create an instance of static class
            System.Console.WriteLine("My college name is: "+ College.collegeName);
         //   System.Console.WriteLine("There are altogether "+ College.Student());
        }
    }
}