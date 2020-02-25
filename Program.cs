using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)


        {
            
        
            int n = 101;

            for (int i = 1; i < n; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                
                
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                    
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                
                else Console.WriteLine(i);


            }




            





        }
    }
}

