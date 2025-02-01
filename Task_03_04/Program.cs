namespace Task_03_04
{
    internal class Program
    {
       /* Пользователь вводить в консоли произвольный текст.После каждого ввода консоль очищается. Когда
        пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
        введенных пользователем. */
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                Console.WriteLine("Введите текст:");

                string userInput = Console.ReadLine();

                if (userInput == "exit" || string.IsNullOrEmpty(userInput))
                {
                    break;
                }
                count++;
                Console.Clear();

            }
            Console.WriteLine("Количество введенных строк: " + count);
        }
    }
}
