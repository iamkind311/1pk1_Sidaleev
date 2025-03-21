namespace Task_11_03
{
    internal class Program
    {
        /*Выходной параметр (out): Напишите метод, который принимает строку и возвращает через 
выходной параметр количество гласных и согласных букв в этой строке */
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            CountVowelsAndConsonants(input, out int vowels, out int consonants);

            Console.WriteLine($"Количество гласных: {vowels}, количество согласных: {consonants}");
        }

        static void CountVowelsAndConsonants(string input, out int vowels, out int consonants)
        {
            vowels = 0;
            consonants = 0;

            foreach (char c in input.ToLower())
            {
                if ("аеёиоуыэюя".Contains(c))
                    vowels++;
                else if (char.IsLetter(c))
                    consonants++;
            }
        }
    }
}
