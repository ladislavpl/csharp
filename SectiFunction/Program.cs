using System;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(sectipico(1, 2));
    }

    private static float secti(float x, float y)
    {
        return x + y;
    }

    private static Func<float, float, float> sectipico => secti;
}