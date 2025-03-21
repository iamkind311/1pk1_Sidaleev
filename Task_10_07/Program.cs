namespace Task_10_07
{
    internal class Program
    {
        /*Создайте метод с помощью которого можно сгенерировать 
         * и вернуть символьный двумерныймассив(состоящийиз символов русского алфавита) и 
         * выведите на консоль данный массив 
         * с помощью другого метода(которыйпринимает данный массив в качестве параметра*/
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во строк: ");
            int rows = int.Parse(Console.ReadLine()); // Пример количества строк
            Console.Write("Введите кол-во столбцов: ");
            int cols = int.Parse(Console.ReadLine()); // Пример количества столбцов
            char[,] charArray = GenerateCharArray(rows, cols);
            PrintCharArray(charArray);
        }

        static char[,] GenerateCharArray(int rows, int cols)
        {
            char[,] array = new char[rows, cols];
            Random random = new Random();
            char[] russianAlphabet = "абвгдезийклмнопрстуфхцчшщъыьэюя".ToCharArray();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = russianAlphabet[random.Next(russianAlphabet.Length)];
                }
            }

            return array;
        }

        static void PrintCharArray(char[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t"); // Вывод элемента массива
                }
                Console.WriteLine(); // Переход на новую строку после каждой строки массива
            }
        }
    }
}
