namespace Task_04_08
{
    internal class Program
    {
        /* Дан массив, содержащий последовательность 50 случайных чисел. Найти количество пар элементов, значения
которых равны. */
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 50;
            int[] numbers = new int[arraySize];

            // Заполнение массива случайными числами
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = random.Next(1, 101); // Генерируем числа от 1 до 100
            }

            // Подсчет количества пар равных элементов
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            int pairsCount = 0;
            foreach (var count in counts.Values)
            {
                pairsCount += count / 2; // Каждые 2 одинаковых числа образуют 1 пару
            }

            // Вывод результатов
            Console.WriteLine("Сгенерированные числа: " + string.Join(", ", numbers));
            Console.WriteLine("Количество пар равных элементов: " + pairsCount);
        }
    }
}
