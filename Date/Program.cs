using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Horas a serem acrescentadas:");
           DateTime n = DateTime.Parse(Console.ReadLine());
            DateTime d1 = DateTime.Now;
            DateTime d2 = d1.AddDays('n');

            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
