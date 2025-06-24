using System;
public class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Console.WriteLine("Small Multiplication Practice v1.0\n");
        while (true)
        {
            int[] nums = { rnd.Next(1, 10), rnd.Next(1, 10) };
            int result = nums[0] * nums[1];
            int userAnswer;
            Console.Write($"{nums[0]} * {nums[1]} = ");
            try
            {
                userAnswer = Convert.ToInt32(Console.ReadLine());
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Zadali jste neplatnou hodnotu!\nHodnota musí být celé číslo!\n");
                continue;
            }
            if (result == userAnswer)
            {
                Console.WriteLine("Správně!\n");
            }
            else
            {
                Console.WriteLine($"Špatně!\nSprávný výsledek je: {result}\n");
            }
        }
    }
}
