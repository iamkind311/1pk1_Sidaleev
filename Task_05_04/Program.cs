namespace Task_05_04
{
    internal class Program
    {
        /* Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
диагональной (все элементы вне главной диагонали равны нулю)
Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
сообщение что матрица не является диагональной. */
        static void Main(string[] args)
        {
            int n = 3; // Размерность матрицы
            int[,] matrix = {
            { 1, 0, 0 },
            { 0, 2, 0 },
            { 0, 0, 3 }
        };

            if (IsDiagonalMatrix(matrix, n))
            {
                Console.WriteLine("Матрица является диагональной:");
                PrintMatrixWithHighlight(matrix, n);
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной.");
            }
        }

        static bool IsDiagonalMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] != 0)
                    {
                        return false; // Если элемент вне главной диагонали не равен нулю
                    }
                }
            }
            return true; // Если все элементы вне главной диагонали равны нулю
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
                        Console.Write(matrix[i, j] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
