namespace Task_03_09
{
    internal class Program
    {
        /* Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
         отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
         менее y рублей. */
        static void Main(string[] args)
        {
            //Ввод данных
            Console.Write("Введите начальную сумму вклада {x} : ");
            double initialDeposit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент увеличения (p): ");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите целевую сумму вклада (y): ");
            double targetAmount = Convert.ToDouble(Console.ReadLine());

            int years = 0;

            //Вычисление количества лет
            while (initialDeposit < targetAmount)
            {
                initialDeposit += Math.Floor(initialDeposit * (interestRate / 100));//Увелечение вклада
                years++; // Увелечение счетчика лет

            }
            // Вывод результата
            Console.WriteLine($"Количество лет до достижения цели: {years}");
        }
    }
}
