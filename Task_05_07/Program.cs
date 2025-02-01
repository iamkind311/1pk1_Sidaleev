namespace Task_05_07
{
    internal class Program
    {
        /* У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными
        числами в диапазоне от 10 до 99 включительно.
        Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее
        минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность квадратной матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random random = new Random();

            // Заполнение матрицы случайными числами от 10 до 99
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(10, 100);
                }
            }

            // Поиск минимального элемента
            int minElement = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Минимальный элемент в матрице: {minElement}");

            // Умножение матрицы на минимальный элемент
            int[,] multipliedMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    multipliedMatrix[i, j] = matrix[i, j] * minElement;
                }
            }

            // Поиск пяти максимальных значений
            int[] maxValues = new int[5];
            for (int i = 0; i < 5; i++)
            {
                maxValues[i] = int.MinValue;  // Инициализация минимальным значением
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int current = multipliedMatrix[i, j];
                    for (int k = 0; k < 5; k++)
                    {
                        if (current > maxValues[k])
                        {
                            // Сдвинуть все меньшие значения
                            for (int l = 4; l > k; l--)
                            {
                                maxValues[l] = maxValues[l - 1];
                            }
                            maxValues[k] = current;
                            break;
                        }
                    }
                }
            }

            // Вывод матрицы с выделением 5 максимальных значений
            Console.WriteLine("Умноженная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool isMax = false;
                    for (int k = 0; k < 5; k++)
                    {
                        if (multipliedMatrix[i, j] == maxValues[k])
                        {
                            isMax = true;
                            break;
                        }
                    }

                    if (isMax)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; // Желтый цвет для максимальных значений
                        Console.Write(multipliedMatrix[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(multipliedMatrix[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
