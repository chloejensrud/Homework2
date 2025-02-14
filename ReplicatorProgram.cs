namespace Replicator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ogArray = new int[5];

            Console.WriteLine("Enter 5 Nnumbers: ");
            for (int i = 0; i < ogArray.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}:");
            }

            int[] copyArray = new int[5];

            for (int i = 0;i < ogArray.Length;i++)
            {
                copyArray[i] = ogArray[i];
            }
            Console.WriteLine("Original Array: " + string.Join(",", ogArray));
            Console.WriteLine("Copy Array: " + string.Join (",", copyArray));
        }
    }
}