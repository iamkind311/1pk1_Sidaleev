
namespace Task_24_07
{
    internal class Program
    {
        /* Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки, содержащие это 
слово (регистронезависимо)*/
        static void Main()
        {
            string path = "tere.txt";
            string searchWord = "программирование";

            try
            {
                List<string> results = FileHelper.FindLinesWithWord(path, searchWord);

                if (results.Count == 0)
                {
                    Console.WriteLine("Слово не найдено в файле.");
                }
                else
                {
                    Console.WriteLine("Найденные строки:");
                    foreach (string line in results)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
