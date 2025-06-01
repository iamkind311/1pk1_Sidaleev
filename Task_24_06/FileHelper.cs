using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace Task_24_06
{
    public class FileHelper
    {
        public static int CountLines(string filePath)
        {
            int lineCount = 0;

            // Проверяем, существует ли файл
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден", filePath);
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            return lineCount;
        }
        public static void ReplaceTextInFile(string filePath, string oldText, string newText)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден", filePath);
            }

            string fileContent = File.ReadAllText(filePath);
            fileContent = fileContent.Replace(oldText, newText);
            File.WriteAllText(filePath, fileContent);
        }
    }
}