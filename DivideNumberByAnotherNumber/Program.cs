using System;

namespace DivideNumberByAnotherNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat = 0;

            Console.WriteLine("welcome to the most fabulous experience known at the day");

            Console.WriteLine("enter a number for n1");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a number for n2");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if(n2 != 0)
            {
                Console.WriteLine("impossible to divide : "); 
            }
            else
            {
                resultat = n1 / n2;
            }

            Console.WriteLine("result : "+resultat);
        }
    }
}
