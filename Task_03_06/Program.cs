namespace Task_03_06
{
    internal class Program
    {
        /* Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5. */
        static void Main(string[] args)
        {
            // Определение диапазона и шага
            double startX = -4;
            double endX = 4;
            double step = 0.5;

            //Заголовок таблицы
            Console.WriteLine("   x   |   y = |x|");
            Console.WriteLine("---------------------");

            //Вывод таблицы значений
            for (double x = startX; x <= endX; x += step)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"{x,6:F1} | {y,8:F1}"); //вывод
            }
        }
    }
}
