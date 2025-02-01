namespace Task_05_05
{
    internal class Program
    {
        /* У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
        случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
        по следующему правилу:
        • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
        • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом  */
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов (m): ");
            int m = int.Parse(Console.ReadLine());

            int[,] array = new int[n, m];
            Random random = new Random();

            // Заполнение массива случайными числами в диапазоне от -99 до 99
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(-99, 100);
                }
            }

            // Преобразование массива и вывод с выделением
            Console.WriteLine("Преобразованный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет для отрицательных элементов
                        Console.Write(Math.Abs(array[i, j]) + " "); // Отбрасываем знак
                    }
                    else if (array[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Красный цвет для нулей
                        Console.Write(1 + " "); // Перезаписываем единицей
                        array[i, j] = 1; // Перезаписываем значение в массиве
                    }
                    else
                    {
                        Console.Write(array[i, j] + " "); // Обычный вывод для положительных элементов
                    }
                    Console.ResetColor(); // Сброс цвета
                }
                Console.WriteLine();
            }
        }
    }
}
