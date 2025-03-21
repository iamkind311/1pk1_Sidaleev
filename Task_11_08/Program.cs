namespace Task_11_08
{
    internal class Program
    {
        /*Использование params и out: Напишите метод, который принимает переменное количество 
чисел и возвращает их сумму и максимальное значение через выходные параметры (out).*/
        static void Main()
        {
            SumAndMax(out int sum, out int max, 1, 2, 3, 4, 5);

            Console.WriteLine($"Сумма: {sum}, Максимальное значение: {max}");
        }

        static void SumAndMax(out int sum, out int max, params int[] numbers)
        {
            sum = 0;
            max = int.MinValue;

            foreach (int number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }
        }
    }
}
