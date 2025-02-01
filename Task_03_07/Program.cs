namespace Task_03_07
{
    internal class Program
    {
        /* Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t ,
        где 2 g = 9,8 м/с2 – ускорение свободного падения. */
        static void Main(string[] args)
        {
            const double g = 9.8; //Ускорение свободного падения
            double timeStep = 0.5; //Шаг времени
            double maxTime = 10; //Максимальное время (например, 10 секунд)

            //Заголовок таблицы
            Console.WriteLine(" Время (с) | Скорость (м/с)");
            Console.WriteLine("---------------------------------");

            //Вывод таблицы значений
            for (double t = 0; t <= maxTime; t += timeStep)
            {
                double v = g * t; // Вычисление скорости 
                Console.WriteLine($"{t,10:F1} | {v,15:F2}"); //вывод
            }
        }
    }
}
