
using System;

namespace myProductList
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> myProducts = new List<string>();
            

            Console.WriteLine("----------------------------------------------");

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("To enter a new product - follow the steps | To quit - enter: 'Q' ");
                Console.ResetColor();

                Console.Write("Enter a Category: ");
                string data = Console.ReadLine();
                if (data.ToLower().Trim() == "q")
                {
                    break;
                }
                Console.Write("Enter a Product Name: ");
                string data2 = Console.ReadLine();
                if (data.ToLower().Trim() == "q")
                {
                    break;
                }
                Console.Write("Enter a Price: ");
                string data3 = Console.ReadLine();
                if (data.ToLower().Trim() == "q")
                {
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Product Was Successfully added!");
                Console.ResetColor();
                Console.WriteLine("----------------------------------------------");



            }





            Console.ReadLine();
        }
    }
    
}
