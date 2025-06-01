namespace Task_24_08
{
    internal class Program
    {
        /* Реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, введенные пользователе*/
        static void Main()
        {
            Console.Write("Введите путь к файлу: ");
            string path = Console.ReadLine();

            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            Console.Write("Введите текст для замены: ");
            string replaceText = Console.ReadLine();

            try
            {
                FileHelper.ReplaceTextInFile(path, searchText, replaceText);
                Console.WriteLine("Замена выполнена успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
