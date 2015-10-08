using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        string stringHelloWorld = (string)helloWorld;
        Console.WriteLine(stringHelloWorld);
    }
}
