namespace Task_05_09
{
    internal class Program
    {
        /* Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей
        (это матрица, где все недиагональные элементы меньше нуля)
        Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. Если не выполняется, то
        вывести сообщение что данная матрица не является Z-матрицей */
        static void Main(string[] args)
        {
            Console.Write("Введите размерность квадратной матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random random = new Random();

            // Заполнение матрицы случайными числами от -9 до 9
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(-9, 10); // Генерация числа от -9 до 9
                }
            }

            // Проверка на Z-матрицу
            if (IsZMatrix(matrix, n))
            {
                Console.WriteLine("Данная матрица является Z-матрицей:");
                PrintMatrixWithHighlight(matrix, n);
            }
            else
            {
                Console.WriteLine("Данная матрица не является Z-матрицей.");
            }
        }

        static bool IsZMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Проверяем, что все недиагональные элементы меньше нуля
                    if (i != j && matrix[i, j] >= 0)
                    {
                        return false; // Если недиагональный элемент не меньше нуля
                    }
                }
            }
            return true; // Если все недиагональные элементы меньше нуля
        }

        static void PrintMatrixWithHighlight(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет для главной диагонали
                        Console.Write(matrix[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
