namespace Task_11_07
{
    internal class Program
    {
        /*Передача массива по ссылке (ref): Напишите метод, который принимает массив целых чисел по 
ссылке и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли 
оригинальный массив вне метода. */
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("До вызова метода: " + string.Join(", ", numbers));
            IncrementArrayRef(ref numbers);
            Console.WriteLine("После вызова метода: " + string.Join(", ", numbers));
        }

        static void IncrementArrayRef(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
        }
    }
}
