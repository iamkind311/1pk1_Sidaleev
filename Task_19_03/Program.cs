namespace Task_19_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            string input;

            Console.WriteLine("Введите строки (пустая строка для завершения ввода):");

            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;

                lines.Add(input);
            }

            string result = string.Join("-", lines);
            Console.WriteLine($"Результат: \"{result}\"");
        }
    }
}
