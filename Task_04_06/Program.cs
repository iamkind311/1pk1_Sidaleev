namespace Task_04_06
{
    internal class Program
    {
        /* Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
модулю были разными. Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
двух равных по модулю. В полученном массиве найти наибольшее по модулю число. */
        static void Main(string[] args)
        {
            Random random = new Random();
            HashSet<int> uniqueAbsoluteValues = new HashSet<int>();
            int arraySize = 30;
            int[] numbers = new int[arraySize];

            // Заполнение массива уникальными по модулю числами
            for (int i = 0; i < arraySize; i++)
            {
                int value;
                do
                {
                    value = random.Next(-100, 101); // Генерируем числа от -100 до 100
                } while (uniqueAbsoluteValues.Contains(Math.Abs(value))); // Проверяем уникальность по модулю

                uniqueAbsoluteValues.Add(Math.Abs(value));
                numbers[i] = value;
            }

            // Нахождение наибольшего по модулю числа
            int maxByAbsoluteValue = numbers.OrderByDescending(Math.Abs).First();

            // Вывод результатов
            Console.WriteLine("Сгенерированные числа: " + string.Join(", ", numbers));
            Console.WriteLine("Наибольшее по модулю число: " + maxByAbsoluteValue);
        }
    }
}
