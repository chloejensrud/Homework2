//Written By Chloe Jensrud
// 2/5/25


namespace MagicCannon
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                bool fire = (i % 3 == 0);
                bool electric = (i % 5 == 0);

                if(fire && electric)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}: Fire and Electric"); 
                }
                if (fire)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}: Fire");
                }
                if (electric)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i}: Electric");
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine($"{i}: Normal");
                }

            }
        }
    }
}
