namespace Task_11_04
{
    internal class Program
    {
        /*Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает 
их среднее значение. Используйте ключевое слово params */
        static void Main()
        {
            double average = CalculateArray(1, 2, 3, 4, 5);
            Console.WriteLine($"Среднее значение: {average}");
        }

        static double CalculateArray(params int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length;
        }
    }
}
