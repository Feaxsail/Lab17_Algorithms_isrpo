using System;

namespace Step4_TipsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму счёта:");
            double bill = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите процент чаевых:");
            double percent = Convert.ToDouble(Console.ReadLine());

            double tips = bill * (percent / 100);
            double total = bill + tips;

            Console.WriteLine($"Сумма чаевых: {tips}");
            Console.WriteLine($"Общая сумма: {total}");
        }
    }
}