namespace Task_13_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Использование конструктора по умолчанию
            Car car1 = new Car();
            car1.Drive(50); 
            car1.Brake(60); 

            // Использование конструктора с параметрами
            Car car2 = new Car("A123BC", "Toyota", "Красный");
            car2.Drive(80); 
            car2.Brake(60); 
        }
    }
}
