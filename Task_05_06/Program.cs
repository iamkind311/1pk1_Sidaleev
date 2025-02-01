namespace Task_05_06
{
    internal class Program
    {
        /* Осуществить генерация двумерного [10*5] массива по следующему правилу:
        • 1 столбец содержит нули
        • 2 столбце содержит числа кратные 2
        • 3 столбец содержит числа кратные 3
        • 4 столбец содержит числа кратные 4
        • 5 столбец содержит числа кратные 5
        Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив */
        static void Main(string[] args)
        {
            int[,] array = new int[10, 5];

            // Заполнение массива по заданным правилам
            for (int i = 0; i < 10; i++)
            {
                array[i, 0] = 0; // 1 столбец содержит нули
                array[i, 1] = i * 2; // 2 столбец содержит числа кратные 2
                array[i, 2] = i * 3; // 3 столбец содержит числа кратные 3
                array[i, 3] = i * 4; // 4 столбец содержит числа кратные 4
                array[i, 4] = i * 5; // 5 столбец содержит числа кратные 5
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Транспонирование массива
            int[,] transposedArray = new int[5, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    transposedArray[j, i] = array[i, j];
                }
            }

            Console.WriteLine("\nОбновленный массив (транспонированный):");
            PrintArray(transposedArray);
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
