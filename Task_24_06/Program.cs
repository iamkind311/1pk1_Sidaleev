using System;
using System.IO;
namespace Task_24_06
{
    /* Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. Используйте 
        StreamReader */
    internal class Program
    {
        static void Main()
        {
            string path = "ter.txt";
            try
            {
                int count = FileHelper.CountLines(path);
                Console.WriteLine($"Количество строк в файле: {count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}

       