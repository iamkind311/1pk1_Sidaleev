namespace Task_14_03
{
    /* Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал. Сделайте 
так, чтобы метод работал только для неотрицательных чисел.*/
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Введите неотрицательное целое число: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Ошибка: Факториал не определен для отрицательных чисел.");
                }
                else
                {
                    long result = Factorial(number);
                    Console.WriteLine($"Факториал {number} = {result}");
                }
            }
        public static long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
    
