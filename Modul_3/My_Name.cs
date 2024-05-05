using System;
class MainClass
{
    public static void Main(string[] args)
    {
        const string MyName = "Никита";
        byte age = 25;
        byte shoesize = 44;
        bool pet = true;
        Console.WriteLine("My nane is " + MyName);
        Console.WriteLine("My age is " + age);
        Console.WriteLine("Do I hane a pet? " + pet);
        Console.WriteLine("Me shoe size is " + shoesize);
        Console.WriteLine("ByteMin {0} ", byte.MinValue);
        Console.WriteLine("ByteMax {0}", byte.MaxValue);
        Console.ReadKey();
    }
}