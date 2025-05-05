namespace Task_22_03
{
    internal class Program
    { /*Создать класс CustomTimer, который измеряет временные промежутки.
        Методы:
        • Start() - начать отсчёт
        • Stop() - остановить и вернуть TimeSpan
        • Pause() / Resume() - управление паузо*/
        static void Main(string[] args)
        {   
        CustomTimer timer = new CustomTimer();

         timer.Start();
         System.Threading.Thread.Sleep(2000); // Задержка 2 секунды
         timer.Pause();

         Console.WriteLine($"Время: {timer.ElapsedTime()}");

         System.Threading.Thread.Sleep(1000); // Задержка 1 секунда
         timer.Resume();

         System.Threading.Thread.Sleep(3000); // Задержка 3 секунды
         TimeSpan totalTime = timer.Stop();

         Console.WriteLine($"Общее время: {totalTime}");
            
        }
        public class CustomTimer
        {
            private DateTime startTime;
            private TimeSpan elapsedTime;
            private bool isRunning;
            private bool isPaused;

            public CustomTimer()
            {
                elapsedTime = TimeSpan.Zero;
                isRunning = false;
                isPaused = false;
            }

            public void Start()
            {
                if (!isRunning)
                {
                    startTime = DateTime.Now;
                    isRunning = true;
                    isPaused = false;
                    Console.WriteLine("Таймер запущен.");
                }
            }

            public TimeSpan Stop()
            {
                if (isRunning)
                {
                    elapsedTime += DateTime.Now - startTime;
                    isRunning = false;
                    Console.WriteLine("Таймер остановлен.");
                }
                return elapsedTime;
            }

            public void Pause()
            {
                if (isRunning && !isPaused)
                {
                    elapsedTime += DateTime.Now - startTime;
                    isPaused = true;
                    isRunning = false;
                    Console.WriteLine("Таймер приостановлен.");
                }
            }

            public void Resume()
            {
                if (isPaused)
                {
                    startTime = DateTime.Now;
                    isRunning = true;
                    isPaused = false;
                    Console.WriteLine("Таймер продолжен.");
                }
            }

            public TimeSpan ElapsedTime()
            {
                if (isRunning)
                {
                    return elapsedTime + (DateTime.Now - startTime);
                }
                return elapsedTime;
            }
        }
    }
}
