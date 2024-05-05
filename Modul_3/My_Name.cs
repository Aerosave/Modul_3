using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        Console.WriteLine("What is your age?");
        var age = checked ((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        Console.WriteLine("What is your birthdate? ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Your birthdate is {0}, your name is {1} and age is {2}", birthdate, name,age);

    }
}