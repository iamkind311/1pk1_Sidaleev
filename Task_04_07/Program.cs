namespace Task_04_07
{
    internal class Program
    {
        /* В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан
отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
мальчиков и девочек. При выводе избавиться от отрицательных значений. */
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 30;
            int[] heights = new int[arraySize];

            // Заполнение массива ростом учеников
            for (int i = 0; i < arraySize; i++)
            {
                // Генерируем рост мальчиков (отрицательные значения) и девочек (положительные значения)
                heights[i] = random.Next(-150, 201); // Рост от -150 до 200 см
            }

            // Подсчет количества мальчиков и девочек
            int boysCount = heights.Count(h => h < 0);
            int girlsCount = heights.Count(h => h > 0);

            // Вычисление среднего роста для мальчиков и девочек
            double averageBoysHeight = boysCount > 0 ? heights.Where(h => h < 0).Average(h => Math.Abs(h)) : 0;
            double averageGirlsHeight = girlsCount > 0 ? heights.Where(h => h > 0).Average() : 0;

            // Вывод результатов
            Console.WriteLine("Количество мальчиков: " + boysCount);
            Console.WriteLine("Количество девочек: " + girlsCount);
            Console.WriteLine("Средний рост мальчиков: " + averageBoysHeight + " см");
            Console.WriteLine("Средний рост девочек: " + averageGirlsHeight + " см");
        }
    }
}
