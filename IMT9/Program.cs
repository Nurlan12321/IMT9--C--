using System;

namespace IMT9
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Ros, Ves, IMT;
            Ros = 0;
            Ves = 0;
            try
            {
                Console.WriteLine("Введите рост");
                Ros = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вес");
                Ves = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Нужно ввести число");
                Console.ReadKey();
            }
            IMT = Ves / Ros;
            Console.WriteLine(IMT);
            Console.ReadKey();
        }
    }
}
