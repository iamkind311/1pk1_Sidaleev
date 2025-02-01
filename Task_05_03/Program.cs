namespace Task_05_03
{
    internal class Program
    {
        /* Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
        да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
        элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны. */
        static void Main(string[] args)
        {
            char[,] matrix1 = {
            { 'f', 'h', 'h' },
            { 'w', 'g', 'k' },
            { 'a', 'f', 'j' }
        };

            char[,] matrix2 = {
            { 'f', 'h', 'h' },
            { 'w', 'g', 'k' },
            { 'a', 'f', 'o' }
        };

            if (AreMatricesEqual(matrix1, matrix2))
            {
                Console.WriteLine("Матрицы равны");
            }
            else
            {
                PrintMatricesWithHighlight(matrix1, matrix2);
            }
        }

        static bool AreMatricesEqual(char[,] matrix1, char[,] matrix2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void PrintMatricesWithHighlight(char[,] matrix1, char[,] matrix2)
        {
            Console.WriteLine("Первая матрица:");
            PrintMatrixWithHighlight(matrix1, matrix2);
            Console.WriteLine("\nВторая матрица:");
            PrintMatrixWithHighlight(matrix2, matrix1);
        }

        static void PrintMatrixWithHighlight(char[,] matrix, char[,] comparisonMatrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] == comparisonMatrix[i, j])
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет для совпадающих элементов
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
