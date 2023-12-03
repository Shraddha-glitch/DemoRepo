using System;
using System.Collections.Concurrent;
namespace GenericsDemo{
    public class Program{
       public static void Main(string[] args){
            bool Equal = Calculator.AreEqual<string>("A","A");
            if (Equal){
                System.Console.WriteLine("Equal");
            }else{
                System.Console.WriteLine("Not Equal");
                Console.ReadLine();
            }
        }
    }
     class Calculator{
        /*public static bool AreEqual(object value1, object value2){
            
        //    //during compile time, each time, A string need to be converted into object type 
        //    //i.e boxing unessesary boxing and 
        //    //unboxing is happenning. So to avoid this, we use generics
        //    //to make this method(AreEqual) independent od data type, we use generics]

        //     return value1 == value2;
        */
        public static bool AreEqual<T>(T value1, T value2){
            //we made method generic
            return value1.Equals(value2);
        }
        
         }

    }
}