//Written By Chloe Jensrud
// 2/5/25


using System.ComponentModel.Design;

namespace BuyingInventory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following items are avaliable:");
            Console.WriteLine("1 - Rope"); 
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.WriteLine("What number do you want to see the price of?");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) Console.WriteLine("Rope costs 10 gold.");
            if (choice == 2) Console.WriteLine("Torches cost 16 gold.");
            if (choice == 3) Console.WriteLine("Climbing Equipment costs 24 gold.");
            if (choice == 4) Console.WriteLine("Clean Water costs 2 gold.");
            if (choice == 5) Console.WriteLine("Machete costs 20 gold.");
            if (choice == 6) Console.WriteLine("Canoe casts 200 gold.");
            if (choice == 7) Console.WriteLine("Food Supplies costs 2 gold.");

            //Updated code for Discounted inventory
           int price = item switch
           {
               
           }
            
            
            
            Console.Write("What is your name?: ")
            string name = Console.ReadLine();

            if (name == "Chloe") price /= 2;


        }
    }
}
