namespace Task_19_02
{
    internal class Program
    {
        /*
        2. Напишите программу, которая запрашивает у пользователя произвольный текст, содержащий предложения (есть знаки препинания). программу после анализа выводит текст, разделенный на части:
        a)	По пробелам (отдельные слова построчно)
        b)	По предложениям (отдельные предложения построчно)
        (используйте метод Split())*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный текст:");
            string inputText = Console.ReadLine();

            // Разделение по пробелам
            string[] words = inputText.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nСлова (по пробелам):");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            // Разделение по предложениям
            char[] sentenceDelimiters = { '.', '!', '?' };
            string[] sentences = inputText.Split(sentenceDelimiters, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nПредложения:");
            foreach (var sentence in sentences)
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    
    }
}
