namespace Task_04_10
{
    internal class Program
    {
        /* Заполнить массив из 10 элементов случайными числами в интервале [-10..10] и сделать реверс элементов
отдельно для 1-ой и 2-ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array
использовать нельзя. */
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 10;
            int[] numbers = new int[arraySize];

            // Заполнение массива случайными числами в интервале [-10, 10]
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = random.Next(-10, 11); // Генерация чисел от -10 до 10
            }

            // Вывод исходного массива
            Console.WriteLine("Исходный массив: " + string.Join(", ", numbers));

            // Реверс первой половины массива
            for (int i = 0; i < arraySize / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[arraySize / 2 - 1 - i];
                numbers[arraySize / 2 - 1 - i] = temp;
            }

            // Реверс второй половины массива
            for (int i = arraySize / 2; i < (arraySize / 2) + (arraySize / 2); i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[arraySize - 1 - (i - (arraySize / 2))];
                numbers[arraySize - 1 - (i - (arraySize / 2))] = temp;
            }

            // Вывод результата
            Console.WriteLine("Результат: " + string.Join(", ", numbers));
        }
    }
}
