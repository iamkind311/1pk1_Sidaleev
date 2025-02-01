namespace Task_05_08
{
    internal class Program
    {
        /* Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет
        произведением двух предыдущих (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
        результирующий массив)
        Вывести результирующий массив */
        static void Main(string[] args)
        {
            int size = 10;
            int[,] array1 = new int[size, size];
            int[,] array2 = new int[size, size];
            int[,] resultArray = new int[size, size];
            Random random = new Random();

            // Заполнение первого массива случайными числами от 1 до 9
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array1[i, j] = random.Next(1, 10); // Генерация числа от 1 до 9
                }
            }

            // Заполнение второго массива случайными числами от 1 до 9
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array2[i, j] = random.Next(1, 10); // Генерация числа от 1 до 9
                }
            }

            // Перемножение элементов двух массивов
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    resultArray[i, j] = array1[i, j] * array2[i, j];
                }
            }

            // Вывод результирующего массива
            Console.WriteLine("Результирующий массив (произведение двух массивов):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(resultArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
