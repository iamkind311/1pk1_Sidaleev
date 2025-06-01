using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_07
{
    public class FileHelper
    {
        public static List<string> FindLinesWithWord(string filePath, string word)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден", filePath);
            }

            List<string> matchingLines = new List<string>();
            string lowerWord = word.ToLower();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.ToLower().Contains(lowerWord))
                    {
                        matchingLines.Add(line);
                    }
                }
            }

            return matchingLines;
        }
        public static void ReplaceTextInFile(string filePath, string oldText, string newText)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Файл не найден", filePath);
            }

            string content = File.ReadAllText(filePath);
            content = content.Replace(oldText, newText);
            File.WriteAllText(filePath, content);
        }
    }
}
