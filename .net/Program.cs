// See https://aka.ms/new-console-template for more information
using System;
using BasicsOfAbstration;
public class Program{
    static void Main(){
        Student obj = new Student();
        obj.Name="Raj Shrestha";
        obj.Age=22;
        System.Console.WriteLine(obj.GetStudentDetail());
        Console.ReadKey();
    }
}