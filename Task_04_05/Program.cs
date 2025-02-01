namespace Task_04_05
{
    internal class Program
    {
        /* В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общее
        количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и
        отдельно вывести дни без осадков. Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет
        осадков, до 300 мм выпавших осадков. */
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] precipitation = new int[30];

            // Заполнение массива случайными осадками
            for (int i = 0; i < precipitation.Length; i++)
            {
                precipitation[i] = random.Next(0, 301);
            }

            // Общее количество осадков за каждую декаду
            int[] decades = new int[3];
            for (int i = 0; i < 3; i++)
            {
                decades[i] = precipitation.Skip(i * 10).Take(10).Sum();
            }

            // День с самыми сильными осадками
            int maxPrecipitation = precipitation.Max();
            int dayMaxPrecipitation = Array.IndexOf(precipitation, maxPrecipitation) + 1;

            // Дни без осадков
            var daysWithoutPrecipitation = precipitation.Select((value, index) => value == 0 ? index + 1 : 0).Where(x => x != 0).ToList();

            // Вывод результатов
            Console.WriteLine("Общее количество осадков за каждую декаду: " + string.Join(", ", decades));
            Console.WriteLine("День с самыми сильными осадками: " + dayMaxPrecipitation + " с осадками " + maxPrecipitation + " мм");
            Console.WriteLine("Дни без осадков: " + string.Join(", ", daysWithoutPrecipitation));
        }
    }
}
