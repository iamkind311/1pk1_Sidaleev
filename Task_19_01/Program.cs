namespace Task_19_01
{
    internal class Program
    {
        /*Задачи (для личного репозитория)

        1. Напишите программу, в которой пользователь вводит произвольный текст в консоли, после чего программа запрашивает подстроку для поиска. Если подстрока найдена - то программа запрашивает текст для того чтобы заменить на него эту подстроку (столько раз, сколько раз подстрока встречена в тексте)
        Пример:
        Введите строку: "Привет, мир!"
        Введите подстроку для поиска: "мир"
        Введите подстроку для замены: "друг"
        Результат: "Привет, друг!"

*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string inputText = Console.ReadLine();

            Console.WriteLine("Введите подстроку для поиска: ");
            string searchString = Console.ReadLine();

            if (inputText.Contains(searchString))
            {
                Console.WriteLine("Введите подстроку для замены: ");
                string replacementString = Console.ReadLine();

                string resultText = ReplaceSubstring(inputText, searchString, replacementString);
                Console.WriteLine($"Результат: \"{resultText}\"");
            }
            else  Console.WriteLine("Подстрока не найдена");
            static string ReplaceSubstring(string text, string search, string replacement)
            {
                char[] textArray = text.ToCharArray();
                char[] searchArray = search.ToCharArray();
                int searchLength = search.Length;

                for (int i = 0; i <=  text.Length - search.Length; i++)
                {
                    bool found = true;
                    for (int j = 0; j < search.Length; j++)
                    {
                        if (textArray[i + j] != searchArray[j])
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        // Заменяем подстроку
                        text = text.Remove(i, searchLength).Insert(i, replacement);
                        // Увеличиваем индекс
                        i += replacement.Length - 1;
                    }
                }

                return text;
            }
        }

    }

}
    

