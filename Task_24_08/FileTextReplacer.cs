using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_08
{
    public class FileHelper
    {
        // Метод для замены текста в файле
        public static void ReplaceTextInFile(string filePath, string searchText, string replaceText)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден", filePath);
            }

            string content = File.ReadAllText(filePath);

            string updatedContent = content.Replace(searchText, replaceText);

            File.WriteAllText(filePath, updatedContent);
        }
    }
}
