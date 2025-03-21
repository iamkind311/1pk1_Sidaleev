namespace Task_11_06
{
    internal class Program
    {
        /*Передача массива по значению: Напишите метод, который принимает массив целых чисел и 
изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный 
массив вне метода. */
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("До вызова метода: " + string.Join(", ", numbers));
            IncrementArray(numbers);
            Console.WriteLine("После вызова метода: " + string.Join(", ", numbers));
        }

        static void IncrementArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
        }
    }
}
