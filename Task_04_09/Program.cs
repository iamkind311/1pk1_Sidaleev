namespace Task_04_09
{
    internal class Program
    {
        /* В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран. То есть найти и
вывести уникальные элементы массива. (LINQ использовать нельзя) */
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

            // Выводим сгенерированные числа
            Console.WriteLine("Сгенерированные числа: " + string.Join(", ", numbers));

            // Поиск уникальных элементов
            for (int i = 0; i < arraySize; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < arraySize; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine("Уникальный элемент: " + numbers[i]);
                }
            }
        }
    }
}
