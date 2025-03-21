namespace Task_10_06
{
    /*Создать Метод ArrayGeneration 
     * не возвращающий значения, принимает целое число n,
     * выводит наконсольсгенерированный массив размерности n*n.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");

            int n = int.Parse(Console.ReadLine());

            ArrayGeneration(n);
        }
        static void ArrayGeneration(int n)
        {
            int[,] Array = new int[n, n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Array[i, j] = random.Next(1, 100);

                        Console.Write(Array[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
