using System;

namespace Binary_and_Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n;
            int[] x = new int [] { 1, 3, 6, 7, 10, 16, 19, 300, 302 };
            Console.WriteLine("what number are you looking for?");
            n = Convert.ToInt32(Console.ReadLine());
            for (int y = 0; y > x.Length - 1; y = y + 1)
            {
                if (n == x[y])
                {
                    Console.WriteLine("Your number is" + x[y]);
                }
                
                

            }
            Console.ReadLine();
            
        }
        
    }
}
