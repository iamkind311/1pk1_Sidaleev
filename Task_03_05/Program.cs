namespace Task_03_05
{
    /* Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
     Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
     время работы программы. */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод диапазона и шага 

            Console.WriteLine("Введите начальную температуру: ");
            double startCelsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конечную температуру: ");
            double endCelsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите шаг изменения температуры: ");
            double step = Convert.ToDouble(Console.ReadLine());

            //Заголовок таблицы

            Console.WriteLine("Температура в Цельсиях | Температура в Фаренгейтах");
            Console.WriteLine("---------------------------------------------------------");

            for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
            {
                double farenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius,20:F1} | {farenheit,20:F1}");
            }
        }
    }
}
