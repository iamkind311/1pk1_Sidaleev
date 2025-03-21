namespace Task_11_01
{
    internal class Program
    {
        /*Передача по значению: Напишите метод, который принимает два целых числа и меняет их 
местами. Проверьте, изменились ли значения переменных вне метода */
        static void Main()
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"До вызова метода: x = {x}, y = {y}");

            (x, y) = SwapByValue(x, y);

            Console.WriteLine($"После вызова метода: x = {x}, y = {y}"); 
        }
        static (int, int) SwapByValue(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return (a, b);

        }
    }
}

   

