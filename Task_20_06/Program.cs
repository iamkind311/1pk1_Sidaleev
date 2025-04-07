namespace Task_20_06
{
    internal class Program
    {
        /* Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
        • Red
        • Yellow
        • Green
         Реализуйте автоматическое переключение цветов (каждые 3 секунды).
        При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep).
        Добавьте возможность ручного переключения (например, по нажатию клавиши).
        */
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            Thread trafficLightThread = new Thread(new ThreadStart(trafficLight.Start));
            trafficLightThread.Start();

            while (true)
            {
                Console.WriteLine("Нажмите 'R' для красного, 'Y' для желтого, 'G' для зеленого (или 'Q' для выхода):");
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.R)
                {
                    trafficLight.ManualSwitch(TrafficLightColor.Red);
                }
                else if (key == ConsoleKey.Y)
                {
                    trafficLight.ManualSwitch(TrafficLightColor.Yellow);
                }
                else if (key == ConsoleKey.G)
                {
                    trafficLight.ManualSwitch(TrafficLightColor.Green);
                }
                else if (key == ConsoleKey.Q)
                {
                    break; // Выход из программы
                }
            }

            trafficLightThread.Abort(); // Завершение потока светофора
        }
        class TrafficLight
        {
            private TrafficLightColor currentColor;

            public TrafficLight()
            {
                currentColor = TrafficLightColor.Red;
            }

            public void Start()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Светофор: {currentColor}");
                    Thread.Sleep(5000); // Задержка 

                    SwitchColor();
                }
            }

            public void SwitchColor()
            {
                if (currentColor == TrafficLightColor.Red)
                {
                    currentColor = TrafficLightColor.Green;
                }
                else if (currentColor == TrafficLightColor.Green)
                {
                    currentColor = TrafficLightColor.Yellow;
                }
                else
                {
                    currentColor = TrafficLightColor.Red;
                }
            }

            public void ManualSwitch(TrafficLightColor newColor)
            {
                currentColor = newColor;
                Console.WriteLine($"Светофор переключён вручную: {currentColor}");
            }
        }
    }
}
