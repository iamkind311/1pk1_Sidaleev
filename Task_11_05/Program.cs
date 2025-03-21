namespace Task_11_05
{
    internal class Program
    {
        /*Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и 
возвращает их сумму и произведение через выходные параметры (out). */
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"До вызова метода: a = {a}, b = {b}");
            SumAndProduct(ref a, ref b, out int sum, out int product);
            Console.WriteLine($"После вызова метода: a = {a}, b = {b}");
            Console.WriteLine($"Сумма: {sum}, Произведение: {product}");
        }

        static void SumAndProduct(ref int x, ref int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
        }
    }
}
