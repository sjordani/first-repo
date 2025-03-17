namespace Storey_6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a program to return the product of all elements in array except i
            Console.WriteLine("Jordan Storey \t6.2.2\n");
            Console.WriteLine("This is a program to return the product of all elements in array except i");
            Console.WriteLine("=========================================================================\n");

            int[] nums = { 1, 2, 3, 4 };
            int[] products = new int[4];

            int product = 1;
            foreach(int i in nums) { Console.Write(i + " ");}

            for(int i = 0; i < nums.Length; i++)
            {
                product = product * nums[i];
            }

            int j = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                int temp = product;
                products[j] = temp/ nums[i];
                j++;
            }

            Console.WriteLine();
            foreach(int p in products) { Console.Write(p + " "); }
            Console.ReadKey();
        }
    }
}
