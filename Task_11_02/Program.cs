namespace Task_11_02
{
    internal class Program
    {
        /*Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и 
меняет их местами. Проверьте, изменились ли значения переменных вне метода */
        static void Main()
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"До вызова метода: x = {x}, y = {y}");

            SwapByValue(ref x, ref y);

            Console.WriteLine($"После вызова метода: x = {x}, y = {y}");
        }
        static void SwapByValue(ref int a,ref  int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
