using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.CancelKeyPress += new ConsoleCancelEventHandler(CancelKeyPressHandler);
        while (true)
        {
            double[] sides = { 0, 0, 0 };
            double c = 0;
            double result = 0;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Zadej {i + 1}. stranu: ");
                    sides[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Zadali jste neplatnou hodnotu!\n");
                continue;
            }
            if ((sides[0] > sides[1]) && (sides[0] > sides[2]))
            {
                c = sides[0];
                result = Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2);
            }
            else if ((sides[1] > sides[0]) && (sides[1] > sides[2]))
            {
                c = sides[1];
                result = Math.Pow(sides[0], 2) + Math.Pow(sides[2], 2);
            }
            else if (sides[2] > sides[1] && (sides[2] > sides[0]))
            {
                c = sides[2];
                result = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
            }
            if ((sides[0] == sides[1]) || (sides[0] == sides[2]) || (sides[1] == sides[2]))
            {
                Console.WriteLine("Trojuhelník není pravoúhlý\n");
            }
            else if (Math.Pow(c, 2) == result)
            {
                Console.WriteLine("Trojuhelník je pravoúhlý\n");
            }
            else
            {
                Console.WriteLine("Trojuhelník není pravoúhlý\n");
            }
        }
    }
    private static void CancelKeyPressHandler(object sender, ConsoleCancelEventArgs e)
    {
        e.Cancel = true;
        Environment.Exit(0);
    }
}
