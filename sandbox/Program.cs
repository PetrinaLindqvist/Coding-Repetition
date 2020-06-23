using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                Console.WriteLine("Give a number:");
                int nbr = Convert.ToInt32(Console.ReadLine());

                if (nbr == 42)
                {
                break;
                }
            }
        }
    }
}
