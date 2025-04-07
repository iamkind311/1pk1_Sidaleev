namespace Task_21_02
{
    internal class Program
    {
        /* Дан текст. Написать метод, который возвращает словарь, где ключ — слово, а значение — количество его 
        вхождений в тексте.*/
        static void Main(string[] args)
        {
            string text = "Программирование на C# — это интересно. C# позволяет создавать различные приложения. Программирование требует практики.";

            Dictionary<string, int> wordCount = CountWords(text);

            Console.WriteLine("Словарь частоты слов:");
            foreach (var entry in wordCount)
            {
                Console.WriteLine($"Слово: '{entry.Key}' — Количество вхождений: {entry.Value}");
            }
        }

        static Dictionary<string, int> CountWords(string text)
        {
            var wordCount = new Dictionary<string, int>();
            char[] delimiters = { ' ', ',', '.', '!', '?', '-', ';', ':' };

            string[] words = text.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }
    }
}
