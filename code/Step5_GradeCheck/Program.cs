using System;

namespace Step5_GradeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество баллов:");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score >= 91 && score <= 100)
            {
                Console.WriteLine("Оценка: Отлично (5)");
            }
            else if (score >= 71 && score <= 90)
            {
                Console.WriteLine("Оценка: Хорошо (4)");
            }
            else if (score >= 51 && score <= 70)
            {
                Console.WriteLine("Оценка: Удовлетворительно (3)");
            }
            else if (score >= 0 && score <= 50)
            {
                Console.WriteLine("Оценка: Неудовлетворительно (2)");
            }
            else
            {
                Console.WriteLine("Ошибка: неверное значение баллов");
            }
        }
    }
}