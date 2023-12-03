using System;
using Microsoft.VisualBasic;
namespace MyApplication2
{
      class Animal{
        public  void animalSound(){
            Console.WriteLine("Animal ");
        }
    }
     class Dog: Animal{
        public void animalSound(){
            Console.WriteLine("Bhau Bhau");
        }
    }
     class Cat: Animal{
        public void animalSound(){
            Console.WriteLine("Meow Meow!!");
        }

    }

     class Program{

         public static void Main(String[] args){
            Animal myanimal = new Animal();
            Dog mydog= new Dog();
            Cat mycat= new Cat();

            myanimal.animalSound();
            mydog.animalSound();
            mycat.animalSound();
        }
    }
}
