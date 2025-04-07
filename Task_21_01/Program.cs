namespace Task_21_01
{
    internal class Program
    {
        /* Дан список чисел. Создать новый список, содержащий только чётные числа из исходного списка, умноженные на 
        10*/
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evenNumbersMultipliedByTen = numbers
                .Where(n => n % 2 == 0) // Фильтруем четные числа
                .Select(n => n * 10)    // Умножаем на 10
                .ToList();               // Превращаем в список

            Console.WriteLine("Чётные числа, умноженные на 10:");
            foreach (var number in evenNumbersMultipliedByTen)
            {
                Console.WriteLine(number);
            }
        }
    }
}
